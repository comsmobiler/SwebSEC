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
    partial class frmBoDetail : Swebui.Controls.SwebUserControl
    {
        public frmBoDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }


        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string BoId;  //借用单编号

        private void frmBoDetail_Load(object sender, EventArgs e)
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
                
                AssBorrowOrderOutputDto assBorrowOrderOutput = _autofacConfig.AssetsService.GetBobyId(BoId);
                if (assBorrowOrderOutput != null)
                {
                    txtBOMan.Text = assBorrowOrderOutput.Borrower;
                    txtHMan.Text = assBorrowOrderOutput.Brhandleman;
                    txtLocation.Text = assBorrowOrderOutput.Locationid;
                    txtNote.Text = assBorrowOrderOutput.Note;
                    DPickerCO.Value = assBorrowOrderOutput.Borrowdate;
                    DPickerRs.Value = assBorrowOrderOutput.Eptreturndate;
                }
                DataTable rowsTable = _autofacConfig.AssetsService.GetRowsByBoid(BoId);
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
            this.Parent.Controls.Add(new frmBorrowOrder() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
    }
}