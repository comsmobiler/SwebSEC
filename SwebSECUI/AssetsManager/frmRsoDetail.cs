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
    partial class frmRsoDetail : Swebui.Controls.SwebUserControl
    {
        public frmRsoDetail() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string RsoId;      //退库单编号

        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmRestoreOrder() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRsoDetail_Load(object sender, EventArgs e)
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
                AssRestoreOrderOutputDto assRestoreOrderOutput = _autofacConfig.AssetsService.GetRsobyId(RsoId);
                if (assRestoreOrderOutput != null)
                {
                    txtHMan.Text = assRestoreOrderOutput.Handleman;
                    txtLocation.Text = assRestoreOrderOutput.LocationName;
                    txtNote.Text = assRestoreOrderOutput.Note;
                    DPickerRs.Value = assRestoreOrderOutput.Restoredate;
                    txtPlace.Text = assRestoreOrderOutput.Place;
                }
                DataTable rowsTable = _autofacConfig.AssetsService.GetRowsByRsoid(RsoId);
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