using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmCollarOrder : Swebui.Controls.SwebUserControl
    {
        public frmCollarOrder() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmCoCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            Bind();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCollarOrder_Load(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("CoId");
                dt.Columns.Add("Userid");
                dt.Columns.Add("Collardate");
                dt.Columns.Add("LocationName");
                dt.Columns.Add("Place");
                dt.Columns.Add("InUsedDep");
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
                DataTable assborrowTable = _autofacConfig.AssetsService.GetCoByUserId(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "", LocationId);
               
                if (assborrowTable.Rows.Count > 0)
                {
                    foreach (DataRow data in assborrowTable.Rows)
                    {
                        dt.Rows.Add(data["CoId"], data["Userid"], ((DateTime)data["Collardate"]).ToString("yyyy-MM-dd"), data["LocationName"],data["Place"], data["InUsedDep"]);
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
                    string id = selectrow["CoId"].ToString();
                    frmCoDetail frm = new frmCoDetail() { Flex = 1 };
                    frm.CoId = id;
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