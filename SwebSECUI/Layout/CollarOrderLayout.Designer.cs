using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class CollarOrderLayout : Swebui.Controls.SwebUserControl
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
            this.panel3 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.Label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.LblID = new Swebui.Controls.Label();
            this.LblDate = new Swebui.Controls.Label();
            this.LblLocation = new Swebui.Controls.Label();
            this.LblDep = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.LblBMan = new Swebui.Controls.Label();
            this.LblPlace = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5});
            this.panel1.Flex = 1;
            this.panel1.Margin = new Swebui.Controls.Margin(5F, 10F, 5F, 10F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.Label1,
            this.LblID,
            this.label9,
            this.LblBMan});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 49);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.LblDate});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 56);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.LblLocation,
            this.label10,
            this.LblPlace});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 60);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.LblDep});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 100);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(125, 0);
            this.Label1.Text = "单号";
            this.Label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 0);
            this.label2.Text = "日期";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 0);
            this.label3.Text = "区域";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 0);
            this.label4.Text = "部门";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblID
            // 
            this.LblID.DataMember = "COID";
            this.LblID.DisplayMember = "COID";
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(300, 0);
            this.LblID.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblDate
            // 
            this.LblDate.DataMember = "COLLARDATE";
            this.LblDate.DisplayMember = "COLLARDATE";
            this.LblDate.Flex = 1;
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(300, 0);
            this.LblDate.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblLocation
            // 
            this.LblLocation.DataMember = "LOCATIONNAME";
            this.LblLocation.DisplayMember = "LOCATIONNAME";
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(300, 0);
            this.LblLocation.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblDep
            // 
            this.LblDep.DataMember = "InUsedDep";
            this.LblDep.DisplayMember = "InUsedDep";
            this.LblDep.Flex = 1;
            this.LblDep.Name = "LblDep";
            this.LblDep.Size = new System.Drawing.Size(300, 0);
            this.LblDep.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 0);
            this.label9.Text = "领用人";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 0);
            this.label10.Text = "地点";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblBMan
            // 
            this.LblBMan.DataMember = "USERID";
            this.LblBMan.DisplayMember = "USERID";
            this.LblBMan.Flex = 1;
            this.LblBMan.Name = "LblBMan";
            this.LblBMan.Size = new System.Drawing.Size(100, 0);
            this.LblBMan.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // LblPlace
            // 
            this.LblPlace.DataMember = "PLACE";
            this.LblPlace.DisplayMember = "PLACE";
            this.LblPlace.Flex = 1;
            this.LblPlace.Name = "LblPlace";
            this.LblPlace.Size = new System.Drawing.Size(100, 0);
            this.LblPlace.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // CollarOrderLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 260);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        internal Label Label1;
        internal Label LblID;
        internal Label label9;
        internal Label LblBMan;
        private Panel panel3;
        internal Label label2;
        internal Label LblDate;
        private Panel panel4;
        internal Label label3;
        internal Label LblLocation;
        internal Label label10;
        internal Label LblPlace;
        private Panel panel5;
        internal Label label4;
        internal Label LblDep;
    }
}