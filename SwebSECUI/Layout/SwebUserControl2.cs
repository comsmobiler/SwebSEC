using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
using SwebSECUI.Layout;
using System.Data;
using System.Drawing;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class SwebUserControl2 : Swebui.Controls.SwebUserControl
    {
        public SwebUserControl2() : base()
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
        private void SwebUserControl2_Load(object sender, EventArgs e)
        {
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
                allAssTable.Columns.Add("RESULTNAME");
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
            keys2[0] = allAssTable.Columns["SN"];
            allAssTable.PrimaryKey = keys2;
            
            UserId = Client.Session["UserID"].ToString();

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
            
            //获得需要盘点的资产列表
            assList = _autofacConfig.AssInventoryService.GetPendingInventoryList(IID);

            //得到盘点单当前的所有行项
            assDictionary = _autofacConfig.AssInventoryService.GetResultDictionary(IID);

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
                listView1.Rows.Clear();
                listView1.DataSource = alreadyTable;
                listView1.DataBind();
            }
        }
    }
}