using Swebui.Controls;
using System;

namespace SwebSECUI.MasterData
{
    partial class frmAssetsDetail : Swebui.Controls.SwebUserControl
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
            this.txtAssId1 = new Swebui.Controls.TextBox();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.EditBtn = new Swebui.Controls.Button();
            this.UserChangeBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel12 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.txtName1 = new Swebui.Controls.TextBox();
            this.panel = new Swebui.Controls.Panel();
            this.ImgPicture = new Swebui.Controls.Image();
            this.txtSN1 = new Swebui.Controls.TextBox();
            this.panel4 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.txtPrice1 = new Swebui.Controls.TextBox();
            this.txtType = new Swebui.Controls.TextBox();
            this.txtLocation1 = new Swebui.Controls.TextBox();
            this.panel6 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.txtPlace1 = new Swebui.Controls.TextBox();
            this.txtDep = new Swebui.Controls.TextBox();
            this.txtUnit1 = new Swebui.Controls.TextBox();
            this.panel8 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.txtBuyDate = new Swebui.Controls.TextBox();
            this.txtEDate = new Swebui.Controls.TextBox();
            this.txtVendor1 = new Swebui.Controls.TextBox();
            this.panel10 = new Swebui.Controls.Panel();
            this.label13 = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            this.panel11 = new Swebui.Controls.Panel();
            this.txtManager = new Swebui.Controls.TextBox();
            this.txtNote1 = new Swebui.Controls.TextBox();
            this.txtSPE1 = new Swebui.Controls.TextBox();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Title1,
            this.txtAssId1});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.White;
            this.Title1.Bold = true;
            this.Title1.FontSize = 18F;
            this.Title1.Margin = new Swebui.Controls.Margin(10F);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(0, 20);
            this.Title1.Text = "资产详情";
            this.Title1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtAssId1
            // 
            this.txtAssId1.FontSize = 16F;
            this.txtAssId1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtAssId1.Name = "txtAssId1";
            this.txtAssId1.Size = new System.Drawing.Size(0, 20);
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.EditBtn,
            this.UserChangeBtn});
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
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.Border = new Swebui.Controls.Border(1F);
            this.EditBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.EditBtn.ForeColor = System.Drawing.Color.DimGray;
            this.EditBtn.IconName = "fa fa-pencil-square-o";
            this.EditBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.NumberOfLines = 0;
            this.EditBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.EditBtn.Size = new System.Drawing.Size(0, 26);
            this.EditBtn.Text = "修改资产";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // UserChangeBtn
            // 
            this.UserChangeBtn.BackColor = System.Drawing.Color.White;
            this.UserChangeBtn.Border = new Swebui.Controls.Border(1F);
            this.UserChangeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.UserChangeBtn.ForeColor = System.Drawing.Color.DimGray;
            this.UserChangeBtn.IconName = "fa fa-bookmark";
            this.UserChangeBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.UserChangeBtn.Name = "UserChangeBtn";
            this.UserChangeBtn.NumberOfLines = 0;
            this.UserChangeBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.UserChangeBtn.Size = new System.Drawing.Size(0, 26);
            this.UserChangeBtn.Text = "使用者变更";
            this.UserChangeBtn.Click += new System.EventHandler(this.UserChangeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel12,
            this.panel13,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10,
            this.panel11});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
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
            this.label5.Text = "名称";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "图片";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.Text = "SN";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName1,
            this.panel,
            this.txtSN1});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel13.Name = "panel13";
            this.panel13.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel13.Size = new System.Drawing.Size(0, 45);
            // 
            // txtName1
            // 
            this.txtName1.BackColor = System.Drawing.Color.Transparent;
            this.txtName1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtName1.Flex = 1;
            this.txtName1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtName1.Name = "txtName1";
            this.txtName1.ReadOnly = true;
            this.txtName1.Size = new System.Drawing.Size(100, 35);
            // 
            // panel
            // 
            this.panel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ImgPicture});
            this.panel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel.Flex = 1;
            this.panel.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(0, 45);
            // 
            // ImgPicture
            // 
            this.ImgPicture.Border = new Swebui.Controls.Border(1F);
            this.ImgPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ImgPicture.Name = "ImgPicture";
            this.ImgPicture.ResourceID = "";
            this.ImgPicture.Size = new System.Drawing.Size(45, 45);
            this.ImgPicture.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.ImgPicture.Zooming = true;
            // 
            // txtSN1
            // 
            this.txtSN1.BackColor = System.Drawing.Color.Transparent;
            this.txtSN1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtSN1.Flex = 1;
            this.txtSN1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtSN1.Name = "txtSN1";
            this.txtSN1.ReadOnly = true;
            this.txtSN1.Size = new System.Drawing.Size(100, 35);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2,
            this.label3});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 30);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.Text = "金额";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "类别";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "区域";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtPrice1,
            this.txtType,
            this.txtLocation1});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel5.Name = "panel5";
            this.panel5.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel5.Size = new System.Drawing.Size(0, 35);
            // 
            // txtPrice1
            // 
            this.txtPrice1.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtPrice1.Flex = 1;
            this.txtPrice1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.ReadOnly = true;
            this.txtPrice1.Size = new System.Drawing.Size(100, 35);
            this.txtPrice1.ValueType = Swebui.Controls.TextBoxValueType.Number;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.Transparent;
            this.txtType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtType.Flex = 1;
            this.txtType.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(100, 35);
            this.txtType.ValueType = Swebui.Controls.TextBoxValueType.Number;
            // 
            // txtLocation1
            // 
            this.txtLocation1.BackColor = System.Drawing.Color.Transparent;
            this.txtLocation1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtLocation1.Flex = 1;
            this.txtLocation1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtLocation1.Name = "txtLocation1";
            this.txtLocation1.ReadOnly = true;
            this.txtLocation1.Size = new System.Drawing.Size(100, 35);
            this.txtLocation1.ValueType = Swebui.Controls.TextBoxValueType.Number;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label6,
            this.label7});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel6.Size = new System.Drawing.Size(0, 30);
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            this.label4.Text = "地点";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.Text = "部门";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "单位";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtPlace1,
            this.txtDep,
            this.txtUnit1});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel7.Name = "panel7";
            this.panel7.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel7.Size = new System.Drawing.Size(0, 35);
            // 
            // txtPlace1
            // 
            this.txtPlace1.BackColor = System.Drawing.Color.Transparent;
            this.txtPlace1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtPlace1.Flex = 1;
            this.txtPlace1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtPlace1.Name = "txtPlace1";
            this.txtPlace1.ReadOnly = true;
            this.txtPlace1.Size = new System.Drawing.Size(100, 35);
            // 
            // txtDep
            // 
            this.txtDep.BackColor = System.Drawing.Color.Transparent;
            this.txtDep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtDep.Flex = 1;
            this.txtDep.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtDep.Name = "txtDep";
            this.txtDep.ReadOnly = true;
            this.txtDep.Size = new System.Drawing.Size(100, 35);
            // 
            // txtUnit1
            // 
            this.txtUnit1.BackColor = System.Drawing.Color.Transparent;
            this.txtUnit1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtUnit1.Flex = 1;
            this.txtUnit1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtUnit1.Name = "txtUnit1";
            this.txtUnit1.ReadOnly = true;
            this.txtUnit1.Size = new System.Drawing.Size(100, 35);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.label11,
            this.label12});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel8.Size = new System.Drawing.Size(0, 30);
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 0);
            this.label8.Text = "购入时间";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Flex = 1;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.Text = "过期时间";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 0);
            this.label12.Text = "供应商";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtBuyDate,
            this.txtEDate,
            this.txtVendor1});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel9.Name = "panel9";
            this.panel9.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel9.Size = new System.Drawing.Size(0, 35);
            // 
            // txtBuyDate
            // 
            this.txtBuyDate.BackColor = System.Drawing.Color.Transparent;
            this.txtBuyDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtBuyDate.Flex = 1;
            this.txtBuyDate.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtBuyDate.Name = "txtBuyDate";
            this.txtBuyDate.ReadOnly = true;
            this.txtBuyDate.Size = new System.Drawing.Size(100, 35);
            // 
            // txtEDate
            // 
            this.txtEDate.BackColor = System.Drawing.Color.Transparent;
            this.txtEDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtEDate.Flex = 1;
            this.txtEDate.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtEDate.Name = "txtEDate";
            this.txtEDate.ReadOnly = true;
            this.txtEDate.Size = new System.Drawing.Size(100, 35);
            // 
            // txtVendor1
            // 
            this.txtVendor1.BackColor = System.Drawing.Color.Transparent;
            this.txtVendor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtVendor1.Flex = 1;
            this.txtVendor1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtVendor1.Name = "txtVendor1";
            this.txtVendor1.ReadOnly = true;
            this.txtVendor1.Size = new System.Drawing.Size(100, 35);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label13,
            this.label14,
            this.label15});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel10.Name = "panel10";
            this.panel10.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel10.Size = new System.Drawing.Size(0, 30);
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 0);
            this.label13.Text = "管理者";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Flex = 1;
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 0);
            this.label14.Text = "备注";
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Flex = 1;
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 0);
            this.label15.Text = "规格型号";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtManager,
            this.txtNote1,
            this.txtSPE1});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.panel11.Name = "panel11";
            this.panel11.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel11.Size = new System.Drawing.Size(0, 35);
            // 
            // txtManager
            // 
            this.txtManager.BackColor = System.Drawing.Color.Transparent;
            this.txtManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtManager.Flex = 1;
            this.txtManager.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtManager.Name = "txtManager";
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(100, 35);
            // 
            // txtNote1
            // 
            this.txtNote1.BackColor = System.Drawing.Color.Transparent;
            this.txtNote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNote1.Flex = 1;
            this.txtNote1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.ReadOnly = true;
            this.txtNote1.Size = new System.Drawing.Size(100, 35);
            // 
            // txtSPE1
            // 
            this.txtSPE1.BackColor = System.Drawing.Color.Transparent;
            this.txtSPE1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtSPE1.Flex = 1;
            this.txtSPE1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtSPE1.Name = "txtSPE1";
            this.txtSPE1.ReadOnly = true;
            this.txtSPE1.Size = new System.Drawing.Size(100, 35);
            // 
            // frmAssetsDetail
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.frmAssetsDetail_Load);

        }
        #endregion

        private Panel panel1;
        private Label Title1;
        private Panel panel2;
        internal Button BackBtn;
        internal Button EditBtn;
        private Panel panel3;
        private Panel panel12;
        private Label label5;
        private Label label9;
        private Label label10;
        private Panel panel13;
        internal TextBox txtName1;
        private Panel panel;
        private Image ImgPicture;
        internal TextBox txtSN1;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel5;
        internal TextBox txtPrice1;
        internal TextBox txtType;
        internal TextBox txtLocation1;
        private Panel panel6;
        private Label label4;
        private Label label6;
        private Label label7;
        private Panel panel7;
        internal TextBox txtPlace1;
        internal TextBox txtDep;
        internal TextBox txtUnit1;
        private Panel panel8;
        private Label label8;
        private Label label11;
        private Label label12;
        private Panel panel9;
        internal TextBox txtBuyDate;
        internal TextBox txtEDate;
        internal TextBox txtVendor1;
        private Panel panel10;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel11;
        internal TextBox txtManager;
        internal TextBox txtNote1;
        private TextBox txtSPE1;
        internal TextBox txtAssId1;
        internal Button UserChangeBtn;
    }
}