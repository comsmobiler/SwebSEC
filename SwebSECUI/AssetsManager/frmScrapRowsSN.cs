using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using System.Data;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmScrapRowsSN : Swebui.Controls.SwebUserControl
    {
        public frmScrapRowsSN() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmScrapCreateSN() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            Bind();
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmScrapRowsSN_Load(object sender, EventArgs e)
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
                DataTable dt = new DataTable();
                dt.Columns.Add("SOID");
                dt.Columns.Add("SCRAPDATE");
                dt.Columns.Add("NOTE");
                List<AssScrapOrder> Data = new List<AssScrapOrder>();
                if (Client.Session["Role"].ToString() == "SMOSECUser")
                {
                    Data = autofacConfig.assScrapOrderService.GetByUser(Client.Session["UserID"].ToString());
                }
                else
                {
                    Data = autofacConfig.assScrapOrderService.GetByUser(null);
                }
                if (Data.Count > 0)
                {
                    foreach (var data in Data)
                    {
                        dt.Rows.Add(data.SOID,data.SCRAPDATE.ToString("yyyy-MM-dd"),data.NOTE);
                    }
                    gridView1.DataSource = dt;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string roid = selectrow["SOID"].ToString();
                    frmScrapDetailSN frm = new frmScrapDetailSN();
                    frm.SOID = roid;
                    frm.Flex = 1;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                }
                else { Toast("未选择行！"); }
            });
        }
    }
}