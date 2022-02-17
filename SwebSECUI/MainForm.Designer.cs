using Swebui;
using System;

namespace SwebSECUI
{
    partial class MainForm : Swebui.Controls.SwebForm
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
            Swebui.Controls.MenuItem menuItem1 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem2 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem3 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem4 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem5 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem6 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem7 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem8 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem9 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem10 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem11 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem12 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem13 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem14 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem15 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem16 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem17 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem18 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem19 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem20 = new Swebui.Controls.MenuItem();
            Swebui.Controls.MenuItem menuItem21 = new Swebui.Controls.MenuItem();
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.exitBtn = new Swebui.Controls.Button();
            this.useBtn = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            this.menuView1 = new Swebui.Controls.MenuView();
            this.tabPageView1 = new Swebui.Controls.TabPageView();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2,
            this.exitBtn,
            this.useBtn});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // label1
            // 
            this.label1.FontSize = 20F;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.Text = "SwebSEC";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Bold = true;
            this.exitBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.exitBtn.IconName = "fa fa-sign-out";
            this.exitBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.NumberOfLines = 0;
            this.exitBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.exitBtn.SelectBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.SelectColor = System.Drawing.Color.DimGray;
            this.exitBtn.Size = new System.Drawing.Size(0, 60);
            this.exitBtn.Text = "退出";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // useBtn
            // 
            this.useBtn.BackColor = System.Drawing.Color.Transparent;
            this.useBtn.Bold = true;
            this.useBtn.ForeColor = System.Drawing.Color.Silver;
            this.useBtn.IconName = "fa fa-user";
            this.useBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.useBtn.Name = "useBtn";
            this.useBtn.NumberOfLines = 0;
            this.useBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.useBtn.SelectBackgroundColor = System.Drawing.Color.DarkGray;
            this.useBtn.SelectColor = System.Drawing.Color.Silver;
            this.useBtn.Size = new System.Drawing.Size(0, 60);
            this.useBtn.Text = "admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.menuView1,
            this.tabPageView1});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // menuView1
            // 
            this.menuView1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuView1.Color = System.Drawing.Color.White;
            this.menuView1.DefaultIcon = "tasks";
            menuItem1.Icon = "home";
            menuItem1.Id = "Home";
            menuItem1.Text = "主页";
            menuItem2.Icon = "archive";
            menuItem3.Id = "FrmAssets";
            menuItem3.Text = "资产列表";
            menuItem4.Id = "FrmBorrowOrder";
            menuItem4.Text = "借用";
            menuItem5.Id = "FrmReturnOrder";
            menuItem5.Text = "归还";
            menuItem6.Id = "FrmCollarOrder";
            menuItem6.Text = "领用";
            menuItem7.Id = "FrmRestoreOrder";
            menuItem7.Text = "退库";
            menuItem8.Id = "FrmRepairRowsSN";
            menuItem8.Text = "维修";
            menuItem9.Id = "FrmScrapRowsSN";
            menuItem9.Text = "报废";
            menuItem10.Id = "FrmTransferRowsSN";
            menuItem10.Text = "调拨";
            menuItem11.Id = "FrmAssInventory";
            menuItem11.Text = "盘点";
            menuItem12.Id = "FrmAssetsTypeRows";
            menuItem12.Text = "资产分类";
            menuItem13.Id = "FrmLocationRows";
            menuItem13.Text = "区域";
            menuItem14.Id = "FrmDepartment";
            menuItem14.Text = "部门";
            menuItem2.Items.AddRange(new Swebui.Controls.MenuItem[] {
            menuItem3,
            menuItem4,
            menuItem5,
            menuItem6,
            menuItem7,
            menuItem8,
            menuItem9,
            menuItem10,
            menuItem11,
            menuItem12,
            menuItem13,
            menuItem14});
            menuItem2.Text = "资产管理";
            menuItem15.Icon = "cube";
            menuItem16.Id = "FrmConsumables";
            menuItem16.Text = "耗材";
            menuItem17.Id = "FrmWarehouseReceipt";
            menuItem17.Text = "入库";
            menuItem18.Id = "FrmOutboundOrder";
            menuItem18.Text = "出库";
            menuItem19.Id = "FrmTransferRows";
            menuItem19.Text = "调拨";
            menuItem20.Id = "FrmConInventory";
            menuItem20.Text = "盘点";
            menuItem15.Items.AddRange(new Swebui.Controls.MenuItem[] {
            menuItem16,
            menuItem17,
            menuItem18,
            menuItem19,
            menuItem20});
            menuItem15.Text = "耗材管理";
            menuItem21.Icon = "user-circle-o";
            menuItem21.Id = "FrmMessage";
            menuItem21.Text = "账户信息";
            this.menuView1.Items.AddRange(new Swebui.Controls.MenuItem[] {
            menuItem1,
            menuItem2,
            menuItem15,
            menuItem21});
            this.menuView1.Name = "menuView1";
            this.menuView1.Size = new System.Drawing.Size(200, 0);
            this.menuView1.MenuItemClick += new Swebui.Controls.MenuViewItemClickEventHandler(this.menuView1_MenuItemClick);
            // 
            // tabPageView1
            // 
            this.tabPageView1.BackColor = System.Drawing.Color.White;
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Margin = new Swebui.Controls.Margin(10F);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndex = 0;
            this.tabPageView1.PageIndicator = Swebui.Controls.TabPageIndicator.None;
            this.tabPageView1.Size = new System.Drawing.Size(100, 0);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2});
            this.Load += new System.EventHandler(this.MainForm_Load);

        }
        #endregion

        private Swebui.Controls.Panel panel1;
        private Swebui.Controls.Label label1;
        private Swebui.Controls.Label label2;
        private Swebui.Controls.Button exitBtn;
        private Swebui.Controls.Button useBtn;
        private Swebui.Controls.Panel panel2;
        private Swebui.Controls.MenuView menuView1;
        private Swebui.Controls.TabPageView tabPageView1;
    }
}