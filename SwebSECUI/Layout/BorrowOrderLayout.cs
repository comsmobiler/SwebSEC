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
    partial class BorrowOrderLayout : Swebui.Controls.SwebUserControl
    {
        public BorrowOrderLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 点击，查看借用单详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmBoDetail boDetail = new frmBoDetail { BoId = LblID.BindDataValue.ToString() };
                this.Parent.Controls.Add(new frmBoDetail() { Flex = 1 });
                this.Parent.Controls.RemoveAt(0);
            }
            catch (Exception ex)
            {
                Parent.Form.Toast(ex.Message);
            }
        }
    }
}