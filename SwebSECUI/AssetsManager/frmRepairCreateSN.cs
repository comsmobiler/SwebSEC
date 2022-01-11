using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.Domain.Entity;
using System.Data;
using SwebSECUI.Layout;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmRepairCreateSN : Swebui.Controls.SwebUserControl
    {
        public frmRepairCreateSN() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<AssetsOrderRow> SNRowData;   //开启SN行项
        public ROInputDto RepairData = new ROInputDto();         //维修单信息
        private String SN;       //序列号
        #endregion
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmRepairRowsSN() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 创建报修单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeSelect1.Tag == null)
                    throw new Exception("处理人不能为空");
                else
                    RepairData.HANDLEMAN = treeSelect1.Tag.ToString();     //处理人                
                if (String.IsNullOrEmpty(txtPrice.Text) == false)
                    RepairData.COST = Convert.ToDecimal(txtPrice.Text);   //维修花费
                if (String.IsNullOrEmpty(txtContent.Text))
                    throw new Exception("维修内容不能为空!");
                else
                    RepairData.REPAIRCONTENT = txtContent.Text;               //维修内容

                RepairData.APPLYDATE = DatePicker.Value;                  //业务日期
                RepairData.NOTE = txtNote.Text;                           //备注
                RepairData.STATUS = 0;                                    //维修单状态
                RepairData.ISSNCONTROL = (Int32)ISSNCONTROL.启用;         //是否属于SN
                RepairData.CREATEUSER = Client.Session["UserID"].ToString();      //创建用户
                RepairData.CREATEDATE = DateTime.Now;

                List<AssRepairOrderRow> Data = new List<AssRepairOrderRow>();
                if (ListAssetsSN.Rows.Count == 0) throw new Exception("维修行项不能为空!");
                foreach (ListViewRow Row in ListAssetsSN.Rows)
                {
                    frmOrderCreateSNLayout Layout = Row.Control as frmOrderCreateSNLayout;
                    AssetsOrderRow RowData = Layout.getData();
                    AssRepairOrderRow assRow = new AssRepairOrderRow();

                    assRow.IMAGE = RowData.IMAGE;
                    assRow.ASSID = RowData.ASSID;
                    assRow.WAITREPAIRQTY = RowData.QTY;
                    assRow.SN = RowData.SN;
                    assRow.LOCATIONID = RowData.LOCATIONID;
                    assRow.STATUS = RowData.STATUS;
                    assRow.CREATEDATE = DateTime.Now;
                    Data.Add(assRow);
                }
                RepairData.Rows = Data;
                ReturnInfo r = autofacConfig.assRepairOrderService.AddAssRepairOrder(RepairData);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                         //创建成功
                    Toast("创建维修单成功!");
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
        /// <summary>
        /// 添加数据
        /// </summary>
        public void Bind()
        {
            try
            {
                DataTable tableAssets = new DataTable();       //未开启SN的资产列表
                tableAssets.Columns.Add("ASSID");              //资产编号
                tableAssets.Columns.Add("NAME");               //资产名称 
                tableAssets.Columns.Add("IMAGE");              //图片编号
                tableAssets.Columns.Add("SN");                 //序列号
                if (SNRowData.Count > 0)
                {
                    foreach (AssetsOrderRow Row in SNRowData)
                    {
                        Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN);
                    }
                }
                ListAssetsSN.DataSource = tableAssets;
                ListAssetsSN.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 删除当前所选行项
        /// </summary>
        /// <param name="ASSID"></param>
        /// <param name="SN"></param>
        public void ReMoveAssSN(String ASSID, String SN)
        {
            try
            {
                foreach (AssetsOrderRow Row in SNRowData)
                {
                    if (Row.ASSID == ASSID && Row.SN == SN)
                    {
                        SNRowData.Remove(Row);
                        break;
                    }
                }
                Bind();       //刷新当前页面
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void txtCode_TouchEnter(object sender, EventArgs e)
        {

        }

        private void txtCode_SubmitEditing(object sender, EventArgs e)
        {
            btnSelect_Click(null, null);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                AssetsOrderRow Data = new AssetsOrderRow();
                SN = txtCode.Text;
                Assets assets = autofacConfig.orderCommonService.GetUnusedAssetsBySN(SN);
                if (assets == null) throw new Exception("不存在序列号为" + SN + "的闲置资产");
                Data.ASSID = assets.ASSID;
                Data.LOCATIONID = assets.LOCATIONID;
                Data.IMAGE = assets.IMAGE;
                Data.QTY = 0;
                Data.SN = SN;
                if (SNRowData != null)
                {
                    foreach (AssetsOrderRow Row in SNRowData)
                    {
                        if (Data.ASSID == Row.ASSID)
                            throw new Exception("该资产已添加，请勿重复添加!");
                    }
                    SNRowData.Add(Data);
                }
                else
                {
                    List<AssetsOrderRow> Datas = new List<AssetsOrderRow>();
                    Datas.Add(Data);
                    SNRowData = Datas;
                }
                Bind();        //重新绑定数据
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void frmRepairCreateSN_Load(object sender, EventArgs e)
        {
            ///添加处理人
            List<coreUser> listRole = autofacConfig.coreUserService.GetAdmin();
            foreach (coreUser role in listRole)
            {
                treeSelect1.Nodes.Add(new TreeSelectNode(role.USER_ID, role.USER_NAME));
            }
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect1.Tag = args.TreeID;
        }
    }
}