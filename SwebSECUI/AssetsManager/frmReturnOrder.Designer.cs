using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmReturnOrder : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.GridViewColumn gridViewColumn9 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn10 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn11 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn12 = new Swebui.Controls.GridViewColumn();
            this.panel1 = new Swebui.Controls.Panel();
            this.plButton = new Swebui.Controls.Panel();
            this.btnAdd = new Swebui.Controls.Button();
            this.ViewBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.gridView1 = new Swebui.Controls.GridView();
            this.label1 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnAdd,
            this.ViewBtn});
            this.plButton.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(0, 50);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Border = new Swebui.Controls.Border(1F);
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.IconName = "fa fa-plus";
            this.btnAdd.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NumberOfLines = 0;
            this.btnAdd.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.White;
            this.ViewBtn.Border = new Swebui.Controls.Border(1F);
            this.ViewBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.ViewBtn.BorderRadius = 5;
            this.ViewBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ViewBtn.IconName = "fa fa-plus";
            this.ViewBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.NumberOfLines = 0;
            this.ViewBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.ViewBtn.Size = new System.Drawing.Size(80, 35);
            this.ViewBtn.Text = "查看";
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridView1});
            this.panel3.Flex = 1;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // gridView1
            // 
            this.gridView1.AllowPaging = true;
            gridViewColumn9.DisplayMember = "Rtoid";
            gridViewColumn9.HeaderText = "单号";
            gridViewColumn10.DisplayMember = "Returndate";
            gridViewColumn10.HeaderText = "日期";
            gridViewColumn11.DisplayMember = "HandleMan";
            gridViewColumn11.HeaderText = "处理人";
            gridViewColumn12.DisplayMember = "LocationName";
            gridViewColumn12.HeaderText = "区域";
            this.gridView1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn9,
            gridViewColumn10,
            gridViewColumn11,
            gridViewColumn12});
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
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
            this.label1.Text = "归还单列表";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmReturnOrder
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.plButton,
            this.panel3});
            this.Load += new System.EventHandler(this.frmReturnOrder_Load);

        }
        #endregion

        private Panel panel1;
        private Panel plButton;
        private Panel panel3;
        internal Button btnAdd;
        internal Button ViewBtn;
        private GridView gridView1;
        private Label label1;
    }
}