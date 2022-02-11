using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class PWDLayout : Swebui.Controls.SwebUserControl
    {
        public PWDLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String oldPwd;        //旧密码
        #endregion
        /// <summary>
        /// 验证原始密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                coreUser user = autofacConfig.coreUserService.GetUserByID(Client.Session["UserID"].ToString());
                oldPwd = user.USER_PASSWORD;
                if(txtEditInfo.Text.Equals(oldPwd))
                {
                    panel5.Visible = panel6.Visible = true;
                    oldPsdPanel.Visible = panel4.Visible = false;
                }
                else
                {
                    errorlab.Text = "密码错误！";
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String newPwd1 = txtPassWord1.Text.Trim();
                String newPwd2 = txtPassWord2.Text.Trim();
                if (newPwd1.Length < 0) throw new Exception("请输入新密码!");
                if (newPwd1.Length < 6 || newPwd1.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (newPwd2.Length < 0) throw new Exception("请输入确认密码!");
                if (newPwd2.Length < 6 || newPwd2.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (newPwd1.Equals(newPwd2) == false) throw new Exception("两次密码输入不一致，请检查!");
                if (oldPwd.Equals(newPwd1)) throw new Exception("新密码不能与原密码相同，请重新输入!");
                ReturnInfo RInfo = autofacConfig.coreUserService.ChangePwd(Client.Session["UserID"].ToString(), oldPwd, newPwd1);
                if (RInfo.IsSuccess == true)
                {
                    Toast("密码修改成功");
                    this.Close();
                }
                else
                {
                    throw new Exception(RInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}