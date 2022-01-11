using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmAssetsSNShowLayout : Swebui.Controls.SwebUserControl
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
            this.imgAss = new Swebui.Controls.Image();
            this.panel3 = new Swebui.Controls.Panel();
            this.lblName = new Swebui.Controls.Label();
            this.lblSN = new Swebui.Controls.Label();
            this.lblStatus = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.lblStatus});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Margin = new Swebui.Controls.Margin(10F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgAss});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 0);
            // 
            // imgAss
            // 
            this.imgAss.BorderRadius = 15;
            this.imgAss.DisplayMember = "IMAGE";
            this.imgAss.Flex = 1;
            this.imgAss.Name = "imgAss";
            this.imgAss.ResourceID = "";
            this.imgAss.Size = new System.Drawing.Size(0, 45);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblName,
            this.lblSN});
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // lblName
            // 
            this.lblName.DataMember = "ASSID";
            this.lblName.DisplayFormat = "资产名称: {0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Flex = 1;
            this.lblName.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 35);
            this.lblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblSN
            // 
            this.lblSN.DataMember = "SN";
            this.lblSN.DisplayFormat = "序列号: {0}";
            this.lblSN.DisplayMember = "SN";
            this.lblSN.Flex = 1;
            this.lblSN.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(0, 35);
            this.lblSN.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblStatus
            // 
            this.lblStatus.DisplayMember = "STATUS";
            this.lblStatus.Flex = 1;
            this.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStatus.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblStatus.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 20F);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 0);
            this.lblStatus.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmAssetsSNShowLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 100);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        internal Image imgAss;
        private Panel panel3;
        internal Label lblName;
        internal Label lblSN;
        internal Label lblStatus;
    }
}