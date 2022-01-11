using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.OutputDTO;
using System.Data;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmRtoDetail : Swebui.Controls.SwebUserControl
    {
        public frmRtoDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string RtoId;   //归还单编号

       

        public DataTable rowsTable = new DataTable();
        #endregion

        private void frmRtoDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {
                AssReturnOrderOutputDto assBorrowOrderOutput = _autofacConfig.AssetsService.GetRtobyId(RtoId);
                if (assBorrowOrderOutput != null)
                {
                    txtHMan.Text = assBorrowOrderOutput.Handleman;
                    txtLocation.Text = assBorrowOrderOutput.Locationid;
                    txtNote.Text = assBorrowOrderOutput.Note;
                    DPickerCO.Value = assBorrowOrderOutput.Returndate;
                }
                DataTable rowsTable = _autofacConfig.AssetsService.GetRowsByRtoid(RtoId);
                if (rowsTable != null)
                {
                    ListAss.DataSource = rowsTable;
                    ListAss.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmReturnOrder() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

    }
}