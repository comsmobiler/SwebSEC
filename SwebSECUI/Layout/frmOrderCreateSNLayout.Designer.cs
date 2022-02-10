using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmOrderCreateSNLayout : Swebui.Controls.SwebUserControl
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
            this.plRow = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.imgAss = new Swebui.Controls.Image();
            this.lblName = new Swebui.Controls.Label();
            this.lblASSID = new Swebui.Controls.Label();
            this.lblSN = new Swebui.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.lblName,
            this.lblASSID,
            this.lblSN});
            this.plRow.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plRow.Flex = 1;
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(0, 100);
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgAss});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 0);
            // 
            // imgAss
            // 
            this.imgAss.DisplayMember = "IMAGE";
            this.imgAss.Flex = 1;
            this.imgAss.Name = "imgAss";
            this.imgAss.ResourceID = "";
            this.imgAss.Size = new System.Drawing.Size(45, 45);
            this.imgAss.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.imgAss.Zooming = true;
            // 
            // lblName
            // 
            this.lblName.DataMember = "ASSID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Flex = 1;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 0);
            this.lblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblASSID
            // 
            this.lblASSID.DataMember = "ASSID";
            this.lblASSID.DisplayMember = "ASSID";
            this.lblASSID.Flex = 1;
            this.lblASSID.Name = "lblASSID";
            this.lblASSID.Size = new System.Drawing.Size(100, 0);
            this.lblASSID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblSN
            // 
            this.lblSN.DataMember = "SN";
            this.lblSN.DisplayMember = "SN";
            this.lblSN.Flex = 1;
            this.lblSN.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(100, 0);
            this.lblSN.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmOrderCreateSNLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 45);

        }
        #endregion
        private Panel panel2;
        internal Image imgAss;
        internal Panel plRow;
        internal Label lblName;
        internal Label lblASSID;
        internal Label lblSN;
    }
}