using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmRepairRowsSN : Swebui.Controls.SwebUserControl
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
            this.btnCreate = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            this.listRepairOrder = new Swebui.Controls.ListView();
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
            this.MenuTitle.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.MenuTitle.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(0, 35);
            this.MenuTitle.Text = "资产报修单列表";
            this.MenuTitle.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnCreate});
            this.spContent.Name = "spContent";
            this.spContent.Size = new System.Drawing.Size(0, 50);
            // 
            // btnCreate
            // 
            this.btnCreate.BorderRadius = 5;
            this.btnCreate.Flex = 1;
            this.btnCreate.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NumberOfLines = 0;
            this.btnCreate.Size = new System.Drawing.Size(0, 35);
            this.btnCreate.Text = "添加";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.listRepairOrder});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // listRepairOrder
            // 
            this.listRepairOrder.Flex = 1;
            this.listRepairOrder.Name = "listRepairOrder";
            this.listRepairOrder.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listRepairOrder.Size = new System.Drawing.Size(0, 300);
            this.listRepairOrder.TemplateControlName = "frmRepairRowsLayout";
            // 
            // frmRepairRowsSN
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.spContent,
            this.panel2});
            this.Load += new System.EventHandler(this.frmRepairRowsSN_Load);

        }
        #endregion

        private Panel panel1;
        private Label MenuTitle;
        internal Panel spContent;
        private Button btnCreate;
        private Panel panel2;
        internal ListView listRepairOrder;
    }
}