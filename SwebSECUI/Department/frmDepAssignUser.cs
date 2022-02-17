using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SwebSECUI.Layout;
using SMOSEC.CommLib;
using SMOSEC.DTOs.OutputDTO;
using Swebui;

namespace SwebSECUI.Department
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmDepAssignUser : Swebui.Controls.SwebUserControl
    {
        public frmDepAssignUser() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        int selectUserQty = 0;//选中人员数
        public DepInputDto department;//部门信息
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmDepartment() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 上传部门头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                Client.FileUpload((obj, args) =>
                {

                    if (string.IsNullOrEmpty(args.error))
                    {
                        string imgName = "";
                        if (string.IsNullOrEmpty(imgPortrait.ResourceID))
                        {
                            string[] name = args.ResourceID.Split('.');
                            imgName = DateTime.Now.ToString("yyyyMMddHHmmss") + "." + name[1];
                        }
                        else
                        {
                            string[] name = args.ResourceID.Split('.');
                            string[] firstName = imgPortrait.ResourceID.Split(',');
                            imgName = firstName[0] + "." + name[1];
                        }
                        args.SaveFile(imgName, SwebResourceManager.DefaultImagePath);
                        imgPortrait.ResourceID = imgName;
                        imgPortrait.Refresh();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect1.Tag = args.TreeID;
            try
            {
                if (treeSelect1.Tag!= null)
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
                        MessageBox.Show(treeSelect1.Tag.ToString() + "已是部门成员，是否确定为该部门责任人？", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs Args) =>
                        {
                            //此委托为异步委托事件
                            if (Args.Result == ShowResult.Yes)
                            {
                                department.MANAGER = treeSelect1.Tag.ToString();

                            }
                        });
                    //}
                    //如果选中用户不是部门责任人且不是部门成员，则为该部门负责人
                    if (isLeader == false & userdep != null & string.IsNullOrEmpty(userdep.DEPARTMENTID) == true)
                    {
                        department.MANAGER = treeSelect1.Tag.ToString();

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
        private void frmDepAssignUser_Load(object sender, EventArgs e)
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
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                if (department != null)
                {
                    txtDepName.Text = department.NAME;
                    if (string.IsNullOrEmpty(department.IMAGEID) == false)
                    {
                        imgPortrait.ResourceID = department.IMAGEID;
                        imgPortrait.Refresh();
                    }
                    treeSelect1.Placeholder = AutofacConfig.coreUserService.GetUserByID(department.MANAGER).USER_NAME;
                    List<DataGridviewbyUser> listUser = new List<DataGridviewbyUser>();
                    List<coreUser> listDepUser = AutofacConfig.coreUserService.GetAll();//获取分配部门人员
                    //部门创建时ListView绑定数据
                    if (string.IsNullOrEmpty(department.DEPARTMENTID) == true)
                    {
                        if (listDepUser.Count > 0)
                        {
                            //将未分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == true) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.男:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = "";
                                    depUser.DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //将已分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == false) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.男:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = user.USER_DEPARTMENTID;
                                    string DepName = "";
                                    if (AutofacConfig.DepartmentService.GetDepartmentByDepID(user.USER_DEPARTMENTID) != null)
                                    {
                                        DepName = AutofacConfig.DepartmentService.GetDepartmentByDepID(user.USER_DEPARTMENTID).NAME;
                                    }
                                    depUser.DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                        }
                    }
                    //部门编辑时ListView绑定数据
                    if (string.IsNullOrEmpty(department.DEPARTMENTID) == false)
                    {
                        if (listDepUser.Count > 0)
                        {
                            //将当前部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == false) & (department.DEPARTMENTID.Equals(user.USER_DEPARTMENTID)) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.男:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = department.DEPARTMENTID;
                                    depUser.DepName = department.NAME;
                                    depUser.SelectCheck = true;
                                    listUser.Add(depUser);
                                }
                            }
                            //将未分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == true) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.男:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = "";
                                    depUser.DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //将已分配部门且不是当前部门的用户，添加到listUser中
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == false) & (!department.DEPARTMENTID.Equals(user.USER_DEPARTMENTID)) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.男:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = user.USER_DEPARTMENTID;
                                    string DepName = "";
                                    if (AutofacConfig.DepartmentService.GetDepartmentByDepID(user.USER_DEPARTMENTID) != null)
                                    {
                                        DepName = AutofacConfig.DepartmentService.GetDepartmentByDepID(user.USER_DEPARTMENTID).NAME;
                                    }
                                    depUser.DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                        }
                    }

                    gridUserData.Rows.Clear();//清空人员列表数据
                    if (listUser.Count > 0)
                    {
                        gridUserData.DataSource = listUser; //绑定ListView数据
                        gridUserData.DataBind();
                        upCheckState();
                    }

                }
                else
                {
                    throw new Exception("请输入部门信息！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 全选
        /// </summary>
        private void Checkall()
        {
            switch (checkBox1.Checked)
            {
                case true:
                    foreach (ListViewRow rows in gridUserData.Rows)
                    {
                        //rows.Cell.Items["Check"].DefaultValue = true;
                        ((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue = true;

                    }
                    selectUserQty = gridUserData.Rows.Count;
                    break;
                case false:
                    foreach (ListViewRow rows in gridUserData.Rows)
                    {
                        //rows.Cell.Items["Check"].DefaultValue = false;
                        ((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue = false;

                    }
                    selectUserQty = 0;
                    break;
            }
        }
        /// <summary>
        /// 分配部门人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listUser = new List<string>(); //用户集合
                string assignUser = "";//已分配部门用户
                string depLeader = "";//部门责任人用户
                department.NAME = txtDepName.Text.Trim();
                listUser.Add(department.MANAGER);//添加当前部门负责人
                string depuser = null;//选中用户中且已分配部门的用户
                List<string> listselectuserdep = new List<string>();//获取选中用户的且是已分配部门中，用户的部门
                foreach (ListViewRow rows in gridUserData.Rows)
                {

                    if ((Convert.ToBoolean(((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue) == true) & (!department.MANAGER.Equals(((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString())))
                    {
                        string user = ((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                        listUser.Add(user);
                        //获取选中用户中的已分配部门的用户                      
                        if (string.IsNullOrEmpty(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString()) == false)
                        {
                            if (string.IsNullOrEmpty(depuser) == true)
                            {
                                depuser = ((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                            }
                            else
                            {
                                depuser += "," + ((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                            }
                            if (listselectuserdep.Count <= 0)
                            {
                                listselectuserdep.Add(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString());//添加选中用户的部门
                            }
                            else
                            {
                                if (listselectuserdep.Contains(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString()) == false)
                                {
                                    listselectuserdep.Add(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString());//添加选中用户的部门
                                }
                            }
                        }
                    }
                }
                //如果已分配部门的用户不为空时
                if (string.IsNullOrEmpty(depuser) == false)
                {
                    string[] depusers = depuser.Split(',');
                    //创建部门时，判断选中用户是否为部门责任人和是否为已分配部门成员
                    if (string.IsNullOrEmpty(department.DEPARTMENTID) == true)
                    {
                        foreach (string user in depusers)
                        {
                            //如果是部门责任人，则添加到部门责任人用户depLeader中，否则添加到已分配部门用户assignUser中
                            if (AutofacConfig.DepartmentService.IsLeader(user) == true)
                            {
                                coreUser userd = AutofacConfig.coreUserService.GetUserByID(user);
                                if (string.IsNullOrEmpty(depLeader) == true)
                                {
                                    depLeader = userd.USER_NAME;
                                }
                                else
                                {
                                    depLeader += "," + userd.USER_NAME;
                                }

                            }
                            else
                            {
                                if (string.IsNullOrEmpty(assignUser) == true)
                                {
                                    assignUser = user;
                                }
                                else
                                {
                                    assignUser += "," + user;
                                }
                            }
                        }
                    }
                    //编辑部门时，判断选中用户是否为部门责任人和是否为已分配部门成员
                    if (string.IsNullOrEmpty(department.DEPARTMENTID) == false)
                    {
                        foreach (string user in depusers)
                        {
                            coreUser userd = AutofacConfig.coreUserService.GetUserByID(user);
                            if (!department.DEPARTMENTID.Equals(userd.USER_DEPARTMENTID))
                            {
                                //如果是部门责任人，则添加到部门责任人用户depLeader中，否则添加到已分配部门用户assignUser中
                                if (AutofacConfig.DepartmentService.IsLeader(user) == true)
                                {

                                    if (string.IsNullOrEmpty(depLeader) == true)
                                    {
                                        depLeader = userd.USER_NAME;
                                    }
                                    else
                                    {
                                        depLeader += "," + userd.USER_NAME;
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(assignUser) == true)
                                    {
                                        assignUser = user;
                                    }
                                    else
                                    {
                                        assignUser += "," + user;
                                    }
                                }
                            }
                        }
                    }
                    if (listselectuserdep.Count > 0 & string.IsNullOrEmpty(assignUser) == false)
                    {

                        string[] assignUsers = assignUser.Split(',');
                        string assignUser1 = "";
                        foreach (string depNO in listselectuserdep)
                        {
                            string assignU = "";
                            foreach (string user in assignUsers)
                            {
                                coreUser userd = AutofacConfig.coreUserService.GetUserByID(user);
                                if (user != null)
                                {
                                    if (userd.USER_DEPARTMENTID.Equals(depNO))
                                    {
                                        if (string.IsNullOrEmpty(assignU) == true)
                                        {
                                            assignU = userd.USER_NAME;
                                        }
                                        else
                                        {
                                            assignU += "," + userd.USER_NAME;
                                        }
                                    }
                                }
                            }
                            if (string.IsNullOrEmpty(assignU) == false)
                            {
                                if (string.IsNullOrEmpty(assignU) == false)
                                {
                                    assignUser1 = assignU + "已是" + AutofacConfig.DepartmentService.GetDepartmentByDepID(depNO).NAME + "部门成员";
                                }
                                else
                                {
                                    assignUser1 += "；" + assignU + "已是" + AutofacConfig.DepartmentService.GetDepartmentByDepID(depNO).NAME + "部门成员";
                                }
                            }
                        }
                        assignUser = assignUser1;
                    }
                }
                if (string.IsNullOrEmpty(depLeader) == false)
                {
                    throw new Exception(depLeader + "已是部门责任人，请先解散部门！");
                }
                //bool isUPdateDep = false; //是否更新部门人员
                ReturnInfo result;
                if (string.IsNullOrEmpty(assignUser) == false)
                {
                    MessageBox.Show(assignUser + "是否分配？", "分配人员", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result == ShowResult.Yes)
                        {
                            //isUPdateDep = true;
                            department.UserIDs = listUser;
                            if (department.DEPARTMENTID != null)
                            {

                                result = AutofacConfig.DepartmentService.UpdateDepartment(department);
                            }
                            else
                            {

                                result = AutofacConfig.DepartmentService.AddDepartment(department);
                            }
                            if (result.IsSuccess == false)
                            {
                                throw new Exception(result.ErrorInfo);
                            }
                            else
                            {
                                ShowResult = ShowResult.Yes;
                                Toast("部门人员分配成功！", ToastLength.SHORT);
                                BackBtn_Click(null, null);
                            }
                        }
                    }
                      );
                }
                else
                {

                    department.UserIDs = listUser;
                    if (department.DEPARTMENTID != null)
                    {

                        result = AutofacConfig.DepartmentService.UpdateDepartment(department);
                    }
                    else
                    {

                        result = AutofacConfig.DepartmentService.AddDepartment(department);
                    }
                    if (result.IsSuccess == false)
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                    else
                    {
                        ShowResult = ShowResult.Yes;
                        Toast("部门人员分配成功！", ToastLength.SHORT);
                        BackBtn_Click(null, null);
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Press(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            Checkall();
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAll_CheckedChanged_1(object sender, EventArgs e)
        {
            Checkall();
        }
        /// <summary>
        /// 更新全选状态
        /// </summary>
        private void upCheckState()
        {
            selectUserQty = 0;
            foreach (ListViewRow rows in gridUserData.Rows)
            {
                if (Convert.ToBoolean(((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue) == true)
                {
                    selectUserQty += 1;
                }
            }
            //当ListView行项选中条数等于ListView行数时，为全选状态，否则为不选状态。
            if (selectUserQty == gridUserData.Rows.Count)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
    }
}