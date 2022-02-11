using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using SwebSECUI.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebSECUI.ConsumablesManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmOutOrderCreate : Swebui.Controls.SwebUserControl
    {
        public frmOutOrderCreate() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string TypeId;
        private string HManId;
        private string LocationId;
        public DataTable ConTable;
        public List<string> ConList;

        private List<OutboundOrderRowInputDto> rowsInputDtos = new List<OutboundOrderRowInputDto>();
        private string UserId;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOutOrderCreate_Load(object sender, EventArgs e)
        {
            try
            {
                ///绑定区域数据
                List<AssLocation> locations = _autofacConfig.assLocationService.GetEnableAll();
                foreach (var location in locations)
                {
                    btnLocation.Nodes.Add(new TreeSelectNode(location.LOCATIONID, location.NAME));
                }
            }
            catch (Exception ex)
            {

                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 返回按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmOutboundOrder() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GetRows();
                int TId = int.Parse(TypeId);
                OutboundOrderInputDto outboundOrderInput = new OutboundOrderInputDto()
                {
                    BUSINESSDATE = DPickerCO.Value,
                    MODIFYUSER = UserId,
                    CREATEUSER = UserId,
                    HANDLEDATE = DateTime.Now,
                    LOCATIONID = LocationId,
                    NOTE = txtNote.Text,
                    HANDLEMAN = HManId,
                    RowInputDtos = rowsInputDtos,
                    TYPE = TId
                };
                ReturnInfo returnInfo = _autofacConfig.ConsumablesService.AddOutboundOrder(outboundOrderInput);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("添加成功");
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 得到行项数据
        /// </summary>
        private void GetRows()
        {
            rowsInputDtos.Clear();
            foreach (ConOutChooseLayout row in listPanel.Controls)
            {
                decimal Quant;
                if (decimal.TryParse(row.QUANT,out Quant) == false)
                {
                    throw new Exception("耗材编号" + row.TemplateID + "的库存格式不正确。");
                }
                decimal Quantity;
                if (decimal.TryParse(row.NumQuant.ToString(), out Quantity) == false)
                {
                    throw new Exception("耗材编号" + row.TemplateID + "的数量格式不正确。");
                }
                decimal Money;
                if (decimal.TryParse(row.NumPrice.ToString(), out Money) == false)
                {
                    throw new Exception("耗材编号" + row.TemplateID + "的金额格式不正确。");
                }
                if (Quantity > Quant)
                {
                    throw new Exception("耗材编号" + row.TemplateID + "库存不足。");
                }
                OutboundOrderRowInputDto rowInput = new OutboundOrderRowInputDto
                {
                    CID = row.TemplateID,
                    MONEY = Money,
                    NOTE = row.TXTNote,
                    QUANTITY = Quantity
                };
                if (rowsInputDtos.Count > 0)
                {
                    foreach(var dto in rowsInputDtos)
                    {
                        if (dto.CID == rowInput.CID)
                            throw new Exception("存在编号重复项，请先合并");
                    }
                }
                rowsInputDtos.Add(rowInput);
            }
        }

        /// <summary>
        /// 区域选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnDealMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            try
            {
                if (LocationId != null && LocationId != args.TreeID)
                {
                    ClearInfo();
                }
                LocationId = args.TreeID;
                AssLocation location = _autofacConfig.assLocationService.GetByID(LocationId);
                if (location != null)
                {
                    coreUser manager = _autofacConfig.coreUserService.GetUserByID(location.MANAGER);
                    HManId = location.MANAGER;
                    if (manager != null) txtHMan.Text = manager.USER_NAME;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 清空相关的数据
        /// </summary>
        private void ClearInfo()
        {
            listPanel.Controls.Clear();
        }
        /// <summary>
        /// 新增行项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               DataTable conTable = _autofacConfig.ConsumablesService.GetConListByLocationAndName(LocationId, "");
                listPanel.Controls.Add(new ConOutChooseLayout(conTable) );
            }
           catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 出库类型选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void btnBOMan_Press(object sender, TreeSelectPressEventArgs args)
        {
            TypeId = args.TreeID;
        }
    }
}