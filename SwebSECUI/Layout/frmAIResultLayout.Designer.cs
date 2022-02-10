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
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.label4 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label13 = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel12,
            this.panel3,
            this.panel4,
            this.panel5});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.label1,
            this.label2,
            this.label3});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 60);
            // 
            // image1
            // 
            this.image1.DataMember = "Image";
            this.image1.DisplayMember = "Image";
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(85, 0);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.Margin = new Swebui.Controls.Margin(5F, 10F, 0F, 10F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 0);
            this.label1.Text = "资产名称";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.DataMember = "Name";
            this.label2.DisplayMember = "Name";
            this.label2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 10F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 0);
            // 
            // label3
            // 
            this.label3.DataMember = "RESULTNAME";
            this.label3.DisplayMember = "RESULTNAME";
            this.label3.Margin = new Swebui.Controls.Margin(20F, 10F, 0F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 0);
            this.label3.Text = "状态";
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label9,
            this.label10});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.Flex = 1;
            this.panel12.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel12.Name = "panel12";
            this.panel12.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel12.Size = new System.Drawing.Size(0, 30);
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 0);
            this.label5.Text = "条形码";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "资产分类";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.Text = "来源区域";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label6,
            this.label7});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Flex = 1;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label4
            // 
            this.label4.DataMember = "ASSID";
            this.label4.DisplayMember = "ASSID";
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            this.label4.Text = "借用人";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.DataMember = "TypeName";
            this.label6.DisplayMember = "TypeName";
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.Text = "借出日期";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.DataMember = "SN";
            this.label7.DisplayMember = "SN";
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "SN";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8,
            this.label11,
            this.label12});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Flex = 1;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 10F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 30);
            // 
            // label8
            // 
            this.label8.Flex = 1;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 0);
            this.label8.Text = "规格型号";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Flex = 1;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 0);
            this.label11.Text = "价格";
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Flex = 1;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 0);
            this.label12.Text = "区域";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label13,
            this.label14,
            this.label15});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label13
            // 
            this.label13.DataMember = "Specification";
            this.label13.DisplayMember = "Specification";
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 0);
            this.label13.Text = "借用人";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label14
            // 
            this.label14.DataMember = "Price";
            this.label14.DisplayMember = "Price";
            this.label14.Flex = 1;
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 0);
            this.label14.Text = "借出日期";
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label15
            // 
            this.label15.DataMember = "LocationName";
            this.label15.DisplayMember = "LocationName";
            this.label15.Flex = 1;
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 0);
            this.label15.Text = "来源区域";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmAIResultLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 200);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Image image1;
        private Label label1;
        private Label label2;
        public Label label3;
        private Panel panel12;
        private Label label5;
        private Label label9;
        private Label label10;
        private Panel panel3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Panel panel4;
        private Label label8;
        private Label label11;
        private Label label12;
        private Panel panel5;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}