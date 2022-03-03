﻿using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.Enum;
using SwebSECUI.Layout;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.Domain.Entity;
using SMOSEC.CommLib;
using System.Data;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmTransferDealSN : Swebui.Controls.SwebUserControl
    {
        public frmTransferDealSN() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String TOID;     //调拨单编号
        public PROCESSMODE Type;   //操作类型
        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmTransferRowsSN() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 调拨单操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (getNum() == 0) throw new Exception("请选择确认行项!");

                TOInputDto BasicData = new TOInputDto();
                BasicData.MODIFYDATE = DateTime.Now;
                BasicData.MODIFYUSER = Client.Session["UserID"].ToString();
                BasicData.TOID = TOID;

                List<AssTransferOrderRow> Data = new List<AssTransferOrderRow>();
                foreach (ListViewRow Row in ListAssetsSN.Rows)
                {
                    frmAssSNTDLayout Layout = Row.Control as frmAssSNTDLayout;
                    if (Layout.getData() != null)
                    {
                        Data.Add(Layout.getData());
                    }
                }
                BasicData.Rows = Data;
                ReturnInfo r = autofacConfig.assTransferOrderService.UpdateAssTransferOrder(BasicData, Type, OperateType.资产);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    BackBtn_Click(null,null);
                    if (Type == PROCESSMODE.调拨确认)
                    {
                        Toast("确认调拨成功!");
                    }
                    else
                    {
                        Toast("取消调拨成功!");
                    }
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

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewRow Row in ListAssetsSN.Rows)
            {
                frmAssSNTDLayout Layout = Row.Control as frmAssSNTDLayout;
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
            foreach (ListViewRow Row in ListAssetsSN.Rows)
            {
                frmAssSNTDLayout Layout = Row.Control as frmAssSNTDLayout;
                selectQty += Layout.checkNum();
            }
            return selectQty;
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferDealSN_Load(object sender, EventArgs e)
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
                if (Type == PROCESSMODE.调拨确认) Title1.Text = "调拨单确认";
                if (Type == PROCESSMODE.调拨取消) Title1.Text = "调拨单取消";
                TOInputDto TOData = autofacConfig.assTransferOrderService.GetByID(TOID);
                coreUser DeanInUser = autofacConfig.coreUserService.GetUserByID(TOData.MANAGER);
                coreUser DealUser = autofacConfig.coreUserService.GetUserByID(TOData.HANDLEMAN);
                AssLocation assLocation = autofacConfig.assLocationService.GetByID(TOData.DESLOCATIONID);
                lblTDInMan.Text = DeanInUser.USER_NAME;
                lblDealMan.Text = DealUser.USER_NAME;
                lblLocation.Text = assLocation.NAME;
                DatePicker.Value = TOData.TRANSFERDATE;
                if (String.IsNullOrEmpty(TOData.NOTE)) lblNote.Text = TOData.NOTE;

                DataTable tableAssets = new DataTable();       //未开启SN的资产列表
                tableAssets.Columns.Add("TOROWID");           //报修单行项编号
                tableAssets.Columns.Add("ASSID");              //资产编号
                tableAssets.Columns.Add("NAME");               //资产名称
                tableAssets.Columns.Add("IMAGE");              //图片编号
                tableAssets.Columns.Add("SN");                 //序列号
                foreach (AssTransferOrderRow Row in TOData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.TOROWID, Row.ASSID, assets.NAME, Row.IMAGE, Row.SN);
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
    }
}