using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwebSECUI;
using SMOSEC.DTOs.OutputDTO;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SwebSECUI.UserInfo;

namespace SwebSECUI.Department
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmDepartment : Swebui.Controls.SwebUserControl
    {
        public frmDepartment() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        public DepartmentMode Mode; //客户展示模式
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// 跳转到创建部门界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmDepartmentCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            Bind();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            gridDepData.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string roid = selectrow["NAME"].ToString();
                    frmDepartmentDetail frm = new frmDepartmentDetail();
                    frm.D_ID = roid;
                    frm.Flex = 1;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                }
                else { Toast("未选择行！"); }
            });
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartment_Load(object sender, EventArgs e)
        {
            Mode = DepartmentMode.列表;
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
                switch (Mode)
                {
                    case DepartmentMode.列表:
                        //gridDepData.Rows.Clear();//清空部门列表数据
                        DModeBtn.Text = DepartmentMode.层级 + "展示";
                        break;
                    case DepartmentMode.层级:
                        treeDepData.Nodes.Clear();//清空部门层级数据
                        DModeBtn.Text = DepartmentMode.列表 + "展示";
                        break;
                }

                if (listDep.Count > 0)
                {
                    DModeBtn.Visible = true;

                    
                    foreach (DepartmentDto dep in listDep)
                    {
                        if (string.IsNullOrEmpty(dep.IMAGEID) == true)
                        {
                            dep.IMAGEID = "bumenicon";
                        }

                    }
                    switch (Mode)
                    {
                        case DepartmentMode.列表:
                            gridDepData.Visible = true;
                            treeDepData.Visible = false;
                            gridDepData.DataSource = listDep;
                            gridDepData.DataBind();
                            break;
                        case DepartmentMode.层级:
                            gridDepData.Visible = false;
                            treeDepData.Visible = true;
                            foreach (DepartmentDto dep in listDep)
                            {
                                TreeViewNode node = new TreeViewNode(dep.DEPARTMENTID, /*null, dep.IMAGEID, (int)TreeMode.dep + "," +*/ dep.NAME);
                                //node.TextColor = System.Drawing.Color.FromArgb(45, 45, 45);
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
                                        TreeViewNode node1 = new TreeViewNode(user.USER_ID, /*null, portrait, (int)TreeMode.user + "," + */user.USER_NAME);
                                        //node1.TextColor = System.Drawing.Color.FromArgb(145, 145, 145);
                                        node.Nodes.Add(node1);
                                    }

                                }
                                treeDepData.Nodes.Add(node);
                            }
                            break;
                    }

                }
                else
                {
                    // btnDMode.Visible = false;
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// treeDepData点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeDepData_Press(object sender, TreeViewOnPressEventArgs e)
        {
            string ID = e.ToString();
            switch (Convert.ToInt32(ID.Split(',')[0]))
            {
                case (int)TreeMode.dep:
                    frmDepartmentDetail frm = new frmDepartmentDetail();
                    frm.D_ID = ID.Split(',')[1];
                    frm.Flex = 1;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                    Mode = DepartmentMode.层级;
                    Bind();
                    break;
                case (int)TreeMode.user:
                    frmDepPerMessage frmMes = new frmDepPerMessage();
                    frmMes.UserID = ID.Split(',')[1];
                    frmMes.Flex = 1;
                    this.Parent.Controls.Add(frmMes);
                    this.Parent.Controls.RemoveAt(0);
                    break;
            }
        }
        /// <summary>
        /// 部门显示模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DModeBtn_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case DepartmentMode.列表:
                    Mode = DepartmentMode.层级;
                    break;
                case DepartmentMode.层级:
                    Mode = DepartmentMode.列表;
                    break;
            }
            Bind();
        }
    }
}