using SMOSEC.CommLib;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwebSECUI.UserInfo;

namespace SwebSECUI
{
    partial class FrmLogon : Swebui.Controls.SwebForm
    {
        public FrmLogon() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogon_Click(object sender, EventArgs e)
        {
            try
            {
                String userID = txtUserName.Text.Trim();
                String PassWord = txtPassWord.Text.Trim();
                if (userID.Length <= 0)
                    throw new Exception("请输入手机号码");
                if (PassWord.Length < 0)
                    throw new Exception("请输入密码");
                LoadClientData(Client.SessionID + "user", userID);
                ReturnInfo result = autofacConfig.coreUserService.Login(userID, PassWord);

                if (result.IsSuccess)
                {
                    String Role = autofacConfig.coreUserService.GetUserByID(userID).USER_ROLE;
                    Client.Session["UserID"] = userID;
                    Client.Session["Role"] = Role;
                    MainForm frm = new MainForm();
                    Show(frm);
                }
                else
                {
                    throw new Exception(result.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Show(new FrmRegister());
        }
        /// <summary>
        /// 快速登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String Role = autofacConfig.coreUserService.GetUserByID("13123456789").USER_ROLE;
                Client.Session["UserID"] = "13123456789";
                Client.Session["Role"] = Role;
                MainForm frm = new MainForm();
                Show(frm);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
    }
}