using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class CIResultTotalLayout : Swebui.Controls.SwebUserControl
    {
        public CIResultTotalLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 定义变量
        public String CID;       //耗材编号
        #endregion
        private void CIResultTotalLayout_Load(object sender, EventArgs e)
        {

        }
        public bool WaitVisible
        {
            set { lblNumber.Visible = label4.Visible = value; }
        }
        public string WaitNum
        {
            set { lblNumber.Text = value; }
        }
        public string RealAmount {
            get { return txtRealAmount.Text; }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(txtRealAmount.Text)) throw new Exception("实盘数量不能为空!");
                if (System.Text.RegularExpressions.Regex.IsMatch(txtRealAmount.Text.Trim(), "^\\d+$") == false)
                {
                    throw new Exception("请输入数字!");
                }
                this.ShowResult = ShowResult.Yes;
                this.Close();
             }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}