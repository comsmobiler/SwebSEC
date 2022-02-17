using Swebui.Controls;
using System;

namespace SwebSECUI.Department
{
    partial class frmDepPerMessage : Swebui.Controls.SwebUserControl
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
            this.MenuTitle = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.treeView1 = new Swebui.Controls.TreeView();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.imgUser = new Swebui.Controls.Image();
            this.lblName = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.lblSex = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.lblAddress = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.dpkBirthday = new Swebui.Controls.DatePicker();
            this.panel9 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.lblLocation = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel11 = new Swebui.Controls.Panel();
            this.label11 = new Swebui.Controls.Label();
            this.lblID = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.label13 = new Swebui.Controls.Label();
            this.lblPhone = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.label15 = new Swebui.Controls.Label();
            this.lblEmail = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.MenuTitle});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // MenuTitle
            // 
            this.MenuTitle.BackColor = System.Drawing.Color.White;
            this.MenuTitle.Bold = true;
            this.MenuTitle.Flex = 1;
            this.MenuTitle.FontSize = 18F;
            this.MenuTitle.Margin = new Swebui.Controls.Margin(10F);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(0, 35);
            this.MenuTitle.Text = "部门成员详细信息";
            this.MenuTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 10F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 45);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Border = new Swebui.Controls.Border(1F);
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
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
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeView1,
            this.panel4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // treeView1
            // 
            this.treeView1.Border = new Swebui.Controls.Border(0F, 0F, 1F, 0F);
            this.treeView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.treeView1.DefaultValue = new string[0];
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(137)))), ((int)(((byte)(248)))));
            this.treeView1.Size = new System.Drawing.Size(240, 0);
            this.treeView1.Press += new Swebui.Controls.TreeView.TreeViewOnPressEventHandler(this.treeView1_Press);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10,
            this.panel11,
            this.panel12,
            this.panel13});
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgUser,
            this.lblName});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 45);
            // 
            // imgUser
            // 
            this.imgUser.Name = "imgUser";
            this.imgUser.ResourceID = "";
            this.imgUser.Size = new System.Drawing.Size(45, 45);
            this.imgUser.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.imgUser.Zooming = true;
            // 
            // lblName
            // 
            this.lblName.Flex = 1;
            this.lblName.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 0);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.lblSex});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 45);
            // 
            // label1
            // 
            this.label1.Flex = 3;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.Text = "性别";
            // 
            // lblSex
            // 
            this.lblSex.Flex = 7;
            this.lblSex.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(100, 0);
            this.lblSex.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.lblAddress});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 45);
            // 
            // label3
            // 
            this.label3.Flex = 3;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "地址";
            // 
            // lblAddress
            // 
            this.lblAddress.Flex = 7;
            this.lblAddress.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 0);
            this.lblAddress.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.dpkBirthday});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 45);
            // 
            // label5
            // 
            this.label5.Flex = 3;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 0);
            this.label5.Text = "出生日期";
            // 
            // dpkBirthday
            // 
            this.dpkBirthday.Enable = false;
            this.dpkBirthday.Flex = 7;
            this.dpkBirthday.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.dpkBirthday.Name = "dpkBirthday";
            this.dpkBirthday.Size = new System.Drawing.Size(100, 0);
            this.dpkBirthday.Value = new System.DateTime(2022, 2, 11, 16, 41, 59, 568);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.lblLocation});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 45);
            // 
            // label7
            // 
            this.label7.Flex = 3;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "所属区域";
            // 
            // lblLocation
            // 
            this.lblLocation.Flex = 7;
            this.lblLocation.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(100, 0);
            this.lblLocation.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label9,
            this.label10});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 45);
            // 
            // label9
            // 
            this.label9.Flex = 3;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "基本信息";
            // 
            // label10
            // 
            this.label10.Flex = 7;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label11,
            this.lblID});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 45);
            // 
            // label11
            // 
            this.label11.Flex = 3;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.Text = "账号";
            // 
            // lblID
            // 
            this.lblID.Flex = 7;
            this.lblID.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 0);
            this.lblID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label13,
            this.lblPhone});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 45);
            // 
            // label13
            // 
            this.label13.Flex = 3;
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 0);
            this.label13.Text = "电话";
            // 
            // lblPhone
            // 
            this.lblPhone.Flex = 7;
            this.lblPhone.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 0);
            this.lblPhone.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label15,
            this.lblEmail});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(0, 45);
            // 
            // label15
            // 
            this.label15.Flex = 3;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 0);
            this.label15.Text = "邮箱";
            // 
            // lblEmail
            // 
            this.lblEmail.Flex = 7;
            this.lblEmail.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 0);
            this.lblEmail.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmDepPerMessage
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.frmDepPerMessage_Load);

        }
        #endregion

        private Panel panel1;
        private Label MenuTitle;
        private Panel panel2;
        internal Button BackBtn;
        private Panel panel3;
        private TreeView treeView1;
        private Panel panel4;
        private Panel panel5;
        private Image imgUser;
        internal Label lblName;
        private Panel panel6;
        private Label label1;
        private Label lblSex;
        private Panel panel7;
        private Label label3;
        private Label lblAddress;
        private Panel panel8;
        private Label label5;
        internal DatePicker dpkBirthday;
        private Panel panel9;
        private Label label7;
        private Label lblLocation;
        private Panel panel10;
        private Label label9;
        private Label label10;
        private Panel panel11;
        private Label label11;
        private Label lblID;
        private Panel panel12;
        private Label label13;
        private Label lblPhone;
        private Panel panel13;
        private Label label15;
        private Label lblEmail;
    }
}