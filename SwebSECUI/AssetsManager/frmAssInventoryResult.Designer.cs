using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmAssInventoryResult : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.SaveBtn = new Swebui.Controls.Button();
            this.SuccessBtn = new Swebui.Controls.Button();
            this.panel12 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.TextBox();
            this.txtHandleMan = new Swebui.Controls.TextBox();
            this.txtLocatin = new Swebui.Controls.TextBox();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtDep = new Swebui.Controls.TextBox();
            this.txtType = new Swebui.Controls.TextBox();
            this.txtCount = new Swebui.Controls.TextBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.label6 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.tabPageView1 = new Swebui.Controls.TabPageView();
            this.panel6 = new Swebui.Controls.Panel();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtCode = new Swebui.Controls.TextBox();
            this.btnSelect = new Swebui.Controls.Button();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label13 = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            this.label16 = new Swebui.Controls.Label();
            this.label17 = new Swebui.Controls.Label();
            this.label18 = new Swebui.Controls.Label();
            this.label19 = new Swebui.Controls.Label();
            this.label20 = new Swebui.Controls.Label();
            this.label21 = new Swebui.Controls.Label();
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
            this.label1.FontSize = 18F;
            this.label1.Margin = new Swebui.Controls.Margin(10F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "资产盘点单列表";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.SaveBtn,
            this.SuccessBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
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
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.Border = new Swebui.Controls.Border(1F);
            this.SaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.SaveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SaveBtn.IconName = "fa fa-floppy-o";
            this.SaveBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.NumberOfLines = 0;
            this.SaveBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.SaveBtn.Size = new System.Drawing.Size(0, 26);
            this.SaveBtn.Text = "保存";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SuccessBtn
            // 
            this.SuccessBtn.BackColor = System.Drawing.Color.White;
            this.SuccessBtn.Border = new Swebui.Controls.Border(1F);
            this.SuccessBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.SuccessBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SuccessBtn.IconName = "fa fa-floppy-o";
            this.SuccessBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.SuccessBtn.Name = "SuccessBtn";
            this.SuccessBtn.NumberOfLines = 0;
            this.SuccessBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.SuccessBtn.Size = new System.Drawing.Size(0, 26);
            this.SuccessBtn.Text = "结束";
            this.SuccessBtn.Click += new System.EventHandler(this.SuccessBtn_Click);
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
            this.label5.Text = "盘点表";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "盘点人";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.Text = "区域";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.txtHandleMan,
            this.txtLocatin});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel13.Name = "panel13";
            this.panel13.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel13.Size = new System.Drawing.Size(0, 35);
            // 
            // txtName
            // 
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 0);
            this.txtName.WaterMarkText = "（选填）";
            // 
            // txtHandleMan
            // 
            this.txtHandleMan.Flex = 1;
            this.txtHandleMan.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtHandleMan.Name = "txtHandleMan";
            this.txtHandleMan.ReadOnly = true;
            this.txtHandleMan.Size = new System.Drawing.Size(100, 0);
            this.txtHandleMan.WaterMarkText = "（选填）";
            // 
            // txtLocatin
            // 
            this.txtLocatin.Flex = 1;
            this.txtLocatin.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtLocatin.Name = "txtLocatin";
            this.txtLocatin.ReadOnly = true;
            this.txtLocatin.Size = new System.Drawing.Size(100, 0);
            this.txtLocatin.WaterMarkText = "（选填）";
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label3,
            this.label4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "部门";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "类型";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            this.label4.Text = "需盘点总数";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtDep,
            this.txtType,
            this.txtCount});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtDep
            // 
            this.txtDep.Flex = 1;
            this.txtDep.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtDep.Name = "txtDep";
            this.txtDep.ReadOnly = true;
            this.txtDep.Size = new System.Drawing.Size(100, 0);
            // 
            // txtType
            // 
            this.txtType.Flex = 1;
            this.txtType.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(100, 0);
            this.txtType.WaterMarkText = "（选填）";
            // 
            // txtCount
            // 
            this.txtCount.Flex = 1;
            this.txtCount.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(100, 0);
            this.txtCount.WaterMarkText = "（选填）";
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label6,
            this.label11,
            this.label12});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.Text = "请输入编号";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Flex = 1;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // tabPageView1
            // 
            this.tabPageView1.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.tabPageView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndex = 0;
            this.tabPageView1.PageIndicator = Swebui.Controls.TabPageIndicator.Title2;
            this.tabPageView1.Size = new System.Drawing.Size(0, 30);
            this.tabPageView1.Titles = new string[] {
        "待盘点",
        "已盘点"};
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel8,
            this.label7,
            this.label8});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtCode,
            this.btnSelect});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Flex = 1;
            this.panel8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 0);
            // 
            // txtCode
            // 
            this.txtCode.Border = new Swebui.Controls.Border(1F);
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtCode.Flex = 7;
            this.txtCode.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 0);
            this.txtCode.TouchEnter += new System.EventHandler(this.txtCode_TouchEnter);
            this.txtCode.SubmitEditing += new System.EventHandler(this.txtCode_SubmitEditing);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Border = new Swebui.Controls.Border(1F);
            this.btnSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSelect.Flex = 3;
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NumberOfLines = 0;
            this.btnSelect.Size = new System.Drawing.Size(100, 0);
            this.btnSelect.Text = "添加到已盘点";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 0);
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label13,
            this.label14,
            this.label15,
            this.label16,
            this.label17,
            this.label18,
            this.label19,
            this.label20,
            this.label21});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 35);
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 0);
            this.label13.Text = "000";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label14
            // 
            this.label14.Flex = 1;
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 0);
            this.label14.Text = "资产名称";
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label15
            // 
            this.label15.Flex = 1;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 0);
            this.label15.Text = "资产编号";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label16
            // 
            this.label16.Flex = 1;
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 0);
            this.label16.Text = "资产种类";
            this.label16.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label17
            // 
            this.label17.Flex = 1;
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 0);
            this.label17.Text = "SN号";
            this.label17.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label18
            // 
            this.label18.Flex = 1;
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 0);
            this.label18.Text = "规格型号";
            this.label18.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label19
            // 
            this.label19.Flex = 1;
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 0);
            this.label19.Text = "金额";
            this.label19.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label20
            // 
            this.label20.Flex = 1;
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 0);
            this.label20.Text = "区域";
            this.label20.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label21
            // 
            this.label21.Flex = 1;
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 0);
            this.label21.Text = "资产状态";
            this.label21.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // frmAssInventoryResult
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel12,
            this.panel13,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.tabPageView1});
            this.Load += new System.EventHandler(this.frmAssInventoryResult_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        internal Button BackBtn;
        internal Button SaveBtn;
        private Panel panel12;
        private Label label5;
        private Label label9;
        private Label label10;
        private Panel panel13;
        internal TextBox txtName;
        internal TextBox txtHandleMan;
        internal TextBox txtLocatin;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        internal TextBox txtDep;
        internal TextBox txtType;
        internal TextBox txtCount;
        private Label label6;
        private TabPageView tabPageView1;
        private Label label11;
        private Label label12;
        private Panel panel8;
        private TextBox txtCode;
        private Button btnSelect;
        private Label label7;
        private Label label8;
        internal Button SuccessBtn;
        internal Panel panel5;
        internal Panel panel6;
        private Panel panel7;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
    }
}