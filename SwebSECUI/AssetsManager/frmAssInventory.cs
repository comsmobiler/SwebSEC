using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using SMOSEC.DTOs.Enum;
using SwebSECUI.Layout;
using SMOSEC.CommLib;
using SMOSEC.DTOs.InputDTO;
using SwebSECUI.AssetsManager;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssInventory : Swebui.Controls.SwebUserControl
    {
        public frmAssInventory() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化界面时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventory_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 添加盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmAssInventoryCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            Bind();
        }
        //绑定数据
        public void Bind()
        {
            try
            {

                string LocationId = "";
                string UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                }

                DataTable assInventoryList = _autofacConfig.AssInventoryService.GetAssInventoryList(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "", LocationId);

                if (assInventoryList.Rows.Count > 0)
                {
                    gridView1.DataSource = assInventoryList;
                    gridView1.DataBind();
                }
                //foreach (var row in gridView1)
                //{
                //    frmAssInventoryLayout layout = (frmAssInventoryLayout)row.Control;
                //    switch (layout.label1.Text)
                //    {
                //        case "盘点结束":
                //            layout.label1.ForeColor = Color.FromArgb(43, 125, 43);
                //            break;
                //        case "盘点中":
                //            layout.label1.ForeColor = Color.FromArgb(43, 140, 255);
                //            layout.btnStart.Text = "继续盘点";
                //            break;
                //        case "盘点未开始":
                //            layout.label1.ForeColor = Color.FromArgb(211, 215, 217);
                //            break;
                //    }
                //}

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 编辑盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["IID"].ToString();
                    frmAssInventoryEdit frm = new frmAssInventoryEdit() { Flex = 1 };
                    frm.IID = id;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                }
                else
                {
                    Toast("未选择行！");
                }

            });
        }
        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["IID"].ToString();
                    gridView1.RemoveRow();
                }
                else
                {
                    Toast("未选择行！");
                }
            });
        }
        /// <summary>
        /// 开始盘点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            gridView1.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string id = selectrow["IID"].ToString();
                    frmAssInventoryResult frm = new frmAssInventoryResult() { Flex = 1 };
                    frm.IID = id;
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