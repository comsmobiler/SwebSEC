using Swebui;
using System;

namespace SwebSECUI
{
    partial class FrmLogon : Swebui.Controls.SwebForm
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
            this.image1 = new Swebui.Controls.Image();
            this.panel2 = new Swebui.Controls.Panel();
            this.image2 = new Swebui.Controls.Image();
            this.psdPanel = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.txtUserName = new Swebui.Controls.TextBox();
            this.panel6 = new Swebui.Controls.Panel();
            this.fontIcon2 = new Swebui.Controls.FontIcon();
            this.txtPassWord = new Swebui.Controls.TextBox();
            this.btnLogon = new Swebui.Controls.Button();
            this.panel7 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            this.fastLoginPanel = new Swebui.Controls.Panel();
            this.panel8 = new Swebui.Controls.Panel();
            this.fontIcon3 = new Swebui.Controls.FontIcon();
            this.textBox1 = new Swebui.Controls.TextBox();
            this.button3 = new Swebui.Controls.Button();
            this.label1 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.fontIcon4 = new Swebui.Controls.FontIcon();
            this.textBox2 = new Swebui.Controls.TextBox();
            this.button4 = new Swebui.Controls.Button();
            this.button5 = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.panel2});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Size = new System.Drawing.Size(600, 400);
            // 
            // image1
            // 
            this.image1.Name = "image1";
            this.image1.ResourceID = "2018.jpg";
            this.image1.Size = new System.Drawing.Size(300, 0);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image2,
            this.psdPanel,
            this.fastLoginPanel});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // image2
            // 
            this.image2.BorderRadius = 2;
            this.image2.Margin = new Swebui.Controls.Margin(0F, 40F, 0F, 0F);
            this.image2.Name = "image2";
            this.image2.ResourceID = "smosec";
            this.image2.Size = new System.Drawing.Size(0, 80);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // psdPanel
            // 
            this.psdPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel5,
            this.panel6,
            this.btnLogon,
            this.panel7});
            this.psdPanel.Flex = 1;
            this.psdPanel.Name = "psdPanel";
            this.psdPanel.Size = new System.Drawing.Size(0, 100);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.BorderColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.txtUserName});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.Margin = new Swebui.Controls.Margin(20F);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // fontIcon1
            // 
            this.fontIcon1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "user";
            this.fontIcon1.Size = new System.Drawing.Size(15, 15);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.txtUserName.BorderColor = System.Drawing.Color.White;
            this.txtUserName.Flex = 1;
            this.txtUserName.FontSize = 15F;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtUserName.Size = new System.Drawing.Size(100, 30);
            this.txtUserName.WaterMarkText = "账号";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.BorderColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon2,
            this.txtPassWord});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel6.Margin = new Swebui.Controls.Margin(20F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 30);
            // 
            // fontIcon2
            // 
            this.fontIcon2.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "unlock-alt";
            this.fontIcon2.Size = new System.Drawing.Size(15, 15);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.Transparent;
            this.txtPassWord.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.txtPassWord.BorderColor = System.Drawing.Color.White;
            this.txtPassWord.Flex = 1;
            this.txtPassWord.FontSize = 15F;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtPassWord.SecurityMode = true;
            this.txtPassWord.Size = new System.Drawing.Size(100, 30);
            this.txtPassWord.WaterMarkText = "密码";
            // 
            // btnLogon
            // 
            this.btnLogon.Margin = new Swebui.Controls.Margin(20F, 30F, 20F, 0F);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.NumberOfLines = 0;
            this.btnLogon.Size = new System.Drawing.Size(0, 35);
            this.btnLogon.Text = "登陆";
            this.btnLogon.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.button2});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.SpaceBetween;
            this.panel7.Margin = new Swebui.Controls.Margin(20F, 20F, 20F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 38);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button1.Size = new System.Drawing.Size(100, 0);
            this.button1.Text = "立即注册";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button2.Size = new System.Drawing.Size(100, 0);
            this.button2.Text = "忘记密码";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fastLoginPanel
            // 
            this.fastLoginPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel8,
            this.label1,
            this.panel9,
            this.button4,
            this.button5});
            this.fastLoginPanel.Flex = 1;
            this.fastLoginPanel.Name = "fastLoginPanel";
            this.fastLoginPanel.Size = new System.Drawing.Size(0, 100);
            this.fastLoginPanel.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Border = new Swebui.Controls.Border(1F);
            this.panel8.BorderColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon3,
            this.textBox1,
            this.button3});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel8.Margin = new Swebui.Controls.Margin(20F, 20F, 20F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // fontIcon3
            // 
            this.fontIcon3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon3.Name = "fontIcon3";
            this.fontIcon3.ResourceID = "phone";
            this.fontIcon3.Size = new System.Drawing.Size(15, 15);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.textBox1.BorderColor = System.Drawing.Color.White;
            this.textBox1.Flex = 1;
            this.textBox1.FontSize = 15F;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.WaterMarkText = "电话";
            // 
            // button3
            // 
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.Padding = new Swebui.Controls.Padding(5F, 0F, 5F, 0F);
            this.button3.Size = new System.Drawing.Size(0, 35);
            this.button3.Text = "获取验证码";
            // 
            // label1
            // 
            this.label1.Margin = new Swebui.Controls.Margin(20F, 0F, 20F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.BorderColor = System.Drawing.Color.LightGray;
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon4,
            this.textBox2});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel9.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel9.Margin = new Swebui.Controls.Margin(20F, 0F, 20F, 0F);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // fontIcon4
            // 
            this.fontIcon4.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.fontIcon4.Name = "fontIcon4";
            this.fontIcon4.ResourceID = "unlock-alt";
            this.fontIcon4.Size = new System.Drawing.Size(15, 15);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Transparent;
            this.textBox2.Border = new Swebui.Controls.Border(1F, 0F, 0F, 0F);
            this.textBox2.BorderColor = System.Drawing.Color.White;
            this.textBox2.Flex = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.WaterMarkText = "验证码";
            // 
            // button4
            // 
            this.button4.Margin = new Swebui.Controls.Margin(20F, 30F, 20F, 0F);
            this.button4.Name = "button4";
            this.button4.NumberOfLines = 0;
            this.button4.Size = new System.Drawing.Size(0, 35);
            this.button4.Text = "登录";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Margin = new Swebui.Controls.Margin(20F, 30F, 20F, 0F);
            this.button5.Name = "button5";
            this.button5.NumberOfLines = 0;
            this.button5.Size = new System.Drawing.Size(0, 35);
            this.button5.Text = "<<返回";
            // 
            // FrmLogon
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
        private Swebui.Controls.Image image1;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.Image image2;
        private Swebui.Controls.Panel psdPanel;
        private Swebui.Controls.Panel panel5;
        private Swebui.Controls.FontIcon fontIcon1;
        private Swebui.Controls.TextBox txtUserName;
        private Swebui.Controls.Panel panel6;
        private Swebui.Controls.FontIcon fontIcon2;
        private Swebui.Controls.TextBox txtPassWord;
        private Swebui.Controls.Button btnLogon;
        private Swebui.Controls.Panel panel7;
        private Swebui.Controls.Button button2;
        private Swebui.Controls.Button button1;
        private Swebui.Controls.Panel fastLoginPanel;
        private Swebui.Controls.Panel panel8;
        private Swebui.Controls.FontIcon fontIcon3;
        private Swebui.Controls.TextBox textBox1;
        private Swebui.Controls.Button button3;
        private Swebui.Controls.Label label1;
        private Swebui.Controls.Panel panel9;
        private Swebui.Controls.FontIcon fontIcon4;
        private Swebui.Controls.TextBox textBox2;
        private Swebui.Controls.Button button4;
        private Swebui.Controls.Button button5;
    }
}