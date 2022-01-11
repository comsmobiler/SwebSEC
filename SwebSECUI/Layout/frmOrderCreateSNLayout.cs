using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.InputDTO;
using SwebSECUI.AssetsManager;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmOrderCreateSNLayout : Swebui.Controls.SwebUserControl
    {
        public frmOrderCreateSNLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public AssetsOrderRow getData()
        {
            AssetsOrderRow Data = new AssetsOrderRow();
            Data.IMAGE = imgAss.BindDisplayValue.ToString();
            Data.ASSID = lblName.BindDataValue.ToString();
            Data.SN = lblSN.BindDataValue.ToString();
            Data.QTY = 1;
            //Data.LOCATIONID = lblLocation.BindDataValue.ToString();
            Data.STATUS = 0;
            return Data;
        }
        private void plRow_Press(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("是否删除该行项?", "系统提醒", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.Yes)     //删除该区域
                        {
                            switch (Form.ToString())
                            {
                                case "SwebSECUI.AssetsManager.frmRepairCreateSN":
                                    ((frmRepairCreateSN)this.Parent).ReMoveAssSN(lblName.BindDataValue.ToString(), lblSN.BindDataValue.ToString());
                                    break;
                                case "SwbSECUI.AssetsManager.frmScrapCreateSN":
                                    ((frmScrapCreateSN)this.Parent).ReMoveAssSN(lblName.BindDataValue.ToString(), lblSN.BindDataValue.ToString());
                                    break;
                                    //case "SwbSECUI.AssetsManager.frmTransferCreateSN":
                                    //    ((frmTransferCreateSN)this.Parent).ReMoveAssSN(lblName.BindDataValue.ToString(), lblSN.BindDataValue.ToString());
                                    //    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Form.Toast(ex.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}