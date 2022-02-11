using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.Domain.Entity;
using System.Data;
using SMOSEC.DTOs.Enum;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmTransferDetailSN : Swebui.Controls.SwebUserControl
    {
        public frmTransferDetailSN() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String TOID;     //调拨单编号
        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmTransferRowsSN() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferDetailSN_Load(object sender, EventArgs e)
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
                TOInputDto TOData = autofacConfig.assTransferOrderService.GetByID(TOID);
                coreUser DeanInUser = autofacConfig.coreUserService.GetUserByID(TOData.MANAGER);
                coreUser DealUser = autofacConfig.coreUserService.GetUserByID(TOData.HANDLEMAN);
                AssLocation assLocation = autofacConfig.assLocationService.GetByID(TOData.DESLOCATIONID);
                lblTDInMan.Text = DeanInUser.USER_NAME;
                lblDealMan.Text = DealUser.USER_NAME;
                lblLocation.Text = assLocation.NAME;
                DatePicker.Value = TOData.TRANSFERDATE;
                if (String.IsNullOrEmpty(TOData.NOTE) == false) lblNote.Text = TOData.NOTE;

                DataTable tableAssets = new DataTable();      //未开启SN的资产列表
                tableAssets.Columns.Add("ASSID");             //资产编号
                tableAssets.Columns.Add("NAME");              //资产名称
                tableAssets.Columns.Add("IMAGE");             //资产图片
                tableAssets.Columns.Add("SN");                //序列号
                tableAssets.Columns.Add("STATUS");            //行项状态
                foreach (AssTransferOrderRow Row in TOData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "调拨中");
                    }
                    else if (Row.STATUS == 1)
                    {
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "调拨完成");
                    }
                    else
                    {
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "调拨取消");
                    }
                }
                if (tableAssets.Rows.Count > 0)
                {
                    ListAssetsSN.DataSource = tableAssets;
                    ListAssetsSN.DataBind();
                }
                if (Client.Session["Role"].ToString() == "SMOSECUser") panel2.Visible = false;
                //如果维修单已完成，则隐藏维修单处理按钮
                if (TOData.STATUS == 1 || TOData.STATUS == 2) panel2.Visible = false;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 调拨确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            frmTransferDealSN frm = new frmTransferDealSN();
            frm.TOID = TOID;
            frm.Flex = 1;
            this.Parent.Controls.Add(frm);
            this.Parent.Controls.RemoveAt(0);
            frm.Type = PROCESSMODE.调拨确认;
            Bind();   //刷新数据显示
        }
        /// <summary>
        /// 调拨取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            frmTransferDealSN frm = new frmTransferDealSN();
            frm.TOID = TOID;
            frm.Flex = 1;
            this.Parent.Controls.Add(frm);
            this.Parent.Controls.RemoveAt(0);
            frm.Type = PROCESSMODE.调拨取消;
            Bind();   //刷新数据显示
        }
    }
}