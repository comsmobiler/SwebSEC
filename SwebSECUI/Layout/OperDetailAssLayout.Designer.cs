using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class OperDetailAssLayout : Swebui.Controls.SwebUserControl
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
            this.Image = new Swebui.Controls.Image();
            this.LblSN = new Swebui.Controls.Label();
            this.lblASSID = new Swebui.Controls.Label();
            this.LblName = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.LblSN,
            this.lblASSID,
            this.LblName});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 5F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Image});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 0);
            // 
            // Image
            // 
            this.Image.DataMember = "IMAGE";
            this.Image.DisplayMember = "IMAGE";
            this.Image.Flex = 1;
            this.Image.Name = "Image";
            this.Image.ResourceID = "";
            this.Image.Size = new System.Drawing.Size(45, 45);
            this.Image.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.Image.Zooming = true;
            // 
            // LblSN
            // 
            this.LblSN.BackColor = System.Drawing.Color.White;
            this.LblSN.DataMember = "SN";
            this.LblSN.DisplayMember = "SN";
            this.LblSN.Flex = 1;
            this.LblSN.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.LblSN.Name = "LblSN";
            this.LblSN.Size = new System.Drawing.Size(100, 0);
            this.LblSN.Text = "资产条码";
            this.LblSN.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblASSID
            // 
            this.lblASSID.BackColor = System.Drawing.Color.White;
            this.lblASSID.DataMember = "ASSID";
            this.lblASSID.DisplayMember = "ASSID";
            this.lblASSID.Flex = 1;
            this.lblASSID.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblASSID.Name = "lblASSID";
            this.lblASSID.Size = new System.Drawing.Size(100, 0);
            this.lblASSID.Text = "资产条码";
            this.lblASSID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.White;
            this.LblName.DataMember = "NAME";
            this.LblName.DisplayMember = "NAME";
            this.LblName.Flex = 1;
            this.LblName.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(100, 0);
            this.LblName.Text = "资产条码";
            this.LblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // OperDetailAssLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 45);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        internal Image Image;
        private Label LblSN;
        internal Label lblASSID;
        internal Label LblName;
    }
}