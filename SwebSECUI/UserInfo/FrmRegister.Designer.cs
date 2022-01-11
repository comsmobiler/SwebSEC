using Swebui;
using System;

namespace SwebSECUI.UserInfo
{
    partial class FrmRegister : Swebui.Controls.SwebForm
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
            this.panel1 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.txtTel = new Swebui.Controls.TextBox();
            this.panel4 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.panel5 = new Swebui.Controls.Panel();
            this.panel6 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.txtName = new Swebui.Controls.TextBox();
            this.panel7 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.txtPwd1 = new Swebui.Controls.TextBox();
            this.tpPwd1 = new Swebui.Controls.Panel();
            this.fontPwd1 = new Swebui.Controls.FontIcon();
            this.panel8 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.txtPwd2 = new Swebui.Controls.TextBox();
            this.tpPwd2 = new Swebui.Controls.Panel();
            this.fontPwd2 = new Swebui.Controls.FontIcon();
            this.panel9 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.comboBox1 = new Swebui.Controls.ComboBox();
            this.btnSave = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5});
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 615);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Margin = new Swebui.Controls.Margin(20F, 0F, 20F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 60);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.Flex = 1;
            this.label1.FontSize = 20F;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.Text = "用户注册";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtTel});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(0F, 30F, 0F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 40);
            // 
            // txtTel
            // 
            this.txtTel.BorderRadius = 8;
            this.txtTel.Flex = 1;
            this.txtTel.FontSize = 15F;
            this.txtTel.Margin = new Swebui.Controls.Margin(50F, 0F, 50F, 0F);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(500, 0);
            this.txtTel.WaterMarkText = "手机号码";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 30F, 0F, 100F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 40);
            // 
            // button1
            // 
            this.button1.Flex = 1;
            this.button1.FontSize = 15F;
            this.button1.Margin = new Swebui.Controls.Margin(200F, 0F, 200F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.Text = "注册";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel6,
            this.panel7,
            this.panel8,
            this.panel9,
            this.btnSave});
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 80);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.txtName});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 50);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 0);
            this.label2.Text = "昵称";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.txtPwd1,
            this.tpPwd1});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 50);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 0);
            this.label3.Text = "新密码";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.txtPwd2,
            this.tpPwd2});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 50);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 0);
            this.label4.Text = "确认密码";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
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
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.comboBox1});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 50);
            // 
            // label5
            // 
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.Flex = 1;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Placeholder = "";
            this.comboBox1.PopupHeight = 0;
            this.comboBox1.Size = new System.Drawing.Size(100, 0);
            this.comboBox1.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.NumberOfLines = 0;
            this.btnSave.Size = new System.Drawing.Size(0, 35);
            this.btnSave.Text = "开始使用";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmRegister
            // 
            this.BackgroundImage = "bg.png";
            this.BackgroundImageSizeMode = Swebui.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;

        }
        #endregion

        private Swebui.Controls.Panel panel1;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.Label label1;
        private Swebui.Controls.Panel panel3;
        private Swebui.Controls.TextBox txtTel;
        private Swebui.Controls.Panel panel4;
        private Swebui.Controls.Panel panel5;
        private Swebui.Controls.Button button1;
        private Swebui.Controls.Panel panel6;
        private Swebui.Controls.Label label2;
        private Swebui.Controls.TextBox txtName;
        private Swebui.Controls.Panel panel7;
        private Swebui.Controls.Label label3;
        private Swebui.Controls.TextBox txtPwd1;
        private Swebui.Controls.Panel tpPwd1;
        private Swebui.Controls.FontIcon fontPwd1;
        private Swebui.Controls.Panel panel8;
        private Swebui.Controls.Label label4;
        private Swebui.Controls.TextBox txtPwd2;
        private Swebui.Controls.Panel tpPwd2;
        private Swebui.Controls.FontIcon fontPwd2;
        private Swebui.Controls.Panel panel9;
        private Swebui.Controls.Label label5;
        private Swebui.Controls.ComboBox comboBox1;
        private Swebui.Controls.Button btnSave;
    }
}