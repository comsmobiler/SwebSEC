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
    partial class frmScrapRowsLayout : Swebui.Controls.SwebUserControl
    {
        public frmScrapRowsLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 点击查看报废单详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plContent_Press(object sender, EventArgs e)
        {
            try
            {
                frmScrapDetailSN frm = new frmScrapDetailSN { SOID = lblID.BindDataValue.ToString() };
                this.Parent.Controls.Add(new frmScrapDetailSN() { Flex = 1 });
                this.Parent.Controls.RemoveAt(0);
                ((frmScrapRowsSN)Parent).Bind();        //重新绑定数据
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}