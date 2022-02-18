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
    partial class frmLocationRowsEdit : Swebui.Controls.SwebUserControl
    {
        public frmLocationRowsEdit() : base()
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
        /// <summary>
        /// 提交操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtID.Text)) throw new Exception("区域编号不能为空");
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("区域名称不能为空");
                if (treeSelect1.Tag == null) throw new Exception("区域负责人不能为空");

                AssLocation ass = autofacConfig.assLocationService.GetByManager(treeSelect1.Tag.ToString());
                String[] data = treeSelect1.Placeholder.Split(' ');
                if (ass != null) throw new Exception(data[0] + "已经是区域管理员,请选择其他用户！");
                //获取创建区域信息
                AssLocation AssLoc = new AssLocation
                {
                    LOCATIONID = txtID.Text,
                    NAME = txtName.Text,
                    MANAGER = treeSelect1.Tag.ToString(),
                };
                if (isCreate == false)     //修改区域
                {
                    ReturnInfo r = autofacConfig.assLocationService.UpdateAssLocation(AssLoc, OldManger);
                    if (r.IsSuccess == false)
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                    else
                    {
                        Form.Toast("修改区域信息成功");
                        this.Close();
                    }
                }
                this.ShowResult = ShowResult.Yes;
                //刷新显示列表
                ((frmLocationRows)Parent).Bind();
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect1.Tag = args.TreeID;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmLocationRows() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLocationRowsEdit_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ID) == false)    //区域信息编辑
            {
                AssLocation location = autofacConfig.assLocationService.GetByID(ID);
                coreUser core = autofacConfig.coreUserService.GetUserByID(location.MANAGER);
                txtID.ReadOnly = true;                //区域编号不允许修改
                this.txtID.Text = ID;                 //区域编号
                this.txtName.Text = location.NAME;          //区域名称
                this.treeSelect1.Placeholder = core.USER_NAME;     //区域管理者名称
                this.treeSelect1.Tag = location.MANAGER;    //区域管理者编号
                OldManger = location.MANAGER;        //区域的原管理员
                switchIsEnable.Checked = location.ISENABLE == 1 ? true : false;
            }
            ///添加区域负责人
            List<coreUser> users = autofacConfig.coreUserService.GetAll();
            foreach (coreUser role in users)

            {
                treeSelect1.Nodes.Add(new TreeSelectNode(role.USER_ID, role.USER_NAME));
            }
        }

        //private void switchIsEnable_CheckedChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (switchIsEnable.Checked)
        //        {
        //            ReturnInfo rInfo = autofacConfig.assLocationService.ChangeEnable(txtID.Text, IsEnable.启用);
        //            if (rInfo.IsSuccess)
        //            {
        //                Toast("启用区域成功");
        //            }
        //            else
        //            throw new Exception(rInfo.ErrorInfo);
        //            this.ShowResult = ShowResult.Yes;
        //        }
        //        else
        //        {
        //            ReturnInfo rInfo = autofacConfig.assLocationService.ChangeEnable(txtID.Text, IsEnable.禁用);
        //            if (rInfo.IsSuccess)
        //            {
        //                Toast("禁用区域成功");
        //            }
        //            else
        //                throw new Exception(rInfo.ErrorInfo);
        //            this.ShowResult = ShowResult.Yes;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Toast(ex.Message);
        //    }
        //}
    }
}