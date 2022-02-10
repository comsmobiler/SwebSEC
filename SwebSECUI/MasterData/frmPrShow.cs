using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.OutputDTO;
using SwebSECUI.MasterData;
using SMOSEC.DTOs.Enum;
using System.Data;
using SMOSEC.Application;

namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmPrShow : Swebui.Controls.SwebUserControl
    {
        public frmPrShow() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        public string AssId;  //资产编号
        AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmAssets() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void frmPrShow_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("PrId");
                dt.Columns.Add("AssId");
                dt.Columns.Add("SN");
                dt.Columns.Add("HandleMan");
                dt.Columns.Add("HandleDate");
                dt.Columns.Add("ProcessModeName");
                dt.Columns.Add("ProcessContent");
                DataTable table = _autofacConfig.SettingService.GetRecords(AssId, "");
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow data in table.Rows)
                   
                    {
                        dt.Rows.Add(data["PrId"], data["AssId"], data["SN"], data["HandleMan"], ((DateTime)data["HandleDate"]).ToString("yyyy-MM-dd"), data["ProcessModeName"], data["ProcessContent"]);
                    }
                    gridView1.DataSource = dt;
                    gridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}