using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmAIResultLayout : Swebui.Controls.SwebUserControl
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
            this.image1 = new Swebui.Controls.Image();
            this.panel4 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.panel4});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 60);
            // 
            // image1
            // 
            this.image1.DataMember = "Image";
            this.image1.DisplayMember = "Image";
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(45, 0);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image1.Zooming = true;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label1,
            this.label2,
            this.label3,
            this.label10,
            this.label11,
            this.label12,
            this.label5});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // label4
            // 
            this.label4.DataMember = "Name";
            this.label4.DisplayMember = "Name";
            this.label4.Flex = 1;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            // 
            // label1
            // 
            this.label1.DataMember = "ASSID";
            this.label1.DisplayMember = "ASSID";
            this.label1.Flex = 1;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.DataMember = "TypeName";
            this.label2.DisplayMember = "TypeName";
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.DataMember = "SN";
            this.label3.DisplayMember = "SN";
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.DataMember = "Specification";
            this.label10.DisplayMember = "Specification";
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.DataMember = "Price";
            this.label11.DisplayMember = "Price";
            this.label11.Flex = 1;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.DataMember = "LocationName";
            this.label12.DisplayMember = "LocationName";
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 0);
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.DataMember = "RESULTNAME";
            this.label5.DisplayMember = "RESULTNAME";
            this.label5.Flex = 1;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 0);
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmAIResultLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 45);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Image image1;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label10;
        private Label label11;
        public Label label12;
        private Label label4;
        internal Label label5;
    }
}