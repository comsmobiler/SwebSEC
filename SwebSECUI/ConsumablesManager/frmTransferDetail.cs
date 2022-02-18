using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;
using SwebSECUI.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmTransferDetail : Swebui.Controls.SwebUserControl
    {
        public frmTransferDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String TOID;     //调拨单编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConTransferDetail_Load(object sender, EventArgs e)
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
                lblTID.Text = TOID;
                TOInputDto TOData = autofacConfig.assTransferOrderService.GetByID(TOID);
                coreUser DeanInUser = autofacConfig.coreUserService.GetUserByID(TOData.MANAGER);
                coreUser DealUser = autofacConfig.coreUserService.GetUserByID(TOData.HANDLEMAN);
                AssLocation assLocation = autofacConfig.assLocationService.GetByID(TOData.DESLOCATIONID);
                lblTDInMan.Text = DeanInUser.USER_NAME;
                lblDealMan.Text = DealUser.USER_NAME;
                lblLocation.Text = assLocation.NAME;
                lblDatePicker.Text = TOData.TRANSFERDATE.ToString();
                if (String.IsNullOrEmpty(TOData.NOTE) == false) lblNote.Text = TOData.NOTE;

                //DataTable tableAssets = new DataTable();      //未开启SN的资产列表
                //tableAssets.Columns.Add("CID");               //耗材编号
                //tableAssets.Columns.Add("NAME");              //资产名称
                //tableAssets.Columns.Add("IMAGE");             //资产图片
                //tableAssets.Columns.Add("WAITREPAIRQTY");     //待确认数量
                //tableAssets.Columns.Add("STATUS");            //行项状态
                foreach (AssTransferOrderRow Row in TOData.Rows)
                {
                    ConsumablesOutputDto cons = autofacConfig.ConsumablesService.GetConsumablesByID(Row.CID);
                    if (Row.STATUS == 0)
                    {
                        snPanel.Controls.Add(new ConTransDetailLayout() { CID = Row.CID, NAME = cons.NAME, Image = cons.IMAGE, INTRANSFERQTY = Row.INTRANSFERQTY.ToString(), Status = "调拨中" });
                    }
                    else if (Row.STATUS == 1)
                    {
                        snPanel.Controls.Add(new ConTransDetailLayout() { CID = Row.CID, NAME = cons.NAME, Image = cons.IMAGE, INTRANSFERQTY = Row.INTRANSFERQTY.ToString(), Status = "已完成" });
                    }
                    else
                    {
                        snPanel.Controls.Add(new ConTransDetailLayout() { CID = Row.CID, NAME = cons.NAME, Image = cons.IMAGE, INTRANSFERQTY = Row.INTRANSFERQTY.ToString(), Status = "已取消" });
                    }
                }
                if (Client.Session["Role"].ToString() == "SMOSECUser")
                    INBtn.Visible = OutBtn.Visible = false;
                //如果调拨完成 隐藏 调拨按钮
                if (TOData.STATUS == 1 || TOData.STATUS == 2)
                    INBtn.Visible = OutBtn.Visible = false;
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
            this.Parent.Controls.Add(new frmTransferRows() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 调拨确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void INBtn_Click(object sender, EventArgs e)
        {
            frmTransferDeal frmTransferDeal = new frmTransferDeal();
            frmTransferDeal.TOID = TOID;
            frmTransferDeal.Type = SMOSEC.DTOs.Enum.PROCESSMODE.调拨确认;
            frmTransferDeal.Flex = 1;
            this.Parent.Controls.Add(frmTransferDeal);
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 调拨取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutBtn_Click(object sender, EventArgs e)
        {
            frmTransferDeal frmTransferDeal = new frmTransferDeal();
            frmTransferDeal.TOID = TOID;
            frmTransferDeal.Type = SMOSEC.DTOs.Enum.PROCESSMODE.调拨取消;
            frmTransferDeal.Flex = 1;
            this.Parent.Controls.Add(frmTransferDeal);
            this.Parent.Controls.RemoveAt(0);
        }


    }
}