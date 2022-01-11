using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;

namespace SwebSECUI.UserInfo
{
    partial class FrmRegister : Swebui.Controls.SwebForm
    {
        public FrmRegister() : base()
        {
            //This call is required by the SwebForm.
            InitializeComponent();
        }

        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public Boolean isForgetPwd;       //是否忘记手机密码
        public String UserID;             //用户编号(手机号码或者邮箱)
        //string VCode = "1234";
        public String Tel;       //手机号码
        public String code;             //手机验证码
        public Boolean isPwd1;       //新密码是否显示密码字符变量
        private Boolean isPwd2;     //确认密码是否显示密码字符变量
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Boolean isPhone = false;
                if (txtTel.Text.Trim().Length <= 0)    //是否是手机号码
                    throw new Exception("请输入电话号码!");
                else
                {
                    UserID = txtTel.Text.Trim();
                    if (isForgetPwd)
                    {
                        if (UserID.Contains("@"))
                        {
                            Regex regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                            if (regex.IsMatch(UserID) == false)
                                throw new Exception("邮箱格式不正确!");
                        }
                        else
                        {
                            Regex regex = new Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                            if (regex.IsMatch(UserID) == false)
                                throw new Exception("手机号码格式不正确!");
                            else
                                isPhone = true;
                        }
                    }
                    else
                    {
                        isPhone = true;
                    }
                    if (isPhone)
                    {
                        //验证手机号码是否已注册
                        Boolean isRegister = autofacConfig.coreUserService.PhoneIsExit(UserID);
                        //手机注册时，验证手机号码是否已注册，当返回true时，则抛出错误
                        if (isRegister == true) throw new Exception("电话号码" + UserID + "已注册!");
                        if (isRegister == false && isForgetPwd == true) throw new Exception("账号" + UserID + "不存在!");
                    }
                    int result = autofacConfig.ValidateCodeService.SendVCodeM(UserID, Client.DeviceID);
                    if (result != 0)
                    {
                        if (isPhone)
                        {
                            //frmVerificationCode frm = new frmVerificationCode
                            {
                                Tel = UserID;
                                isForgetPwd = isForgetPwd;
                                code = result.ToString();
                            };
                            //Show(frm);
                            panel3.Visible = false;
                            panel4.Visible = false;
                            panel5.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

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
                if (comboBox1.Text != "SMOSECUser")     //用户必须选择区域，管路员可以不选
                {
                    if (comboBox2.Text == null) throw new Exception("请选择所属区域");
                }
                List<string> listrole = new List<string>();
                listrole.Add(comboBox1.SelectKey);
                listrole.Add(comboBox2.SelectKey);

                coreUser UserData = new coreUser();
                UserData.USER_ID = Tel;
                if (comboBox2.Tag != null)
                    UserData.USER_LOCATIONID = comboBox2.Tag.ToString();
                UserData.USER_NAME = txtName.Text;
                UserData.USER_PASSWORD = pwd1;
                UserData.USER_PHONE = Tel;
                UserData.USER_LANGUAGE = 0;
                UserData.USER_ROLE = comboBox1.Text;

                ReturnInfo RInfo = autofacConfig.coreUserService.AddUser(UserData);
                if (RInfo.IsSuccess)
                {
                   
                    Client.Session["UserID"] = txtTel.Text.Trim();
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

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            //List<coreUser> listRole = autofacConfig.coreUserService.GetUser();
            List<coreUser> listRole = autofacConfig.coreUserService.GetAll();
            if (listRole.Count > 0)
            {
                foreach (coreUser role in listRole)
                {
                    comboBox1.Items.Add(new ComboBoxItem(role.USER_ID, role.USER_ROLE));
                    comboBox2.Items.Add(new ComboBoxItem(role.USER_ID, role.USER_ADDRESS));
                }

            }
        }
    }
}