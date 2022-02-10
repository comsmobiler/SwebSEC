using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class OperCreateAssExLayout : Swebui.Controls.SwebUserControl
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
            this.panel3 = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.LblSN = new Swebui.Controls.Label();
            this.lblASSID = new Swebui.Controls.Label();
            this.LblName = new Swebui.Controls.Label();
            this.lblCurrentUser = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.LblType = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.panel4});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Image});
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
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel5});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.LblSN,
            this.lblASSID,
            this.LblName,
            this.lblCurrentUser});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 68);
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
            this.LblSN.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblASSID
            // 
            this.lblASSID.BackColor = System.Drawing.Color.White;
            this.lblASSID.DataMember = "ASSID";
            this.lblASSID.DisplayMember = "ASSID";
            this.lblASSID.Flex = 1;
            this.lblASSID.Name = "lblASSID";
            this.lblASSID.Size = new System.Drawing.Size(100, 0);
            this.lblASSID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.White;
            this.LblName.DataMember = "NAME";
            this.LblName.DisplayMember = "NAME";
            this.LblName.Flex = 1;
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(100, 0);
            this.LblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.BackColor = System.Drawing.Color.White;
            this.lblCurrentUser.DataMember = "USERNAME";
            this.lblCurrentUser.DisplayMember = "USERNAME";
            this.lblCurrentUser.Flex = 1;
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(100, 0);
            this.lblCurrentUser.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.LblType});
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 0);
            // 
            // LblType
            // 
            this.LblType.DataMember = "TYPE";
            this.LblType.DisplayMember = "TYPE";
            this.LblType.Flex = 1;
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(0, 35);
            this.LblType.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            this.LblType.Visible = false;
            // 
            // OperCreateAssExLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 45);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        internal Image Image;
        private Panel panel3;
        private Panel panel5;
        private Label LblSN;
        private Panel panel4;
        internal Label LblType;
        internal Label lblASSID;
        internal Label LblName;
        internal Label lblCurrentUser;
    }
}