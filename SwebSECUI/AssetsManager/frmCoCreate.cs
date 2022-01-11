using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmCoCreate : Swebui.Controls.SwebUserControl
    {
        public frmCoCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        AutofacConfig autofacConfig = new AutofacConfig();
        public List<string> AssIdList = new List<string>();

        public DataTable AssTable = new DataTable();
        public string LocationId;
        public string CoManId;
        public string HManId;
        private string UserId;
        private string DepId;

        #endregion

        /// <summary>
        /// 添加领用单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (AssIdList.Count == 0)
                {
                    throw new Exception("请添加领用的资产！");
                }
                AssCollarOrderInputDto assCollarOrderInput = new AssCollarOrderInputDto()
                {
                    AssIds = AssIdList,
                    COLLARDATE = DPickerCO.Value,
                    USERID = CoManId,
                    HANDLEMAN = HManId,
                    CREATEUSER = UserId,
                    EPTRESTOREDATE = DPickerRs.Value,
                    LOCATIONID = LocationId,
                    INUSEDDEP = DepId,
                    PLACE = txtPlace.Text,
                    MODIFYUSER = UserId,
                    NOTE = txtNote.Text
                };
                ReturnInfo returnInfo = _autofacConfig.AssetsService.AddAssCollarOrder(assCollarOrderInput);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("添加成功");
                    Close();
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 界面初始化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCoCreate_Load(object sender, EventArgs e)
        {
            try
            {
                if (AssTable.Columns.Count == 0)
                {
                    AssTable.Columns.Add("IMAGE");
                    AssTable.Columns.Add("ASSID");
                    AssTable.Columns.Add("NAME");
                    AssTable.Columns.Add("TYPE");
                    AssTable.Columns.Add("SN");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = AssTable.Columns["ASSID"];
                AssTable.PrimaryKey = keys;
                UserId = Client.Session["UserID"].ToString();
                switch (Client.Session["Role"].ToString())
                {
                    case "SMOSECAdmin":
                        {
                            var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                            LocationId = user.USER_LOCATIONID;
                            var location = _autofacConfig.assLocationService.GetByID(LocationId);
                            treeSelect2.Tag = location.NAME;
                            //btnLocation.Enabled = false;
                            //btnLocation1.Enabled = false;
                        }
                        break;
                    case "SMOSECUser":
                        {
                            CoManId = UserId;
                            var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                            treeSelect1.Tag = user.USER_NAME;
                            //btnCOMan.Enabled = false;
                            //btnCOMan1.Enabled = false;
                            //var department = _autofacConfig.DepartmentService.GetDepartmentByDepID(user.USER_DEPARTMENTID);
                            //DepId = user.USER_DEPARTMENTID;
                            //txtDep.Text = department.NAME;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            ///添加借用人
            List<coreUser> listRole = autofacConfig.coreUserService.GetAll();
            foreach (coreUser role in listRole)

            {
                treeSelect1.Nodes.Add(new TreeSelectNode(role.USER_ID, role.USER_NAME));
            }

            ///添加来源区域
            List<AssLocation> locations = _autofacConfig.assLocationService.GetEnableAll();
            foreach (var location in locations)
            {
                treeSelect2.Nodes.Add(new TreeSelectNode(location.LOCATIONID, location.NAME));
            }

        }

        /// <summary>
        /// 绑定行项数据
        /// </summary>
        public void BindListView()
        {
            try
            {
                ListAss.DataSource = AssTable;
                ListAss.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
       
        /// <summary>
        /// 清空存储的行项数据
        /// </summary>
        private void ClearInfo()
        {
            AssTable.Rows.Clear();
            AssIdList.Clear();
            BindListView();
        }
       
        /// <summary>
        /// 添加相关行项数据
        /// </summary>
        /// <param name="assId"></param>
        /// <param name="sn"></param>
        /// <param name="image"></param>
        /// <param name="name"></param>
        public void AddAss(string assId, string sn, string image, string name)
        {
            try
            {
                if (AssIdList.Contains(assId))
                {

                }
                else
                {
                    DataRow row = AssTable.NewRow();
                    row["ASSID"] = assId;
                    row["SN"] = sn;
                    row["IMAGE"] = image;
                    row["NAME"] = name;
                    row["TYPE"] = "CO";
                    AssTable.Rows.Add(row);
                    AssIdList.Add(assId);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// 移除相关行项数据
        /// </summary>
        /// <param name="assId"></param>
        public void RemoveAss(string assId)
        {
            try
            {
                DataRow row = AssTable.Rows.Find(assId);
                AssTable.Rows.Remove(row);
                AssIdList.Remove(assId);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(LocationId))
                {
                    throw new Exception("请先选择区域");
                }
                else
                {
                    string txtCode1 = txtCode.Text;
                    DataTable info = _autofacConfig.SettingService.GetUnUsedAssEx(LocationId, txtCode1);
                    if (info.Rows.Count == 0)
                    {
                        throw new Exception("未在该区域的闲置物品中找到该物品");
                    }
                    else
                    {
                        DataRow row = info.Rows[0];
                        AddAss(row["ASSID"].ToString(), txtCode1, row["IMAGE"].ToString(), row["NAME"].ToString());
                        BindListView();
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        private void txtCode_TouchEnter(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(LocationId))
                {
                    throw new Exception("请先选择退库的区域");
                }
                else
                {
                    txtCode.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmCollarOrder() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void txtCode_SubmitEditing(object sender, EventArgs e)
        {
            btnSelect_Click(null, null);
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            CoManId = args.TreeID;
            try
            {
                if (treeSelect1.Tag != null)
                {
                    //CoManId = treeSelect1.Tag.ToString();
                    var user = _autofacConfig.coreUserService.GetUserByID(CoManId);
                    var department = _autofacConfig.DepartmentService.GetDepartmentByDepID(user.USER_DEPARTMENTID);
                    DepId = user.USER_DEPARTMENTID;
                    if (department != null) txtDep.Text = department.NAME;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void treeSelect2_Press(object sender, TreeSelectPressEventArgs args)
        {
            LocationId = args.TreeID;
            try
            {
                AssLocation location = _autofacConfig.assLocationService.GetByID(LocationId);
                coreUser manager = _autofacConfig.coreUserService.GetUserByID(location.MANAGER);
                HManId = location.MANAGER;
                txtHMan.Text = manager.USER_NAME;
                ClearInfo();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}