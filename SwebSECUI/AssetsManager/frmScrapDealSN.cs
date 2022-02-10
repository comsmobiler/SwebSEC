﻿using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SwebSECUI.Layout;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.Enum;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmScrapDealSN : Swebui.Controls.SwebUserControl
    {
        public frmScrapDealSN() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String SOID;     //报废单编号
        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmScrapRowsSN() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewRow Row in ListAssetsSN.Rows)
            {
                frmAssSNSDLayout Layout = Row.Control as frmAssSNSDLayout;
                Layout.setCheck(Checkall.Checked);
            }
        }
        /// <summary>
        /// 更新全选框状态
        /// </summary>
        public void upCheckState()
        {
            if (getNum() == ListAssetsSN.Rows.Count)
                Checkall.Checked = true;          //选中所有行项时
            else
                Checkall.Checked = false;        //没有选中所有行项
        }
        /// <summary>
        /// 计算当前选择行数
        /// </summary>
        /// <returns></returns>
        public Int32 getNum()
        {
            Int32 selectQty = 0;        //当前选择行项数
                                        //if (tpvAssets.PageIndex == 0)
                                        //{
            foreach (ListViewRow Row in ListAssetsSN.Rows)
            {
                frmAssSNSDLayout Layout = Row.Control as frmAssSNSDLayout;
                selectQty += Layout.checkNum();
            }
            return selectQty;
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmScrapDealSN_Load(object sender, EventArgs e)
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
                SOInputDto SOData = autofacConfig.assScrapOrderService.GetByID(SOID);
                coreUser User = autofacConfig.coreUserService.GetUserByID(SOData.SCRAPMAN);
                lblDealMan.Text = User.USER_NAME;
                lblDealMan.Tag = SOData.SCRAPMAN;
                DatePicker.Value = SOData.SCRAPDATE;

                if (String.IsNullOrEmpty(SOData.NOTE)) txtNote.Text = SOData.NOTE;

                DataTable tableAssets = new DataTable();       //未开启SN的资产列表
                tableAssets.Columns.Add("SOROWID");           //报修单行项编号
                tableAssets.Columns.Add("ASSID");              //资产编号
                tableAssets.Columns.Add("NAME");               //资产名称
                tableAssets.Columns.Add("IMAGE");              //图片编号
                tableAssets.Columns.Add("SN");                 //序列号
                foreach (AssScrapOrderRow Row in SOData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.SOROWID, Row.ASSID, assets.NAME, Row.IMAGE, Row.SN);
                    }
                }
                if (tableAssets.Rows.Count > 0)
                {
                    ListAssetsSN.DataSource = tableAssets;
                    ListAssetsSN.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 确认还原
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (getNum() == 0) throw new Exception("请选择确认行项!");

                SOInputDto BasicData = new SOInputDto();
                BasicData.MODIFYDATE = DateTime.Now;
                BasicData.MODIFYUSER = Client.Session["UserID"].ToString();
                BasicData.SOID = SOID;

                List<AssScrapOrderRow> Data = new List<AssScrapOrderRow>();
                foreach (ListViewRow Row in ListAssetsSN.Rows)
                {
                    frmAssSNSDLayout Layout = Row.Control as frmAssSNSDLayout;
                    Data.Add(Layout.getData());
                }
                BasicData.Rows = Data;
                ReturnInfo r = autofacConfig.assScrapOrderService.UpdateAssScrapOrder(BasicData);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("资产还原成功!");
                    BackBtn_Click(null,null);
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}