using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmScrapRowsLayout : Swebui.Controls.SwebUserControl
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
            this.plContent = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.lblID = new Swebui.Controls.Label();
            this.lblDate = new Swebui.Controls.Label();
            this.lblContent = new Swebui.Controls.Label();
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3});
            this.plContent.Flex = 1;
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(0, 100);
            this.plContent.Press += new System.EventHandler(this.plContent_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblID,
            this.lblDate});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 30);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblContent});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // lblID
            // 
            this.lblID.DataMember = "SOID";
            this.lblID.DisplayFormat = "单号  {0}";
            this.lblID.DisplayMember = "SOID";
            this.lblID.Flex = 1;
            this.lblID.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 0);
            this.lblID.Text = "单号";
            this.lblID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblDate
            // 
            this.lblDate.DisplayFormat = "清理日期  {0:yyyy/MM/dd}";
            this.lblDate.DisplayMember = "SCRAPDATE";
            this.lblDate.Flex = 1;
            this.lblDate.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 0);
            this.lblDate.Text = "日期";
            this.lblDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblContent
            // 
            this.lblContent.DisplayFormat = "备注  {0}";
            this.lblContent.DisplayMember = "NOTE";
            this.lblContent.Flex = 1;
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(0, 35);
            this.lblContent.Text = "备注 ";
            this.lblContent.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmScrapRowsLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.plContent});
            this.Size = new System.Drawing.Size(0, 50);

        }
        #endregion

        internal Panel plContent;
        private Panel panel2;
        internal Label lblID;
        internal Label lblDate;
        private Panel panel3;
        internal Label lblContent;
    }
}