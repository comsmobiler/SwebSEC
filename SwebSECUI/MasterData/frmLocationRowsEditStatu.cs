using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;

namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmLocationRowsEditStatu : Swebui.Controls.SwebUserControl
    {
        public frmLocationRowsEditStatu() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "define"
        AutofacConfig autofacConfig = new AutofacConfig();
        public String ID;        //区域编号
        public Boolean isCreate = false;       //页面是否为创建状态
        public Boolean isEdit = false;      //页面是否为编辑状态
        private String OldManger;          //区域原管理员
        public bool Enable = false;    //是否启用
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmLocationRows() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Yes;
            BackBtn_Click(null,null);
        }


        private void switchIsEnable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (switchIsEnable.Checked)
                {
                    ReturnInfo rInfo = autofacConfig.assLocationService.ChangeEnable(txtID.Text, IsEnable.启用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("启用区域成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                   
                }
                else
                {
                    ReturnInfo rInfo = autofacConfig.assLocationService.ChangeEnable(txtID.Text, IsEnable.禁用);
                    if (rInfo.IsSuccess)
                    {
                        Toast("禁用区域成功");
                    }
                    else
                        throw new Exception(rInfo.ErrorInfo);
                    
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void frmLocationRowsEditStatu_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ID) == false)    //区域信息编辑
            {
                AssLocation location = autofacConfig.assLocationService.GetByID(ID);
                coreUser core = autofacConfig.coreUserService.GetUserByID(location.MANAGER);
                txtID.ReadOnly = true;                //区域编号不允许修改
                this.txtID.Text = ID;                 //区域编号
                this.txtName.Text = location.NAME;          //区域名称
                textBox1.Text = core.USER_NAME;     //区域管理者名称
                //this.treeSelect1.Tag = location.MANAGER;    //区域管理者编号
                OldManger = location.MANAGER;        //区域的原管理员
                switchIsEnable.Checked = location.ISENABLE == 1 ? true : false;
            }
        }
    }
}