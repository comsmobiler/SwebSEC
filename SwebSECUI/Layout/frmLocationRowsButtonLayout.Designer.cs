using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmLocationRowsButtonLayout : Swebui.Controls.SwebUserControl
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
            this.btnEdit = new Swebui.Controls.Button();
            this.btnDelete = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.btnEdit,
            this.btnDelete});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Flex = 1;
            this.btnEdit.ForeColor = System.Drawing.Color.DimGray;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NumberOfLines = 0;
            this.btnEdit.Size = new System.Drawing.Size(0, 35);
            this.btnEdit.Text = "编辑此分类";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Flex = 1;
            this.btnDelete.ForeColor = System.Drawing.Color.DimGray;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NumberOfLines = 0;
            this.btnDelete.Size = new System.Drawing.Size(0, 35);
            this.btnDelete.Text = "删除此分类";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmLocationRowsButtonLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 60);
            this.Load += new System.EventHandler(this.frmLocationRowsButtonLayout_Load);

        }
        #endregion

        private Panel panel1;
        internal Button btnEdit;
        internal Button btnDelete;
    }
}