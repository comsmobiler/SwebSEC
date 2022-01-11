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
            this.panel1 = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.txtNote = new Swebui.Controls.TextBox();
            this.btnSearch = new Swebui.Controls.Button();
            this.tpSearch = new Swebui.Controls.Panel();
            this.treeSelect1 = new Swebui.Controls.TreeSelect();
            this.treeSelect2 = new Swebui.Controls.TreeSelect();
            this.treeSelect3 = new Swebui.Controls.TreeSelect();
            this.panel2 = new Swebui.Controls.Panel();
            this.gridAssRows = new Swebui.Controls.ListView();
            this.panel4 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.txtNote,
            this.btnSearch});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Margin = new Swebui.Controls.Margin(20F, 10F, 20F, 10F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 30);
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
            this.txtNote.Border = new Swebui.Controls.Border(1F);
            this.txtNote.FontSize = 15F;
            this.txtNote.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtNote.Size = new System.Drawing.Size(337, 30);
            this.txtNote.WaterMarkText = "请输入资产名称或资产条码";
            // 
            // btnSearch
            // 
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NumberOfLines = 0;
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.Color.White;
            this.tpSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tpSearch.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeSelect1,
            this.treeSelect2,
            this.treeSelect3});
            this.tpSearch.Direction = Swebui.Controls.LayoutDirection.Row;
            this.tpSearch.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(0, 40);
            // 
            // treeSelect1
            // 
            this.treeSelect1.DefaultValue = new string[0];
            this.treeSelect1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect1.Name = "treeSelect1";
            this.treeSelect1.Placeholder = "部门选择▼";
            this.treeSelect1.Size = new System.Drawing.Size(200, 0);
            // 
            // treeSelect2
            // 
            this.treeSelect2.DefaultValue = new string[0];
            this.treeSelect2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect2.Name = "treeSelect2";
            treeSelectNode1.Text = "全部";
            treeSelectNode1.TreeID = null;
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
            this.treeSelect2.Placeholder = "资产状态▼";
            this.treeSelect2.Size = new System.Drawing.Size(200, 0);
            // 
            // treeSelect3
            // 
            this.treeSelect3.DefaultValue = new string[0];
            this.treeSelect3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect3.Name = "treeSelect3";
            this.treeSelect3.Placeholder = "类别选择▼";
            this.treeSelect3.Size = new System.Drawing.Size(200, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridAssRows});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            this.panel2.ZIndex = 1;
            // 
            // gridAssRows
            // 
            this.gridAssRows.Flex = 1;
            this.gridAssRows.Name = "gridAssRows";
            this.gridAssRows.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridAssRows.Size = new System.Drawing.Size(0, 300);
            this.gridAssRows.TemplateControlName = "frmAssetsExLayout";
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
            this.label1.FontSize = 16F;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Margin = new Swebui.Controls.Margin(10F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "资产列表";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmAssets
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.panel1,
            this.tpSearch,
            this.panel2});
            this.Load += new System.EventHandler(this.frmAssets_Load);

        }
        #endregion

        private Panel panel1;
        private Panel tpSearch;
        private Panel panel3;
        private FontIcon fontIcon1;
        private TextBox txtNote;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        internal ListView gridAssRows;
        private TreeSelect treeSelect1;
        private TreeSelect treeSelect2;
        private TreeSelect treeSelect3;
        internal Button btnSearch;
    }
}