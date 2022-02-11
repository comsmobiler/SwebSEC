using SMOSEC.DTOs.OutputDTO;
using SwebSECUI.Layout;
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
    partial class frmOutOrderDetail : Swebui.Controls.SwebUserControl
    {
        public frmOutOrderDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类      
        public string OOId;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOutOrderDetail_Load(object sender, EventArgs e)
        {
            try
            {
                lblOrder.Text = OOId;
                OutboundOrderOutputDto outboundOrder = _autofacConfig.ConsumablesService.GetOutboundOrderById(OOId);
                if (outboundOrder != null)
                {
                    txtType.Text = outboundOrder.TYPENAME;
                    txtHMan.Text = outboundOrder.HANDLEMANNAME;
                    txtLocation.Text = outboundOrder.LOCATIONNAME;
                    txtNote.Text = outboundOrder.NOTE;
                    DPickerCO.Text = outboundOrder.BUSINESSDATE.ToString();
                    txtType.Text = outboundOrder.TYPE == 1 ? "退货" : "领用";
                }

                DataTable rowsTable = _autofacConfig.ConsumablesService.GetOORowListByOOId(OOId);
                if (rowsTable != null)
                {
                    foreach(DataRow row in rowsTable.Rows)
                    {
                        listPanel.Controls.Add(new ConDetialLayout()
                        {
                            CONName = row["NAME"].ToString(),
                            Img = row["IMAGE"].ToString(),
                            TemplateID = row["CID"].ToString(),
                            NumQuant= row["QUANTITY"].ToString(),
                            NumPrice= row["MONEY"].ToString(),
                            TXTNote= row["NOTE"].ToString()
                        }) ;
                    }
                }
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
            this.Parent.Controls.Add(new frmOutboundOrder() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
    }
}