using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.OutputDTO;
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
        AutofacConfig AutofacConfig = new AutofacConfig();     //调用配置类
        public String UserID;        //用户名
        private string SelectID;
        #endregion

        private void frmDepPerMessage_Load(object sender, EventArgs e)
        {
            Bind();
            
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        public void Bind()
        {
            try
            {
                //获取所有部门数据
                List<DepartmentDto> listDep = AutofacConfig.DepartmentService.GetAllDepartment();
                foreach (DepartmentDto dep in listDep)
                            {
                                TreeViewNode node = new TreeViewNode(dep.DEPARTMENTID,dep.NAME);
                                List<coreUser> listDepUser = AutofacConfig.coreUserService.GetUserByDepID(dep.DEPARTMENTID);
                                if (listDepUser.Count > 0)
                                {
                                    foreach (coreUser user in listDepUser)
                                    {
                                        string Name = "";
                                        if (dep.MANAGER.Equals(user.USER_ID))
                                        {
                                            Name = user.USER_NAME + "  负责人";
                                        }
                                        else
                                        {
                                            Name = user.USER_NAME;
                                        }
                                        string portrait = "";
                                        if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                        {
                                            switch (user.USER_SEX)
                                            {
                                                case (int)Sex.男:
                                                    portrait = "male";
                                                    break;
                                                case (int)Sex.女:
                                                    portrait = "female";
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            portrait = user.USER_IMAGEID;
                                        }
                                        TreeViewNode node1 = new TreeViewNode(user.USER_ID,Name);
                                        node.Nodes.Add(node1);
                                    }

                                }
                                treeView1.Nodes.Add(node);          
                 }

             }
                 catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }

        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmDepartment() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void treeView1_Press(object sender, TreeViewOnPressEventArgs e)
        {
            SelectID = e.TreeID;
            GetContent(e.TreeID);
        }
        private void GetContent(string UserID)
        {
            try
            {
                coreUser UserData = AutofacConfig.coreUserService.GetUserByID(UserID);
                if (UserData.USER_SEX != null)
                {
                    if (Convert.ToInt32(UserData.USER_SEX) == 0)
                        lblSex.Text = "男";
                    else
                        lblSex.Text = "女";
                }
                if (UserData.USER_IMAGEID == null)
                {
                    if (Convert.ToInt32(UserData.USER_SEX) == 0)
                        imgUser.ResourceID = "male";
                    else
                        imgUser.ResourceID = "female";
                }
                else
                {
                    imgUser.ResourceID = UserData.USER_IMAGEID;
                }
                AssLocation assLocation = AutofacConfig.assLocationService.GetByID(UserData.USER_LOCATIONID);
                lblLocation.Text = assLocation.NAME;
                if (UserData.USER_ADDRESS != null) lblAddress.Text = UserData.USER_ADDRESS;
                if (UserData.USER_EMAIL != null) lblEmail.Text = UserData.USER_EMAIL;
                lblID.Text = UserID;
                if (UserData.USER_NAME != null)
                {
                    lblName.Text = UserData.USER_NAME;
                }
                else
                {
                    lblName.Text = UserID;
                }
                if (UserData.USER_PHONE != null) lblPhone.Text = UserData.USER_PHONE;
                if (UserData.USER_EMAIL != null) lblEmail.Text = UserData.USER_EMAIL;
                if (UserData.USER_BIRTHDAY != null) dpkBirthday.Value = (DateTime)UserData.USER_BIRTHDAY;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

    }
}