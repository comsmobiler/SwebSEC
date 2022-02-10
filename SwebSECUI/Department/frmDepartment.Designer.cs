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
            this.panel1 = new Swebui.Controls.Panel();
            this.MenuTitle = new Swebui.Controls.Label();
            this.spContent = new Swebui.Controls.Panel();
            this.btnAdd = new Swebui.Controls.Button();
            this.EditBtn = new Swebui.Controls.Button();
            this.DModeBtn = new Swebui.Controls.Button();
            this.gridDepData = new Swebui.Controls.GridView();
            this.treeDepData = new Swebui.Controls.TreeView();
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
            this.MenuTitle.Text = "部门";
            this.MenuTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnAdd,
            this.EditBtn,
            this.DModeBtn});
            this.spContent.Direction = Swebui.Controls.LayoutDirection.Row;
            this.spContent.Name = "spContent";
            this.spContent.Size = new System.Drawing.Size(0, 50);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Border = new Swebui.Controls.Border(1F);
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.IconName = "fa fa-plus";
            this.btnAdd.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NumberOfLines = 0;
            this.btnAdd.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.Border = new Swebui.Controls.Border(1F);
            this.EditBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.EditBtn.BorderRadius = 5;
            this.EditBtn.ForeColor = System.Drawing.Color.DimGray;
            this.EditBtn.IconName = "fa fa-pencil-square-o";
            this.EditBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.NumberOfLines = 0;
            this.EditBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.EditBtn.Size = new System.Drawing.Size(120, 35);
            this.EditBtn.Text = "查看此分类";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DModeBtn
            // 
            this.DModeBtn.BackColor = System.Drawing.Color.White;
            this.DModeBtn.Border = new Swebui.Controls.Border(1F);
            this.DModeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.DModeBtn.BorderRadius = 5;
            this.DModeBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DModeBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.DModeBtn.Name = "DModeBtn";
            this.DModeBtn.NumberOfLines = 0;
            this.DModeBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.DModeBtn.Size = new System.Drawing.Size(120, 35);
            this.DModeBtn.Text = "删除此分类";
            this.DModeBtn.Click += new System.EventHandler(this.DModeBtn_Click);
            // 
            // gridDepData
            // 
            gridViewColumn1.DisplayMember = "NAME";
            gridViewColumn1.HeaderText = "部门名称";
            gridViewColumn2.DisplayMember = "MANAGERNAME";
            gridViewColumn2.HeaderText = "责任人";
            this.gridDepData.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2});
            this.gridDepData.DataSource = null;
            this.gridDepData.Flex = 1;
            this.gridDepData.Name = "gridDepData";
            this.gridDepData.RowWidth = 0;
            this.gridDepData.Size = new System.Drawing.Size(0, 30);
            // 
            // treeDepData
            // 
            this.treeDepData.DefaultValue = new string[0];
            this.treeDepData.Flex = 1;
            this.treeDepData.Name = "treeDepData";
            this.treeDepData.Size = new System.Drawing.Size(0, 30);
            this.treeDepData.Press += new Swebui.Controls.TreeView.TreeViewOnPressEventHandler(this.treeDepData_Press);
            // 
            // frmDepartment
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.spContent,
            this.gridDepData,
            this.treeDepData});
            this.Load += new System.EventHandler(this.frmDepartment_Load);

        }
        #endregion

        private Panel panel1;
        private Label MenuTitle;
        internal Panel spContent;
        internal Button btnAdd;
        internal Button EditBtn;
        internal Button DModeBtn;
        private GridView gridDepData;
        private TreeView treeDepData;
    }
}