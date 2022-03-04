using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmAssInventory : Swebui.Controls.SwebUserControl
    {
        #region "SwebUserControl generated code "

        //SwebUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SwebUserControl
        //It can be modified using the SwebUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Swebui.Controls.GridViewColumn gridViewColumn1 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn2 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn3 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn4 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn5 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn6 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn7 = new Swebui.Controls.GridViewColumn();
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.plButton = new Swebui.Controls.Panel();
            this.btnAdd = new Swebui.Controls.Button();
            this.WatchBtn = new Swebui.Controls.Button();
            this.EditBtn = new Swebui.Controls.Button();
            this.DelBtn = new Swebui.Controls.Button();
            this.StartBtn = new Swebui.Controls.Button();
            this.RefreshBtn = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            this.gridView1 = new Swebui.Controls.GridView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Bold = true;
            this.label1.Flex = 1;
            this.label1.FontSize = 18F;
            this.label1.Margin = new Swebui.Controls.Margin(10F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "资产盘点单列表";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // plButton
            // 
            this.plButton.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.plButton.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnAdd,
            this.WatchBtn,
            this.EditBtn,
            this.DelBtn,
            this.StartBtn,
            this.RefreshBtn});
            this.plButton.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plButton.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.plButton.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.plButton.Name = "plButton";
            this.plButton.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.plButton.Size = new System.Drawing.Size(0, 46);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Border = new Swebui.Controls.Border(1F);
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.IconName = "fa fa-plus";
            this.btnAdd.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NumberOfLines = 0;
            this.btnAdd.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.btnAdd.Size = new System.Drawing.Size(0, 26);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // WatchBtn
            // 
            this.WatchBtn.BackColor = System.Drawing.Color.White;
            this.WatchBtn.Border = new Swebui.Controls.Border(1F);
            this.WatchBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.WatchBtn.ForeColor = System.Drawing.Color.DimGray;
            this.WatchBtn.IconName = "fa fa-bookmark";
            this.WatchBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.WatchBtn.Name = "WatchBtn";
            this.WatchBtn.NumberOfLines = 0;
            this.WatchBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.WatchBtn.Size = new System.Drawing.Size(0, 26);
            this.WatchBtn.Text = " 查看";
            this.WatchBtn.Click += new System.EventHandler(this.WatchBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.Border = new Swebui.Controls.Border(1F);
            this.EditBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.EditBtn.ForeColor = System.Drawing.Color.DimGray;
            this.EditBtn.IconName = "fa fa-pencil-square-o";
            this.EditBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.NumberOfLines = 0;
            this.EditBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.EditBtn.Size = new System.Drawing.Size(0, 26);
            this.EditBtn.Text = "编辑";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.White;
            this.DelBtn.Border = new Swebui.Controls.Border(1F);
            this.DelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.DelBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DelBtn.IconName = "fa fa-trash";
            this.DelBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.NumberOfLines = 0;
            this.DelBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.DelBtn.Size = new System.Drawing.Size(0, 26);
            this.DelBtn.Text = "删除";
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.White;
            this.StartBtn.Border = new Swebui.Controls.Border(1F);
            this.StartBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.StartBtn.ForeColor = System.Drawing.Color.DimGray;
            this.StartBtn.IconName = "fa fa-bookmark";
            this.StartBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.NumberOfLines = 0;
            this.StartBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.StartBtn.Size = new System.Drawing.Size(0, 26);
            this.StartBtn.Text = "开始盘点";
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Border = new Swebui.Controls.Border(1F);
            this.RefreshBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.RefreshBtn.ForeColor = System.Drawing.Color.DimGray;
            this.RefreshBtn.IconName = "fa fa-refresh";
            this.RefreshBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.NumberOfLines = 0;
            this.RefreshBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.RefreshBtn.Size = new System.Drawing.Size(0, 26);
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridView1});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // gridView1
            // 
            this.gridView1.AllowPaging = true;
            gridViewColumn1.DisplayMember = "IID";
            gridViewColumn1.HeaderText = "盘点单单号";
            gridViewColumn2.DisplayMember = "NAME";
            gridViewColumn2.HeaderText = "盘点单名称";
            gridViewColumn3.DisplayMember = "CREATEUSER";
            gridViewColumn3.HeaderText = "盘点人";
            gridViewColumn4.DisplayMember = "Time";
            gridViewColumn4.HeaderText = "创建日期";
            gridViewColumn5.DisplayMember = "TOTAL";
            gridViewColumn5.HeaderText = "盘点总数";
            gridViewColumn6.DisplayMember = "RESULTCOUNT";
            gridViewColumn6.HeaderText = "已盘点数";
            gridViewColumn7.DisplayMember = "STATUSNAME";
            gridViewColumn7.HeaderText = "盘点状态";
            this.gridView1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2,
            gridViewColumn3,
            gridViewColumn4,
            gridViewColumn5,
            gridViewColumn6,
            gridViewColumn7});
            this.gridView1.DataSource = null;
            this.gridView1.EditSetting.AllowDeleting = true;
            this.gridView1.Flex = 1;
            this.gridView1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.gridView1.Name = "gridView1";
            this.gridView1.RowHeight = 0;
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // frmAssInventory
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.plButton,
            this.panel2});
            this.Load += new System.EventHandler(this.frmAssInventory_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel plButton;
        internal Button btnAdd;
        private Panel panel2;
        internal Button EditBtn;
        internal Button DelBtn;
        internal Button StartBtn;
        private GridView gridView1;
        internal Button RefreshBtn;
        internal Button WatchBtn;
    }
}