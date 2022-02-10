using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssInventoryEdit : Swebui.Controls.SwebUserControl
    {
        public frmAssInventoryEdit() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string LocationId;
        public string HManId;
        private string UserId;
        public string typeId;
        public string DepId;
        public string IID;
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmAssInventory() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            HManId = args.TreeID;
            try
            {
                if (treeSelect1.Tag != null)
                {

                    HManId = treeSelect1.Tag.ToString();
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
                if (treeSelect1.Tag != null)
                {

                    LocationId = treeSelect1.Tag.ToString();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void treeSelect3_Press(object sender, TreeSelectPressEventArgs args)
        {
            typeId = args.TreeID;
            try
            {
                if (treeSelect1.Tag != null)
                {

                    typeId = treeSelect1.Tag.ToString();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void treeSelect4_Press(object sender, TreeSelectPressEventArgs args)
        {
            DepId = args.TreeID;
            try
            {
                if (treeSelect1.Tag != null)
                {

                    DepId = treeSelect1.Tag.ToString();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 保存修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddAIResultInputDto assInventoryInput = new AddAIResultInputDto()
                {
                    IID = IID,
                    HANDLEMAN = HManId,
                    LocationId = LocationId,
                    typeId = typeId,
                    DepartmentId = DepId,
                    UserId = UserId,
                    Name = txtName.Text
                };
                ReturnInfo returnInfo = _autofacConfig.AssInventoryService.UpdateInventoryOnly(assInventoryInput);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("修改成功");
                    BackBtn_Click(null,null);
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
        /// 初始化界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryEdit_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();

                var assInventory = _autofacConfig.AssInventoryService.GetAssInventoryById(IID);
                txtName.Text = assInventory.NAME;
                treeSelect1.Placeholder = assInventory.HANDLEMANNAME + "   > ";
                if (string.IsNullOrEmpty(assInventory.DEPARTMENTID))
                {
                    treeSelect4.Placeholder = "全部   > ";
                }
                else
                {
                    treeSelect4.Placeholder = assInventory.DEPARTMENTNAME + "   > ";
                }
                if (string.IsNullOrEmpty(assInventory.TYPEID))
                {
                    treeSelect3.Placeholder = "全部   > ";
                }
                else
                {
                    treeSelect3.Placeholder = assInventory.TYPENAME + "   > ";
                }
                treeSelect2.Placeholder = assInventory.LOCATIONNAME + "   > ";
                HManId = assInventory.HANDLEMAN;
                DepId = assInventory.DEPARTMENTID;
                LocationId = assInventory.LOCATIONID;
                typeId = assInventory.TYPEID;
                if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                    var location = _autofacConfig.assLocationService.GetByID(LocationId);
                    if (location != null) treeSelect2.Tag = location.NAME;
                    
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            ///添加盘点人
            List<coreUser> users = _autofacConfig.coreUserService.GetAll();
            foreach (coreUser Row in users)
            {
                treeSelect1.Nodes.Add(new TreeSelectNode(Row.USER_ID, Row.USER_NAME));
            }
            ///添加盘点区域
            List<AssLocation> locations = _autofacConfig.assLocationService.GetAll();
            foreach (var location in locations)
            {
                treeSelect2.Nodes.Add(new TreeSelectNode(location.LOCATIONID, location.NAME));
            }
            ///添加盘点资产类型
            TreeSelectNode first = new TreeSelectNode
            {
                Text = "全部",
                TreeID = ""
            };
            treeSelect3.Nodes.Add(first);
            var typelist = _autofacConfig.assTypeService.GetAll();
            foreach (var type in typelist)
            {
                treeSelect3.Nodes.Add(new TreeSelectNode(type.TYPEID, type.NAME));
            }
            //////添加盘点部门
            TreeSelectNode second = new TreeSelectNode
            {
                Text = "全部",
                TreeID = ""
            };
            treeSelect4.Nodes.Add(second);
            var deplist = _autofacConfig.DepartmentService.GetAllDepartment();
            foreach (var dep in deplist)
            {
                treeSelect4.Nodes.Add(new TreeSelectNode(dep.DEPARTMENTID, dep.NAME));
            }
        }


    }
}