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
            this.panel2 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.txtAssId1 = new Swebui.Controls.TextBox();
            this.panel5 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.txtName1 = new Swebui.Controls.TextBox();
            this.panel6 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.panel14 = new Swebui.Controls.Panel();
            this.image1 = new Swebui.Controls.Image();
            this.panel7 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.txtSN1 = new Swebui.Controls.TextBox();
            this.panel8 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.txtPrice1 = new Swebui.Controls.TextBox();
            this.panel9 = new Swebui.Controls.Panel();
            this.label6 = new Swebui.Controls.Label();
            this.txtType = new Swebui.Controls.TextBox();
            this.panel10 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.panel11 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.txtLocation1 = new Swebui.Controls.TextBox();
            this.panel12 = new Swebui.Controls.Panel();
            this.label9 = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.label10 = new Swebui.Controls.Label();
            this.panel15 = new Swebui.Controls.Panel();
            this.label12 = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.label13 = new Swebui.Controls.Label();
            this.panel17 = new Swebui.Controls.Panel();
            this.label14 = new Swebui.Controls.Label();
            this.panel18 = new Swebui.Controls.Panel();
            this.label15 = new Swebui.Controls.Label();
            this.panel19 = new Swebui.Controls.Panel();
            this.label16 = new Swebui.Controls.Label();
            this.panel20 = new Swebui.Controls.Panel();
            this.label17 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.btnEdit = new Swebui.Controls.Button();
            this.btnLog = new Swebui.Controls.Button();
            this.btnChange = new Swebui.Controls.Button();
            this.btnDelete = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Title1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 40);
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
            this.Title1.Text = "资产详情";
            this.Title1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10,
            this.panel11,
            this.panel12,
            this.panel13,
            this.panel15,
            this.panel16,
            this.panel17,
            this.panel18,
            this.panel19,
            this.panel20});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 500);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.txtAssId1});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 20);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 0);
            this.label1.Text = "资产编号";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtAssId1
            // 
            this.txtAssId1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssId1.Flex = 1;
            this.txtAssId1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtAssId1.Name = "txtAssId1";
            this.txtAssId1.ReadOnly = true;
            this.txtAssId1.Size = new System.Drawing.Size(100, 0);
            this.txtAssId1.WaterMarkText = "(必填)";
            this.txtAssId1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.txtName1});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 20);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 0);
            this.label2.Text = "名称";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtName1
            // 
            this.txtName1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName1.Flex = 1;
            this.txtName1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtName1.Name = "txtName1";
            this.txtName1.ReadOnly = true;
            this.txtName1.Size = new System.Drawing.Size(100, 0);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.label11,
            this.panel14});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 20);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 0);
            this.label3.Text = "图片";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(500, 0);
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel14
            // 
            this.panel14.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1});
            this.panel14.Flex = 1;
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(300, 0);
            // 
            // image1
            // 
            this.image1.Flex = 1;
            this.image1.Name = "image1";
            this.image1.ResourceID = "mare";
            this.image1.Size = new System.Drawing.Size(0, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.txtSN1});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Flex = 1;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 20);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 0);
            this.label4.Text = "SN";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtSN1
            // 
            this.txtSN1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSN1.Flex = 1;
            this.txtSN1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtSN1.Name = "txtSN1";
            this.txtSN1.ReadOnly = true;
            this.txtSN1.Size = new System.Drawing.Size(100, 0);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.txtPrice1});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Flex = 1;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 41);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 0);
            this.label5.Text = "金额";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPrice1
            // 
            this.txtPrice1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPrice1.Flex = 1;
            this.txtPrice1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.ReadOnly = true;
            this.txtPrice1.Size = new System.Drawing.Size(100, 0);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label6,
            this.txtType});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Flex = 1;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 41);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 0);
            this.label6.Text = "类别";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtType
            // 
            this.txtType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtType.Flex = 1;
            this.txtType.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(100, 0);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Flex = 1;
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 41);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 0);
            this.label7.Text = "规格型号";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.txtLocation1});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Flex = 1;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 41);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 0);
            this.label8.Text = "区域";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtLocation1
            // 
            this.txtLocation1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtLocation1.Flex = 1;
            this.txtLocation1.Name = "txtLocation1";
            this.txtLocation1.ReadOnly = true;
            this.txtLocation1.Size = new System.Drawing.Size(100, 0);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label9});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Flex = 1;
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 41);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 0);
            this.label9.Text = "地点";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label10});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Flex = 1;
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(0, 41);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 0);
            this.label10.Text = "部门";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel15.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label12});
            this.panel15.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel15.Flex = 1;
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(0, 30);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 0);
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel16.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label13});
            this.panel16.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel16.Flex = 1;
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(0, 30);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 0);
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel17.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label14});
            this.panel17.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel17.Flex = 1;
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(0, 30);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 0);
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel18.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label15});
            this.panel18.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel18.Flex = 1;
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(0, 30);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 0);
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel19.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label16});
            this.panel19.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel19.Flex = 1;
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(0, 30);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 0);
            this.label16.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel20.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label17});
            this.panel20.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel20.Flex = 1;
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(0, 30);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 0);
            this.label17.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnEdit,
            this.btnLog,
            this.btnChange,
            this.btnDelete});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.Flex = 1;
            this.btnEdit.Margin = new Swebui.Controls.Margin(5F, 7F, 5F, 7F);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NumberOfLines = 0;
            this.btnEdit.Size = new System.Drawing.Size(100, 0);
            this.btnEdit.Text = "修改资产";
            // 
            // btnLog
            // 
            this.btnLog.BorderRadius = 8;
            this.btnLog.Flex = 1;
            this.btnLog.Margin = new Swebui.Controls.Margin(5F, 7F, 5F, 7F);
            this.btnLog.Name = "btnLog";
            this.btnLog.NumberOfLines = 0;
            this.btnLog.Size = new System.Drawing.Size(100, 0);
            this.btnLog.Text = "处理记录";
            // 
            // btnChange
            // 
            this.btnChange.BorderRadius = 8;
            this.btnChange.Flex = 1;
            this.btnChange.Margin = new Swebui.Controls.Margin(5F, 7F, 5F, 7F);
            this.btnChange.Name = "btnChange";
            this.btnChange.NumberOfLines = 0;
            this.btnChange.Size = new System.Drawing.Size(100, 0);
            this.btnChange.Text = "使用者变更";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.Flex = 1;
            this.btnDelete.Margin = new Swebui.Controls.Margin(5F, 7F, 5F, 7F);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NumberOfLines = 0;
            this.btnDelete.Size = new System.Drawing.Size(100, 0);
            this.btnDelete.Text = "资产删除";
            // 
            // frmAssetsDetail
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});

        }
        #endregion

        private Panel panel1;
        private Label Title1;
        private Panel panel2;
        private Panel panel4;
        internal Label label1;
        internal TextBox txtAssId1;
        private Panel panel5;
        internal Label label2;
        internal TextBox txtName1;
        private Panel panel6;
        internal Label label3;
        internal Label label11;
        internal Panel panel14;
        internal Image image1;
        private Panel panel7;
        internal Label label4;
        internal TextBox txtSN1;
        private Panel panel8;
        internal Label label5;
        private Panel panel9;
        internal Label label6;
        private Panel panel10;
        internal Label label7;
        private Panel panel11;
        internal Label label8;
        private Panel panel12;
        internal Label label9;
        private Panel panel13;
        internal Label label10;
        private Panel panel15;
        internal Label label12;
        private Panel panel16;
        internal Label label13;
        private Panel panel17;
        internal Label label14;
        private Panel panel18;
        internal Label label15;
        private Panel panel19;
        internal Label label16;
        private Panel panel20;
        internal Label label17;
        private Panel panel3;
        internal Button btnEdit;
        internal Button btnLog;
        internal Button btnChange;
        internal Button btnDelete;
        private TextBox txtType;
        private TextBox txtLocation1;
        internal TextBox txtPrice1;
    }
}