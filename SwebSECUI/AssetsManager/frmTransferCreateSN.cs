using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.Domain.Entity;
using SMOSEC.CommLib;
using SwebSECUI.Layout;
using System.Data;
using SMOSEC.DTOs.Enum;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmTransferCreateSN : Swebui.Controls.SwebUserControl
    {
        public frmTransferCreateSN() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<AssetsOrderRow> SNRowData;   //开启SN行项
        public TOInputDto TransferData = new TOInputDto();         //调拨单信息
        private String SN;       //序列号
        #endregion
        /// <summary>
        /// 加载数据
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmTransferRowsSN() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 创建调拨单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeSelect1.Tag == null)
                    throw new Exception("调入管理员不能为空");
                else
                    TransferData.MANAGER = treeSelect1.Tag.ToString();     //调入管理员

                if (treeSelect2.Tag == null)
                    throw new Exception("调入区域不能为空");
                else
                    TransferData.DESLOCATIONID = treeSelect2.Tag.ToString();     //调入区域

                if (treeSelect3.Tag == null)
                    throw new Exception("处理人不能为空");
                else
                    TransferData.HANDLEMAN = treeSelect3.Tag.ToString();     //处理人

                TransferData.TRANSFERDATE = DatePicker.Value;   //维修花费
                TransferData.NOTE = txtNote.Text;                           //备注
                TransferData.STATUS = 0;                                    //维修单状态
                TransferData.ISSNCONTROL = (Int32)ISSNCONTROL.启用;         //是否属于SN
                TransferData.CREATEUSER = Client.Session["UserID"].ToString();      //创建用户
                TransferData.CREATEDATE = DateTime.Now;

                List<AssTransferOrderRow> Data = new List<AssTransferOrderRow>();
                if (ListAssetsSN.Rows.Count == 0) throw new Exception("调拨行项不能为空!");
                foreach (ListViewRow Row in ListAssetsSN.Rows)
                {
                    frmOrderCreateSNLayout Layout = Row.Control as frmOrderCreateSNLayout;
                    AssetsOrderRow RowData = Layout.getData();
                    AssTransferOrderRow assRow = new AssTransferOrderRow();

                    assRow.IMAGE = RowData.IMAGE;
                    assRow.ASSID = RowData.ASSID;
                    assRow.INTRANSFERQTY = RowData.QTY;
                    assRow.SN = RowData.SN;
                    assRow.LOCATIONID = RowData.LOCATIONID;
                    assRow.STATUS = RowData.STATUS;
                    assRow.CREATEDATE = DateTime.Now;
                    Data.Add(assRow);
                }
                TransferData.Rows = Data;
                ReturnInfo r = autofacConfig.assTransferOrderService.AddAssTransferOrder(TransferData, OperateType.资产);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("创建调拨单成功!");
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
            btnSelect_Click(null,null);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                AssetsOrderRow Data = new AssetsOrderRow();
                SN = txtCode.Text;
                Assets assets = autofacConfig.orderCommonService.GetUnusedAssetsBySN(SN);
                if (assets == null) throw new Exception("不存在序列号为" + SN + "的闲置资产");
                if (assets.LOCATIONID == treeSelect2.Tag.ToString()) throw new Exception("该资产已在目的区域!");
                Data.ASSID = assets.ASSID;
                Data.LOCATIONID = assets.LOCATIONID;
                Data.IMAGE = assets.IMAGE;
                Data.QTY = 0;
                Data.SN = SN;
                if (SNRowData != null)
                {
                    foreach (AssetsOrderRow Row in SNRowData)
                    {
                        if (Data.ASSID == Row.ASSID && Data.SN == Row.SN)
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

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect1.Tag = args.TreeID;
        }

        private void treeSelect2_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect2.Tag = args.TreeID;
        }

        private void treeSelect3_Press(object sender, TreeSelectPressEventArgs args)
        {
            treeSelect3.Tag = args.TreeID;
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        private void frmTransferCreateSN_Load(object sender, EventArgs e)
        {
            ///调入管理员选择
            List<coreUser> users = autofacConfig.coreUserService.GetDealInAdmin();
            foreach (coreUser role in users)

            {
                treeSelect1.Nodes.Add(new TreeSelectNode(role.USER_ID, role.USER_NAME));
            }
            ///调入区域选择
            List<AssLocation> locations = autofacConfig.assLocationService.GetEnableAll();
            foreach (var location in locations)
            {
                treeSelect2.Nodes.Add(new TreeSelectNode(location.LOCATIONID, location.NAME));
            }
            ///调入处理人选择
            List<coreUser> coreusers = autofacConfig.coreUserService.GetAdmin();
            foreach (coreUser role in users)
            {
                treeSelect3.Nodes.Add(new TreeSelectNode(role.USER_ID, role.USER_NAME));
            }
        }
    }
}