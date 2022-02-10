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
            this.panel1 = new Swebui.Controls.Panel();
            this.title1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.btnConfirm = new Swebui.Controls.Button();
            this.panel12 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label1 = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.treeSelect1 = new Swebui.Controls.TreeSelect();
            this.DPickerCO = new Swebui.Controls.DatePicker();
            this.txtManager = new Swebui.Controls.TextBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.label29 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.txtNote = new Swebui.Controls.TextBox();
            this.panel9 = new Swebui.Controls.Panel();
            this.txtCode = new Swebui.Controls.TextBox();
            this.btnSelect = new Swebui.Controls.Button();
            this.label12 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.ListAss = new Swebui.Controls.ListView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.title1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 40);
            // 
            // title1
            // 
            this.title1.Bold = true;
            this.title1.Flex = 1;
            this.title1.FontSize = 18F;
            this.title1.Margin = new Swebui.Controls.Margin(10F);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(0, 35);
            this.title1.Text = "归还单创建";
            this.title1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.btnConfirm});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 45);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Border = new Swebui.Controls.Border(1F);
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackBtn.BorderRadius = 5;
            this.BackBtn.ForeColor = System.Drawing.Color.DimGray;
            this.BackBtn.IconName = "fa fa-angle-left";
            this.BackBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.NumberOfLines = 0;
            this.BackBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.BackBtn.Size = new System.Drawing.Size(80, 35);
            this.BackBtn.Text = "返回";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.Border = new Swebui.Controls.Border(1F);
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnConfirm.BorderRadius = 5;
            this.btnConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirm.IconName = "fa fa-floppy-o";
            this.btnConfirm.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NumberOfLines = 0;
            this.btnConfirm.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.btnConfirm.Size = new System.Drawing.Size(80, 35);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label9,
            this.label1});
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
            this.label5.Text = "归还到区域";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "归还日期";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.Text = "归还负责人";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeSelect1,
            this.DPickerCO,
            this.txtManager});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel13.Name = "panel13";
            this.panel13.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel13.Size = new System.Drawing.Size(0, 35);
            // 
            // treeSelect1
            // 
            this.treeSelect1.Border = new Swebui.Controls.Border(1F);
            this.treeSelect1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.treeSelect1.DefaultValue = new string[0];
            this.treeSelect1.Flex = 1;
            this.treeSelect1.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect1.Name = "treeSelect1";
            this.treeSelect1.Size = new System.Drawing.Size(100, 0);
            this.treeSelect1.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect1_Press);
            // 
            // DPickerCO
            // 
            this.DPickerCO.BackColor = System.Drawing.Color.White;
            this.DPickerCO.Border = new Swebui.Controls.Border(1F);
            this.DPickerCO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DPickerCO.Flex = 1;
            this.DPickerCO.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.DPickerCO.Name = "DPickerCO";
            this.DPickerCO.Size = new System.Drawing.Size(100, 0);
            this.DPickerCO.Value = new System.DateTime(2022, 1, 11, 16, 50, 13, 648);
            // 
            // txtManager
            // 
            this.txtManager.Flex = 1;
            this.txtManager.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtManager.Name = "txtManager";
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(100, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label29,
            this.label3,
            this.label4});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label29
            // 
            this.label29.Flex = 1;
            this.label29.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 0);
            this.label29.Text = "备注";
            this.label29.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "请输入编号";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtNote,
            this.panel9,
            this.label12});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel3.Size = new System.Drawing.Size(0, 35);
            // 
            // txtNote
            // 
            this.txtNote.Border = new Swebui.Controls.Border(1F);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNote.Flex = 1;
            this.txtNote.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 0);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtCode,
            this.btnSelect});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Flex = 1;
            this.panel9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 0);
            // 
            // txtCode
            // 
            this.txtCode.Border = new Swebui.Controls.Border(1F);
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCode.Flex = 8;
            this.txtCode.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 0);
            this.txtCode.ValueType = Swebui.Controls.TextBoxValueType.Number;
            this.txtCode.TouchEnter += new System.EventHandler(this.txtCode_TouchEnter);
            this.txtCode.SubmitEditing += new System.EventHandler(this.txtCode_SubmitEditing);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Border = new Swebui.Controls.Border(1F);
            this.btnSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSelect.Flex = 2;
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NumberOfLines = 0;
            this.btnSelect.Size = new System.Drawing.Size(100, 0);
            this.btnSelect.Text = "搜索";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 0);
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.ListAss});
            this.panel6.Flex = 1;
            this.panel6.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 100);
            // 
            // panel4
            // 
            this.panel4.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label6,
            this.label7,
            this.label8,
            this.label10});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 40);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 0);
            this.label2.Text = "图片";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.Text = "SN号";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "资产条码";
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
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.Text = "持有人";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // ListAss
            // 
            this.ListAss.BackColor = System.Drawing.Color.White;
            this.ListAss.Border = new Swebui.Controls.Border(1F);
            this.ListAss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.Flex = 1;
            this.ListAss.Name = "ListAss";
            this.ListAss.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAss.ShowSplitLine = true;
            this.ListAss.Size = new System.Drawing.Size(0, 300);
            this.ListAss.TemplateControlName = "OperCreateAssExLayout";
            // 
            // frmRtoCreate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel12,
            this.panel13,
            this.panel5,
            this.panel3,
            this.panel6});
            this.Load += new System.EventHandler(this.frmRtoCreate_Load);

        }
        #endregion

        private Panel panel1;
        private Label title1;
        private Panel panel2;
        internal Button BackBtn;
        internal Button btnConfirm;
        private Panel panel12;
        private Label label5;
        private Label label9;
        private Panel panel13;
        private Panel panel5;
        private Label label29;
        private Panel panel3;
        internal TextBox txtNote;
        private Panel panel6;
        private ListView ListAss;
        private TreeSelect treeSelect1;
        internal DatePicker DPickerCO;
        private Label label1;
        internal TextBox txtManager;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Panel panel9;
        private TextBox txtCode;
        private Button btnSelect;
        private Label label12;
    }
}