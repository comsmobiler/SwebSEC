using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.OutputDTO;
using System.Data;

namespace SwebSECUI.MasterData
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssets : Swebui.Controls.SwebUserControl
    {
        public frmAssets() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string SelectAssId;  //当前选择的资产

        private string UserId;
        private string LocatinId;

        #endregion
        private void btnDep_Click(object sender, EventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            
        }

        public static explicit operator frmAssets(SwebForm v)
        {
            throw new NotImplementedException();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
           
           
        }
        /// <summary>
        /// 按照SN或者名称模糊匹配查询资产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFactor_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void SearchData()
        {
            try
            {
                String DepId = btnDep.Tag == null ? null : btnDep.Tag.ToString();     //选择部门编号
                String Status = btnStatus.Tag == null ? null : btnStatus.Tag.ToString();   //选择资产状态
                String Type = btnType.Tag == null ? null : btnType.Tag.ToString();
                DataTable table = _autofacConfig.SettingService.QueryAssets(txtNote.Text, LocatinId, DepId, Status, Type);
                gridAssRows.Rows.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["AssId"].ToString() == SelectAssId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {
                LocatinId = "";
                if (Client.Session["Role"].ToString() != "ADMIN")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocatinId = user.USER_LOCATIONID;
                }

                DataTable table = _autofacConfig.SettingService.GetAllAss(LocatinId);
                gridAssRows.Rows.Clear();
                table.Columns.Add("IsChecked");
                foreach (DataRow Row in table.Rows)
                {
                    if (Row["AssId"].ToString() == SelectAssId)
                    {
                        Row["IsChecked"] = true;
                    }
                    else
                    {
                        Row["IsChecked"] = false;
                    }
                }
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssets_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}