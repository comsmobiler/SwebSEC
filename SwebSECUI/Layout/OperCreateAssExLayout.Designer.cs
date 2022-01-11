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
            this.label1 = new Swebui.Controls.Label();
            this.LblSN = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.lblASSID = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.LblName = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
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
            this.panel1.Margin = new Swebui.Controls.Margin(10F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Image});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 0);
            // 
            // Image
            // 
            this.Image.DataMember = "IMAGE";
            this.Image.DisplayMember = "IMAGE";
            this.Image.Flex = 1;
            this.Image.Name = "Image";
            this.Image.ResourceID = "";
            this.Image.Size = new System.Drawing.Size(0, 45);
            this.Image.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.LblSN});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 68);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 0);
            this.label1.Text = "SN号";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblSN
            // 
            this.LblSN.BackColor = System.Drawing.Color.White;
            this.LblSN.DataMember = "SN";
            this.LblSN.DisplayMember = "SN";
            this.LblSN.Flex = 1;
            this.LblSN.Name = "LblSN";
            this.LblSN.Size = new System.Drawing.Size(100, 0);
            this.LblSN.Text = "资产条码";
            this.LblSN.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.lblASSID});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 68);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 0);
            this.label2.Text = "资产条码";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblASSID
            // 
            this.lblASSID.BackColor = System.Drawing.Color.White;
            this.lblASSID.DataMember = "ASSID";
            this.lblASSID.DisplayMember = "ASSID";
            this.lblASSID.Flex = 1;
            this.lblASSID.Name = "lblASSID";
            this.lblASSID.Size = new System.Drawing.Size(100, 0);
            this.lblASSID.Text = "资产条码";
            this.lblASSID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.LblName});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Flex = 1;
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 68);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 0);
            this.label3.Text = "资产名称";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.White;
            this.LblName.DataMember = "NAME";
            this.LblName.DisplayMember = "NAME";
            this.LblName.Flex = 1;
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(100, 0);
            this.LblName.Text = "资产条码";
            this.LblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.lblCurrentUser});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Flex = 1;
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 68);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 0);
            this.label4.Text = "持有人";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.BackColor = System.Drawing.Color.White;
            this.lblCurrentUser.DataMember = "USERNAME";
            this.lblCurrentUser.DisplayMember = "USERNAME";
            this.lblCurrentUser.Flex = 1;
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(100, 0);
            this.lblCurrentUser.Text = "资产条码";
            this.lblCurrentUser.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.LblType});
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 0);
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
            this.Size = new System.Drawing.Size(0, 260);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        internal Image Image;
        private Panel panel3;
        private Panel panel5;
        internal Label label1;
        private Label LblSN;
        private Panel panel6;
        internal Label label2;
        private Panel panel7;
        internal Label label3;
        private Panel panel8;
        internal Label label4;
        private Panel panel4;
        internal Label lblASSID;
        internal Label LblName;
        internal Label lblCurrentUser;
        internal Label LblType;
    }
}