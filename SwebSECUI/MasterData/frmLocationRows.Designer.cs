using Swebui.Controls;
using System;

namespace SwebSECUI.MasterData
{
    partial class frmLocationRows : Swebui.Controls.SwebUserControl
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
            this.DelBtn = new Swebui.Controls.Button();
            this.RefreshBtn = new Swebui.Controls.Button();
            this.StatuBtn = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            this.gridView1 = new Swebui.Controls.GridView();
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
            this.MenuTitle.Text = "区域";
            this.MenuTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnAdd,
            this.EditBtn,
            this.DelBtn,
            this.RefreshBtn,
            this.StatuBtn});
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
            this.EditBtn.Size = new System.Drawing.Size(80, 35);
            this.EditBtn.Text = "编辑";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.White;
            this.DelBtn.Border = new Swebui.Controls.Border(1F);
            this.DelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.DelBtn.BorderRadius = 5;
            this.DelBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DelBtn.IconName = "fa fa-pencil-square-o";
            this.DelBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.NumberOfLines = 0;
            this.DelBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.DelBtn.Size = new System.Drawing.Size(80, 35);
            this.DelBtn.Text = "删除";
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Border = new Swebui.Controls.Border(1F);
            this.RefreshBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.RefreshBtn.BorderRadius = 5;
            this.RefreshBtn.ForeColor = System.Drawing.Color.DimGray;
            this.RefreshBtn.IconName = "fa fa-pencil-square-o";
            this.RefreshBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.NumberOfLines = 0;
            this.RefreshBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.RefreshBtn.Size = new System.Drawing.Size(80, 35);
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // StatuBtn
            // 
            this.StatuBtn.BackColor = System.Drawing.Color.White;
            this.StatuBtn.Border = new Swebui.Controls.Border(1F);
            this.StatuBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.StatuBtn.BorderRadius = 5;
            this.StatuBtn.ForeColor = System.Drawing.Color.DimGray;
            this.StatuBtn.IconName = "fa fa-pencil-square-o";
            this.StatuBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.StatuBtn.Name = "StatuBtn";
            this.StatuBtn.NumberOfLines = 0;
            this.StatuBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.StatuBtn.Size = new System.Drawing.Size(120, 35);
            this.StatuBtn.Text = "修改区域状态";
            this.StatuBtn.Click += new System.EventHandler(this.StatuBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.gridView1});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // gridView1
            // 
            this.gridView1.AllowPaging = true;
            gridViewColumn1.DisplayMember = "LOCATIONID";
            gridViewColumn1.HeaderText = "区域编码";
            gridViewColumn2.DisplayMember = "NAME";
            gridViewColumn2.HeaderText = "区域名称";
            gridViewColumn3.DisplayMember = "ISENABLE";
            gridViewColumn3.HeaderText = "区域状态";
            this.gridView1.Columns.AddRange(new Swebui.Controls.GridViewColumn[] {
            gridViewColumn1,
            gridViewColumn2,
            gridViewColumn3});
            this.gridView1.DataSource = null;
            this.gridView1.Flex = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowHeight = 0;
            this.gridView1.RowWidth = 0;
            this.gridView1.Size = new System.Drawing.Size(0, 30);
            // 
            // frmLocationRows
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.spContent,
            this.panel2});
            this.Load += new System.EventHandler(this.frmLocationRows_Load);

        }
        #endregion

        private Panel panel1;
        private Label MenuTitle;
        internal Panel spContent;
        internal Button btnAdd;
        private Panel panel2;
        private GridView gridView1;
        internal Button EditBtn;
        internal Button DelBtn;
        internal Button RefreshBtn;
        internal Button StatuBtn;
    }
}