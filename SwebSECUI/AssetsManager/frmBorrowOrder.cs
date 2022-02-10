using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SMOSEC.Domain.Entity;


namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmBorrowOrder : Swebui.Controls.SwebUserControl
    {
        public frmBorrowOrder() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        //public string BoNo;//借用单模板编号
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmBoCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            Bind();
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBorrowOrder_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        private void Bind()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("BOID");
                dt.Columns.Add("BORROWER");
                dt.Columns.Add("BORROWDATE");
                dt.Columns.Add("LOCATIONNAME");
                string LocationId = "";
                string UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                 
                }
                if (Client.Session["Role"].ToString() == "SMOSECUser")
                {
                    plButton.Visible = false;
                }
                DataTable table = _autofacConfig.AssetsService.GetBoByUserId(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "", LocationId);
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow data in table.Rows)
                    {
                        dt.Rows.Add(data["BOID"], data["BORROWER"], ((DateTime)data["BORROWDATE"]).ToString("yyyy-MM-dd"), data["LOCATIONNAME"]);
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

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["BOID"].ToString();
                    frmBoDetail frm = new frmBoDetail() { Flex = 1 };
                    frm.BoId = id;
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