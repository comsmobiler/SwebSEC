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
    partial class CollarOrderLayout : Swebui.Controls.SwebUserControl
    {
        public CollarOrderLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmCoDetail coDetail = new frmCoDetail { CoId = LblID.BindDataValue.ToString() };
                this.Parent.Controls.Add(new frmCoDetail() { Flex = 1 });
                this.Parent.Controls.RemoveAt(0);
            }
            catch (Exception ex)
            {
                Parent.Form.Toast(ex.Message);
            }
        }
    }
}