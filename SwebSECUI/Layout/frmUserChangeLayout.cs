using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmUserChangeLayout : Swebui.Controls.SwebUserControl
    {
        public frmUserChangeLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        public string AssId; //资产编号
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string LastUser; //资产最近的拥有者

        #endregion

        private void frmUserChangeLayout_Load(object sender, EventArgs e)
        {
            try
            {   List<coreUser> users = _autofacConfig.coreUserService.GetAll();
            foreach (coreUser Row in users)
            {
               treeSelect1.Nodes.Add(new TreeSelectNode(Row.USER_ID, Row.USER_NAME));
            } 
                Assets assets = _autofacConfig.orderCommonService.GetAssetsByID(AssId);
            treeSelect1.DefaultValue = new string[] { assets.CURRENTUSER};

           

            }
            catch (Exception ex) { Toast(ex.Message); }
         
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ShowResult = ShowResult.No;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeSelect1.Tag.ToString() != LastUser)     //如果更换了使用者
                {
                    ReturnInfo RInfo = _autofacConfig.AssetsService.ChangeUser(AssId, treeSelect1.Tag.ToString(), Client.Session["UserID"].ToString());
                    if (RInfo.IsSuccess)
                    {
                        Toast("更改使用者成功!");
                        LastUser = treeSelect1.Tag.ToString();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception(RInfo.ErrorInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect1.Tag = args.TreeID;
        }
    }
}