using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmRtoCreate : Swebui.Controls.SwebUserControl
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
            this.panel1 = new Swebui.Controls.Panel();
            this.title1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.Label1 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.Label2 = new Swebui.Controls.Label();
            this.DPickerCO = new Swebui.Controls.DatePicker();
            this.panel7 = new Swebui.Controls.Panel();
            this.Label4 = new Swebui.Controls.Label();
            this.txtHMan = new Swebui.Controls.TextBox();
            this.panel8 = new Swebui.Controls.Panel();
            this.Label8 = new Swebui.Controls.Label();
            this.txtNote = new Swebui.Controls.TextBox();
            this.panel9 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.textBox1 = new Swebui.Controls.TextBox();
            this.button1 = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.ListAss = new Swebui.Controls.ListView();
            this.panel4 = new Swebui.Controls.Panel();
            this.btnConfirm = new Swebui.Controls.Button();
            this.btnLocation = new Swebui.Controls.ComboBox();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.title1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 70);
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
            this.title1.Text = "归还单创建";
            this.title1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 250);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label1,
            this.btnLocation});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 50);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(160, 0);
            this.Label1.Text = "归还到区域";
            this.Label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label2,
            this.DPickerCO});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 50);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(160, 0);
            this.Label2.Text = "归还日期";
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
            this.DPickerCO.Value = new System.DateTime(2021, 12, 17, 13, 18, 4, 592);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label4,
            this.txtHMan});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 50);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(160, 0);
            this.Label4.Text = "归还到区域";
            this.Label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtHMan
            // 
            this.txtHMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtHMan.Flex = 1;
            this.txtHMan.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtHMan.Name = "txtHMan";
            this.txtHMan.Size = new System.Drawing.Size(100, 0);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label8,
            this.txtNote});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 50);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(160, 0);
            this.Label8.Text = "备注";
            this.Label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.textBox1,
            this.button1});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 50);
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 0);
            this.label3.Text = "请输入编号";
            // 
            // textBox1
            // 
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 0);
            this.textBox1.TouchEnter += new System.EventHandler(this.textBox1_TouchEnter);
            this.textBox1.SubmitEditing += new System.EventHandler(this.textBox1_SubmitEditing);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button1.Flex = 1;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(100, 0);
            this.button1.Text = "搜索";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ListAss});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
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
            this.ListAss.TemplateControlName = "OperCreateAssExLayout";
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnConfirm});
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 30);
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
            comboBoxItem1.Id = "0";
            comboBoxItem1.Text = "嘉兴";
            comboBoxItem2.Id = "1";
            comboBoxItem2.Text = "上海";
            comboBoxItem3.Id = "2";
            comboBoxItem3.Text = "郑州";
            this.btnLocation.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem1,
            comboBoxItem2,
            comboBoxItem3});
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Placeholder = "";
            this.btnLocation.PopupHeight = 0;
            this.btnLocation.Size = new System.Drawing.Size(100, 0);
            this.btnLocation.Text = "";
            // 
            // frmRtoCreate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4});
            this.Load += new System.EventHandler(this.frmRtoCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel3;
        private ListView ListAss;
        private Panel panel4;
        private Label title1;
        internal Label Label1;
        internal Label Label2;
        internal DatePicker DPickerCO;
        internal Label Label4;
        internal TextBox txtHMan;
        internal Label Label8;
        internal TextBox txtNote;
        internal Button btnConfirm;
        private Panel panel9;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private ComboBox btnLocation;
    }
}