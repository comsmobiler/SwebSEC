using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
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
    partial class frmTransferRows : Swebui.Controls.SwebUserControl
    {
        public frmTransferRows() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        /// <summary>
        /// 页面初始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferRows_Load(object sender, EventArgs e)
        {
            try
            {
                List<AssTransferOrder> Data = new List<AssTransferOrder>();
                if (Client.Session["Role"].ToString() == "SMOSECUser")
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(Client.Session["UserID"].ToString(), OperateType.耗材);
                }
                else
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(null, OperateType.耗材);
                }
                DataTable dt = new DataTable();
                dt.Columns.Add("TOID");
                dt.Columns.Add("CREATEDATE");
                dt.Columns.Add("NOTE");
                foreach (var data in Data)
                {
                    dt.Rows.Add(data.TOID, ((DateTime)data.CREATEDATE).ToString("yyyy-MM-dd"), data.NOTE);
                }
                gridView1.DataSource = dt;
                gridView1.DataBind();
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
            this.Parent.Controls.Add(new frmTransferCreate() { Flex = 1 });
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
                if (args.SelectedRows.Count == 0)
                {
                    Toast("未选中行");
                }
                else
                {
                    string toid = args.SelectedRows[0]["TOID"].ToString();
                    frmTransferDetail detail = new frmTransferDetail();
                    detail.TOID = toid;
                    detail.Flex = 1;
                    this.Parent.Controls.Add(detail);
                    this.Parent.Controls.RemoveAt(0);
                }
            });
        }
        /// <summary>
        ///  刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<AssTransferOrder> Data = new List<AssTransferOrder>();
                if (Client.Session["Role"].ToString() == "SMOSECUser")
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(Client.Session["UserID"].ToString(), OperateType.耗材);
                }
                else
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(null, OperateType.耗材);
                }
                DataTable dt = new DataTable();
                dt.Columns.Add("TOID");
                dt.Columns.Add("CREATEDATE");
                dt.Columns.Add("NOTE");
                foreach (var data in Data)
                {
                    dt.Rows.Add(data.TOID, ((DateTime)data.CREATEDATE).ToString("yyyy-MM-dd"), data.NOTE);
                }
                gridView1.Reload(dt);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


    }
}