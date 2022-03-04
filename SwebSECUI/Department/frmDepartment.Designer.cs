using Swebui.Controls;
using System;

namespace SwebSECUI.Department
{
    partial class frmDepartment : Swebui.Controls.SwebUserControl
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
            Swebui.Controls.GridViewColumn gridViewColumn1 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn2 = new Swebui.Controls.GridViewColumn();
            Swebui.Controls.GridViewColumn gridViewColumn3 = new Swebui.Controls.GridViewColumn();
            this.panel1 = new Swebui.Controls.Panel();
            this.MenuTitle = new Swebui.Controls.Label();
            this.spContent = new Swebui.Controls.Panel();
            this.btnAdd = new Swebui.Controls.Button();
            this.EditBtn = new Swebui.Controls.Button();
            this.SaveBtn = new Swebui.Controls.Button();
            this.DeleteBtn = new Swebui.Controls.Button();
            this.UserInfoBtn = new Swebui.Controls.Button();
            this.gridDepData = new Swebui.Controls.GridView();
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
            this.MenuTitle.Text = "部门";
            this.MenuTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // spContent
            // 
            this.spContent.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.spContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.spContent.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnAdd,
            this.EditBtn,
            this.SaveBtn,
            this.DeleteBtn,
            this.UserInfoBtn});
            this.spContent.Direction = Swebui.Controls.LayoutDirection.Row;
            this.spContent.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.spContent.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.spContent.Name = "spContent";
            this.spContent.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.spContent.Size = new System.Drawing.Size(0, 46);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Border = new Swebui.Controls.Border(1F);
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.IconName = "fa fa-plus";
            this.btnAdd.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NumberOfLines = 0;
            this.btnAdd.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.btnAdd.Size = new System.Drawing.Size(0, 26);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.Border = new Swebui.Controls.Border(1F);
            this.EditBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.EditBtn.ForeColor = System.Drawing.Color.DimGray;
            this.EditBtn.IconName = "fa fa-bookmark";
            this.EditBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.NumberOfLines = 0;
            this.EditBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.EditBtn.Size = new System.Drawing.Size(0, 26);
            this.EditBtn.Text = "查看";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.Border = new Swebui.Controls.Border(1F);
            this.SaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.SaveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SaveBtn.IconName = "fa fa-pencil-square-o";
            this.SaveBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.NumberOfLines = 0;
            this.SaveBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.SaveBtn.Size = new System.Drawing.Size(0, 26);
            this.SaveBtn.Text = "编辑";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.Border = new Swebui.Controls.Border(1F);
            this.DeleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.DeleteBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.IconName = "fa fa-trash";
            this.DeleteBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NumberOfLines = 0;
            this.DeleteBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.DeleteBtn.Size = new System.Drawing.Size(0, 26);
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.Visible = false;
            // 
            // UserInfoBtn
            // 
            this.UserInfoBtn.BackColor = System.Drawing.Color.White;
            this.UserInfoBtn.Border = new Swebui.Controls.Border(1F);
            this.UserInfoBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.UserInfoBtn.ForeColor = System.Drawing.Color.DimGray;
            this.UserInfoBtn.IconName = "fa fa-bookmark";
            this.UserInfoBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.UserInfoBtn.Name = "UserInfoBtn";
            this.UserInfoBtn.NumberOfLines = 0;
            this.UserInfoBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.UserInfoBtn.Size = new System.Drawing.Size(0, 26);
            this.UserInfoBtn.Text = "查看所有成员信息";
            this.UserInfoBtn.Click += new System.EventHandler(this.UserInfoBtn_Click);
            // 
            // gridDepData
            // 
            this.gridDepData.AllowPaging = true;
            gridViewColumn1.DisplayMember = "DEPARTMENTID";
            gridViewColumn1.HeaderText = "部门编号";
            gridViewColumn2.DisplayMember = "NAME";
            gridViewColumn2.HeaderText = "部门名称";
            gridViewColumn3.DisplayMember = "MANAGERNAME";
            gridViewColumn3.HeaderText = "责任人";
            this.gridDepData.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2,
            gridViewColumn3});
            this.gridDepData.DataSource = null;
            this.gridDepData.Flex = 1;
            this.gridDepData.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.gridDepData.Name = "gridDepData";
            this.gridDepData.RowHeight = 0;
            this.gridDepData.RowWidth = 0;
            this.gridDepData.Size = new System.Drawing.Size(0, 30);
            // 
            // frmDepartment
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.spContent,
            this.gridDepData});
            this.Load += new System.EventHandler(this.frmDepartment_Load);

        }
        #endregion

        private Panel panel1;
        private Label MenuTitle;
        internal Panel spContent;
        private GridView gridDepData;
        internal Button btnAdd;
        internal Button EditBtn;
        internal Button UserInfoBtn;
        internal Button SaveBtn;
        internal Button DeleteBtn;
    }
}