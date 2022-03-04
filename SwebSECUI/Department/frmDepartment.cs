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
                    string roid = selectrow["DEPARTMENTID"].ToString();
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
                //获取所有部门数据
                List<DepartmentDto> listDep = AutofacConfig.DepartmentService.GetAllDepartment();
                gridDepData.DataSource = listDep;
                gridDepData.DataBind();

        }

        private void UserInfoBtn_Click(object sender, EventArgs e)
        {
           frmDepPerMessage frm = new frmDepPerMessage();
           frm.Flex = 1;
           this.Parent.Controls.Add(frm);
           this.Parent.Controls.RemoveAt(0);
           Mode = DepartmentMode.层级;
           Bind();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            gridDepData.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string roid = selectrow["DEPARTMENTID"].ToString();
                    frmDepartmentDetail frm = new frmDepartmentDetail();
                    frm.D_ID = roid;
                    frm.Flex = 1;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                }
                else { Toast("未选择行！"); }
            });
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            gridDepData.GetSelectedRows((obj, args) =>
            {
                if (args.SelectedRows.Count > 0)
                {
                    Dictionary<string, object> selectrow = args.SelectedRows[0];
                    string roid = selectrow["DEPARTMENTID"].ToString();
                    frmDepartmentCreate frm = new frmDepartmentCreate();
                    frm.D_ID = roid;
                    frm.Flex = 1;
                    this.Parent.Controls.Add(frm);
                    this.Parent.Controls.RemoveAt(0);
                }
                else { Toast("未选择行！"); }
            });
        }
    }

}