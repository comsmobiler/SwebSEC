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
            this.panel1 = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.txtNote = new Swebui.Controls.TextBox();
            this.tpSearch = new Swebui.Controls.Panel();
            this.btnDep = new Swebui.Controls.Button();
            this.btnStatus = new Swebui.Controls.Button();
            this.btnType = new Swebui.Controls.Button();
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
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.txtNote});
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
            this.txtNote.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.txtNote.Flex = 1;
            this.txtNote.FontSize = 15F;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtNote.Size = new System.Drawing.Size(100, 30);
            this.txtNote.WaterMarkText = "请输入资产名称或资产条码";
            this.txtNote.TextChanged += new System.EventHandler(this.txtFactor_TextChanged);
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.Color.White;
            this.tpSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tpSearch.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnDep,
            this.btnStatus,
            this.btnType});
            this.tpSearch.Direction = Swebui.Controls.LayoutDirection.Row;
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(0, 50);
            // 
            // btnDep
            // 
            this.btnDep.BackColor = System.Drawing.Color.White;
            this.btnDep.Flex = 1;
            this.btnDep.Name = "btnDep";
            this.btnDep.NumberOfLines = 0;
            this.btnDep.Size = new System.Drawing.Size(100, 0);
            this.btnDep.Text = "部门选择▼";
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.White;
            this.btnStatus.Flex = 1;
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.NumberOfLines = 0;
            this.btnStatus.Size = new System.Drawing.Size(100, 0);
            this.btnStatus.Text = "资产状态▼";
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.White;
            this.btnType.Flex = 1;
            this.btnType.Name = "btnType";
            this.btnType.NumberOfLines = 0;
            this.btnType.Size = new System.Drawing.Size(100, 0);
            this.btnType.Text = "类别选择▼";
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
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
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
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
        private Button btnDep;
        private Button btnStatus;
        private Button btnType;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        internal ListView gridAssRows;
    }
}