using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmScrapDetailSN : Swebui.Controls.SwebUserControl
    {
        public frmScrapDetailSN() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String SOID;     //报废单编号
        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmScrapRowsSN() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            frmScrapDealSN frm = new frmScrapDealSN();
            frm.SOID = SOID;
            frm.Flex = 1;
            this.Parent.Controls.Add(frm);
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmScrapDetailSN_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
                SOInputDto SOData = autofacConfig.assScrapOrderService.GetByID(SOID);
                coreUser User = autofacConfig.coreUserService.GetUserByID(SOData.SCRAPMAN);
                lblDealMan.Text = User.USER_NAME;
                DatePicker.Value = SOData.SCRAPDATE;
                txtNote.Text = SOData.NOTE;

                if (String.IsNullOrEmpty(SOData.NOTE)) txtNote.Text = SOData.NOTE;

                DataTable tableAssets = new DataTable();      //未开启SN的资产列表
                tableAssets.Columns.Add("ASSID");             //资产编号
                tableAssets.Columns.Add("NAME");              //资产名称
                tableAssets.Columns.Add("IMAGE");             //资产图片
                tableAssets.Columns.Add("SN");                //序列号
                tableAssets.Columns.Add("STATUS");            //行项状态
                foreach (AssScrapOrderRow Row in SOData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "已报废");
                    }
                    else
                    {
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "已还原");
                    }
                }
                if (tableAssets.Rows.Count > 0)
                {
                    ListAssetsSN.DataSource = tableAssets;
                    ListAssetsSN.DataBind();
                }
                if (Client.Session["Role"].ToString() == "SMOSECUser") SaveBtn.Visible = false;
                //如果维修单已完成，则隐藏维修单处理按钮
                if (SOData.STATUS == 1) SaveBtn.Visible = false;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}