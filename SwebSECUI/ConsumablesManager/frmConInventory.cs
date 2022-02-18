using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebSECUI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConInventory : Swebui.Controls.SwebUserControl
    {
        public frmConInventory() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string LocationId = "";
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConInventory_Load(object sender, EventArgs e)
        {
            try
            {
               
                string UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                }

                DataTable assInventoryList = _autofacConfig.ConInventoryService.GetConInventoryList(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "", LocationId);
                if (assInventoryList.Rows.Count > 0)
                {
                    gridView1.DataSource = assInventoryList;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 新增按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmConInventoryCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 编辑按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    if (args.SelectedRows[0]["STATUSNAME"].ToString() == "盘点未开始")
                    {
                        frmConInventoryCreate assetsEdit = new frmConInventoryCreate();
                        assetsEdit.Flex = 1;
                        assetsEdit.IID = args.SelectedRows[0]["IID"].ToString();
                        this.Parent.Controls.Add(assetsEdit);
                        this.Parent.Controls.RemoveAt(0);
                    }
                    else
                    {
                        Toast("该盘点单不允许编辑！");
                    }

                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
        /// <summary>
        /// 盘点按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    frmConInventoryResult assetsEdit = new frmConInventoryResult();
                    assetsEdit.Flex = 1;
                    assetsEdit.IID = args.SelectedRows[0]["IID"].ToString();
                    this.Parent.Controls.Add(assetsEdit);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable assInventoryList = _autofacConfig.ConInventoryService.GetConInventoryList(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "", LocationId);
                gridView1.Reload( assInventoryList);
                  
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }


    }
}