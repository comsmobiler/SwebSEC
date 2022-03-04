using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmScrapDealSN : Swebui.Controls.SwebUserControl
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
            this.Title1 = new Swebui.Controls.Label();
            this.spContent = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.btnSave = new Swebui.Controls.Button();
            this.panel12 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.lblDealMan = new Swebui.Controls.Label();
            this.DatePicker = new Swebui.Controls.DatePicker();
            this.txtNote = new Swebui.Controls.TextBox();
            this.panel7 = new Swebui.Controls.Panel();
            this.ListAssetsSN = new Swebui.Controls.ListView();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.Checkall = new Swebui.Controls.CheckBox();
            this.lblCheckall = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Title1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.White;
            this.Title1.Bold = true;
            this.Title1.Flex = 1;
            this.Title1.FontSize = 18F;
            this.Title1.Margin = new Swebui.Controls.Margin(10F);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(0, 35);
            this.Title1.Text = "资产报废单确认";
            this.Title1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // spContent
            // 
            this.spContent.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.spContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.spContent.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.btnSave});
            this.spContent.Direction = Swebui.Controls.LayoutDirection.Row;
            this.spContent.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.spContent.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.spContent.Name = "spContent";
            this.spContent.Size = new System.Drawing.Size(0, 45);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Border = new Swebui.Controls.Border(1F);
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackBtn.ForeColor = System.Drawing.Color.DimGray;
            this.BackBtn.IconName = "fa fa-angle-left";
            this.BackBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.NumberOfLines = 0;
            this.BackBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.BackBtn.Size = new System.Drawing.Size(0, 26);
            this.BackBtn.Text = "返回";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Border = new Swebui.Controls.Border(1F);
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.IconName = "fa fa-floppy-o";
            this.btnSave.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnSave.Name = "btnSave";
            this.btnSave.NumberOfLines = 0;
            this.btnSave.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.btnSave.Size = new System.Drawing.Size(0, 26);
            this.btnSave.Text = "还原";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label9,
            this.label10});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel12.Name = "panel12";
            this.panel12.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel12.Size = new System.Drawing.Size(0, 30);
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 0);
            this.label5.Text = "处理人";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "清理日期";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.Text = "备注内容";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblDealMan,
            this.DatePicker,
            this.txtNote});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel13.Name = "panel13";
            this.panel13.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel13.Size = new System.Drawing.Size(0, 35);
            // 
            // lblDealMan
            // 
            this.lblDealMan.Flex = 1;
            this.lblDealMan.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.lblDealMan.Name = "lblDealMan";
            this.lblDealMan.Size = new System.Drawing.Size(100, 0);
            this.lblDealMan.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // DatePicker
            // 
            this.DatePicker.BackColor = System.Drawing.Color.White;
            this.DatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.DatePicker.Enable = false;
            this.DatePicker.Flex = 1;
            this.DatePicker.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(100, 0);
            this.DatePicker.Value = new System.DateTime(2022, 1, 11, 16, 50, 13, 648);
            // 
            // txtNote
            // 
            this.txtNote.Flex = 1;
            this.txtNote.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(100, 0);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ListAssetsSN});
            this.panel7.Flex = 1;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 100);
            // 
            // ListAssetsSN
            // 
            this.ListAssetsSN.BackColor = System.Drawing.Color.White;
            this.ListAssetsSN.Border = new Swebui.Controls.Border(1F);
            this.ListAssetsSN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ListAssetsSN.Flex = 1;
            this.ListAssetsSN.Name = "ListAssetsSN";
            this.ListAssetsSN.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAssetsSN.ShowSplitLine = true;
            this.ListAssetsSN.Size = new System.Drawing.Size(0, 300);
            this.ListAssetsSN.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAssetsSN.TemplateControlName = "frmAssSNSDLayout";
            // 
            // panel4
            // 
            this.panel4.Border = new Swebui.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.label7,
            this.label8,
            this.label11});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 45);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Checkall,
            this.lblCheckall});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // Checkall
            // 
            this.Checkall.BackColor = System.Drawing.Color.Transparent;
            this.Checkall.BorderColor = System.Drawing.Color.Black;
            this.Checkall.BorderRadius = 0;
            this.Checkall.Name = "Checkall";
            this.Checkall.Size = new System.Drawing.Size(30, 45);
            this.Checkall.CheckedChanged += new System.EventHandler(this.Checkall_CheckedChanged);
            // 
            // lblCheckall
            // 
            this.lblCheckall.Flex = 1;
            this.lblCheckall.Name = "lblCheckall";
            this.lblCheckall.Size = new System.Drawing.Size(100, 0);
            this.lblCheckall.Text = "全选";
            this.lblCheckall.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 0);
            this.label7.Text = "图片";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 0);
            this.label8.Text = "资产名称";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Flex = 1;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.Text = "SN号";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmScrapDealSN
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.spContent,
            this.panel12,
            this.panel13,
            this.panel4,
            this.panel7});
            this.Load += new System.EventHandler(this.frmScrapDealSN_Load);

        }
        #endregion

        private Panel panel1;
        private Label Title1;
        internal Panel spContent;
        internal Button BackBtn;
        internal Button btnSave;
        private Panel panel12;
        private Label label5;
        private Label label9;
        private Label label10;
        private Panel panel13;
        internal Label lblDealMan;
        internal DatePicker DatePicker;
        private TextBox txtNote;
        private Panel panel7;
        private ListView ListAssetsSN;
        private Panel panel4;
        private Panel panel2;
        internal CheckBox Checkall;
        internal Label lblCheckall;
        private Label label7;
        private Label label8;
        private Label label11;
    }
}