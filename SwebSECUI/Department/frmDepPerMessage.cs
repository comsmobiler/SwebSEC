using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.Department
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmDepPerMessage : Swebui.Controls.SwebUserControl
    {
        public frmDepPerMessage() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String UserID;        //用户名
        #endregion
    }
}