using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.OutputDTO;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.CommLib;

namespace SwebSECUI.Department
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmDepartmentDetail : Swebui.Controls.SwebUserControl
    {
        public frmDepartmentDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        /// <summary>
        /// 部门编号
        /// </summary>
        public string D_ID;
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmDepartment() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartmentDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void Bind()
        {
            try
            {
                //根据部门编号获取部门数据
                DepartmentDto department = AutofacConfig.DepartmentService.GetDepartmentByDepID(D_ID);
                lblName.Text = department.NAME;
                //获取部门人员数据
                if (string.IsNullOrEmpty(department.MANAGER) == false)
                {
                    coreUser user = AutofacConfig.coreUserService.GetUserByID(department.MANAGER);
                    if (user != null)
                    {
                        lblLeader.Text = user.USER_NAME;
                    }
                }
                if (string.IsNullOrEmpty(department.IMAGEID) == false)
                {
                    imgPortrait.ResourceID = department.IMAGEID;
                    imgPortrait.Refresh();
                }
                else
                {
                    imgPortrait.ResourceID = "bumenicon";
                }
                List<coreUser> listDepUser = AutofacConfig.coreUserService.GetUserByDepID(D_ID);
                if (listDepUser.Count > 0)
                {
                    gridUserData.Rows.Clear();
                    foreach (coreUser userinfo in listDepUser)
                    {
                        if (userinfo.USER_ID.Equals(department.MANAGER))
                        {
                            listDepUser.Remove(userinfo);
                            break;
                        }
                    }
                    gridUserData.Rows.Clear();//清空部门人员列表数据
                    if (listDepUser.Count > 0)
                    {
                        foreach (coreUser userinfo in listDepUser)
                        {
                            if (string.IsNullOrEmpty(userinfo.USER_IMAGEID) == true)
                            {
                                switch (userinfo.USER_SEX)
                                {
                                    case (int)Sex.男:
                                        userinfo.USER_IMAGEID = "male";
                                        break;
                                    case (int)Sex.女:
                                        userinfo.USER_IMAGEID = "female";
                                        break;
                                }
                            }
                        }
                    }
                    gridUserData.DataSource = listDepUser;
                    gridUserData.DataBind();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //bool isDelDep = false;//是否删除部门
            MessageBox.Show("是否确定删除部门？", "部门", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args1) =>
            {
                if (args1.Result == ShowResult.Yes)
                {
                    //如果部门人员人数大于0，则弹出提示框在删除部门，否则直接删除
                    if (gridUserData.Rows.Count > 0)
                    {
                        MessageBox.Show(lblName.Text + "已分配部门人员是否删除？", "删除部门", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                        {
                            if (args.Result == ShowResult.Yes)
                            {

                                //isDelDep = true;
                                try
                                {
                                    ReturnInfo result = AutofacConfig.DepartmentService.DeleteDepartment(D_ID);
                                    if (result.IsSuccess == true)
                                    {
                                        ShowResult = ShowResult.Yes;
                                        Toast("部门已删除！", ToastLength.SHORT);
                                        BackBtn_Click(null,null);
                                    }
                                    else
                                    {
                                        throw new Exception(result.ErrorInfo);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Toast(ex.Message, ToastLength.SHORT);
                                }
                            }
                        });
                    }
                    else
                    {
                        //isDelDep = true;
                        ReturnInfo result = AutofacConfig.DepartmentService.DeleteDepartment(D_ID);
                        if (result.IsSuccess == true)
                        {
                            ShowResult = ShowResult.Yes;
                            Toast("部门已删除！", ToastLength.SHORT);
                            BackBtn_Click(null, null);
                        }
                        else
                        {
                            Toast(result.ErrorInfo, ToastLength.SHORT);
                        }
                    }
                }
            });
        }
    }
}