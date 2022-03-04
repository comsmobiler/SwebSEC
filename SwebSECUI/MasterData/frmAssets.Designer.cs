using Swebui.Controls;
using System;

namespace SwebSECUI.MasterData
{
    partial class frmAssets : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.TreeSelectNode treeSelectNode1 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode2 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode3 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode4 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode5 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode6 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.TreeSelectNode treeSelectNode7 = new Swebui.Controls.TreeSelectNode();
            Swebui.Controls.GridViewColumn gridViewColumn1 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn2 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn3 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn4 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn5 = new Swebui.Controls.GridViewColumn();
            this.tpSearch = new Swebui.Controls.Panel();
            this.treeSelect1 = new Swebui.Controls.TreeSelect();
            this.treeSelect2 = new Swebui.Controls.TreeSelect();
            this.treeSelect3 = new Swebui.Controls.TreeSelect();
            this.panel3 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.txtNote = new Swebui.Controls.TextBox();
            this.btnSearch = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            this.gridAssRows = new Swebui.Controls.GridView();
            this.panel4 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.AddBtn = new Swebui.Controls.Button();
            this.ViewBtn = new Swebui.Controls.Button();
            this.CopyBtn = new Swebui.Controls.Button();
            this.DeleteBtn = new Swebui.Controls.Button();
            this.RefreshBtn = new Swebui.Controls.Button();
            this.LogBtn = new Swebui.Controls.Button();
            this.PrintBtn = new Swebui.Controls.Button();
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.Color.White;
            this.tpSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tpSearch.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeSelect1,
            this.treeSelect2,
            this.treeSelect3,
            this.panel3});
            this.tpSearch.Direction = Swebui.Controls.LayoutDirection.Row;
            this.tpSearch.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.tpSearch.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(0, 40);
            // 
            // treeSelect1
            // 
            this.treeSelect1.Border = new Swebui.Controls.Border(1F);
            this.treeSelect1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.treeSelect1.DefaultValue = new string[0];
            this.treeSelect1.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.treeSelect1.Name = "treeSelect1";
            this.treeSelect1.Placeholder = "部门选择";
            this.treeSelect1.Size = new System.Drawing.Size(200, 35);
            this.treeSelect1.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect1_Press);
            // 
            // treeSelect2
            // 
            this.treeSelect2.Border = new Swebui.Controls.Border(1F);
            this.treeSelect2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.treeSelect2.DefaultValue = new string[0];
            this.treeSelect2.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect2.Name = "treeSelect2";
            treeSelectNode1.Text = "全部";
            treeSelectNode2.Text = "闲置";
            treeSelectNode2.TreeID = "0";
            treeSelectNode3.Text = "调拨中";
            treeSelectNode3.TreeID = "1";
            treeSelectNode4.Text = "使用中";
            treeSelectNode4.TreeID = "2";
            treeSelectNode5.Text = "维修中";
            treeSelectNode5.TreeID = "3";
            treeSelectNode6.Text = "报废";
            treeSelectNode6.TreeID = "4";
            treeSelectNode7.Text = "借用中";
            treeSelectNode7.TreeID = "5";
            this.treeSelect2.Nodes.AddRange(new Swebui.Controls.TreeSelectNode[] {
            treeSelectNode1,
            treeSelectNode2,
            treeSelectNode3,
            treeSelectNode4,
            treeSelectNode5,
            treeSelectNode6,
            treeSelectNode7});
            this.treeSelect2.Placeholder = "资产状态";
            this.treeSelect2.Size = new System.Drawing.Size(200, 35);
            this.treeSelect2.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect2_Press);
            // 
            // treeSelect3
            // 
            this.treeSelect3.Border = new Swebui.Controls.Border(1F);
            this.treeSelect3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.treeSelect3.DefaultValue = new string[0];
            this.treeSelect3.DropDownHeight = 280;
            this.treeSelect3.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect3.Name = "treeSelect3";
            this.treeSelect3.Placeholder = "类别选择";
            this.treeSelect3.Size = new System.Drawing.Size(200, 35);
            this.treeSelect3.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect3_Press);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.txtNote,
            this.btnSearch});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 35);
            // 
            // fontIcon1
            // 
            this.fontIcon1.BorderRadius = 2;
            this.fontIcon1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(15, 15);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.Flex = 1;
            this.txtNote.FontSize = 15F;
            this.txtNote.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtNote.Size = new System.Drawing.Size(0, 30);
            this.txtNote.WaterMarkText = "请输入资产名称或资产条码";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NumberOfLines = 0;
            this.btnSearch.Size = new System.Drawing.Size(80, 35);
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridAssRows});
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            this.panel2.ZIndex = 1;
            // 
            // gridAssRows
            // 
            this.gridAssRows.AllowPaging = true;
            gridViewColumn1.DisplayMember = "ASSID";
            gridViewColumn1.HeaderText = "资产编号";
            gridViewColumn2.DisplayMember = "Name";
            gridViewColumn2.HeaderText = "名称";
            gridViewColumn3.DisplayMember = "Price";
            gridViewColumn3.HeaderText = "金额";
            gridViewColumn4.DisplayMember = "StatusName";
            gridViewColumn4.HeaderText = "状态";
            gridViewColumn5.DisplayMember = "DEPARTMENTNAME";
            gridViewColumn5.HeaderText = "部门";
            this.gridAssRows.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2,
            gridViewColumn3,
            gridViewColumn4,
            gridViewColumn5});
            this.gridAssRows.DataSource = null;
            this.gridAssRows.Flex = 1;
            this.gridAssRows.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.gridAssRows.Name = "gridAssRows";
            this.gridAssRows.RowHeight = 0;
            this.gridAssRows.RowWidth = 0;
            this.gridAssRows.Size = new System.Drawing.Size(0, 30);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 50);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.Flex = 1;
            this.label1.FontSize = 18F;
            this.label1.Margin = new Swebui.Controls.Margin(10F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "资产列表";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.AddBtn,
            this.ViewBtn,
            this.CopyBtn,
            this.DeleteBtn,
            this.RefreshBtn,
            this.LogBtn,
            this.PrintBtn});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.Name = "panel5";
            this.panel5.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel5.Size = new System.Drawing.Size(0, 46);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.Border = new Swebui.Controls.Border(1F);
            this.AddBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.AddBtn.ForeColor = System.Drawing.Color.DimGray;
            this.AddBtn.IconName = "fa fa-plus";
            this.AddBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NumberOfLines = 0;
            this.AddBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.AddBtn.Size = new System.Drawing.Size(0, 26);
            this.AddBtn.Text = "资产新增";
            this.AddBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.White;
            this.ViewBtn.Border = new Swebui.Controls.Border(1F);
            this.ViewBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.ViewBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ViewBtn.IconName = "fa fa-bookmark";
            this.ViewBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.NumberOfLines = 0;
            this.ViewBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.ViewBtn.Size = new System.Drawing.Size(0, 26);
            this.ViewBtn.Text = "资产查看";
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.BackColor = System.Drawing.Color.White;
            this.CopyBtn.Border = new Swebui.Controls.Border(1F);
            this.CopyBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.CopyBtn.ForeColor = System.Drawing.Color.DimGray;
            this.CopyBtn.IconName = "fa fa-floppy-o";
            this.CopyBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.NumberOfLines = 0;
            this.CopyBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.CopyBtn.Size = new System.Drawing.Size(0, 26);
            this.CopyBtn.Text = "资产复制";
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.Border = new Swebui.Controls.Border(1F);
            this.DeleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.IconName = "fa fa-trash";
            this.DeleteBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NumberOfLines = 0;
            this.DeleteBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.DeleteBtn.Size = new System.Drawing.Size(0, 26);
            this.DeleteBtn.Text = "资产删除";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.RefreshBtn.Text = "资产刷新";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.BackColor = System.Drawing.Color.White;
            this.LogBtn.Border = new Swebui.Controls.Border(1F);
            this.LogBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.LogBtn.ForeColor = System.Drawing.Color.DimGray;
            this.LogBtn.IconName = "fa fa-bookmark";
            this.LogBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.NumberOfLines = 0;
            this.LogBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.LogBtn.Size = new System.Drawing.Size(0, 26);
            this.LogBtn.Text = "处理记录";
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.White;
            this.PrintBtn.Border = new Swebui.Controls.Border(1F);
            this.PrintBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.PrintBtn.ForeColor = System.Drawing.Color.DimGray;
            this.PrintBtn.IconName = "fa fa-print";
            this.PrintBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.NumberOfLines = 0;
            this.PrintBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.PrintBtn.Size = new System.Drawing.Size(0, 26);
            this.PrintBtn.Text = "打印";
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // frmAssets
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.panel5,
            this.tpSearch,
            this.panel2});
            this.Load += new System.EventHandler(this.frmAssets_Load);

        }
        #endregion
        private Panel tpSearch;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        private TreeSelect treeSelect1;
        private TreeSelect treeSelect2;
        private TreeSelect treeSelect3;
        private Panel panel5;
        internal Button AddBtn;
        internal Button ViewBtn;
        private GridView gridAssRows;
        internal Button CopyBtn;
        internal Button DeleteBtn;
        private Panel panel3;
        private FontIcon fontIcon1;
        private TextBox txtNote;
        internal Button btnSearch;
        internal Button RefreshBtn;
        internal Button LogBtn;
        internal Button PrintBtn;
    }
}