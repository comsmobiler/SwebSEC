﻿using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmCollarOrder : Swebui.Controls.SwebUserControl
    {
        public frmCollarOrder() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmCoCreate() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            Bind();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCollarOrder_Load(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind()
        {
            try
            {
                string LocationId = "";
                string UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                }
                if (Client.Session["Role"].ToString() == "SMOSECUser")
                {
                    plButton.Visible = false;
                }
                DataTable assborrowTable = _autofacConfig.AssetsService.GetCoByUserId(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "", LocationId);
                ListViewCO.Rows.Clear();
                if (assborrowTable.Rows.Count > 0)
                {
                    ListViewCO.DataSource = assborrowTable;
                    ListViewCO.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
           
        }
    }
}