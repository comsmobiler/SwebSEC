using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
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
    partial class frmConInventoryResult : Swebui.Controls.SwebUserControl
    {
        public frmConInventoryResult() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string IID; //盘点单编号
        private string UserId;  //用户编号
        private DataTable waiTable = new DataTable(); //待盘点的资产
        private DataTable alreadyTable = new DataTable(); //已盘点的资产
        private Dictionary<string, List<decimal>> conDictionary = new Dictionary<string, List<decimal>>();  //资产
        private List<string> conList;  //资产的初始列表
        public string LocationId;
        public InventoryStatus Status;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConInventoryResult_Load(object sender, EventArgs e)
        {
            try
            {
                lblIID.Text = IID;
                   UserId = Client.Session["UserID"].ToString();
                //添加各表格的列
                if (waiTable.Columns.Count == 0)
                {
                    waiTable.Columns.Add("RESULTNAME");
                    waiTable.Columns.Add("CID");
                    waiTable.Columns.Add("Image");
                    waiTable.Columns.Add("Name");
                    waiTable.Columns.Add("Specification");
                    waiTable.Columns.Add("Total");
                    waiTable.Columns.Add("RealAmount");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = waiTable.Columns["CID"];
                waiTable.PrimaryKey = keys;

                //添加各表格的列
                if (alreadyTable.Columns.Count == 0)
                {
                    alreadyTable.Columns.Add("RESULTNAME");
                    alreadyTable.Columns.Add("CID");
                    alreadyTable.Columns.Add("Image");
                    alreadyTable.Columns.Add("Name");
                    alreadyTable.Columns.Add("Specification");
                    alreadyTable.Columns.Add("Total");
                    alreadyTable.Columns.Add("RealAmount");
                }
                DataColumn[] keys2 = new DataColumn[1];
                keys2[0] = alreadyTable.Columns["CID"];
                alreadyTable.PrimaryKey = keys2;

                var inventory = _autofacConfig.ConInventoryService.GetConInventoryById(IID);
                lblName.Text = inventory.NAME;
                lblHandleMan.Text = inventory.HANDLEMANNAME;
                lblCount.Text = inventory.TOTAL.ToString();
                lblLocatin.Text = inventory.LOCATIONNAME;
                Status = (InventoryStatus)inventory
                    .STATUS;

                if (Status == InventoryStatus.盘点结束)
                {
                    snPanel.Visible = label7.Visible = false;
                    StartBtn.Visible = endBtn.Visible = upBtn.Visible = false;
                }
                else if (Status == InventoryStatus.盘点未开始)
                {
                    snPanel.Visible = label7.Visible = false;
                    endBtn.Visible = upBtn.Visible = false;
                }
                else
                {
                    StartBtn.Visible = false;
                    endBtn.Visible = upBtn.Visible = true;
                    snPanel.Visible = label7.Visible = true;
                }
                ///获取盘点区域
                var conInventory = _autofacConfig.ConInventoryService.GetConInventoryById(IID);
                LocationId = conInventory.LOCATIONID;
                //获得需要盘点的资产列表
                conList = _autofacConfig.ConInventoryService.GetPendingInventoryList(IID);
                //得到盘点单当前的所有行项
                conDictionary = _autofacConfig.ConInventoryService.GetResultDictionary(IID);

                //得到待盘点的资产列表
                var waiTable1 = _autofacConfig.ConInventoryService.GetPendingInventoryTable(IID, LocationId);
                foreach (DataRow row in waiTable1.Rows)
                {
                    DataRow Row = waiTable.NewRow();
                    Row["CID"] = row["CID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Specification"] = row["Specification"].ToString();
                    Row["Total"] = row["Total"].ToString();
                    Row["RealAmount"] = row["RealAmount"].ToString();

                    waiTable.Rows.Add(Row);
                }
                if (inventory.TOTAL == 0)
                {
                    lblCount.Text = waiTable1.Rows.Count.ToString();
                }


                //得到已盘点的资产列表
                var alreadyTable1 = _autofacConfig.ConInventoryService.GetConInventoryResultsByIID(IID, ResultStatus.已盘点);
                foreach (DataRow row in alreadyTable1.Rows)
                {
                    DataRow Row = alreadyTable.NewRow();
                    Row["CID"] = row["CID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Specification"] = row["Specification"].ToString();
                    Row["Total"] = row["Total"].ToString();
                    Row["RealAmount"] = row["RealAmount"].ToString();

                    alreadyTable.Rows.Add(Row);
                }

                //绑定数据
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 数据加载
        /// </summary>
        private void Bind()
        {
            try
            {
                waitPanel.Controls.Clear();
                waitBtn.Text = "待盘点(" + waiTable.Rows.Count.ToString() + ")";
                foreach (DataRow row in waiTable.Rows)
                {
                    waitPanel.Controls.Add(new CIResultLayout()
                    {
                        CID = row["CID"].ToString(),
                        RESULTNAME = row["RESULTNAME"].ToString(),
                        Image = row["Image"].ToString(),
                        NAME = row["Name"].ToString(),
                        Specification = row["Specification"].ToString(),
                        Total = row["Total"].ToString(),
                        REALAMOUNT = row["RealAmount"].ToString()
                    });
                }
                alPanel.Controls.Clear();
                foreach (DataRow row in alreadyTable.Rows)
                {
                    alPanel.Controls.Add(new CIResultLayout()
                    {
                        CID = row["CID"].ToString(),
                        RESULTNAME = row["RESULTNAME"].ToString(),
                        Image = row["Image"].ToString(),
                        NAME = row["Name"].ToString(),
                        Specification = row["Specification"].ToString(),
                        Total = row["Total"].ToString(),
                        REALAMOUNT = row["RealAmount"].ToString(),
                    });
                }

                alBtn.Text = "已盘点(" + alreadyTable.Rows.Count.ToString() + ")";


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
            this.Parent.Controls.Add(new frmConInventory() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }
        /// <summary>
        /// 开始盘点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddCIResultInputDto inputDto = new AddCIResultInputDto { IID = IID };
                var inventory = _autofacConfig.ConInventoryService.GetConInventoryById(IID);
                ReturnInfo returnInfo = _autofacConfig.ConInventoryService.AddConInventoryResult(inputDto);
                if (returnInfo.IsSuccess)
                {
                    StartBtn.Visible = false;
                    endBtn.Visible = true;
                    upBtn.Visible = true;
                    snPanel.Visible = label7.Visible = true;
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
        /// 结束盘点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //盘点结束
                Dictionary<string, List<decimal>> conDictionary2 = new Dictionary<string, List<decimal>>();
                foreach (var key in conDictionary.Keys)
                {
                    if (conDictionary[key][1] == (int)ResultStatus.待盘点)
                    {
                        List<decimal> list = new List<decimal>();
                        list.Add(0);
                        list.Add(Convert.ToDecimal((int)ResultStatus.盘亏));
                        conDictionary2.Add(key, list);
                    }
                    else
                    {
                        conDictionary2.Add(key, conDictionary[key]);
                    }
                }

                ConInventoryInputDto inputDto2 = new ConInventoryInputDto
                {
                    IID = IID,
                    LOCATIONID = LocationId,
                    IsEnd = false,
                    ConDictionary = conDictionary2
                };
                inputDto2.IsEnd = true;
                ReturnInfo rInfo = _autofacConfig.ConInventoryService.UpdateInventory(inputDto2);
                if (rInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("盘点结束成功.");
                    BackBtn_Click(null, null);
                }
                else
                {
                    throw new Exception(rInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 上传结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ConInventoryInputDto inputDto = new ConInventoryInputDto
                {
                    IID = IID,
                    IsEnd = false,
                    ConDictionary = conDictionary,
                    LOCATIONID = LocationId,
                    CREATEUSER = UserId
                };
                inputDto.IsEnd = false;
                ReturnInfo rInfo = _autofacConfig.ConInventoryService.UpdateInventory(inputDto);
                if (rInfo.IsSuccess)
                    Toast("上传结果成功!");
                else throw new Exception(rInfo.ErrorInfo);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string CID = txtCID.Text;
                var con = _autofacConfig.ConsumablesService.GetConsumablesByID(CID);
                if (con != null)
                {
                    ConInventoryResult result = _autofacConfig.ConInventoryService.GetResultByCID(IID, CID);
                    if (result != null)
                    {
                        if (result.RESULT.ToString() != "0") throw new Exception("该耗材已盘点完毕,请勿重复盘点!");
                        CIResultTotalLayout frm = new CIResultTotalLayout();
                        DataTable conq = _autofacConfig.ConsumablesService.GetQuants(LocationId, CID);
                        frm.WaitNum = conq.Rows[0]["QUANTITY"].ToString();
                        frm.CID = CID;
                        Form.ShowDialog(frm, (obj, args) =>
                        {
                            if (frm.ShowResult == ShowResult.Yes)
                                AddConToDictionary(CID, Convert.ToDecimal(frm.RealAmount));
                        });
                    }
                    else        //盘盈
                    {
                        CIResultTotalLayout frm = new CIResultTotalLayout();
                        DataTable conq = _autofacConfig.ConsumablesService.GetQuants(LocationId, CID);
                        frm.WaitVisible = false;
                        frm.CID = CID;
                        Form.ShowDialog(frm, (obj, args) =>
                        {
                            if (frm.ShowResult == ShowResult.Yes)
                                AddConToDictionary(CID, Convert.ToDecimal(frm.RealAmount));
                        });
                    }
                }
                else
                {
                    Toast("未找到对应的耗材!");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 待盘点按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void waitBtn_Click(object sender, EventArgs e)
        {
            if (waitPanel.Visible == false)
            {
                waitPanel.Visible = true;
                alPanel.Visible = false;
                waitBtn.BackColor = System.Drawing.Color.FromArgb(78, 137, 248);
                waitBtn.ForeColor = System.Drawing.Color.White;
                alBtn.BackColor = System.Drawing.Color.White;
                alBtn.ForeColor = System.Drawing.Color.Black;
            }
        }
        /// <summary>
        /// 已盘点按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alBtn_Click(object sender, EventArgs e)
        {
            if (alPanel.Visible == false)
            {
                alPanel.Visible = true;
                waitPanel.Visible = false;
                alBtn.BackColor = System.Drawing.Color.FromArgb(78, 137, 248);
                alBtn.ForeColor = System.Drawing.Color.White;
                waitBtn.BackColor = System.Drawing.Color.White;
                waitBtn.ForeColor = System.Drawing.Color.Black;
            }
        }
        /// <summary>
        /// 盘点耗材，刷新界面
        /// </summary>
        /// <param name="CID"></param>
        /// <param name="RealNumber"></param>
        public void AddConToDictionary(string CID, Decimal RealAmount)
        {
            if (conList.Contains(CID))
            {
                //如果本来是需要盘点的，状态改为已盘点
                conDictionary[CID][0] = RealAmount;
                //如果待盘点的datatable存在该资产，从待盘点中删除，并加入到已盘点datatable
                DataRow row = waiTable.Rows.Find(CID);
                if (row != null)
                {
                    DataRow alreadyRow = alreadyTable.NewRow();
                    alreadyRow["CID"] = row["CID"].ToString();
                    alreadyRow["Image"] = row["Image"].ToString();
                    alreadyRow["Name"] = row["Name"].ToString();
                    alreadyRow["Specification"] = row["Specification"].ToString();
                    alreadyRow["Total"] = row["Total"].ToString();
                    alreadyRow["RealAmount"] = RealAmount;
                    if (Convert.ToDecimal(row["Total"]) < RealAmount)
                    {
                        alreadyRow["RESULTNAME"] = "盘盈";
                        conDictionary[CID][1] = (int)ResultStatus.盘盈;
                    }
                    else if (Convert.ToDecimal(alreadyRow["Total"]) > RealAmount)
                    {
                        alreadyRow["RESULTNAME"] = "盘亏";
                        conDictionary[CID][1] = (int)ResultStatus.盘亏;
                    }
                    else
                    {
                        alreadyRow["RESULTNAME"] = "存在";
                        conDictionary[CID][1] = (int)ResultStatus.存在;
                    }
                    alreadyTable.Rows.Add(alreadyRow);
                    waiTable.Rows.Remove(row);
                }
                else
                {
                    if (conDictionary[CID][1] != (int)ResultStatus.盘盈)
                    {
                        DataRow Arow = alreadyTable.Rows.Find(CID);
                        if (Convert.ToDecimal(Arow["Total"]) < RealAmount)
                        {
                            conDictionary[CID][1] = (int)ResultStatus.盘盈;
                            Arow["RealAmount"] = RealAmount;
                            Arow["RESULTNAME"] = "盘盈";
                        }
                        else if (Convert.ToDecimal(Arow["Total"]) > RealAmount)
                        {
                            conDictionary[CID][1] = (int)ResultStatus.盘亏;
                            Arow["RealAmount"] = RealAmount;
                            Arow["RESULTNAME"] = "盘亏";
                        }
                        else
                        {
                            conDictionary[CID][1] = (int)ResultStatus.存在;
                            Arow["RealAmount"] = RealAmount;
                            Arow["RESULTNAME"] = "";
                        }
                    }
                    else
                    {
                        DataRow Arow = alreadyTable.Rows.Find(CID);
                        if (Convert.ToDecimal(Arow["Total"]) < RealAmount)
                        {
                            Arow["RealAmount"] = RealAmount;
                        }
                        else if (Convert.ToDecimal(Arow["Total"]) >= RealAmount)
                        {
                            if (Convert.ToDecimal(Arow["Total"]) > RealAmount)
                            {
                                conDictionary[CID][1] = (int)ResultStatus.盘亏;
                                Arow["RESULTNAME"] = "盘亏";
                            }
                            else
                            {
                                conDictionary[CID][1] = (int)ResultStatus.存在;
                                Arow["RESULTNAME"] = "";
                            }
                        }
                    }
                }
            }
            else
            {
                //如果本来是不需要盘点的，状态改为盘盈
                if (!conDictionary.ContainsKey(CID))
                {
                    List<decimal> list = new List<decimal>();
                    list.Add(RealAmount);
                    list.Add(Convert.ToDecimal((int)ResultStatus.盘盈));
                    conDictionary.Add(CID, list);
                }
                DataRow row = alreadyTable.Rows.Find(CID);
                if (row == null)
                {
                    var con = _autofacConfig.ConsumablesService.GetConsumablesByID(CID);

                    DataRow moreRow = alreadyTable.NewRow();
                    moreRow["CID"] = con.CID;
                    moreRow["RESULTNAME"] = "盘盈";
                    moreRow["Image"] = con.IMAGE;
                    moreRow["Name"] = con.NAME;
                    moreRow["Specification"] = con.SPECIFICATION;
                    moreRow["Total"] = 0;
                    moreRow["RealAmount"] = RealAmount;
                    alreadyTable.Rows.Add(moreRow);
                }
                else
                {
                    row["RealAmount"] = RealAmount;
                }
            }
            Bind();
        }
    }
}