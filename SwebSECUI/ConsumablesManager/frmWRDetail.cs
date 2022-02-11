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
    partial class frmWRDetail : Swebui.Controls.SwebUserControl
    {
        public frmWRDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string WRID; //入库单编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWRDetail_Load(object sender, EventArgs e)
        {
            try
            {
                WarehouseReceiptOutputDto warehouseReceipt = _autofacConfig.ConsumablesService.GetWarehouseReceiptById(WRID);
                if (warehouseReceipt != null)
                {
                    lblOrder.Text = WRID;
                    txtVendor.Text = warehouseReceipt.VENDOR;
                    txtHMan.Text = warehouseReceipt.HANDLEMANNAME;
                    txtLocatin.Text = warehouseReceipt.LOCATIONNAME;
                    txtNote.Text = warehouseReceipt.NOTE;
                    DPickerCO.Text = warehouseReceipt.BUSINESSDATE.ToString();
                }

                DataTable rowsTable = _autofacConfig.ConsumablesService.GetWRRowListByWRId(WRID);
                if (rowsTable != null)
                {
                    foreach (DataRow row in rowsTable.Rows)
                    {
                        listPanel.Controls.Add(new ConDetialLayout()
                        {
                            Img = row["IMAGE"].ToString(),
                            TemplateID = row["CID"].ToString(),
                            CONName = row["NAME"].ToString(),
                            NumQuant = row["QUANTITY"].ToString(),
                            NumPrice = row["MONEY"].ToString(),
                            TXTNote = row["NOTE"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 返回按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmWarehouseReceipt() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

    }
}