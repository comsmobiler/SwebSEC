using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ConTransferConsChooseDialog : Swebui.Controls.SwebUserControl
    {
        public ConTransferConsChooseDialog() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConsumablesOrderRow> RowData = new List<ConsumablesOrderRow>();    //未开启SN行项
        public String LocInID;           //调入区域编号
        #endregion
        /// <summary>
        /// 全选按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (snPanel.Controls.Count > 0)
            {
                foreach (ConTDLayout Row in snPanel.Controls)
                {
                    Row.IsChecked = CheckAll.Checked;
                }
            }
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RowData.Count > 0) RowData.Clear();
                foreach (ConTDLayout Row in snPanel.Controls)
                {
                    if (Row.IsChecked)
                    {
                         if (Convert.ToDecimal(Row.Num) == 0) throw new Exception("选择数量不能为0!");
                        ConsumablesOrderRow Data = new ConsumablesOrderRow();
                        Data.IMAGE = Row.Image;
                        Data.CID = Row.CID;
                        Data.QTY = Convert.ToDecimal(Row.Num);
                        Data.LOCATIONID = Row.LOCATIONID;
                        Data.STATUS = 0;
                        RowData.Add(Data);     //添加未开启SN资产信息
                    }
                }
                ShowResult = ShowResult.Yes;
                this.Close();       //关闭当前页面
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Cancel;
            this.Close();
        }

        private void ConTransferConsChooseDialog_Load(object sender, EventArgs e)
        {
            Bind(null);
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        /// <param name="Name"></param>
        public void Bind(String Name)
        {
            try
            {
                List<ConQuant> listAss = new List<ConQuant>();
                if (String.IsNullOrEmpty(Name))     //查询所有耗材
                    listAss = autofacConfig.orderCommonService.GetUnUseCon(LocInID, null);
                else
                {
                    Consumables consumables = autofacConfig.orderCommonService.GetConsByName(Name);
                    listAss = autofacConfig.orderCommonService.GetUnUseCon(LocInID, consumables.CID);
                }
                foreach (ConQuant Row in listAss)
                {
                    Consumables cons = autofacConfig.orderCommonService.GetConsByID(Row.CID);
                    AssLocation location = autofacConfig.assLocationService.GetByID(Row.LOCATIONID);
                    if (RowData.Count > 0)
                    {
                        Boolean isAdd = false;
                        foreach (ConsumablesOrderRow HaveRow in RowData)
                        {
                            if (HaveRow.CID == Row.CID && HaveRow.LOCATIONID == Row.LOCATIONID)
                            {
                                snPanel.Controls.Add(new ConTDLayout() { IsChecked = true, CID = Row.CID, NAME = cons.NAME, LOCATIONID = Row.LOCATIONID, LOCATIONNAME = location.NAME, Image = cons.IMAGE, INTRANSFERQTY = Row.QUANTITY.ToString(), Num = HaveRow.QTY.ToString() });
                                isAdd = true;
                                break;
                            }
                        }
                        if (isAdd == false)
                            snPanel.Controls.Add(new ConTDLayout() { IsChecked = false, CID = Row.CID, NAME = cons.NAME, LOCATIONID = Row.LOCATIONID, LOCATIONNAME = location.NAME, Image = cons.IMAGE, INTRANSFERQTY = Row.QUANTITY.ToString(), Num = "0" });
                    }
                    else
                    {
                        snPanel.Controls.Add(new ConTDLayout() { IsChecked = false, CID = Row.CID, NAME = cons.NAME, LOCATIONID = Row.LOCATIONID, LOCATIONNAME = location.NAME, Image = cons.IMAGE, INTRANSFERQTY = Row.QUANTITY.ToString(), Num = "0" });
                    }

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            snPanel.Controls.Clear();
            Bind(txtName.Text);
        }
    }
}