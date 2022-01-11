using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmRepairRowsLayout : Swebui.Controls.SwebUserControl
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
            this.plContent.Touchable = true;
            this.plContent.Press += new System.EventHandler(this.plContent_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblID,
            this.lblDate});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 45);
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
            this.lblID.DataMember = "ROID";
            this.lblID.DisplayFormat = "单号  {0}";
            this.lblID.DisplayMember = "ROID";
            this.lblID.Flex = 1;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(189, 0);
            this.lblID.Text = "单号";
            // 
            // lblDate
            // 
            this.lblDate.DisplayFormat = "日期  {0:yyyy/MM/dd}";
            this.lblDate.DisplayMember = "APPLYDATE";
            this.lblDate.Flex = 1;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 0);
            this.lblDate.Text = "日期";
            // 
            // lblContent
            // 
            this.lblContent.DisplayFormat = "内容  {0}";
            this.lblContent.DisplayMember = "REPAIRCONTENT";
            this.lblContent.Flex = 1;
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(0, 35);
            this.lblContent.Text = "内容";
            // 
            // frmRepairRowsLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.plContent});
            this.Size = new System.Drawing.Size(0, 80);

        }
        #endregion

        internal Panel plContent;
        private Panel panel2;
        private Panel panel3;
        internal Label lblID;
        internal Label lblDate;
        internal Label lblContent;
    }
}