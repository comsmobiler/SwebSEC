using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmCoCreate : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.ComboBoxItem comboBoxItem1 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem2 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem3 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem4 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem5 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem6 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem7 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem8 = new Swebui.Controls.ComboBoxItem();
            this.panel1 = new Swebui.Controls.Panel();
            this.Title1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.Label1 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.Label2 = new Swebui.Controls.Label();
            this.DPickerCO = new Swebui.Controls.DatePicker();
            this.panel7 = new Swebui.Controls.Panel();
            this.Label3 = new Swebui.Controls.Label();
            this.txtDep = new Swebui.Controls.TextBox();
            this.panel8 = new Swebui.Controls.Panel();
            this.Label4 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.Label5 = new Swebui.Controls.Label();
            this.txtPlace = new Swebui.Controls.TextBox();
            this.panel10 = new Swebui.Controls.Panel();
            this.Label6 = new Swebui.Controls.Label();
            this.DPickerRs = new Swebui.Controls.DatePicker();
            this.panel11 = new Swebui.Controls.Panel();
            this.Label7 = new Swebui.Controls.Label();
            this.txtHMan = new Swebui.Controls.TextBox();
            this.panel12 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.txtNote = new Swebui.Controls.TextBox();
            this.panel3 = new Swebui.Controls.Panel();
            this.Label9 = new Swebui.Controls.Label();
            this.txtCode = new Swebui.Controls.TextBox();
            this.btnSelect = new Swebui.Controls.Button();
            this.panel4 = new Swebui.Controls.Panel();
            this.ListAss = new Swebui.Controls.ListView();
            this.panel13 = new Swebui.Controls.Panel();
            this.btnConfirm = new Swebui.Controls.Button();
            this.btnCOMan = new Swebui.Controls.ComboBox();
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
            this.Title1.Flex = 1;
            this.Title1.FontSize = 15F;
            this.Title1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(0, 35);
            this.Title1.Text = "领用单创建";
            this.Title1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10,
            this.panel11,
            this.panel12});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 300);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label1,
            this.btnCOMan});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 36);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(160, 0);
            this.Label1.Text = "领用人";
            this.Label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label2,
            this.DPickerCO});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 56);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(160, 0);
            this.Label2.Text = "领用日期";
            this.Label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // DPickerCO
            // 
            this.DPickerCO.BackColor = System.Drawing.Color.White;
            this.DPickerCO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DPickerCO.Flex = 1;
            this.DPickerCO.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.DPickerCO.MaxDate = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.DPickerCO.MinDate = new System.DateTime(((long)(0)));
            this.DPickerCO.Name = "DPickerCO";
            this.DPickerCO.Size = new System.Drawing.Size(100, 0);
            this.DPickerCO.Value = new System.DateTime(2021, 12, 22, 11, 22, 23, 887);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label3,
            this.txtDep});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Flex = 1;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 59);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(160, 0);
            this.Label3.Text = "使用部门";
            this.Label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtDep
            // 
            this.txtDep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtDep.Flex = 1;
            this.txtDep.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtDep.Name = "txtDep";
            this.txtDep.ReadOnly = true;
            this.txtDep.Size = new System.Drawing.Size(100, 0);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label4,
            this.btnLocation});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Flex = 1;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 59);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(160, 0);
            this.Label4.Text = "来源区域";
            this.Label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label5,
            this.txtPlace});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Flex = 1;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 59);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(160, 0);
            this.Label5.Text = "存放地点";
            this.Label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label6,
            this.DPickerRs});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Flex = 1;
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 59);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(160, 0);
            this.Label6.Text = "预计退库日期";
            this.Label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // DPickerRs
            // 
            this.DPickerRs.BackColor = System.Drawing.Color.White;
            this.DPickerRs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DPickerRs.Flex = 1;
            this.DPickerRs.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.DPickerRs.MaxDate = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.DPickerRs.MinDate = new System.DateTime(((long)(0)));
            this.DPickerRs.Name = "DPickerRs";
            this.DPickerRs.Size = new System.Drawing.Size(100, 0);
            this.DPickerRs.Value = new System.DateTime(2021, 12, 22, 13, 51, 39, 684);
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label7,
            this.txtHMan});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Flex = 1;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 59);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(160, 0);
            this.Label7.Text = "领用处理人";
            this.Label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtHMan
            // 
            this.txtHMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtHMan.Flex = 1;
            this.txtHMan.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtHMan.Name = "txtHMan";
            this.txtHMan.ReadOnly = true;
            this.txtHMan.Size = new System.Drawing.Size(100, 0);
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.txtNote});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Flex = 1;
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 59);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 0);
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label9,
            this.txtCode,
            this.btnSelect});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 40);
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(160, 0);
            this.Label9.Text = "请输入编号";
            this.Label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtCode
            // 
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(470, 0);
            this.txtCode.TouchEnter += new System.EventHandler(this.txtCode_TouchEnter);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSelect.Flex = 1;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NumberOfLines = 0;
            this.btnSelect.Size = new System.Drawing.Size(100, 0);
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ListAss});
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 168);
            // 
            // ListAss
            // 
            this.ListAss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.Flex = 1;
            this.ListAss.Name = "ListAss";
            this.ListAss.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAss.Size = new System.Drawing.Size(0, 300);
            this.ListAss.TemplateControlName = "OperCreateAssLayout";
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnConfirm});
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(0, 30);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Flex = 1;
            this.btnConfirm.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NumberOfLines = 0;
            this.btnConfirm.Size = new System.Drawing.Size(0, 35);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCOMan
            // 
            this.btnCOMan.Flex = 1;
            comboBoxItem1.Id = "0";
            comboBoxItem1.Text = "富贵";
            comboBoxItem2.Id = "1";
            comboBoxItem2.Text = "老钱";
            comboBoxItem3.Id = "2";
            comboBoxItem3.Text = "李狗蛋";
            comboBoxItem4.Id = "3";
            comboBoxItem4.Text = "李四";
            comboBoxItem5.Id = "4";
            comboBoxItem5.Text = "王五";
            this.btnCOMan.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem1,
            comboBoxItem2,
            comboBoxItem3,
            comboBoxItem4,
            comboBoxItem5});
            this.btnCOMan.Name = "btnCOMan";
            this.btnCOMan.Placeholder = "";
            this.btnCOMan.PopupHeight = 0;
            this.btnCOMan.Size = new System.Drawing.Size(100, 0);
            this.btnCOMan.Text = "";
            // 
            // btnLocation
            // 
            this.btnLocation.Flex = 1;
            comboBoxItem6.Id = "0";
            comboBoxItem6.Text = "嘉兴";
            comboBoxItem7.Id = "1";
            comboBoxItem7.Text = "上海";
            comboBoxItem8.Id = "2";
            comboBoxItem8.Text = "郑州";
            this.btnLocation.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem6,
            comboBoxItem7,
            comboBoxItem8});
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Placeholder = "";
            this.btnLocation.PopupHeight = 0;
            this.btnLocation.Size = new System.Drawing.Size(100, 0);
            this.btnLocation.Text = "";
            // 
            // frmCoCreate
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel13});
            this.Load += new System.EventHandler(this.frmCoCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Label Title1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel3;
        private Panel panel4;
        internal Label Label1;
        internal Label Label2;
        internal DatePicker DPickerCO;
        internal Label Label3;
        internal TextBox txtDep;
        internal Label Label4;
        internal Label Label5;
        internal TextBox txtPlace;
        internal Label Label6;
        internal DatePicker DPickerRs;
        private Label label8;
        internal Label Label7;
        internal TextBox txtHMan;
        internal TextBox txtNote;
        private Button btnSelect;
        internal Label Label9;
        internal TextBox txtCode;
        private ListView ListAss;
        private Panel panel13;
        internal Button btnConfirm;
        private ComboBox btnCOMan;
        private ComboBox btnLocation;
    }
}