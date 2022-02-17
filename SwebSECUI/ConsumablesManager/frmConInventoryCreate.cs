using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConInventoryCreate : Swebui.Controls.SwebUserControl
    {
        public frmConInventoryCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string IID;
        private string UserId;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConInventoryCreate_Load(object sender, EventArgs e)
        {
            try
            {
                ///盘点人数据绑定
                List<coreUser> users = _autofacConfig.coreUserService.GetAll();
                foreach (coreUser Row in users)
                {
                    btnManager.Nodes.Add(new TreeSelectNode(Row.USER_ID, Row.USER_NAME));
                }
                // 区域数据绑定
                List<AssLocation> locations = _autofacConfig.assLocationService.GetAll();
                foreach (AssLocation Row in locations)
                {
                    btnLocation.Nodes.Add(new TreeSelectNode(Row.LOCATIONID, Row.NAME));
                }
                UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    String LocationId = user.USER_LOCATIONID;
                    var location = _autofacConfig.assLocationService.GetByID(LocationId);
                    btnLocation.DefaultValue = new string[] { LocationId };
                    btnLocation.Tag = LocationId;
                    btnLocation.Disabled = true;
                }
                ///编辑初始化
                if (string.IsNullOrEmpty(IID) == false)
                {
                    labTitle.Text = "编辑耗材盘点单";
                    DeleteBtn.Visible = true;
                    lblIID.Text = IID;
                    var assInventory = _autofacConfig.ConInventoryService.GetConInventoryById(IID);
                    txtName.Text = assInventory.NAME;
                    btnManager.DefaultValue = new string[] { assInventory.HANDLEMAN };
                    btnManager.Tag = assInventory.HANDLEMAN;
                    btnLocation.DefaultValue = new string[] { assInventory.LOCATIONID };
                    btnLocation.Tag = assInventory.LOCATIONID;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmConInventory() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("盘点单名称不能为空!");
                if (btnManager.Tag == null) throw new Exception("盘点人不能为空!");
                if (btnLocation.Tag == null) throw new Exception("区域不能为空!");
                AssLocation loc = _autofacConfig.assLocationService.GetByID(btnLocation.Tag.ToString());
                if (loc.ISLOCKED == 1) throw new Exception("该区域已锁定, 无法创建新的盘点单!");
                if (loc.ISENABLE == 0) throw new Exception("该区域已禁用, 无法创建新的盘点单!");
                if (string.IsNullOrEmpty(IID))
                {
                    ConInventoryInputDto conInventoryInput = new ConInventoryInputDto()
                    {
                        HANDLEMAN = btnManager.Tag.ToString(),
                        CREATEUSER = UserId,
                        LOCATIONID = btnLocation.Tag.ToString(),
                        IsEnd = false,
                        MODIFYUSER = UserId,
                        NAME = txtName.Text
                    };
                    ReturnInfo returnInfo = _autofacConfig.ConInventoryService.AddConInventory(conInventoryInput);
                    if (returnInfo.IsSuccess)
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("添加成功");
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(returnInfo.ErrorInfo);
                    }
                }
                else
                {///编辑
                    AddCIResultInputDto conInventoryInput = new AddCIResultInputDto()
                    {
                        IID = IID,
                        HANDLEMAN = btnManager.Tag.ToString(),
                        LocationId = btnLocation.Tag.ToString(),
                        UserId = Client.Session["UserID"].ToString(),
                        Name = txtName.Text
                    };
                    ReturnInfo returnInfo = _autofacConfig.ConInventoryService.UpdateInventoryOnly(conInventoryInput);
                    if (returnInfo.IsSuccess)
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("修改成功");
                        BackBtn_Click(null, null);
                    }
                    else
                    {
                        throw new Exception(returnInfo.ErrorInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo rInfo = _autofacConfig.ConInventoryService.DeleteInventory(IID);
                if (rInfo.IsSuccess)
                {
                    Toast("删除盘点单成功.");
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(rInfo.ErrorInfo);
                }

            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// 盘点人选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnManager_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnManager.Tag = args.TreeID;
        }

        private void btnLocation_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnLocation.Tag = args.TreeID;
        }
    }
}