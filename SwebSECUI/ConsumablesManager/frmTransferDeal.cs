using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
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
    partial class frmTransferDeal : Swebui.Controls.SwebUserControl
    {
        public frmTransferDeal() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String TOID;     //调拨单编号
        public PROCESSMODE Type;   //操作类型
        #endregion

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferDeal_Load(object sender, EventArgs e)
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
                if (Type == PROCESSMODE.调拨确认) title1.Text = "调拨单确认";
                if (Type == PROCESSMODE.调拨取消) title1.Text = "调拨单取消";
                TOInputDto TOData = autofacConfig.assTransferOrderService.GetByID(TOID);
                coreUser DeanInUser = autofacConfig.coreUserService.GetUserByID(TOData.MANAGER);
                coreUser DealUser = autofacConfig.coreUserService.GetUserByID(TOData.HANDLEMAN);
                AssLocation assLocation = autofacConfig.assLocationService.GetByID(TOData.DESLOCATIONID);
                lblTDInMan.Text = DeanInUser.USER_NAME;
                lblDealMan.Text = DealUser.USER_NAME;
                lblLocation.Text = assLocation.NAME;
                lblDatePicker.Text = TOData.TRANSFERDATE.ToString();
                if (String.IsNullOrEmpty(TOData.NOTE)) lblNote.Text = TOData.NOTE;
                foreach (AssTransferOrderRow Row in TOData.Rows)
                {
                    Consumables cons = autofacConfig.orderCommonService.GetConsByID(Row.CID);
                    AssLocation Location = autofacConfig.assLocationService.GetByID(Row.LOCATIONID);
                    if (Row.STATUS == 0)
                    {
                        snPanel.Controls.Add(new ConTDLayout() { TOROWID = Row.TOROWID, LOCATIONID = Row.LOCATIONID, LOCATIONNAME = Location.NAME, CID = Row.CID, NAME = cons.NAME, Image = Row.IMAGE, INTRANSFERQTY = Row.INTRANSFERQTY.ToString() });

                    }
                }
                //if (tableAssets.Rows.Count > 0)
                //{
                //    ListAssets.DataSource = tableAssets;
                //    ListAssets.DataBind();
                //}
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
            this.Parent.Controls.Add(new frmTransferDetail() { TOID = TOID, Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TOInputDto BasicData = new TOInputDto();
                BasicData.MODIFYDATE = DateTime.Now;
                BasicData.MODIFYUSER = Client.Session["UserID"].ToString();
                BasicData.TOID = TOID;

                List<AssTransferOrderRow> DataList = new List<AssTransferOrderRow>();
                foreach (ConTDLayout Row in snPanel.Controls)
                {

                    if (Row.IsChecked)
                    {
                        if (Convert.ToDecimal(Row.Num) > Convert.ToDecimal(Row.INTRANSFERQTY))
                        {
                            if (Type == PROCESSMODE.调拨确认)
                                throw new Exception("确认数量不能超过调拨数量!");
                            else
                                throw new Exception("取消数量不能超过调拨数量!");
                        }
                        AssTransferOrderRow Data = new AssTransferOrderRow();
                        Data.TOROWID = Row.TOROWID;
                        Data.IMAGE = Row.Image;
                        Data.CID = Row.CID;
                        if (Type == PROCESSMODE.调拨确认)
                        {
                            Data.STATUS = 1;
                            if (Convert.ToDecimal(Row.Num) == 0)
                                Data.TRANSFEREDQTY = Convert.ToDecimal(Row.INTRANSFERQTY);
                            else
                                Data.TRANSFEREDQTY = Convert.ToDecimal(Row.Num);
                        }
                        else
                        {
                            Data.STATUS = 2;
                            if (Convert.ToDecimal(Row.Num) == 0)
                                Data.TRANSFERCANCELQTY = Convert.ToDecimal(Row.INTRANSFERQTY);
                            else
                                Data.TRANSFERCANCELQTY = Convert.ToDecimal(Row.Num);
                        }
                        Data.LOCATIONID = Row.LOCATIONID;
                        DataList.Add(Data);
                    }
                }
                if (DataList.Count == 0) throw new Exception("请选择确认行项!");
                BasicData.Rows = DataList;
                ReturnInfo r = autofacConfig.assTransferOrderService.UpdateAssTransferOrder(BasicData, Type, OperateType.耗材);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    if (Type == PROCESSMODE.调拨确认)
                    {
                        Toast("确认调拨成功!");
                    }
                    else
                    {
                        Toast("取消调拨成功!");
                    }
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 全选按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (snPanel.Controls.Count > 0)
            {
                foreach (ConTDLayout Row in snPanel.Controls)
                {
                    Row.IsChecked = checkAll.Checked;
                }
            }
        }

    }
}