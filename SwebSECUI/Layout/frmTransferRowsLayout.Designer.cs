using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmTransferRowsLayout : Swebui.Controls.SwebUserControl
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
            this.panel2 = new Swebui.Controls.Panel();
            this.lblID = new Swebui.Controls.Label();
            this.lblDate = new Swebui.Controls.Label();
            this.lblContent = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.lblContent});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblID,
            this.lblDate});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 50);
            // 
            // lblID
            // 
            this.lblID.DataMember = "TOID";
            this.lblID.DisplayFormat = "单号  {0}";
            this.lblID.DisplayMember = "TOID";
            this.lblID.Flex = 1;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 0);
            this.lblID.Text = "单号";
            // 
            // lblDate
            // 
            this.lblDate.DisplayFormat = "日期  {0:yyyy/MM/dd}";
            this.lblDate.DisplayMember = "TRANSFERDATE";
            this.lblDate.Flex = 1;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 0);
            this.lblDate.Text = "日期";
            // 
            // lblContent
            // 
            this.lblContent.DisplayFormat = "备注  {0}";
            this.lblContent.DisplayMember = "NOTE";
            this.lblContent.Flex = 1;
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(0, 35);
            this.lblContent.Text = "备注";
            // 
            // frmTransferRowsLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 80);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        internal Label lblID;
        internal Label lblDate;
        internal Label lblContent;
    }
}