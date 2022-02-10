using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
using SwebSECUI.Layout;

namespace SwebSECUI.AssetsManager
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssInventoryResult : Swebui.Controls.SwebUserControl
    {
        /// <summary>
        /// 盘点单详情
        /// </summary>
        public frmAssInventoryResult() : base()
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
        private Dictionary<string, int> assDictionary = new Dictionary<string, int>();  //资产
        private List<string> assList;  //资产的初始列表
 

        private ListView waitListView = new ListView();
        private ListView alreadyListView = new ListView();

        public string LocationId;
        public string typeId;
        public string DepartmentId;
        public InventoryStatus Status;
        private DataTable allAssTable = new DataTable(); //全部资产
        #endregion

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new frmAssInventory() { Flex = 1 });
            this.Parent.Controls.RemoveAt(0);
        }

        private void txtCode_TouchEnter(object sender, EventArgs e)
        {
            if (Status == InventoryStatus.盘点结束 || Status == InventoryStatus.盘点未开始)
            {
                Toast("盘点未开始或已经结束.");
            }
            else
            {
                txtCode.Visible = true;
            }
        }

        private void txtCode_SubmitEditing(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string barCode = txtCode.Text;
                string assId = "";
                //根据sn得到Assid
                var asset = _autofacConfig.SettingService.GetAssetsBySN(barCode, "");
                if (asset != null && asset.Rows.Count == 1)
                {
                    assId = asset.Rows[0]["ASSID"].ToString();
                    AddAssToDictionary(assId, barCode);

                }
                else
                {
                    Toast("未找到该SN对应的资产编号.");
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 初始化界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryResult_Load(object sender, EventArgs e)
        {
            try
            {
                //添加各表格的列
                if (waiTable.Columns.Count == 0)
                {
                    waiTable.Columns.Add("RESULTNAME");
                    waiTable.Columns.Add("ASSID");
                    waiTable.Columns.Add("Image");
                    waiTable.Columns.Add("LocationName");
                    waiTable.Columns.Add("Name");
                    waiTable.Columns.Add("Price");
                    waiTable.Columns.Add("SN");
                    waiTable.Columns.Add("TypeName");
                    waiTable.Columns.Add("Specification");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = waiTable.Columns["ASSID"];
                waiTable.PrimaryKey = keys;

                //添加各表格的列
                if (alreadyTable.Columns.Count == 0)
                {
                    alreadyTable.Columns.Add("RESULTNAME");
                    alreadyTable.Columns.Add("ASSID");
                    alreadyTable.Columns.Add("Image");
                    alreadyTable.Columns.Add("LocationName");
                    alreadyTable.Columns.Add("Name");
                    alreadyTable.Columns.Add("Price");
                    alreadyTable.Columns.Add("SN");
                    alreadyTable.Columns.Add("TypeName");
                    alreadyTable.Columns.Add("Specification");
                }
                DataColumn[] keys2 = new DataColumn[1];
                keys2[0] = alreadyTable.Columns["ASSID"];
                alreadyTable.PrimaryKey = keys2;

                UserId = Client.Session["UserID"].ToString();

                //添加各表格的列
                if (allAssTable.Columns.Count == 0)
                {
                    //allAssTable.Columns.Add("RESULTNAME");
                    allAssTable.Columns.Add("ASSID");
                    allAssTable.Columns.Add("Image");
                    allAssTable.Columns.Add("LocationName");
                    allAssTable.Columns.Add("Name");
                    allAssTable.Columns.Add("Price");
                    allAssTable.Columns.Add("SN");
                    allAssTable.Columns.Add("TypeName");
                    allAssTable.Columns.Add("Specification");
                }
                DataColumn[] keys3 = new DataColumn[1];
                keys[0] = allAssTable.Columns["SN"];
                allAssTable.PrimaryKey = keys;

                var allAssTable1 = _autofacConfig.SettingService.GetAllAss("");
                foreach (DataRow row in allAssTable1.Rows)
                {
                    DataRow Row = allAssTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["LocationName"] = row["LocationName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();
                    allAssTable.Rows.Add(Row);
                }


                //添加ListView到tabpageview
                //TabPageControl tabPage1 = new TabPageControl();
                //tabPage1.Controls.Add(new SwebUserControl1() { Flex = 1 });
                //tabPage1.Flex = 1;
                waitListView.TemplateControlName = "frmAIResultLayout";
                waitListView.ShowSplitLine = true;
                waitListView.SplitLineColor = Color.FromArgb(230, 230, 230);
                waitListView.Flex = 1;
                tabPageView1.Controls.Add(waitListView);
                //TabPageControl tabPage2 = new TabPageControl();
                //tabPage2.Controls.Add(new SwebUserControl2() { Flex = 1 });
                //tabPage2.Flex = 1;
                alreadyListView.TemplateControlName = "frmAIResultLayout";
                alreadyListView.ShowSplitLine = true;
                alreadyListView.SplitLineColor = Color.FromArgb(230, 230, 230);
                alreadyListView.Flex = 1;
                tabPageView1.Controls.Add(alreadyListView);

                var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(IID);
                txtName.Text = inventory.NAME;
                txtHandleMan.Text = inventory.HANDLEMANNAME;
                txtCount.Text = inventory.TOTAL.ToString();
                txtLocatin.Text = inventory.LOCATIONNAME;
                txtDep.Text = string.IsNullOrEmpty(inventory.DEPARTMENTID) ? "全部" : inventory.DEPARTMENTNAME;
                txtType.Text = string.IsNullOrEmpty(inventory.TYPEID) ? "全部" : inventory.TYPENAME;
                Status = (InventoryStatus)inventory
                    .STATUS;

                //获得需要盘点的资产列表
                assList = _autofacConfig.AssInventoryService.GetPendingInventoryList(IID);

                //得到盘点单当前的所有行项
                assDictionary = _autofacConfig.AssInventoryService.GetResultDictionary(IID);

                //得到待盘点的资产列表
                var waiTable1 = _autofacConfig.AssInventoryService.GetPendingInventoryTable(IID, LocationId, typeId,
                    DepartmentId);
                foreach (DataRow row in waiTable1.Rows)
                {
                    DataRow Row = waiTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["LocationName"] = row["LocationName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();
                    waiTable.Rows.Add(Row);
                }
                if (inventory.TOTAL == 0)
                {
                    txtCount.Text = waiTable1.Rows.Count.ToString();
                }


                //得到已盘点的资产列表
                var alreadyTable1 = _autofacConfig.AssInventoryService.GetAssInventoryResultsByIID(IID, ResultStatus.存在);
                foreach (DataRow row in alreadyTable1.Rows)
                {
                    DataRow Row = alreadyTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["LocationName"] = row["LocationName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();
                    alreadyTable.Rows.Add(Row);
                }

                if (Status == InventoryStatus.盘点结束 || Status == InventoryStatus.盘点未开始)
                {
                    panel5.Visible = false;
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
        /// 把搜索到的资产添加到对应的Dictionary
        /// </summary>
        /// <param name="assid">资产编号</param>
        private void AddAssToDictionary(string assid, string SN)
        {
            lock (lockobj)
            {
                if (assList.Contains(assid))
                {
                    //如果状态是待盘点，则变成已盘点
                    DataRow row = waiTable.Rows.Find(assid);
                    if (row != null)
                    {
                        DataRow newRow = getNewRow(row, ResultStatus.存在);
                        assDictionary[assid] = (int)ResultStatus.存在;
                        alreadyTable.Rows.Add(newRow);

                        var newdt = alreadyTable.Clone();
                        newdt.ImportRow(newRow);
                        alreadyListView.NewRow(newdt, "");
                        waitListView.Rows.RemoveAt(waiTable.Rows.IndexOf(row));
                        waiTable.Rows.Remove(row);
                    }
                }
                else
                {
                    //如果本来是不需要盘点的，状态改为盘盈
                    if (!assDictionary.ContainsKey(assid))
                    {
                        assDictionary.Add(assid, (int)ResultStatus.盘盈);
                    }
                    DataRow row = alreadyTable.Rows.Find(assid);
                    if (row == null)
                    {
                        DataRow asset = allAssTable.Rows.Find(SN);
                        if (asset != null)
                        {
                            DataRow newRow = getNewRow(asset, ResultStatus.盘盈);
                            alreadyTable.Rows.Add(newRow);

                            var newdt = alreadyTable.Clone();
                            newdt.ImportRow(newRow);
                            ((frmAIResultLayout)alreadyListView.NewRow(newdt, "")[0].Control).label3.ForeColor = Color.FromArgb(43, 140, 255);
                        }
                    }
                }
                string[] titleStrings = new string[2];
                titleStrings[0] = "待盘点(" + waiTable.Rows.Count.ToString() + ")";
                titleStrings[1] = "已盘点(" + alreadyTable.Rows.Count.ToString() + ")";
                tabPageView1.Titles = titleStrings;

            }
        }
        private DataRow getNewRow(DataRow datarow, ResultStatus status)
        {
            DataRow newRow = alreadyTable.NewRow();
            newRow["ASSID"] = datarow["ASSID"].ToString();
            newRow["Image"] = datarow["Image"].ToString();
            newRow["LocationName"] = datarow["LocationName"].ToString();
            newRow["Name"] = datarow["Name"].ToString();
            newRow["Price"] = datarow["Price"].ToString();
            newRow["SN"] = datarow["SN"].ToString();
            newRow["TypeName"] = datarow["TypeName"].ToString();
            newRow["Specification"] = datarow["Specification"].ToString();
            if (status == ResultStatus.盘盈)
                newRow["RESULTNAME"] = "盘盈";
            else
                newRow["RESULTNAME"] = "";
            return newRow;
        }
        private static object lockobj = new object();
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind()
        {
            lock (lockobj)
            {
                try
                {
                    waitListView.Rows.Clear();
                    waitListView.DataSource = waiTable;
                    waitListView.DataBind();

                    alreadyListView.Rows.Clear();
                    alreadyListView.DataSource = alreadyTable;
                    alreadyListView.DataBind();
                    string[] titleStrings = new string[2];
                    titleStrings[0] = "待盘点(" + waiTable.Rows.Count.ToString() + ")";
                    titleStrings[1] = "已盘点(" + alreadyTable.Rows.Count.ToString() + ")";
                    tabPageView1.Titles = titleStrings;

                    foreach (var row in alreadyListView.Rows)
                    {
                        frmAIResultLayout layout = (frmAIResultLayout)row.Control;
                        if (layout.label3.Text == "盘亏")
                            layout.label3.ForeColor = Color.Red;
                        if (layout.label3.Text == "盘盈")
                            layout.label3.ForeColor = Color.FromArgb(43, 140, 255);
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            }

        }
    }
}