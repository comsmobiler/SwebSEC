using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SwebSECUI.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.UserInfo
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmMessage : Swebui.Controls.SwebUserControl
    {
        public frmMessage() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String UserID;        //用户名
        public EuserInfo eInfo;            //用户修改项
        public Boolean isDemo;       //是否是演示账号
        #endregion
        /// <summary>
        ///页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMessage_Load(object sender, EventArgs e)
        {

            try
            {
                UserID = Client.Session["UserID"].ToString();
                coreUser UserData = autofacConfig.coreUserService.GetUserByID(UserID);
                if (UserData.USER_SEX != null)
                {
                    btnSex.Tag = UserData.USER_SEX.ToString();
                    btnSex.DefaultValue = new string[] { UserData.USER_SEX.ToString() };
                }
                if (UserData.USER_IMAGEID == null)
                {
                    if (Convert.ToInt32(UserData.USER_SEX) == 0)
                        userImg1.ResourceID = imgUser.ResourceID = "male.png";
                    else
                        userImg1.ResourceID = imgUser.ResourceID = "female.png";
                }
                else
                {
                    userImg1.ResourceID = imgUser.ResourceID = UserData.USER_IMAGEID;
                }
                btnLocation.Tag = UserData.USER_LOCATIONID;         //区域编号   
                List<AssLocation> assLocations = autofacConfig.assLocationService.GetEnableAll();
                foreach (var asslocation in assLocations)
                {
                    btnLocation.Nodes.Add(new TreeSelectNode(asslocation.LOCATIONID, asslocation.NAME));
                }

                btnLocation.DefaultValue = new string[] { UserData.USER_LOCATIONID };
                if (UserData.USER_ADDRESS != null) txtAddress.Text = UserData.USER_ADDRESS;
                if (UserData.USER_EMAIL != null) lblEmail.Text = UserData.USER_EMAIL;
                lblID.Text = UserID;
                if (UserData.USER_NAME != null)
                {
                    lblName1.Text = lblName.Text = UserData.USER_NAME;
                }
                else
                {
                    lblName.Text = UserID;
                }
                if (UserData.USER_PHONE != null) labPhone.Text = lblPhone.Text = UserData.USER_PHONE;
                if (UserData.USER_EMAIL != null) lblEmail.Text = UserData.USER_EMAIL;
                if (UserData.USER_BIRTHDAY != null) dpkBirthday.Value = (DateTime)UserData.USER_BIRTHDAY;

                if (UserData.USER_ISDEMO != null)
                {
                    if (UserData.USER_ISDEMO == 1)
                        isDemo = true;
                    else
                        isDemo = false;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 编辑 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            lblName.ReadOnly = lblEmail.ReadOnly = lblPhone.ReadOnly = txtAddress.ReadOnly = false;
            dpkBirthday.Enable = true;
            btnSex.Disabled = btnLocation.Disabled = false;
            saveBtn.Visible = cancelBtn.Visible = true;
            editBtn.Visible = false;
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
                coreUser UserInfo = new coreUser();
                UserInfo.USER_ID = UserID;
                UserInfo.USER_ADDRESS = txtAddress.Text;
                UserInfo.USER_SEX = Convert.ToInt32(btnSex.Tag);
                UserInfo.USER_NAME = lblName.Text;
                UserInfo.USER_BIRTHDAY = Convert.ToDateTime(dpkBirthday.Value);
                UserInfo.USER_LOCATIONID = btnLocation.Tag.ToString();
                UserInfo.USER_PHONE = lblPhone.Text;
                UserInfo.USER_EMAIL = lblEmail.Text;
                ReturnInfo RInfo = autofacConfig.coreUserService.UpdateUser(UserInfo);
                if (RInfo.IsSuccess)
                {
                    Toast("修改信息成功!");
                    lblName1.Text = lblName.Text;
                    labPhone.Text = lblPhone.Text;
                    lblName.ReadOnly = lblEmail.ReadOnly = lblPhone.ReadOnly = txtAddress.ReadOnly = true;
                    dpkBirthday.Enable = false;
                    btnSex.Disabled = btnLocation.Disabled = true;
                    saveBtn.Visible = cancelBtn.Visible = false;
                    editBtn.Visible = true;
                    ((MainForm)this.Form).SetUserBtn(lblName.Text);
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
            btnLocation.Nodes.Clear();
            frmMessage_Load(null,null);
            lblName.ReadOnly = lblEmail.ReadOnly = lblPhone.ReadOnly = txtAddress.ReadOnly = true;
            dpkBirthday.Enable = false;
            btnSex.Disabled = btnLocation.Disabled = true;
            saveBtn.Visible = cancelBtn.Visible = false;
            editBtn.Visible = true;
        }
        /// <summary>
        /// 上传头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (imgUser.ResourceID == "male.png" || imgUser.ResourceID == "female.png")
            {
                Client.FileUpload((obj, args) =>
                {

                    if (args.isError == false)
                    {
                        string[] names = args.ResourceID.Split('.');
                        args.SaveFile(UserID + "." + names[1], Swebui.SwebResourceManager.DefaultImagePath);
                        userImg1.ResourceID = imgUser.ResourceID = UserID + "." + names[1];
                        UpdateUserInfo(EuserInfo.修改头像, imgUser.ResourceID);
                    }
                    else
                    {
                        Toast(args.error);
                    }
                });
            }
            else
            {
                Client.FileUpload((obj, args) =>
                {

                    if (args.isError == false)
                    {
                        string[] names = imgUser.ResourceID.Split('.');
                        string[] suffix = args.ResourceID.Split('.');
                        args.SaveFile(names[0] + "." + suffix[1], Swebui.SwebResourceManager.DefaultImagePath);
                        userImg1.ResourceID = imgUser.ResourceID = names[0] + "." + suffix[1];
                        UpdateUserInfo(EuserInfo.修改头像, imgUser.ResourceID);
                    }
                    else
                    {
                        Toast(args.error);
                    }
                });

            }
        }
        /// <summary>
        /// 更新头像
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Value"></param>
        public void UpdateUserInfo(EuserInfo Type, String Value)
        {
            try
            {
                coreUser UserInfo = new coreUser();
                UserInfo.USER_ID = UserID;
                switch (Type)
                {
                    case EuserInfo.修改头像:
                        UserInfo.USER_IMAGEID = Value;
                        break;
                }
                ReturnInfo RInfo = autofacConfig.coreUserService.UpdateUser(UserInfo, Type);
                if (RInfo.IsSuccess)
                {
                    Toast("修改头像成功!");
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
        /// 性别选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnSex_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnSex.Tag = args.TreeID;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void psdChange_Click(object sender, EventArgs e)
        {
            if (Client.Session["UserID"].ToString() == "13123456789" || Client.Session["UserID"].ToString() == "12345678917")
            {
                Toast("演示账号不能修改密码");
            }
            else
                this.ShowDialog(new PWDLayout());
        }
        /// <summary>
        /// 区域选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnLocation_Press(object sender, TreeSelectPressEventArgs args)
        {
            btnLocation.Tag = args.TreeID;
        }
    }
}