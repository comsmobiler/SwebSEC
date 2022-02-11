using Swebui.Controls;
using System;

namespace SwebSECUI.MasterData
{
    partial class frmAssetsTypeRows : Swebui.Controls.SwebUserControl
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
            this.AddBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.treeView1 = new Swebui.Controls.TreeView();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel6 = new Swebui.Controls.Panel();
            this.labTitle = new Swebui.Controls.Label();
            this.editBtn = new Swebui.Controls.Button();
            this.addTypeBtn = new Swebui.Controls.Button();
            this.Fpanel = new Swebui.Controls.Panel();
            this.panel7 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.txtID = new Swebui.Controls.Label();
            this.txtName = new Swebui.Controls.Label();
            this.panel9 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.panel10 = new Swebui.Controls.Panel();
            this.txtDate = new Swebui.Controls.Label();
            this.txtPlace = new Swebui.Controls.Label();
            this.panel11 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.switchIsEnable = new Swebui.Controls.Switch();
            this.SPanel = new Swebui.Controls.Panel();
            this.panel14 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.panel15 = new Swebui.Controls.Panel();
            this.txtFID = new Swebui.Controls.Label();
            this.txtFName = new Swebui.Controls.Label();
            this.panel16 = new Swebui.Controls.Panel();
            this.label12 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.panel17 = new Swebui.Controls.Panel();
            this.txtFDate = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            this.panel18 = new Swebui.Controls.Panel();
            this.label16 = new Swebui.Controls.Label();
            this.label17 = new Swebui.Controls.Label();
            this.panel19 = new Swebui.Controls.Panel();
            this.txtID1 = new Swebui.Controls.Label();
            this.txtName1 = new Swebui.Controls.Label();
            this.panel20 = new Swebui.Controls.Panel();
            this.label20 = new Swebui.Controls.Label();
            this.label21 = new Swebui.Controls.Label();
            this.panel21 = new Swebui.Controls.Panel();
            this.txtDate1 = new Swebui.Controls.Label();
            this.label23 = new Swebui.Controls.Label();
            this.panel22 = new Swebui.Controls.Panel();
            this.label24 = new Swebui.Controls.Label();
            this.label25 = new Swebui.Controls.Label();
            this.panel23 = new Swebui.Controls.Panel();
            this.switchIsEnable1 = new Swebui.Controls.Switch();
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
            this.MenuTitle.Text = "资产分类";
            this.MenuTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.AddBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.Border = new Swebui.Controls.Border(1F);
            this.AddBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.AddBtn.ForeColor = System.Drawing.Color.DimGray;
            this.AddBtn.IconName = "fa fa-plus";
            this.AddBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NumberOfLines = 0;
            this.AddBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.AddBtn.Size = new System.Drawing.Size(0, 26);
            this.AddBtn.Text = "新增";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeView1,
            this.panel4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
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
            this.panel6,
            this.Fpanel,
            this.SPanel});
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 0);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.labTitle,
            this.editBtn,
            this.addTypeBtn});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Name = "panel6";
            this.panel6.Padding = new Swebui.Controls.Padding(20F, 0F, 20F, 0F);
            this.panel6.Size = new System.Drawing.Size(0, 44);
            // 
            // labTitle
            // 
            this.labTitle.Flex = 1;
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(0, 0);
            this.labTitle.Text = "分类信息";
            this.labTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Border = new Swebui.Controls.Border(1F);
            this.editBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.editBtn.BorderRadius = 8;
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.editBtn.Margin = new Swebui.Controls.Margin(5F, 8F, 5F, 8F);
            this.editBtn.Name = "editBtn";
            this.editBtn.NumberOfLines = 0;
            this.editBtn.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.editBtn.Size = new System.Drawing.Size(0, 0);
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addTypeBtn
            // 
            this.addTypeBtn.BackColor = System.Drawing.Color.Transparent;
            this.addTypeBtn.Border = new Swebui.Controls.Border(1F);
            this.addTypeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addTypeBtn.BorderRadius = 8;
            this.addTypeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addTypeBtn.Margin = new Swebui.Controls.Margin(5F, 8F, 5F, 8F);
            this.addTypeBtn.Name = "addTypeBtn";
            this.addTypeBtn.NumberOfLines = 0;
            this.addTypeBtn.Padding = new Swebui.Controls.Padding(5F, 2F, 5F, 2F);
            this.addTypeBtn.Size = new System.Drawing.Size(0, 0);
            this.addTypeBtn.Text = "新增分类";
            this.addTypeBtn.Click += new System.EventHandler(this.addTypeBtn_Click);
            // 
            // Fpanel
            // 
            this.Fpanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel7,
            this.panel8,
            this.panel9,
            this.panel10,
            this.panel11,
            this.panel12});
            this.Fpanel.Flex = 1;
            this.Fpanel.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.Fpanel.Name = "Fpanel";
            this.Fpanel.Size = new System.Drawing.Size(0, 56);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.label5});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 30);
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "类别编码";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "类别名称";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtID,
            this.txtName});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 35);
            // 
            // txtID
            // 
            this.txtID.Flex = 1;
            this.txtID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 35);
            this.txtID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 35);
            this.txtName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label6});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "年限（月）";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtDate,
            this.txtPlace});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(0, 35);
            // 
            // txtDate
            // 
            this.txtDate.Flex = 1;
            this.txtDate.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 35);
            this.txtDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtPlace
            // 
            this.txtPlace.Flex = 1;
            this.txtPlace.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 35);
            this.txtPlace.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.label8});
            this.panel11.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(0, 30);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.Text = "是否启用";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.switchIsEnable});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(0, 35);
            // 
            // switchIsEnable
            // 
            this.switchIsEnable.BackColor = System.Drawing.Color.Transparent;
            this.switchIsEnable.BorderColor = System.Drawing.Color.Black;
            this.switchIsEnable.BorderRadius = 0;
            this.switchIsEnable.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.switchIsEnable.Name = "switchIsEnable";
            this.switchIsEnable.Size = new System.Drawing.Size(100, 35);
            this.switchIsEnable.CheckedChanged += new System.EventHandler(this.switchIsEnable_CheckedChanged);
            // 
            // SPanel
            // 
            this.SPanel.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel14,
            this.panel15,
            this.panel16,
            this.panel17,
            this.panel18,
            this.panel19,
            this.panel20,
            this.panel21,
            this.panel22,
            this.panel23});
            this.SPanel.Flex = 1;
            this.SPanel.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.SPanel.Name = "SPanel";
            this.SPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // panel14
            // 
            this.panel14.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label9});
            this.panel14.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(0, 30);
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "父类编码";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "父类名称";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel15
            // 
            this.panel15.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtFID,
            this.txtFName});
            this.panel15.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(0, 35);
            // 
            // txtFID
            // 
            this.txtFID.Flex = 1;
            this.txtFID.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtFID.Name = "txtFID";
            this.txtFID.Size = new System.Drawing.Size(100, 35);
            this.txtFID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtFName
            // 
            this.txtFName.Flex = 1;
            this.txtFName.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 35);
            this.txtFName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel16
            // 
            this.panel16.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label12,
            this.label13});
            this.panel16.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(0, 30);
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 30);
            this.label12.Text = "父年限（月）";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 30);
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel17
            // 
            this.panel17.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtFDate,
            this.label15});
            this.panel17.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(0, 35);
            // 
            // txtFDate
            // 
            this.txtFDate.Flex = 1;
            this.txtFDate.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtFDate.Name = "txtFDate";
            this.txtFDate.Size = new System.Drawing.Size(100, 35);
            this.txtFDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Flex = 1;
            this.label15.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 35);
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel18
            // 
            this.panel18.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label16,
            this.label17});
            this.panel18.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(0, 30);
            // 
            // label16
            // 
            this.label16.Flex = 1;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 30);
            this.label16.Text = "类别编码";
            this.label16.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Flex = 1;
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 30);
            this.label17.Text = "类别名称";
            this.label17.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel19
            // 
            this.panel19.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtID1,
            this.txtName1});
            this.panel19.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(0, 35);
            // 
            // txtID1
            // 
            this.txtID1.Flex = 1;
            this.txtID1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(100, 35);
            this.txtID1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtName1
            // 
            this.txtName1.Flex = 1;
            this.txtName1.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 35);
            this.txtName1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel20
            // 
            this.panel20.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label20,
            this.label21});
            this.panel20.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(0, 30);
            // 
            // label20
            // 
            this.label20.Flex = 1;
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 30);
            this.label20.Text = "年限（月）";
            this.label20.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Flex = 1;
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 30);
            this.label21.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel21
            // 
            this.panel21.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtDate1,
            this.label23});
            this.panel21.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(0, 35);
            // 
            // txtDate1
            // 
            this.txtDate1.Flex = 1;
            this.txtDate1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(100, 35);
            this.txtDate1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label23
            // 
            this.label23.Flex = 1;
            this.label23.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 35);
            this.label23.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel22
            // 
            this.panel22.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label24,
            this.label25});
            this.panel22.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(0, 30);
            // 
            // label24
            // 
            this.label24.Flex = 1;
            this.label24.ForeColor = System.Drawing.Color.DimGray;
            this.label24.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 30);
            this.label24.Text = "是否启用";
            this.label24.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label25
            // 
            this.label25.Flex = 1;
            this.label25.ForeColor = System.Drawing.Color.DimGray;
            this.label25.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 30);
            this.label25.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel23
            // 
            this.panel23.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.switchIsEnable1});
            this.panel23.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(0, 35);
            // 
            // switchIsEnable1
            // 
            this.switchIsEnable1.BackColor = System.Drawing.Color.Transparent;
            this.switchIsEnable1.BorderColor = System.Drawing.Color.Black;
            this.switchIsEnable1.BorderRadius = 0;
            this.switchIsEnable1.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.switchIsEnable1.Name = "switchIsEnable1";
            this.switchIsEnable1.Size = new System.Drawing.Size(100, 35);
            this.switchIsEnable1.CheckedChanged += new System.EventHandler(this.switchIsEnable1_CheckedChanged);
            // 
            // frmAssetsTypeRows
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.frmAssetsTypeRows_Load);

        }
        #endregion

        private Panel panel1;
        private Label MenuTitle;
        private Panel panel2;
        private Button AddBtn;
        private Panel panel3;
        private TreeView treeView1;
        private Panel panel4;
        private Panel panel6;
        private Label labTitle;
        private Button editBtn;
        private Button addTypeBtn;
        private Panel Fpanel;
        private Panel panel7;
        private Label label3;
        private Label label5;
        private Panel panel8;
        private Label txtID;
        private Label txtName;
        private Panel panel9;
        private Label label2;
        private Label label6;
        private Panel panel10;
        private Label txtDate;
        private Label txtPlace;
        private Panel panel11;
        private Label label7;
        private Label label8;
        private Panel panel12;
        private Switch switchIsEnable;
        private Panel SPanel;
        private Panel panel14;
        private Label label4;
        private Label label9;
        private Panel panel15;
        private Label txtFID;
        private Label txtFName;
        private Panel panel16;
        private Label label12;
        private Label label13;
        private Panel panel17;
        private Label txtFDate;
        private Label label15;
        private Panel panel18;
        private Label label16;
        private Label label17;
        private Panel panel19;
        private Label txtID1;
        private Label txtName1;
        private Panel panel20;
        private Label label20;
        private Label label21;
        private Panel panel21;
        private Label txtDate1;
        private Label label23;
        private Panel panel22;
        private Label label24;
        private Label label25;
        private Panel panel23;
        private Switch switchIsEnable1;
    }
}