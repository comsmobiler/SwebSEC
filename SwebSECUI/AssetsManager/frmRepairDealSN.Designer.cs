using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmRepairDealSN : Swebui.Controls.SwebUserControl
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
            this.title1 = new Swebui.Controls.Label();
            this.spContent = new Swebui.Controls.Panel();
            this.plRDMan = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.lblDealMan = new Swebui.Controls.Label();
            this.plDate = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.DatePicker = new Swebui.Controls.DatePicker();
            this.plPrice = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.lblPrice = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.plContent = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.lblContent = new Swebui.Controls.Label();
            this.plNote = new Swebui.Controls.Panel();
            this.label6 = new Swebui.Controls.Label();
            this.lblNote = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.ListAssetsSN = new Swebui.Controls.ListView();
            this.plAll = new Swebui.Controls.Panel();
            this.Checkall = new Swebui.Controls.CheckBox();
            this.lblCheckall = new Swebui.Controls.Label();
            this.plButton = new Swebui.Controls.Panel();
            this.btnSave = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.title1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Bold = true;
            this.title1.Flex = 1;
            this.title1.FontSize = 16F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(0, 35);
            this.title1.Text = "资产报修单确认";
            this.title1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.plRDMan,
            this.plDate,
            this.plPrice,
            this.plContent,
            this.plNote});
            this.spContent.Name = "spContent";
            this.spContent.Size = new System.Drawing.Size(0, 276);
            // 
            // plRDMan
            // 
            this.plRDMan.BackColor = System.Drawing.Color.White;
            this.plRDMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRDMan.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.lblDealMan});
            this.plRDMan.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plRDMan.Flex = 1;
            this.plRDMan.Name = "plRDMan";
            this.plRDMan.Size = new System.Drawing.Size(0, 58);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 0);
            this.label1.Text = "处理人";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblDealMan
            // 
            this.lblDealMan.Flex = 1;
            this.lblDealMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblDealMan.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.lblDealMan.Name = "lblDealMan";
            this.lblDealMan.Size = new System.Drawing.Size(100, 0);
            this.lblDealMan.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // plDate
            // 
            this.plDate.BackColor = System.Drawing.Color.White;
            this.plDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plDate.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.DatePicker});
            this.plDate.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plDate.Flex = 1;
            this.plDate.Name = "plDate";
            this.plDate.Size = new System.Drawing.Size(0, 58);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 0);
            this.label3.Text = "业务日期";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // DatePicker
            // 
            this.DatePicker.Enable = false;
            this.DatePicker.Flex = 1;
            this.DatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.DatePicker.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.DatePicker.MaxDate = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.DatePicker.MinDate = new System.DateTime(((long)(0)));
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(100, 0);
            this.DatePicker.Value = new System.DateTime(2021, 12, 28, 14, 32, 27, 715);
            // 
            // plPrice
            // 
            this.plPrice.BackColor = System.Drawing.Color.White;
            this.plPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPrice.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.lblPrice,
            this.label7});
            this.plPrice.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plPrice.Flex = 1;
            this.plPrice.Name = "plPrice";
            this.plPrice.Size = new System.Drawing.Size(0, 58);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 0);
            this.label4.Text = "维修花费";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblPrice
            // 
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblPrice.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(500, 0);
            this.lblPrice.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label7.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "元";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plContent.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.lblContent});
            this.plContent.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plContent.Flex = 1;
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(0, 58);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 0);
            this.label5.Text = "维修内容";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblContent
            // 
            this.lblContent.Flex = 1;
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblContent.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(100, 0);
            this.lblContent.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // plNote
            // 
            this.plNote.BackColor = System.Drawing.Color.White;
            this.plNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plNote.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label6,
            this.lblNote});
            this.plNote.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plNote.Flex = 1;
            this.plNote.Name = "plNote";
            this.plNote.Size = new System.Drawing.Size(0, 58);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 0);
            this.label6.Text = "备注";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblNote
            // 
            this.lblNote.Flex = 1;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblNote.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(100, 0);
            this.lblNote.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ListAssetsSN});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // ListAssetsSN
            // 
            this.ListAssetsSN.BackColor = System.Drawing.Color.White;
            this.ListAssetsSN.Flex = 1;
            this.ListAssetsSN.Name = "ListAssetsSN";
            this.ListAssetsSN.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAssetsSN.Size = new System.Drawing.Size(0, 300);
            this.ListAssetsSN.TemplateControlName = "frmAssSNRDLayout";
            // 
            // plAll
            // 
            this.plAll.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Checkall,
            this.lblCheckall});
            this.plAll.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plAll.Name = "plAll";
            this.plAll.Size = new System.Drawing.Size(0, 50);
            // 
            // Checkall
            // 
            this.Checkall.BackColor = System.Drawing.Color.Transparent;
            this.Checkall.BorderColor = System.Drawing.Color.Black;
            this.Checkall.BorderRadius = 0;
            this.Checkall.Name = "Checkall";
            this.Checkall.Size = new System.Drawing.Size(80, 0);
            this.Checkall.CheckedChanged += new System.EventHandler(this.Checkall_CheckedChanged);
            // 
            // lblCheckall
            // 
            this.lblCheckall.Name = "lblCheckall";
            this.lblCheckall.Size = new System.Drawing.Size(150, 0);
            this.lblCheckall.Text = "全选";
            this.lblCheckall.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnSave});
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(0, 40);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 4;
            this.btnSave.Flex = 1;
            this.btnSave.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.btnSave.Name = "btnSave";
            this.btnSave.NumberOfLines = 0;
            this.btnSave.Size = new System.Drawing.Size(0, 35);
            this.btnSave.Text = "完成";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRepairDealSN
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.spContent,
            this.panel2,
            this.plAll,
            this.plButton});
            this.Load += new System.EventHandler(this.frmRepairDealSN_Load);

        }
        #endregion

        private Panel panel1;
        private Label title1;
        internal Panel spContent;
        private Panel plRDMan;
        private Label label1;
        internal Label lblDealMan;
        private Panel plDate;
        private Label label3;
        private DatePicker DatePicker;
        private Panel plPrice;
        private Label label4;
        internal Label lblPrice;
        private Label label7;
        private Panel plContent;
        private Label label5;
        internal Label lblContent;
        private Panel plNote;
        private Label label6;
        internal Label lblNote;
        private Panel panel2;
        private ListView ListAssetsSN;
        private Panel plAll;
        internal CheckBox Checkall;
        internal Label lblCheckall;
        private Panel plButton;
        private Button btnSave;
    }
}