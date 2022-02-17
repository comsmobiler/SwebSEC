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

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class SwebUserControl1 : Swebui.Controls.SwebUserControl
    {
        public SwebUserControl1() : base()
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
        //private List<string> RFIDlist;    //RFID的扫描数据集合

        private ListView waitListView = new ListView();
        private ListView alreadyListView = new ListView();

        public string LocationId;
        public string typeId;
        public string DepartmentId;
        public InventoryStatus Status;
        private DataTable allAssTable = new DataTable(); //全部资产
        #endregion
        private void SwebUserControl1_Load(object sender, EventArgs e)
        {
            //获得需要盘点的资产列表
            assList = _autofacConfig.AssInventoryService.GetPendingInventoryList(IID);

            //得到盘点单当前的所有行项
            assDictionary = _autofacConfig.AssInventoryService.GetResultDictionary(IID);

            //得到待盘点的资产列表
            DataTable waiTable1 = _autofacConfig.AssInventoryService.GetPendingInventoryTable(IID, LocationId, typeId, DepartmentId);
            if (waiTable1 != null)
            {
                listView1.DataSource = waiTable;
                listView1.DataBind();
            }
        }
    }
}