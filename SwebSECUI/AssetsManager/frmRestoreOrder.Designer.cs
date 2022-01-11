using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmRestoreOrder : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.plButton = new Swebui.Controls.Panel();
            this.btnAdd = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.ListViewCO = new Swebui.Controls.ListView();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.label1.Bold = true;
            this.label1.Flex = 1;
            this.label1.FontSize = 15F;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "退库单列表";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnAdd});
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(0, 50);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.Flex = 1;
            this.btnAdd.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NumberOfLines = 0;
            this.btnAdd.Size = new System.Drawing.Size(0, 35);
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.ListViewCO});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // ListViewCO
            // 
            this.ListViewCO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListViewCO.Flex = 1;
            this.ListViewCO.Name = "ListViewCO";
            this.ListViewCO.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListViewCO.Size = new System.Drawing.Size(0, 300);
            this.ListViewCO.TemplateControlName = "RestoreOrderLayout";
            // 
            // frmRestoreOrder
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.plButton,
            this.panel3});
            this.Load += new System.EventHandler(this.frmRestoreOrder_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel plButton;
        internal Button btnAdd;
        private Panel panel3;
        internal ListView ListViewCO;
    }
}