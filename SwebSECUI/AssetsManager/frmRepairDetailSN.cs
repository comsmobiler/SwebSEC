using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;
using System.Data;
using SMOSEC.DTOs.InputDTO;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmRepairDetailSN : Swebui.Controls.SwebUserControl
    {
        public frmRepairDetailSN() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String ROID;     //报修单编号
        #endregion

        /// <summary>
        /// 维修单确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmRepairDealSN() { ROID = ROID, Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
            Bind();
        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRepairDetailSN_Load(object sender, EventArgs e)
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
                ROInputDto ROData = autofacConfig.assRepairOrderService.GetByID(ROID);
                coreUser User = autofacConfig.coreUserService.GetUserByID(ROData.HANDLEMAN);
                lblDealMan.Text = User.USER_NAME;
                DatePicker.Value = ROData.APPLYDATE;
                if (ROData.COST != 0)
                txtPrice.Text = ROData.COST.ToString();
                txtContent.Text = ROData.REPAIRCONTENT;
                txtNote.Text = ROData.NOTE;

                DataTable tableAssets = new DataTable();      //未开启SN的资产列表
                tableAssets.Columns.Add("ASSID");             //资产编号
                tableAssets.Columns.Add("NAME");              //资产名称
                tableAssets.Columns.Add("IMAGE");             //资产图片
                tableAssets.Columns.Add("SN");                //序列号
                tableAssets.Columns.Add("STATUS");            //行项状态
                foreach (AssRepairOrderRow Row in ROData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "等待维修");
                    }
                    else
                    {
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "维修完毕");
                    }
                }
                if (tableAssets.Rows.Count > 0)
                {
                    ListAssetsSN.DataSource = tableAssets;
                    ListAssetsSN.DataBind();
                }
                if (Client.Session["Role"].ToString() == "SMOSECUser") SaveBtn.Visible = false;
                //如果维修单已完成，则隐藏维修单处理按钮
                if (ROData.STATUS == 1) SaveBtn.Visible = false;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmRepairRowsSN() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            frmRepairDealSN frm = new frmRepairDealSN();
            frm.ROID = ROID;
            frm.Flex = 1;
            this.Parent.Controls.Add(frm);
            this.Parent.Controls.RemoveAt(0);
        }
    }
}