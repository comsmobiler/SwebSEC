using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwebSECUI.Layout;
using System.Data;
using SMOSEC.Domain.Entity;

namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmLocationRows : Swebui.Controls.SwebUserControl
    {
        public frmLocationRows() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLocationRows_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        public void Bind()
        {
            try
            {
                DataTable table = new DataTable();
                List<AssLocation> locs = autofacConfig.assLocationService.GetAll();
                table.Columns.Add("LOCATIONID");
                table.Columns.Add("NAME");
                table.Columns.Add("IMGENABLE");
                table.Columns.Add("TEXTENABLE");
                foreach (AssLocation Row in locs)
                {
                    if (Row.ISENABLE == 1)      //启用
                    {
                        table.Rows.Add(Row.LOCATIONID, Row.NAME, "off", "禁用");
                    }
                    else
                    {
                        table.Rows.Add(Row.LOCATIONID, Row.NAME, "on", "启用");
                    }
                }
                if (table.Rows.Count > 0)
                {
                    listLocation.DataSource = table;
                    listLocation.DataBind();
                }
                foreach (ListViewRow Row in listLocation.Rows)   //根据启用或者禁用，设置对应颜色
                {
                    frmLcoationRowsLayout frm = Row.Control as frmLcoationRowsLayout;
                    frm.setColor();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 创建区域弹出框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLocationCreateLayout frm = new frmLocationCreateLayout();
            frm.isCreate = true;
            this.ShowDialog(frm,(o,a)=> { 
            if(frm.ShowResult== ShowResult.Yes)
                {
                    Bind();
                }
            });
        }
 
    }
}