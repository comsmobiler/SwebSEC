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
            this.panel14 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.imgUser = new Swebui.Controls.Image();
            this.panel5 = new Swebui.Controls.Panel();
            this.lab = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.lblName = new Swebui.Controls.Label();
            this.lblSex = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.label1 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.lblAddress = new Swebui.Controls.Label();
            this.dpkBirthday = new Swebui.Controls.DatePicker();
            this.panel9 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.panel15 = new Swebui.Controls.Panel();
            this.lblLocation = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel11 = new Swebui.Controls.Panel();
            this.label11 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.lblID = new Swebui.Controls.Label();
            this.lblPhone = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.label15 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.lblEmail = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
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
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
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
            this.BackBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.NumberOfLines = 0;
            this.BackBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.BackBtn.Size = new System.Drawing.Size(0, 26);
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
            this.panel14,
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel15,
            this.panel10,
            this.panel11,
            this.panel12,
            this.panel13,
            this.panel16});
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 0);
            this.panel4.Visible = false;
            // 
            // panel14
            // 
            this.panel14.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.imgUser});
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(0, 120);
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.Text = "头像";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // imgUser
            // 
            this.imgUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.imgUser.BorderRadius = 80;
            this.imgUser.Margin = new Swebui.Controls.Margin(0F, 5F, 0F, 5F);
            this.imgUser.Name = "imgUser";
            this.imgUser.ResourceID = "";
            this.imgUser.Size = new System.Drawing.Size(80, 80);
            this.imgUser.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            this.imgUser.SourceHotReadload = true;
            this.imgUser.Zooming = true;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lab,
            this.label4});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // lab
            // 
            this.lab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lab.Flex = 1;
            this.lab.ForeColor = System.Drawing.Color.Silver;
            this.lab.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(0, 30);
            this.lab.Text = "昵称";
            this.lab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.Text = "性别";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblName,
            this.lblSex});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // lblName
            // 
            this.lblName.Flex = 1;
            this.lblName.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 0);
            // 
            // lblSex
            // 
            this.lblSex.Flex = 1;
            this.lblSex.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(100, 0);
            this.lblSex.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.label1});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 30);
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "地址";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.Text = "出生日期";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblAddress,
            this.dpkBirthday});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // lblAddress
            // 
            this.lblAddress.Flex = 1;
            this.lblAddress.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 0);
            this.lblAddress.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // dpkBirthday
            // 
            this.dpkBirthday.Enable = false;
            this.dpkBirthday.Flex = 1;
            this.dpkBirthday.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.dpkBirthday.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.dpkBirthday.Name = "dpkBirthday";
            this.dpkBirthday.Size = new System.Drawing.Size(100, 0);
            this.dpkBirthday.Value = new System.DateTime(2022, 2, 14, 10, 20, 42, 345);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.label5});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "所属区域";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 0);
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel15
            // 
            this.panel15.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblLocation,
            this.label6});
            this.panel15.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(0, 35);
            // 
            // lblLocation
            // 
            this.lblLocation.Flex = 1;
            this.lblLocation.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(100, 0);
            this.lblLocation.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Border = new Swebui.Controls.Border(1F);
            this.panel10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label9,
            this.label10});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 35);
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "基本信息";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label11,
            this.label8});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 30);
            // 
            // label11
            // 
            this.label11.Flex = 1;
            this.label11.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.Text = "账号";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 0);
            this.label8.Text = "电话";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblID,
            this.lblPhone});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 35);
            // 
            // lblID
            // 
            this.lblID.Flex = 1;
            this.lblID.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 0);
            this.lblID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblPhone
            // 
            this.lblPhone.Flex = 1;
            this.lblPhone.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 0);
            this.lblPhone.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label15,
            this.label12});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(0, 30);
            // 
            // label15
            // 
            this.label15.Flex = 1;
            this.label15.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 0);
            this.label15.Text = "邮箱";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 0);
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel16
            // 
            this.panel16.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblEmail,
            this.label13});
            this.panel16.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(0, 35);
            // 
            // lblEmail
            // 
            this.lblEmail.Flex = 1;
            this.lblEmail.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 0);
            this.lblEmail.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 0);
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
        private Panel panel6;
        private Label lblSex;
        private Panel panel7;
        private Label label3;
        private Panel panel8;
        private Panel panel9;
        private Label label7;
        private Panel panel10;
        private Label label9;
        private Label label10;
        private Panel panel11;
        private Label label11;
        private Panel panel12;
        private Label lblPhone;
        private Panel panel13;
        private Label label15;
        private DatePicker dpkBirthday;
        private Panel panel14;
        private Image imgUser;
        private Label label2;
        private Panel panel5;
        private Label lab;
        private Label label4;
        internal Label lblName;
        private Label label1;
        private Label lblAddress;
        private Panel panel15;
        private Label label5;
        private Label lblLocation;
        private Label label6;
        private Label label8;
        private Label lblID;
        private Label label12;
        private Panel panel16;
        private Label lblEmail;
        private Label label13;
    }
}