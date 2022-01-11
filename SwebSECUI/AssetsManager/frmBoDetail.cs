using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmBoDetail : Swebui.Controls.SwebUserControl
    {
        public frmBoDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string BoId;  //借用单编号
    }
}