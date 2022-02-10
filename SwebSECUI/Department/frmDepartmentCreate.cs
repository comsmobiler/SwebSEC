using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.Domain.Entity;
using SMOSEC.CommLib;
using SMOSEC.DTOs.OutputDTO;

namespace SwebSECUI.Department
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmDepartmentCreate : Swebui.Controls.SwebUserControl
    {
        public frmDepartmentCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        public string D_ID;//部门编号
        string leader = "";//责任人
        string D_Portrait = "";//部门头像
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmDepartment() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDep_Name.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入部门名称！");
                }

                if (leader.Length <= 0)
                {
                    throw new Exception("请输入责任人！");
                }
                DepInputDto department = new DepInputDto();
                department.NAME = txtDep_Name.Text;
                department.MODIFYUSER = Client.Session["UserID"].ToString();
                department.MANAGER = leader;
                if (string.IsNullOrEmpty(D_Portrait) == false)
                {
                    department.IMAGEID = D_Portrait;
                }
                else
                {
                    department.IMAGEID = "";
                }
                if (string.IsNullOrEmpty(D_ID) == false)
                {
                    department.DEPARTMENTID = D_ID;
                    List<coreUser> listuserDto = AutofacConfig.coreUserService.GetUserByDepID(D_ID);
                    List<string> listUser = new List<string>();
                    foreach (coreUser user in listuserDto)
                    {
                        listUser.Add(user.USER_ID);
                    }
                    department.UserIDs = listUser;
                    ReturnInfo result = AutofacConfig.DepartmentService.UpdateDepartment(department);
                    if (result.IsSuccess == false)
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                    else
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("部门提交成功！", ToastLength.SHORT);
                        BackBtn_Click(null, null);
                    }
                }
                else
                {
                    //ShowResult = ShowResult.Yes;

                    frmDepAssignUser frmDepAssignUser = new frmDepAssignUser();
                    frmDepAssignUser.department = department;
                    frmDepAssignUser.Flex = 1;
                    this.Parent.Controls.Add(frmDepAssignUser);
                    this.Parent.Controls.RemoveAt(0);
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 责任人赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect1.Tag = args.TreeID;
            try
            {
                if (treeSelect1.Tag != null)
                {
                    //查询该选中的用户是否已经是部门责任人
                    bool isLeader = AutofacConfig.DepartmentService.IsLeader(treeSelect1.Tag.ToString());
                    //如果该选中责任人已是部门责任人，则报错
                    if (isLeader == true)
                    {
                        throw new Exception(treeSelect1.Tag + "已是部门责任人，请先解散部门！");
                    }
                    //
                    UserDepDto userdep = AutofacConfig.coreUserService.GetUseDepByUserID(treeSelect1.Tag.ToString());
                    //如果选中用户已是部门成员且不是部门责任人，则进行选择是否确认为部门责任人，若确认则为该部门负责人
                    if (userdep != null & string.IsNullOrEmpty(userdep.DEPARTMENTID) == false & isLeader == false)
                        //if (AutofacConfig.userService.GetAllUsers().Count > 0 & isLeader== false)
                        //{
                        MessageBox.Show(treeSelect1.Tag + "已是部门成员，是否确定为该部门责任人？", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs Args) =>
                        {
                            //此委托为异步委托事件
                            if (Args.Result == ShowResult.Yes)
                            {
                                leader = treeSelect1.Tag.ToString();
                                
                            }
                        });
                    //}
                    //如果选中用户不是部门责任人且不是部门成员，则为该部门负责人
                    if (isLeader == false & userdep != null & string.IsNullOrEmpty(userdep.DEPARTMENTID) == true)
                    {
                        leader = treeSelect1.Tag.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartmentCreate_Load(object sender, EventArgs e)
        {
            Bind();

            ///获取责任人
            List<coreUser> listuser = AutofacConfig.coreUserService.GetAll();
            foreach (coreUser role in listuser)

            {
                treeSelect1.Nodes.Add(new TreeSelectNode(role.USER_ID, role.USER_NAME));
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        private void Bind()
        {
            try
            {
                if (D_ID != null)
                {
                    DepartmentDto dep = AutofacConfig.DepartmentService.GetDepartmentByDepID(D_ID);
                    if (dep == null)
                    {
                        throw new Exception("部门" + D_ID + "不存在，请检查！");
                    }
                    txtDep_Name.Text = dep.NAME;
                    leader = dep.MANAGER;
                    if (string.IsNullOrEmpty(dep.IMAGEID) == false)
                    {
                        D_Portrait = dep.IMAGEID;
                        imgPortrait.ResourceID = dep.IMAGEID;
                    }
                    else
                    {
                        imgPortrait.ResourceID = "bumenicon";
                    }
                    coreUser userinfo = AutofacConfig.coreUserService.GetUserByID(leader);
                    treeSelect1.Tag = userinfo.USER_NAME;
                    SaveBtn.Text = "提交";
                    btnAssignUser.Visible = true;
                    // btnSave.Top = 190;
                    btnAssignUser.Top = treeSelect1.Top + treeSelect1.Height + 10;
                    SaveBtn.Top = btnAssignUser.Top + btnAssignUser.Height + 10;
                }
                else
                {
                    btnAssignUser.Visible = false;
                    // btnSave.Top = 145;
                    SaveBtn.Top = treeSelect1.Top + treeSelect1.Height + 10;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 上传部门头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            this.Client.FileUpload((obj, args) => {
                if (args.isError == true)
                    if (imgPortrait.ResourceID.Trim().Length > 0 & string.IsNullOrEmpty(D_Portrait) == false)
                    {
                        args.SaveFile(D_Portrait + ".png");
                        imgPortrait.ResourceID = D_Portrait;
                        imgPortrait.Refresh();
                    }
                    else
                    {
                        args.SaveFile(args.ResourceID + ".png");
                        D_Portrait = args.ResourceID;
                        imgPortrait.ResourceID = args.ResourceID;
                        imgPortrait.Refresh();
                    }
            });
        }
        /// <summary>
        /// 跳转到分配部门界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssignUser_Click(object sender, EventArgs e)
        {
            if (D_ID != null)
            {
                DepartmentDto dep = AutofacConfig.DepartmentService.GetDepartmentByDepID(D_ID);
                if (dep != null)
                {
                    DepInputDto department = new DepInputDto();
                    department.DEPARTMENTID = dep.DEPARTMENTID;
                    department.NAME = dep.NAME;
                    department.MANAGER = dep.MANAGER;
                    department.IMAGEID = dep.IMAGEID;
                    frmDepAssignUser frmDepAssignUser = new frmDepAssignUser();
                    frmDepAssignUser.department = department;
                    frmDepAssignUser.Flex = 1;
                    this.Parent.Controls.Add(frmDepAssignUser);
                    this.Parent.Controls.RemoveAt(0);
                }

            }
        }
    }
}