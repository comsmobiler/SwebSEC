using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class OperCreateAssLayout : Swebui.Controls.SwebUserControl
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
            this.Image = new Swebui.Controls.Image();
            this.LblSN = new Swebui.Controls.Label();
            this.lblASSID = new Swebui.Controls.Label();
            this.LblName = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.LblType = new Swebui.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.LblSN,
            this.lblASSID,
            this.LblName,
            this.panel4});
            this.plRow.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plRow.Flex = 1;
            this.plRow.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(0, 210);
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Image});
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
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.LblType});
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 0);
            // 
            // LblType
            // 
            this.LblType.DataMember = "TYPE";
            this.LblType.DisplayMember = "TYPE";
            this.LblType.Flex = 1;
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(0, 35);
            this.LblType.Text = "Label4";
            this.LblType.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            this.LblType.Visible = false;
            // 
            // OperCreateAssLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 45);

        }
        #endregion
        private Panel panel2;
        private Panel panel4;
        internal Panel plRow;
        internal Image Image;
        internal Label LblType;
        internal Label LblSN;
        internal Label lblASSID;
        internal Label LblName;
    }
}