using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsDetail : Swebui.Controls.SwebUserControl
    {
        public frmAssetsDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        public string AssId; //资产编号
        private string LocationId; //区域编号
        private string TypeId; //类型编号
        private string ManagerId; //管理员编号
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string LastUser; //资产最近的拥有者
        private string DepId; //部门编号
        #endregion
        
        


    }

}