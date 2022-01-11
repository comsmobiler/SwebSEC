using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class BorrowOrderLayout : Swebui.Controls.SwebUserControl
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
            this.Label1 = new Swebui.Controls.Label();
            this.LblID = new Swebui.Controls.Label();
            this.Label2 = new Swebui.Controls.Label();
            this.LblBMan = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.Label3 = new Swebui.Controls.Label();
            this.LblDate = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.Label5 = new Swebui.Controls.Label();
            this.LblLocation = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.panel4});
            this.panel1.Flex = 1;
            this.panel1.Margin = new Swebui.Controls.Margin(10F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 230);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label1,
            this.LblID,
            this.Label2,
            this.LblBMan});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 70);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(150, 0);
            this.Label1.Text = "单号";
            // 
            // LblID
            // 
            this.LblID.DataMember = "BOID";
            this.LblID.DisplayMember = "BOID";
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(300, 0);
            // 
            // Label2
            // 
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(150, 0);
            this.Label2.Text = "借用人";
            // 
            // LblBMan
            // 
            this.LblBMan.DataMember = "BORROWER";
            this.LblBMan.DisplayMember = "BORROWER";
            this.LblBMan.Name = "LblBMan";
            this.LblBMan.Size = new System.Drawing.Size(200, 0);
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
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(150, 0);
            this.Label3.Text = "日期";
            // 
            // LblDate
            // 
            this.LblDate.DataMember = "BORROWDATE";
            this.LblDate.DisplayMember = "BORROWDATE";
            this.LblDate.Flex = 1;
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(100, 0);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label5,
            this.LblLocation});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 100);
            // 
            // Label5
            // 
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(150, 0);
            this.Label5.Text = "来源";
            // 
            // LblLocation
            // 
            this.LblLocation.DataMember = "LOCATIONNAME";
            this.LblLocation.DisplayMember = "LOCATIONNAME";
            this.LblLocation.Flex = 1;
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(100, 0);
            // 
            // BorrowOrderLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 100);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        internal Label Label1;
        internal Label LblID;
        internal Label Label2;
        internal Label LblBMan;
        private Panel panel3;
        internal Label Label3;
        internal Label LblDate;
        private Panel panel4;
        internal Label Label5;
        internal Label LblLocation;
    }
}