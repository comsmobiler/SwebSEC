using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;
using SMOSEC.CommLib;
using SwebSECUI.MasterData;

namespace SwebSECUI.UserInfo
{
    partial class frmVerificationCode : Swebui.Controls.SwebForm
    {
        public frmVerificationCode() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String Tel;       //手机号码
        public Boolean isForgetPwd;             //是否忘记密码
        public String code;             //手机验证码
        public Boolean isPwd1;       //新密码是否显示密码字符变量
        private Boolean isPwd2;     //确认密码是否显示密码字符变量


        #endregion

        /// <summary>
        /// 新密码是否显示密码字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpPwd1_Press(object sender, EventArgs e)
        {
            if (isPwd1 == false)
            {
                txtPwd1.SecurityMode = true;
                //设置textbox为密码字符
                fontPwd1.ResourceID = "eye-slash";
                isPwd1 = true;
            }
            {
                txtPwd1.SecurityMode = false;
                //textbox密码字符为空时，显示明文
                fontPwd1.ResourceID = "eye";
                isPwd1 = false;
            }
        }
        /// <summary>
        /// 确认密码是否显示密码字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpPwd2_Press(object sender, EventArgs e)
        {
            if (isPwd2 == false)
            {
                txtPwd2.SecurityMode = false;
                //设置textbox为密码字符
                fontPwd2.ResourceID = "eye-slash";
                isPwd2 = true;
            }
            else
            {
                txtPwd2.SecurityMode = false;
                //textbox密码字符为空时，显示明文
                fontPwd2.ResourceID = "eye";
            }
        }
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim().Length < 0) throw new Exception("请输入昵称");
                String pwd1 = txtPwd1.Text.Trim();
                String pwd2 = txtPwd2.Text.Trim();
                if (pwd1.Length <= 0) throw new Exception("请输入新密码!");
                if (pwd1.Length < 6 || pwd1.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (pwd2.Length <= 0) throw new Exception("请输入确认密码!");
                if (pwd2.Length < 6 || pwd2.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (pwd1.Equals(pwd2) == false) throw new Exception("两次密码输入不一致，请检查!");
                if (String.IsNullOrEmpty(comboBox1.Text)) throw new Exception("请选择角色!");
                if (comboBox1.Text != "ADMIN")     //用户必须选择区域，管路员可以不选
                {
                    if (btnLocation.Text == null) throw new Exception("请选择所属区域");
                }


                coreUser UserData = new coreUser();
                UserData.USER_ID = Tel;
                if (btnLocation.Tag != null)
                UserData.USER_LOCATIONID = btnLocation.Tag.ToString();
                UserData.USER_NAME = txtName.Text;
                UserData.USER_PASSWORD = pwd1;
                UserData.USER_PHONE = Tel;
                UserData.USER_LANGUAGE = 0;
                UserData.USER_ROLE = comboBox1.Text;

                ReturnInfo RInfo = autofacConfig.coreUserService.AddUser(UserData);
                if (RInfo.IsSuccess)
                {
                    Client.Session["UserID"] = Tel;
                    Client.Session["Role"] = comboBox1.Text;
                    MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, (obj, args) => {
                        this.Close();
                    });
                    Show(new MainForm());
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
        /// 选择所属区域后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void frmVerificationCode_Load(object sender, EventArgs e)
        {

        }
    }

}