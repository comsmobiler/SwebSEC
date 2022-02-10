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
            this.spContent = new Swebui.Controls.Panel();
            this.btnAdd = new Swebui.Controls.Button();
            this.EditBtn = new Swebui.Controls.Button();
            this.AddBtn = new Swebui.Controls.Button();
            this.DeleteBtn = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            this.treeAssetsType = new Swebui.Controls.TreeView();
            this.panel3 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.lblName = new Swebui.Controls.Label();
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
            this.MenuTitle.Text = "资产分类";
            this.MenuTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnAdd,
            this.EditBtn,
            this.AddBtn,
            this.DeleteBtn});
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
            this.EditBtn.Text = "编辑此分类";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.Border = new Swebui.Controls.Border(1F);
            this.AddBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.AddBtn.BorderRadius = 5;
            this.AddBtn.ForeColor = System.Drawing.Color.DimGray;
            this.AddBtn.IconName = "plus-circle";
            this.AddBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NumberOfLines = 0;
            this.AddBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.AddBtn.Size = new System.Drawing.Size(80, 35);
            this.AddBtn.Text = "下级";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.Border = new Swebui.Controls.Border(1F);
            this.DeleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.DeleteBtn.BorderRadius = 5;
            this.DeleteBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.IconName = "fa fa-pencil-square-o";
            this.DeleteBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NumberOfLines = 0;
            this.DeleteBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.DeleteBtn.Size = new System.Drawing.Size(120, 35);
            this.DeleteBtn.Text = "删除此分类";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeAssetsType});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // treeAssetsType
            // 
            this.treeAssetsType.DefaultValue = new string[0];
            this.treeAssetsType.Flex = 1;
            this.treeAssetsType.Name = "treeAssetsType";
            this.treeAssetsType.Size = new System.Drawing.Size(0, 30);
            this.treeAssetsType.Press += new Swebui.Controls.TreeView.TreeViewOnPressEventHandler(this.treeAssetsType_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.lblName});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 50);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Flex = 3;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.Text = "当前所选分类";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.Flex = 7;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 0);
            this.lblName.Text = "暂无";
            this.lblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmAssetsTypeRows
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.spContent,
            this.panel2,
            this.panel3});
            this.Load += new System.EventHandler(this.frmAssetsTypeRows_Load);

        }
        #endregion

        private Panel panel1;
        private Label MenuTitle;
        internal Panel spContent;
        internal Button btnAdd;
        internal Button EditBtn;
        private Panel panel2;
        internal Button AddBtn;
        internal TreeView treeAssetsType;
        private Panel panel3;
        internal Label label1;
        internal Label lblName;
        internal Button DeleteBtn;
    }
}