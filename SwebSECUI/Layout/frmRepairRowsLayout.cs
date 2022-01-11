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
    partial class frmRepairRowsLayout : Swebui.Controls.SwebUserControl
    {
        public frmRepairRowsLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        /// <summary>
        /// 点击查看报修单详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plContent_Press(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmRepairDetailSN() { ROID = lblID.BindDataValue.ToString(), Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            ((frmRepairRowsSN)(Parent)).Bind();
        }
    }
}