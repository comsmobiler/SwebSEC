﻿using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmBorrowOrder : Swebui.Controls.SwebUserControl
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
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.plButton = new Swebui.Controls.Panel();
            this.btnAdd = new Swebui.Controls.Button();
            this.ViewBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
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
            this.label1.FontSize = 16F;
            this.label1.Margin = new Swebui.Controls.Margin(10F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "借用单列表";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            gridViewColumn1.DisplayMember = "BOID";
            gridViewColumn1.HeaderText = "单号";
            gridViewColumn2.DisplayMember = "BORROWER";
            gridViewColumn2.HeaderText = "借用人";
            gridViewColumn3.DisplayMember = "BORROWDATE";
            gridViewColumn3.HeaderText = "日期";
            gridViewColumn4.DisplayMember = "LOCATIONNAME";
            gridViewColumn4.HeaderText = "来源";
            this.gridView1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2,
            gridViewColumn3,
            gridViewColumn4});
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // frmBorrowOrder
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.plButton,
            this.panel3});
            this.Load += new System.EventHandler(this.frmBorrowOrder_Load);

        }
        #endregion

        private Panel panel1;
        private Panel plButton;
        private Panel panel3;
        private Label label1;
        internal Button btnAdd;
        private GridView gridView1;
        internal Button ViewBtn;
    }
}