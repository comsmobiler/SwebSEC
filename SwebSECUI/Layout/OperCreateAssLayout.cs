using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwebSECUI.AssetsManager;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class OperCreateAssLayout : Swebui.Controls.SwebUserControl
    {
        public OperCreateAssLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void plRow_Press(object sender, EventArgs e)
        {
            try
            {
                //MessageBox messageBox = new MobileMessageBox(this.Form);
                MessageBox.Show("是否删除该资产？", MessageBoxButtons.YesNo, (object s1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.Yes)
                        {
                            switch (LblType.BindDataValue.ToString())
                            {
                                case "CO":
                                    frmCoCreate coCreate = new frmCoCreate();
                                    coCreate.RemoveAss(lblASSID.Text);
                                    coCreate.BindListView();
                                    break;
                                case "BO":
                                    frmBoCreate boCreate = new frmBoCreate();
                                    boCreate.RemoveAss(lblASSID.Text);
                                    boCreate.BindListView();
                                    break;
                                case "RTO":
                                    frmRtoCreate rtoCreate = new frmRtoCreate();
                                    rtoCreate.RemoveAss(lblASSID.Text);
                                    rtoCreate.BindListView();
                                    break;
                                case "RSO":
                                    frmRsoCreate rsoCreate = new frmRsoCreate();
                                    rsoCreate.RemoveAss(lblASSID.Text);
                                    rsoCreate.BindListView();
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Parent.Form.Toast(ex.Message);
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