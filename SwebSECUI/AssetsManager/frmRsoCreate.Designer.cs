using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmRsoCreate : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.ComboBoxItem comboBoxItem4 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem5 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem6 = new Swebui.Controls.ComboBoxItem();
            this.panel1 = new Swebui.Controls.Panel();
            this.Title1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.Label1 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.Label2 = new Swebui.Controls.Label();
            this.txtHMan = new Swebui.Controls.TextBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.Label3 = new Swebui.Controls.Label();
            this.DPickerRs = new Swebui.Controls.DatePicker();
            this.panel6 = new Swebui.Controls.Panel();
            this.Label4 = new Swebui.Controls.Label();
            this.txtPlace = new Swebui.Controls.TextBox();
            this.panel7 = new Swebui.Controls.Panel();
            this.Label5 = new Swebui.Controls.Label();
            this.txtNote = new Swebui.Controls.TextBox();
            this.panel8 = new Swebui.Controls.Panel();
            this.Label6 = new Swebui.Controls.Label();
            this.txtCode = new Swebui.Controls.TextBox();
            this.btnSearch = new Swebui.Controls.Button();
            this.panel9 = new Swebui.Controls.Panel();
            this.ListAss = new Swebui.Controls.ListView();
            this.panel10 = new Swebui.Controls.Panel();
            this.btnConfirm = new Swebui.Controls.Button();
            this.btnLocation = new Swebui.Controls.ComboBox();
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
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Bold = true;
            this.Title1.Flex = 1;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(0, 35);
            this.Title1.Text = "退库单创建";
            this.Title1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 300);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label1,
            this.btnLocation});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 58);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(160, 0);
            this.Label1.Text = "退库的区域";
            this.Label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label2,
            this.txtHMan});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 50);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(160, 0);
            this.Label2.Text = "退库处理人";
            this.Label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtHMan
            // 
            this.txtHMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtHMan.Flex = 1;
            this.txtHMan.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtHMan.Name = "txtHMan";
            this.txtHMan.Size = new System.Drawing.Size(100, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label3,
            this.DPickerRs});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 38);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(160, 0);
            this.Label3.Text = "实际退库日期";
            this.Label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // DPickerRs
            // 
            this.DPickerRs.Flex = 1;
            this.DPickerRs.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.DPickerRs.MaxDate = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.DPickerRs.MinDate = new System.DateTime(((long)(0)));
            this.DPickerRs.Name = "DPickerRs";
            this.DPickerRs.Size = new System.Drawing.Size(100, 0);
            this.DPickerRs.Value = new System.DateTime(2021, 12, 27, 11, 59, 42, 241);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label4,
            this.txtPlace});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 53);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(160, 0);
            this.Label4.Text = "退库后存放地";
            this.Label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPlace
            // 
            this.txtPlace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPlace.Flex = 1;
            this.txtPlace.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 0);
            this.txtPlace.WaterMarkText = "(选填)";
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label5,
            this.txtNote});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Flex = 1;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 38);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(160, 0);
            this.Label5.Text = "备注";
            this.Label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtNote
            // 
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.Flex = 1;
            this.txtNote.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 0);
            this.txtNote.WaterMarkText = "(选填)";
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label6,
            this.txtCode,
            this.btnSearch});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Flex = 1;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 51);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(160, 0);
            this.Label6.Text = "输入条码";
            this.Label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtCode
            // 
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCode.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(500, 0);
            this.txtCode.TouchEnter += new System.EventHandler(this.txtCode_TouchEnter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearch.Flex = 1;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NumberOfLines = 0;
            this.btnSearch.Size = new System.Drawing.Size(100, 0);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ListAss});
            this.panel9.Flex = 1;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 100);
            // 
            // ListAss
            // 
            this.ListAss.BackColor = System.Drawing.Color.White;
            this.ListAss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.Flex = 1;
            this.ListAss.Name = "ListAss";
            this.ListAss.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAss.Size = new System.Drawing.Size(0, 300);
            this.ListAss.TemplateControlName = "OperCreateAssExLayout";
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnConfirm});
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 30);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 5;
            this.btnConfirm.Flex = 1;
            this.btnConfirm.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NumberOfLines = 0;
            this.btnConfirm.Size = new System.Drawing.Size(0, 35);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Flex = 1;
            comboBoxItem4.Id = "0";
            comboBoxItem4.Text = "嘉兴";
            comboBoxItem5.Id = "1";
            comboBoxItem5.Text = "上海";
            comboBoxItem6.Id = "2";
            comboBoxItem6.Text = "郑州";
            this.btnLocation.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem4,
            comboBoxItem5,
            comboBoxItem6});
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Placeholder = "";
            this.btnLocation.PopupHeight = 0;
            this.btnLocation.Size = new System.Drawing.Size(100, 0);
            this.btnLocation.Text = "";
            // 
            // frmRsoCreate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel9,
            this.panel10});
            this.Load += new System.EventHandler(this.frmRsoCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Label Title1;
        private Panel panel2;
        private Panel panel3;
        internal Label Label1;
        private Panel panel4;
        internal Label Label2;
        private Panel panel5;
        internal Label Label3;
        private Panel panel6;
        internal Label Label4;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        internal Label Label5;
        internal Label Label6;
        private ListView ListAss;
        private Panel panel10;
        internal Button btnConfirm;
        internal TextBox txtPlace;
        internal TextBox txtNote;
        internal TextBox txtCode;
        internal TextBox txtHMan;
        internal DatePicker DPickerRs;
        private Button btnSearch;
        private ComboBox btnLocation;
    }
}