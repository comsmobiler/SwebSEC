using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class ReturnOrderLayout : Swebui.Controls.SwebUserControl
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
            this.Panel1 = new Swebui.Controls.Panel();
            this.panel2 = new Swebui.Controls.Panel();
            this.Label1 = new Swebui.Controls.Label();
            this.LblID = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.Label3 = new Swebui.Controls.Label();
            this.LblDate = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.Label2 = new Swebui.Controls.Label();
            this.lblRSMan = new Swebui.Controls.Label();
            this.Label5 = new Swebui.Controls.Label();
            this.LblLocation = new Swebui.Controls.Label();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.panel4});
            this.Panel1.Flex = 1;
            this.Panel1.Margin = new Swebui.Controls.Margin(10F);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(0, 250);
            this.Panel1.Press += new System.EventHandler(this.Panel1_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label1,
            this.LblID});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(150, 0);
            this.Label1.Text = "单号";
            this.Label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblID
            // 
            this.LblID.BackColor = System.Drawing.Color.White;
            this.LblID.DataMember = "RTOID";
            this.LblID.DisplayMember = "RTOID";
            this.LblID.Flex = 1;
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(100, 0);
            this.LblID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label3,
            this.LblDate});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 100);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(150, 0);
            this.Label3.Text = "日期";
            this.Label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblDate
            // 
            this.LblDate.DataMember = "RETURNDATE";
            this.LblDate.DisplayMember = "RETURNDATE";
            this.LblDate.Flex = 1;
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(100, 0);
            this.LblDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label2,
            this.lblRSMan,
            this.Label5,
            this.LblLocation});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 100);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(150, 0);
            this.Label2.Text = "处理人";
            this.Label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // lblRSMan
            // 
            this.lblRSMan.DataMember = "HandleMan";
            this.lblRSMan.DisplayMember = "HandleMan";
            this.lblRSMan.Name = "lblRSMan";
            this.lblRSMan.Size = new System.Drawing.Size(300, 0);
            this.lblRSMan.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(113, 0);
            this.Label5.Text = "区域";
            this.Label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblLocation
            // 
            this.LblLocation.DataMember = "LOCATIONNAME";
            this.LblLocation.DisplayMember = "LOCATIONNAME";
            this.LblLocation.Flex = 1;
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(100, 0);
            this.LblLocation.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // ReturnOrderLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Panel1});
            this.Size = new System.Drawing.Size(0, 251);

        }
        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        internal Panel Panel1;
        internal Label Label1;
        internal Label LblID;
        internal Label Label3;
        internal Label LblDate;
        internal Label Label2;
        internal Label lblRSMan;
        internal Label Label5;
        internal Label LblLocation;
    }
}