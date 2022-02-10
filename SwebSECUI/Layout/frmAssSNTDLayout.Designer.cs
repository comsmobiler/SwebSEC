using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmAssSNTDLayout : Swebui.Controls.SwebUserControl
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
            this.Check = new Swebui.Controls.CheckBox();
            this.imgAss = new Swebui.Controls.Image();
            this.panel2 = new Swebui.Controls.Panel();
            this.lblName = new Swebui.Controls.Label();
            this.lblSN = new Swebui.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Check,
            this.imgAss,
            this.panel2});
            this.plRow.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plRow.Flex = 1;
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(0, 100);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Transparent;
            this.Check.BorderColor = System.Drawing.Color.Black;
            this.Check.BorderRadius = 0;
            this.Check.DataMember = "TOROWID";
            this.Check.Margin = new Swebui.Controls.Margin(10F, 5F, 0F, 5F);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(77, 0);
            this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // imgAss
            // 
            this.imgAss.BorderRadius = 15;
            this.imgAss.DisplayMember = "IMAGE";
            this.imgAss.Margin = new Swebui.Controls.Margin(5F);
            this.imgAss.Name = "imgAss";
            this.imgAss.ResourceID = "";
            this.imgAss.Size = new System.Drawing.Size(180, 50);
            this.imgAss.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblName,
            this.lblSN});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // lblName
            // 
            this.lblName.DataMember = "ASSID";
            this.lblName.DisplayFormat = "资产名称: {0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Flex = 1;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 0);
            this.lblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblSN
            // 
            this.lblSN.DataMember = "SN";
            this.lblSN.DisplayFormat = "序列号: {0}";
            this.lblSN.DisplayMember = "SN";
            this.lblSN.Flex = 1;
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(100, 0);
            this.lblSN.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmAssSNTDLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 60);

        }
        #endregion

        private Panel plRow;
        internal CheckBox Check;
        internal Image imgAss;
        private Panel panel2;
        internal Label lblName;
        internal Label lblSN;
    }
}