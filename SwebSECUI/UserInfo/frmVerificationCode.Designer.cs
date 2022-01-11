using Swebui;
using System;

namespace SwebSECUI.UserInfo
{
    partial class frmVerificationCode : Swebui.Controls.SwebForm
    {
        #region "SwebForm generated code "

        //SwebForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SwebForm
        //It can be modified using the SwebForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Swebui.Controls.ComboBoxItem comboBoxItem1 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem2 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem3 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem4 = new Swebui.Controls.ComboBoxItem();
            Swebui.Controls.ComboBoxItem comboBoxItem5 = new Swebui.Controls.ComboBoxItem();
            this.panel1 = new Swebui.Controls.Panel();
            this.Title1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.txtName = new Swebui.Controls.TextBox();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.txtPwd1 = new Swebui.Controls.TextBox();
            this.tpPwd1 = new Swebui.Controls.Panel();
            this.fontPwd1 = new Swebui.Controls.FontIcon();
            this.panel4 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.txtPwd2 = new Swebui.Controls.TextBox();
            this.tpPwd2 = new Swebui.Controls.Panel();
            this.fontPwd2 = new Swebui.Controls.FontIcon();
            this.label4 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.comboBox1 = new Swebui.Controls.ComboBox();
            this.panel7 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.btnLocation = new Swebui.Controls.ComboBox();
            this.btnSave = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Title1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 60);
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
            this.Title1.Text = "设置登录信息";
            this.Title1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.txtName});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 50);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 0);
            this.label1.Text = "昵称";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Flex = 1;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 0);
            this.txtName.WaterMarkText = "请输入昵称";
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.txtPwd1,
            this.tpPwd1});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 50);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 0);
            this.label2.Text = "新密码";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPwd1
            // 
            this.txtPwd1.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd1.Flex = 1;
            this.txtPwd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtPwd1.MaxLength = 12;
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.SecurityMode = true;
            this.txtPwd1.Size = new System.Drawing.Size(100, 0);
            this.txtPwd1.WaterMarkText = "请输入6-12位密码";
            // 
            // tpPwd1
            // 
            this.tpPwd1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontPwd1});
            this.tpPwd1.Name = "tpPwd1";
            this.tpPwd1.Size = new System.Drawing.Size(50, 0);
            this.tpPwd1.Press += new System.EventHandler(this.tpPwd1_Press);
            // 
            // fontPwd1
            // 
            this.fontPwd1.Flex = 1;
            this.fontPwd1.Name = "fontPwd1";
            this.fontPwd1.Padding = new Swebui.Controls.Padding(5F);
            this.fontPwd1.ResourceID = "eye-slash";
            this.fontPwd1.Size = new System.Drawing.Size(0, 30);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.txtPwd2,
            this.tpPwd2});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 50);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 0);
            this.label3.Text = "确认密码";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPwd2
            // 
            this.txtPwd2.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd2.Flex = 1;
            this.txtPwd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtPwd2.MaxLength = 12;
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.SecurityMode = true;
            this.txtPwd2.Size = new System.Drawing.Size(100, 0);
            this.txtPwd2.WaterMarkText = "请输入6-12位密码";
            // 
            // tpPwd2
            // 
            this.tpPwd2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontPwd2});
            this.tpPwd2.Name = "tpPwd2";
            this.tpPwd2.Size = new System.Drawing.Size(50, 0);
            this.tpPwd2.Press += new System.EventHandler(this.tpPwd2_Press);
            // 
            // fontPwd2
            // 
            this.fontPwd2.Flex = 1;
            this.fontPwd2.Name = "fontPwd2";
            this.fontPwd2.Padding = new Swebui.Controls.Padding(5F);
            this.fontPwd2.ResourceID = "eye-slash";
            this.fontPwd2.Size = new System.Drawing.Size(0, 30);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 40);
            this.label4.Text = "角色选择";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.comboBox1});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 50);
            // 
            // comboBox1
            // 
            this.comboBox1.Flex = 1;
            comboBoxItem1.Id = "管理员";
            comboBoxItem1.Text = "ADMIN";
            comboBoxItem2.Id = "用户";
            comboBoxItem2.Text = "SMOSECUser";
            this.comboBox1.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem1,
            comboBoxItem2});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Placeholder = "";
            this.comboBox1.PopupHeight = 0;
            this.comboBox1.Size = new System.Drawing.Size(100, 0);
            this.comboBox1.Text = "";
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.btnLocation});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 50);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 0);
            this.label7.Text = "所属区域";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // btnLocation
            // 
            this.btnLocation.Flex = 1;
            comboBoxItem3.Id = "0";
            comboBoxItem3.Text = "上海";
            comboBoxItem4.Id = "1";
            comboBoxItem4.Text = "嘉兴";
            comboBoxItem5.Id = "2";
            comboBoxItem5.Text = "郑州";
            this.btnLocation.Items.AddRange(new Swebui.Controls.ComboBoxItem[] {
            comboBoxItem3,
            comboBoxItem4,
            comboBoxItem5});
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Placeholder = "";
            this.btnLocation.PopupHeight = 0;
            this.btnLocation.Size = new System.Drawing.Size(100, 0);
            this.btnLocation.Text = "";
            this.btnLocation.ValueChanged += new System.EventHandler(this.btnLocation_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.btnSave.Name = "btnSave";
            this.btnSave.NumberOfLines = 0;
            this.btnSave.Size = new System.Drawing.Size(0, 35);
            this.btnSave.Text = "开始使用";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmVerificationCode
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.label4,
            this.panel5,
            this.panel7,
            this.btnSave});
            this.Load += new System.EventHandler(this.frmVerificationCode_Load);

        }
        #endregion

        private Swebui.Controls.Panel panel1;
        private Swebui.Controls.Label Title1;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.Label label1;
        private Swebui.Controls.TextBox txtName;
        private Swebui.Controls.Panel panel3;
        private Swebui.Controls.Label label2;
        private Swebui.Controls.TextBox txtPwd1;
        private Swebui.Controls.Panel tpPwd1;
        private Swebui.Controls.FontIcon fontPwd1;
        private Swebui.Controls.Panel panel4;
        private Swebui.Controls.Label label3;
        private Swebui.Controls.TextBox txtPwd2;
        private Swebui.Controls.Panel tpPwd2;
        private Swebui.Controls.FontIcon fontPwd2;
        private Swebui.Controls.Label label4;
        private Swebui.Controls.Panel panel5;
        private Swebui.Controls.Panel panel7;
        private Swebui.Controls.Label label7;
        private Swebui.Controls.ComboBox btnLocation;
        private Swebui.Controls.Button btnSave;
        private Swebui.Controls.ComboBox comboBox1;
    }
}