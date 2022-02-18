using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.OutputDTO;
using System.Data;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.Enum;
using SMOSEC.Domain.IRepository;
using SMOSEC.Infrastructure;
using SMOSEC.Application;
using SMOSEC.Repository.Assets;

namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssets : Swebui.Controls.SwebUserControl
    {
        public frmAssets() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        AutofacConfig autofacConfig = new AutofacConfig();
        public string SelectAssId;  //当前选择的资产
        public string AssId; //资产编号
        private string UserId;
        private string LocatinId;

        #endregion

        public static explicit operator frmAssets(SwebForm v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 按照SN或者名称模糊匹配查询资产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFactor_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void SearchData()
        {
            try
            {
                String DepId = treeSelect1.Tag == null ? null : treeSelect1.Tag.ToString();     //选择部门编号
                String Status = treeSelect2.Tag == null ? null : treeSelect2.Tag.ToString();   //选择资产状态
                String Type = treeSelect3.Tag == null ? null : treeSelect3.Tag.ToString();
                DataTable table = _autofacConfig.SettingService.QueryAssets(txtNote.Text, LocatinId, DepId, Status, Type);
                //table.Columns.Add("DEPARTMENTNAME");
                //foreach (DataRow row in table.Rows)
                //{
                //    if (string.IsNullOrEmpty(row["DEPARTMENTID"].ToString()) == false)
                //    {
                //        DepartmentDto dto = _autofacConfig.DepartmentService.GetDepartmentByDepID(row["DEPARTMENTID"].ToString());
                //        if (dto != null)
                //            row["DEPARTMENTNAME"] = dto.NAME;
                //    }
                //    switch (row["Status"].ToString())
                //    {
                //        case "0":
                //            row["StatusName"] = "闲置";
                //            break;
                //        case "1":
                //            row["StatusName"] = "调拨中";
                //            break;
                //        case "2":
                //            row["StatusName"] = "使用中";
                //            break;
                //        case "3":
                //            row["StatusName"] = "维修中";
                //            break;
                //        case "4":
                //            row["StatusName"] = "报废";
                //            break;
                //        case "5":
                //            row["StatusName"] = "借用中";
                //            break;

                //    }
                //}
                gridAssRows.Reload(table);

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {
                LocatinId = "";
                if (Client.Session["Role"].ToString() != "ADMIN")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocatinId = user.USER_LOCATIONID;
                }

                DataTable table = _autofacConfig.SettingService.GetAllAss(LocatinId);

                table.Columns.Add("DEPARTMENTNAME");
                foreach (DataRow row in table.Rows)
                {

                    if (string.IsNullOrEmpty(row["DEPARTMENTID"].ToString()) == false)
                    {
                        DepartmentDto dto = _autofacConfig.DepartmentService.GetDepartmentByDepID(row["DEPARTMENTID"].ToString());
                        if (dto != null)
                            row["DEPARTMENTNAME"] = dto.NAME;


                    }
                    switch (row["Status"].ToString())
                    {
                        case "0":
                            row["StatusName"] = "闲置";
                            break;
                        case "1":
                            row["StatusName"] = "调拨中";
                            break;
                        case "2":
                            row["StatusName"] = "使用中";
                            break;
                        case "3":
                            row["StatusName"] = "维修中";
                            break;
                        case "4":
                            row["StatusName"] = "报废";
                            break;
                        case "5":
                            row["StatusName"] = "借用中";
                            break;
                    }
                }

                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssets_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            ///添加部门
            List<DepartmentDto> deps = _autofacConfig.DepartmentService.GetAllDepartment();
            treeSelect1.Nodes.Add(new TreeSelectNode("", "全部"));
            foreach (DepartmentDto Row in deps)
            {
                treeSelect1.Nodes.Add(new TreeSelectNode(Row.DEPARTMENTID, Row.NAME));
            }
            ///添加状态


            ///添加类别
            List<AssetsType> types = _autofacConfig.assTypeService.GetAllFirstLevel();
            treeSelect3.Nodes.Add(new TreeSelectNode("", "全部"));
            foreach (AssetsType Row in types)
            {
                treeSelect3.Nodes.Add(new TreeSelectNode(Row.TYPEID, Row.NAME));
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string barCode = txtNote.Text;
                SearchData();

                //gridAssRows.Reload(table);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmAssetsCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void CopyBtn_Click(object sender, EventArgs e)


        {
            gridAssRows.GetSelectedRows((obj, args) =>
            {
                try
                {
                    if (Client.Session["Role"].ToString() == "SMOSECUser") throw new Exception("当前用户没有权限添加资产!");
                    if (args.SelectedRows.Count > 0)
                    {
                        Dictionary<string, object> selectrow = args.SelectedRows[0];
                        string id = selectrow["ASSID"].ToString();
                        string SelectAssId = selectrow["ASSID"].ToString();
                        if (string.IsNullOrEmpty(SelectAssId))
                        {
                            throw new Exception("请先选择资产.");
                        }
                        var assets = _autofacConfig.SettingService.GetAssetsByID(SelectAssId);

                        frmAssetsCreate frm = new frmAssetsCreate
                        {
                            DatePickerBuy = { Value = assets.BuyDate },
                            DepId = assets.DepartmentId,
                            treeSelect2 = { Placeholder = assets.DepartmentName },
                            DatePickerExpiry = { Value = assets.ExpiryDate },
                            ImgPicture = { ResourceID = assets.Image },
                            LocationId = assets.LocationId,
                            treeSelect1 = { Placeholder = assets.LocationName },
                            ManagerId = assets.Manager,
                            txtManager = { Text = assets.ManagerName },
                            txtName = { Text = assets.Name },
                            txtNote = { Text = assets.Note },
                            txtPlace = { Text = assets.Place },
                            txtPrice = { Text = assets.Price.ToString() },
                            txtSpe = { Text = assets.Specification },
                            treeAssetsType = { Tag = assets.TypeId, Placeholder = assets.TypeName },
                            txtUnit = { Text = assets.Unit },
                            txtVendor = { Text = assets.Vendor },
                            Flex = 1
                        };
                        frm.AssId = id;
                        this.Parent.Controls.Add(frm);
                        this.Parent.Controls.RemoveAt(0);
                        Bind();
                    }
                    else
                    {
                        Toast("未选择行！");
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            });
        }


        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridAssRows.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["ASSID"].ToString();
                    frmAssetsDetail frm = new frmAssetsDetail() { Flex = 1 };
                    frm.AssId = id;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }

            });
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            gridAssRows.GetSelectedRows((obj, args) =>
            {
                try
                {
                    if (args.SelectedRows.Count > 0)
                    {
                        Dictionary<string, object> selectrow = args.SelectedRows[0];
                        string id = selectrow["ASSID"].ToString();
                        AssetsOutputDto ass = _autofacConfig.SettingService.GetAssetsByID(id);
                        if (ass.Status != (int)STATUS.闲置)
                        {
                            throw new Exception("资产处于非空闲状态中，无法删除!");
                        }
                        MessageBox.Show("是否确定删除该资产？", "系统提示", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args1) =>
                            {

                        if (args1.Result == ShowResult.Yes)
                        {
                            ReturnInfo RInfo = _autofacConfig.SettingService.DeleteAssets(id, Client.Session["UserID"].ToString());
                            if (RInfo.IsSuccess)
                            {
                                Toast("删除成功!");
                                RefreshBtn_Click(null, null);
                            }
                            else
                            {
                                throw new Exception(RInfo.ErrorInfo);
                            }
                        }
                    });

                    }
                    else
                    {
                        Toast("未选择行！");
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            });

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            txtNote.Text = "";
            treeSelect1.Nodes.Clear();
            List<DepartmentDto> deps = _autofacConfig.DepartmentService.GetAllDepartment();
            foreach (DepartmentDto Row in deps)
            {
                if (deps.Count > 0)
                {
                    treeSelect1.Nodes.Add(new TreeSelectNode(Row.DEPARTMENTID, Row.NAME));
                }
            }

            treeSelect2.Nodes.Refresh();

            treeSelect3.Nodes.Clear();
            List<AssetsType> types = _autofacConfig.assTypeService.GetAllFirstLevel();
            foreach (AssetsType Row in types)
            {
                if (types.Count > 0)
                {
                    treeSelect3.Nodes.Add(new TreeSelectNode(Row.TYPEID, Row.NAME));
                }

            }
            DataTable table = _autofacConfig.SettingService.GetAllAss(LocatinId);
            table.Columns.Add("DEPARTMENTNAME");
            foreach (DataRow row in table.Rows)
            {
                if (string.IsNullOrEmpty(row["DEPARTMENTID"].ToString()) == false)
                {
                    DepartmentDto dto = _autofacConfig.DepartmentService.GetDepartmentByDepID(row["DEPARTMENTID"].ToString());
                    if (dto != null)
                        row["DEPARTMENTNAME"] = dto.NAME;
                }
                switch (row["Status"].ToString())
                {
                    case "0":
                        row["StatusName"] = "闲置";
                        break;
                    case "1":
                        row["StatusName"] = "调拨中";
                        break;
                    case "2":
                        row["StatusName"] = "使用中";
                        break;
                    case "3":
                        row["StatusName"] = "维修中";
                        break;
                    case "4":
                        row["StatusName"] = "报废";
                        break;
                    case "5":
                        row["StatusName"] = "借用中";
                        break;
                }

                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();

                }
            }
            gridAssRows.Reload(table);
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect1.Tag = args.TreeID;
            SearchData();
        }

        private void treeSelect2_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect2.Tag = args.TreeID;
            SearchData();
        }

        private void treeSelect3_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect3.Tag = args.TreeID;
            SearchData();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            gridAssRows.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["ASSID"].ToString();
                    frmPrShow frm = new frmPrShow { Flex = 1 };
                    frm.AssId = id;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }

            });
        }
    }

}