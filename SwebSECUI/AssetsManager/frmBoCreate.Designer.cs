using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmBoCreate : Swebui.Controls.SwebUserControl
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
            this.title1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.Label1 = new Swebui.Controls.Label();
            this.comboBox1 = new Swebui.Controls.ComboBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.Label2 = new Swebui.Controls.Label();
            this.DPickerCO = new Swebui.Controls.DatePicker();
            this.panel6 = new Swebui.Controls.Panel();
            this.Label4 = new Swebui.Controls.Label();
            this.comboBox2 = new Swebui.Controls.ComboBox();
            this.panel7 = new Swebui.Controls.Panel();
            this.Label7 = new Swebui.Controls.Label();
            this.txtManager = new Swebui.Controls.TextBox();
            this.panel8 = new Swebui.Controls.Panel();
            this.Label6 = new Swebui.Controls.Label();
            this.DPickerRs = new Swebui.Controls.DatePicker();
            this.panel9 = new Swebui.Controls.Panel();
            this.Label8 = new Swebui.Controls.Label();
            this.txtNote = new Swebui.Controls.TextBox();
            this.panel11 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.txtCode = new Swebui.Controls.TextBox();
            this.btnSelect = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.ListAss = new Swebui.Controls.ListView();
            this.panel10 = new Swebui.Controls.Panel();
            this.btnSave = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.title1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 80);
            // 
            // title1
            // 
            this.title1.Bold = true;
            this.title1.Flex = 1;
            this.title1.FontSize = 18F;
            this.title1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.title1.Margin = new Swebui.Controls.Margin(10F);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(0, 35);
            this.title1.Text = "借用单创建";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel11});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 360);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label1,
            this.comboBox1});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 60);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Swebui.Controls.Padding(10F, 10F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(161, 0);
            this.Label1.Text = "借用人";
            this.Label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.Flex = 1;
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
            this.comboBox1.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem1,
            comboBoxItem2,
            comboBoxItem3,
            comboBoxItem4,
            comboBoxItem5});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Placeholder = "";
            this.comboBox1.PopupHeight = 0;
            this.comboBox1.Size = new System.Drawing.Size(100, 0);
            this.comboBox1.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label2,
            this.DPickerCO});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 60);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(161, 0);
            this.Label2.Text = "借出日期";
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
            this.DPickerCO.Value = new System.DateTime(2021, 12, 10, 16, 36, 20, 372);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label4,
            this.comboBox2});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 60);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(161, 0);
            this.Label4.Text = "来源区域";
            this.Label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.Flex = 1;
            comboBoxItem6.Id = "0";
            comboBoxItem6.Text = "嘉兴";
            comboBoxItem7.Id = "1";
            comboBoxItem7.Text = "上海";
            comboBoxItem8.Id = "2";
            comboBoxItem8.Text = "郑州";
            this.comboBox2.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem6,
            comboBoxItem7,
            comboBoxItem8});
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Placeholder = "";
            this.comboBox2.PopupHeight = 0;
            this.comboBox2.Size = new System.Drawing.Size(100, 0);
            this.comboBox2.Text = "";
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label7,
            this.txtManager});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Flex = 1;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 60);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(161, 0);
            this.Label7.Text = "借出处理人";
            // 
            // txtManager
            // 
            this.txtManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtManager.Flex = 1;
            this.txtManager.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtManager.Name = "txtManager";
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(100, 0);
            this.txtManager.Text = "李四";
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label6,
            this.DPickerRs});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Flex = 1;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 60);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(161, 0);
            this.Label6.Text = "预计归还日期";
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
            this.DPickerRs.Value = new System.DateTime(2021, 12, 10, 16, 57, 24, 539);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label8,
            this.txtNote});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Flex = 1;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 60);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(161, 0);
            this.Label8.Text = "备注";
            this.Label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtNote
            // 
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.Flex = 1;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 0);
            this.txtNote.WaterMarkText = "(选填)";
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.txtCode,
            this.btnSelect});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Flex = 1;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 40);
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 0);
            this.label3.Text = "请输入编号";
            // 
            // txtCode
            // 
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(470, 0);
            this.txtCode.TouchEnter += new System.EventHandler(this.txtCode_TouchEnter);
            // 
            // btnSelect
            // 
            this.btnSelect.Flex = 1;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NumberOfLines = 0;
            this.btnSelect.Size = new System.Drawing.Size(100, 0);
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ListAss});
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 130);
            // 
            // ListAss
            // 
            this.ListAss.BackColor = System.Drawing.Color.White;
            this.ListAss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.Flex = 1;
            this.ListAss.Name = "ListAss";
            this.ListAss.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAss.ShowSplitLine = true;
            this.ListAss.Size = new System.Drawing.Size(0, 300);
            this.ListAss.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.TemplateControlName = "OperCreateAssLayout";
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnSave});
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 30);
            // 
            // btnSave
            // 
            this.btnSave.Flex = 1;
            this.btnSave.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.btnSave.Name = "btnSave";
            this.btnSave.NumberOfLines = 0;
            this.btnSave.Size = new System.Drawing.Size(0, 20);
            this.btnSave.Text = "确定";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmBoCreate
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel10});
            this.Load += new System.EventHandler(this.frmBoCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Label title1;
        private Panel panel2;
        private Panel panel4;
        internal Label Label1;
        private Panel panel5;
        internal Label Label2;
        internal DatePicker DPickerCO;
        private Panel panel6;
        internal Label Label4;
        private Panel panel7;
        internal Label Label7;
        internal TextBox txtManager;
        private Panel panel8;
        internal Label Label6;
        internal DatePicker DPickerRs;
        private Panel panel9;
        internal Label Label8;
        private Panel panel3;
        private ListView ListAss;
        private Panel panel10;
        internal Button btnSave;
        private TextBox txtNote;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Panel panel11;
        private Label label3;
        private TextBox txtCode;
        private Button btnSelect;
    }
}