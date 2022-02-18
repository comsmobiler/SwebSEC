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
    partial class frmTransferCreate : Swebui.Controls.SwebUserControl
    {
        public frmTransferCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConsumablesOrderRow> RowData = new List<ConsumablesOrderRow>();    //未开启SN行项
        public TOInputDto TransferData = new TOInputDto();        //维修单信息
        public String CID;               //耗材编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferCreate_Load(object sender, EventArgs e)
        {
            ///绑定调入管理员数据
            List<coreUser> users = autofacConfig.coreUserService.GetDealInAdmin();
            foreach (coreUser Row in users)
            {
                btnDealInMan.Nodes.Add(new TreeSelectNode(Row.USER_ID, Row.USER_NAME));
            }
            ///绑定调入区域数据
            List<AssLocation> locations = autofacConfig.assLocationService.GetEnableAll();
            foreach (AssLocation Row in locations)
            {
                btnLocation.Nodes.Add(new TreeSelectNode(Row.LOCATIONID, Row.NAME));
            }
            ///绑定处理人数据
            List<coreUser> users1 = autofacConfig.coreUserService.GetAdmin();
            foreach (coreUser Row in users1)
            {
                btnDealMan.Nodes.Add(new TreeSelectNode(Row.USER_ID, Row.USER_NAME));
            }
            datepicker.Value = DateTime.Now;
        }
        /// <summary>
        ///返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmTransferRows() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnDealInMan.Tag == null)
                    throw new Exception("调入管理员不能为空");
                else
                    TransferData.MANAGER = btnDealInMan.Tag.ToString();     //调入管理员

                if (btnLocation.Tag == null)
                    throw new Exception("调入区域不能为空");
                else
                    TransferData.DESLOCATIONID = btnLocation.Tag.ToString();     //调入区域

                if (btnDealMan.Tag == null)
                    throw new Exception("处理人不能为空");
                else
                    TransferData.HANDLEMAN = btnDealMan.Tag.ToString();     //处理人

                TransferData.TRANSFERDATE = datepicker.Value;   //调入时间
                TransferData.NOTE = txtNote.Text;                           //备注
                TransferData.STATUS = 0;                                    //调拨单状态
                TransferData.CREATEUSER = Client.Session["UserID"].ToString();      //创建用户
                TransferData.CREATEDATE = DateTime.Now;

                List<AssTransferOrderRow> Data = new List<AssTransferOrderRow>();
                if (snPanel.Controls.Count == 0) throw new Exception("调拨行项不能为空!");
                foreach (ConTDLayout RowData in snPanel.Controls)
                {
                    if (RowData.IsChecked)
                    {
                        if (Convert.ToDecimal(RowData.Num) > Convert.ToDecimal(RowData.INTRANSFERQTY)) throw new Exception("选择数量不可超过可用数量!");
                        if (Convert.ToDecimal(RowData.Num) == 0) throw new Exception("选择数量不能为0!");
                        AssTransferOrderRow assRow = new AssTransferOrderRow();
                        assRow.IMAGE = RowData.Image;
                        assRow.CID = RowData.CID;
                        assRow.INTRANSFERQTY = Convert.ToDecimal(RowData.Num);
                        assRow.LOCATIONID = RowData.LOCATIONID;
                        assRow.STATUS = 0;
                        assRow.CREATEDATE = DateTime.Now;
                        Data.Add(assRow);
                    }

                }
                TransferData.Rows = Data;
                ReturnInfo r = autofacConfig.assTransferOrderService.AddAssTransferOrder(TransferData, OperateType.耗材);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("创建调拨单成功!");
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
        /// 调入管理员选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealInMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnDealInMan.Tag = args.TreeID;
        }
        /// <summary>
        /// 处理人选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnDealMan.Tag = args.TreeID;
        }
        /// <summary>
        /// 区域选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnLocation_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnLocation.Tag = args.TreeID;
        }
        /// <summary>
        /// 选择耗材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnLocation.Tag == null) throw new Exception("请选择调入区域!");
                ConTransferConsChooseDialog frm = new ConTransferConsChooseDialog();
                frm.LocInID = btnLocation.Tag.ToString();
                ShowDialog(frm, (sender1, args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        //重新加载数据
                        RowData = frm.RowData;
                        Bind();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
           // snPanel.Controls.Clear();
                if (RowData.Count > 0)
                {
                    foreach (ConsumablesOrderRow Row in RowData)
                    {
                        ConQuant conQuant = autofacConfig.orderCommonService.GetUnUseConByCID(Row.CID, Row.LOCATIONID);
                        Consumables con = autofacConfig.orderCommonService.GetConsByID(Row.CID);
                        AssLocation Loc = autofacConfig.assLocationService.GetByID(Row.LOCATIONID);
                        bool isExist = false;
                        foreach (ConTDLayout layout in snPanel.Controls)
                        {
                            if (Row.CID == layout.CID && Row.LOCATIONID == layout.LOCATIONID)
                            {
                                layout.Num = (Convert.ToDecimal(layout.Num) + Row.QTY).ToString();
                                isExist = true;
                                break;
                            }
                        }
                        if(isExist==false)
                        snPanel.Controls.Add(new ConTDLayout() { IsChecked=true,CID = Row.CID, NAME = con.NAME, LOCATIONID = Row.LOCATIONID, LOCATIONNAME = Loc.NAME, Image = con.IMAGE, INTRANSFERQTY = conQuant.QUANTITY.ToString(), Num = Row.QTY.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        ///    全选按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (snPanel.Controls.Count > 0)
            {
                foreach (ConTDLayout Row in snPanel.Controls)
                {
                    Row.IsChecked = CheckAll.Checked;
                }
            }
        }
    }
}