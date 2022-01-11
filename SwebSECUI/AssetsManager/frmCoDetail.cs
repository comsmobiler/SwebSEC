using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SMOSEC.DTOs.OutputDTO;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmCoDetail : Swebui.Controls.SwebUserControl
    {
        public frmCoDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string CoId; //领用单编号        

        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmCollarOrder() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 界面初始化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCoDetail_Load(object sender, EventArgs e)
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
                AssCollarOrderOutputDto assCollarOrderOutput = _autofacConfig.AssetsService.GetCobyId(CoId);
                if (assCollarOrderOutput != null)
                {
                    txtCOMan.Text = assCollarOrderOutput.Userid;
                    txtHMan.Text = assCollarOrderOutput.Handleman;
                    txtLocation.Text = assCollarOrderOutput.Locationid;
                    txtNote.Text = assCollarOrderOutput.Note;
                    DPickerCO.Value = assCollarOrderOutput.Collardate;
                    if (assCollarOrderOutput.Eptrestoredate != null)
                    {
                        DPickerRs.Value = assCollarOrderOutput.Eptrestoredate.Value;
                    }
                    txtDep.Text = assCollarOrderOutput.Inusedep;
                    txtPlace.Text = assCollarOrderOutput.Place;
                }
                DataTable rowsTable = _autofacConfig.AssetsService.GetRowsByCoid(CoId);
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
    }
}