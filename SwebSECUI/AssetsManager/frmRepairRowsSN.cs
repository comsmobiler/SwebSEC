using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmRepairRowsSN : Swebui.Controls.SwebUserControl
    {
        public frmRepairRowsSN() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion

        /// <summary>
        /// 创建维修单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmRepairCreateSN() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            Bind();
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRepairRowsSN_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        public void Bind()
        {
            try
            {
                List<AssRepairOrder> Data = new List<AssRepairOrder>();
                if (Client.Session["Role"].ToString() == "SMOSECUser")
                {
                    Data = autofacConfig.assRepairOrderService.GetByUser(Client.Session["UserID"].ToString());
                }
                else
                {
                    Data = autofacConfig.assRepairOrderService.GetByUser(null);
                }
                if (Data.Count > 0)
                {
                    listRepairOrder.DataSource = Data;
                    listRepairOrder.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}