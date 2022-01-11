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
    partial class frmBoCreate : Swebui.Controls.SwebUserControl
    {
        public frmBoCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public List<string> AssIdList = new List<string>(); //所有行项的ASSID的集合

        public DataTable AssTable = new DataTable();   //行项数据的表格
        public string LocationId;
        public string BoManId;
        public string HManId;
        private string UserId;
        #endregion
        /// <summary>
        /// 保存借用单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (AssIdList.Count == 0)
                {
                    throw new Exception("请添加借用的资产！");
                }
                AssBorrowOrderInputDto assBorrowOrderInput = new AssBorrowOrderInputDto
                {
                    AssIds = AssIdList,
                    BORROWDATE = DateTime.Now,
                    BORROWER = BoManId,
                    BRHANDLEMAN = HManId,
                    CREATEUSER = UserId,
                    EPTRETURNDATE = DateTime.Now.AddYears(1),
                    LOCATIONID = LocationId,
                    MODIFYUSER = UserId,
                    NOTE = txtNote.Text
                };
                ReturnInfo returnInfo = _autofacConfig.AssetsService.AddAssBorrowOrder(assBorrowOrderInput);
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

        private void frmBoCreate_Load(object sender, EventArgs e)
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

                UserId = this.Client.Session["UserID"].ToString();
                switch (Client.Session["Role"].ToString())
                {
                    case "SMOSECAdmin":
                        {
                            var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                            LocationId = user.USER_LOCATIONID;
                            var location = _autofacConfig.assLocationService.GetByID(LocationId);
                            //btnLocation.Text = location.NAME;
                            //btnLocation.Enabled = false;
                            //btnLocation1.Enabled = false;
                        }
                        break;
                    case "SMOSECUser":
                        {
                            BoManId = UserId;
                            var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                            //btnBOMan.Text = user.USER_NAME;
                            //btnBOMan.Enabled = false;
                            //btnBOMan1.Enabled = false;
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 绑定数据
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
        /// 情况保存的数据
        /// </summary>
        private void ClearInfo()
        {
            AssTable.Rows.Clear();
            AssIdList.Clear();
            BindListView();
        }
        /// <summary>
        /// 添加资产到表格
        /// </summary>
        /// <param name="assId">资产编号</param>
        /// <param name="sn">序列号</param>
        /// <param name="image">图片</param>
        /// <param name="name">名称</param>
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
                    row["TYPE"] = "BO";
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
        /// 从相关数据中删除资产
        /// </summary>
        /// <param name="assId">资产编号</param>
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
                if (string.IsNullOrEmpty(comboBox2.Text))
                {
                    throw new Exception("请先选择区域");
                }
                else
                {
                    string barCode = e.ToString();
                    DataTable info = _autofacConfig.SettingService.GetUnUsedAssEx(LocationId, barCode);
                    if (info.Rows.Count == 0)
                    {
                        throw new Exception("未在该区域的闲置物品中找到该物品");
                    }
                    else
                    {
                        DataRow row = info.Rows[0];
                        AddAss(row["ASSID"].ToString(), barCode, row["IMAGE"].ToString(), row["NAME"].ToString());
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
                if (string.IsNullOrEmpty(comboBox2.Text))
                {
                    throw new Exception("请先选择区域");
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
    }
}