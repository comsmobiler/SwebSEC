using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmAssetsTypeCreateLayout : Swebui.Controls.SwebUserControl
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
            this.SaveBtn = new Swebui.Controls.Button();
            this.CancelBtn = new Swebui.Controls.Button();
            this.panel12 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.plFID = new Swebui.Controls.Panel();
            this.txtFID = new Swebui.Controls.TextBox();
            this.label1 = new Swebui.Controls.Label();
            this.plFName = new Swebui.Controls.Panel();
            this.txtFName = new Swebui.Controls.TextBox();
            this.label2 = new Swebui.Controls.Label();
            this.plFDate = new Swebui.Controls.Panel();
            this.txtFDate = new Swebui.Controls.TextBox();
            this.label3 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtID = new Swebui.Controls.TextBox();
            this.label13 = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.TextBox();
            this.label14 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.txtDate = new Swebui.Controls.TextBox();
            this.label15 = new Swebui.Controls.Label();
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
            this.MenuTitle.FontSize = 16F;
            this.MenuTitle.Margin = new Swebui.Controls.Margin(10F);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(0, 35);
            this.MenuTitle.Text = "资产类别";
            this.MenuTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.SaveBtn,
            this.CancelBtn});
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
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.Border = new Swebui.Controls.Border(1F);
            this.SaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.SaveBtn.BorderRadius = 5;
            this.SaveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SaveBtn.IconName = "fa fa-floppy-o";
            this.SaveBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.NumberOfLines = 0;
            this.SaveBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.SaveBtn.Size = new System.Drawing.Size(80, 35);
            this.SaveBtn.Text = "提交";
            this.SaveBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.White;
            this.CancelBtn.Border = new Swebui.Controls.Border(1F);
            this.CancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.CancelBtn.BorderRadius = 5;
            this.CancelBtn.ForeColor = System.Drawing.Color.DimGray;
            this.CancelBtn.IconName = "fa fa-floppy-o";
            this.CancelBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.NumberOfLines = 0;
            this.CancelBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.CancelBtn.Size = new System.Drawing.Size(80, 35);
            this.CancelBtn.Text = "取消";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
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
            this.label5.Text = "父类编码";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "父类名称";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.Text = "父年限(月)";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.plFID,
            this.plFName,
            this.plFDate});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel13.Name = "panel13";
            this.panel13.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel13.Size = new System.Drawing.Size(0, 35);
            // 
            // plFID
            // 
            this.plFID.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtFID,
            this.label1});
            this.plFID.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plFID.Flex = 1;
            this.plFID.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.plFID.Name = "plFID";
            this.plFID.Size = new System.Drawing.Size(300, 0);
            // 
            // txtFID
            // 
            this.txtFID.Border = new Swebui.Controls.Border(1F);
            this.txtFID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtFID.BorderRadius = 4;
            this.txtFID.Flex = 1;
            this.txtFID.Name = "txtFID";
            this.txtFID.ReadOnly = true;
            this.txtFID.Size = new System.Drawing.Size(100, 0);
            this.txtFID.WaterMarkText = "父类编码";
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            // 
            // plFName
            // 
            this.plFName.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtFName,
            this.label2});
            this.plFName.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plFName.Flex = 1;
            this.plFName.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.plFName.Name = "plFName";
            this.plFName.Size = new System.Drawing.Size(300, 0);
            // 
            // txtFName
            // 
            this.txtFName.Border = new Swebui.Controls.Border(1F);
            this.txtFName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtFName.BorderRadius = 4;
            this.txtFName.Flex = 1;
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(100, 0);
            this.txtFName.WaterMarkText = "父类名称";
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            // 
            // plFDate
            // 
            this.plFDate.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtFDate,
            this.label3});
            this.plFDate.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plFDate.Flex = 1;
            this.plFDate.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.plFDate.Name = "plFDate";
            this.plFDate.Size = new System.Drawing.Size(300, 0);
            // 
            // txtFDate
            // 
            this.txtFDate.Border = new Swebui.Controls.Border(1F);
            this.txtFDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtFDate.BorderRadius = 4;
            this.txtFDate.Flex = 1;
            this.txtFDate.Name = "txtFDate";
            this.txtFDate.ReadOnly = true;
            this.txtFDate.Size = new System.Drawing.Size(100, 0);
            this.txtFDate.WaterMarkText = "父年限(月)";
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.panel5,
            this.panel6});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label6});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 0);
            // 
            // label4
            // 
            this.label4.Flex = 2;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            this.label4.Text = "*";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 8;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.Text = "类别编码";
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.label8});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 0);
            // 
            // label7
            // 
            this.label7.Flex = 2;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.Flex = 8;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 0);
            this.label8.Text = "类别名称";
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label11,
            this.label12});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 0);
            // 
            // label11
            // 
            this.label11.Flex = 2;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.Flex = 8;
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 0);
            this.label12.Text = "年限(月)";
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel8,
            this.panel9,
            this.panel10});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel7.Size = new System.Drawing.Size(0, 35);
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtID,
            this.label13});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Flex = 1;
            this.panel8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 0);
            // 
            // txtID
            // 
            this.txtID.Border = new Swebui.Controls.Border(1F);
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtID.BorderRadius = 4;
            this.txtID.Flex = 1;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 0);
            this.txtID.WaterMarkText = "类别编码";
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 0);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.label14});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Flex = 1;
            this.panel9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 0);
            // 
            // txtName
            // 
            this.txtName.Border = new Swebui.Controls.Border(1F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtName.BorderRadius = 4;
            this.txtName.Flex = 1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 0);
            this.txtName.WaterMarkText = "类别名称";
            // 
            // label14
            // 
            this.label14.Flex = 1;
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 0);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtDate,
            this.label15});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Flex = 1;
            this.panel10.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(300, 0);
            // 
            // txtDate
            // 
            this.txtDate.Border = new Swebui.Controls.Border(1F);
            this.txtDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtDate.BorderRadius = 4;
            this.txtDate.Flex = 1;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 0);
            this.txtDate.WaterMarkText = "年限(月)";
            // 
            // label15
            // 
            this.label15.Flex = 1;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 0);
            // 
            // frmAssetsTypeCreateLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel12,
            this.panel13,
            this.panel3,
            this.panel7});
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.frmAssetsTypeCreateLayout_Load);

        }
        #endregion

        private Panel panel1;
        private Label MenuTitle;
        private Panel panel2;
        internal Button BackBtn;
        internal Button SaveBtn;
        internal Button CancelBtn;
        private Panel panel12;
        private Panel panel13;
        internal Panel plFID;
        internal TextBox txtFID;
        internal Label label1;
        internal Panel plFName;
        internal TextBox txtFName;
        internal Label label2;
        internal Panel plFDate;
        internal TextBox txtFDate;
        internal Label label3;
        private Panel panel3;
        private Panel panel4;
        internal Label label4;
        internal Label label6;
        private Panel panel5;
        internal Label label7;
        internal Label label8;
        private Panel panel6;
        internal Label label11;
        internal Label label12;
        private Panel panel7;
        internal Panel panel8;
        internal TextBox txtID;
        internal Label label13;
        internal Panel panel9;
        internal TextBox txtName;
        internal Label label14;
        internal Panel panel10;
        internal TextBox txtDate;
        internal Label label15;
        internal Label label5;
        internal Label label9;
        internal Label label10;
    }
}