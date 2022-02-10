using Swebui.Controls;
using System;

namespace SwebSECUI.Department
{
    partial class frmDepAssignUser : Swebui.Controls.SwebUserControl
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
            this.btnAll = new Swebui.Controls.Panel();
            this.checkAll = new Swebui.Controls.CheckBox();
            this.lblCheckall = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.txtDepName = new Swebui.Controls.TextBox();
            this.panel3 = new Swebui.Controls.Panel();
            this.imgPortrait = new Swebui.Controls.Image();
            this.btnUp = new Swebui.Controls.Button();
            this.treeSelect1 = new Swebui.Controls.TreeSelect();
            this.gridUserData = new Swebui.Controls.ListView();
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
            this.MenuTitle.Text = "部门人员分配";
            this.MenuTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.SaveBtn,
            this.btnAll});
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
            this.SaveBtn.Text = "下一步";
            this.SaveBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAll
            // 
            this.btnAll.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkAll,
            this.lblCheckall});
            this.btnAll.Direction = Swebui.Controls.LayoutDirection.Row;
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(300, 0);
            this.btnAll.Touchable = true;
            this.btnAll.Press += new System.EventHandler(this.btnAll_Press);
            // 
            // checkAll
            // 
            this.checkAll.BackColor = System.Drawing.Color.Transparent;
            this.checkAll.BorderColor = System.Drawing.Color.Black;
            this.checkAll.BorderRadius = 0;
            this.checkAll.Margin = new Swebui.Controls.Margin(5F);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(54, 0);
            this.checkAll.CheckedChanged += new System.EventHandler(this.CheckAll_CheckedChanged_1);
            // 
            // lblCheckall
            // 
            this.lblCheckall.Flex = 1;
            this.lblCheckall.Margin = new Swebui.Controls.Margin(10F);
            this.lblCheckall.Name = "lblCheckall";
            this.lblCheckall.Size = new System.Drawing.Size(100, 0);
            this.lblCheckall.Text = "全选";
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
            this.label5.Text = "部门名称";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "部门头像";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.Text = "责任人";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtDepName,
            this.panel3,
            this.treeSelect1});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel13.Name = "panel13";
            this.panel13.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel13.Size = new System.Drawing.Size(0, 35);
            // 
            // txtDepName
            // 
            this.txtDepName.Flex = 1;
            this.txtDepName.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(100, 0);
            this.txtDepName.WaterMarkText = "（必填）";
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgPortrait,
            this.btnUp});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.Flex = 8;
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "";
            this.imgPortrait.Size = new System.Drawing.Size(0, 45);
            this.imgPortrait.SizeMode = Swebui.Controls.ImageSizeMode.Stretch;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.Flex = 2;
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUp.Name = "btnUp";
            this.btnUp.NumberOfLines = 0;
            this.btnUp.Size = new System.Drawing.Size(0, 35);
            this.btnUp.Text = ">";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // treeSelect1
            // 
            this.treeSelect1.DefaultValue = new string[0];
            this.treeSelect1.Flex = 1;
            this.treeSelect1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect1.Name = "treeSelect1";
            this.treeSelect1.Placeholder = "选择（必填）   > ";
            this.treeSelect1.Size = new System.Drawing.Size(100, 0);
            this.treeSelect1.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect1_Press);
            // 
            // gridUserData
            // 
            this.gridUserData.Flex = 1;
            this.gridUserData.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.gridUserData.Name = "gridUserData";
            this.gridUserData.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridUserData.Size = new System.Drawing.Size(0, 300);
            this.gridUserData.TemplateControlName = "frmDepAssignUserLayout";
            // 
            // frmDepAssignUser
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel12,
            this.panel13,
            this.gridUserData});
            this.Load += new System.EventHandler(this.frmDepAssignUser_Load);

        }
        #endregion

        private Panel panel1;
        private Label MenuTitle;
        private Panel panel2;
        internal Button BackBtn;
        internal Button SaveBtn;
        private Panel panel12;
        private Label label5;
        private Label label9;
        private Label label10;
        private Panel panel13;
        internal TextBox txtDepName;
        private Panel panel3;
        private Image imgPortrait;
        internal Button btnUp;
        private TreeSelect treeSelect1;
        private ListView gridUserData;
        private Panel btnAll;
        internal CheckBox checkAll;
        internal Label lblCheckall;
    }
}