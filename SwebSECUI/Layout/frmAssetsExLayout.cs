using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwebSECUI.MasterData;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsExLayout : Swebui.Controls.SwebUserControl
    {
        public frmAssetsExLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        /// <summary>
        /// 点击行项，进入资产详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void touchPanel1_Press(object sender, EventArgs e)
        //{

        //    //this.Controls.Add(new frmAssetsDetail() { AssId = lblID.BindDataValue.ToString(), Flex = 1 });
        //    //this.Controls.RemoveAt(0);
        //    ((frmAssets)Form).Bind();
        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((frmAssets)Form).SelectAssId = checkBox1.Checked ? lblID.Text : "";
                ((frmAssets)Form).Bind();
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}