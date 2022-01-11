using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmAssetsExLayout : Swebui.Controls.SwebUserControl
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
            this.tpRow = new Swebui.Controls.Panel();
            this.checkBox1 = new Swebui.Controls.CheckBox();
            this.panel2 = new Swebui.Controls.Panel();
            this.imgPicture = new Swebui.Controls.Image();
            this.panel3 = new Swebui.Controls.Panel();
            this.lblID = new Swebui.Controls.Label();
            this.lblName = new Swebui.Controls.Label();
            this.panel1 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.lblPrice = new Swebui.Controls.Label();
            // 
            // tpRow
            // 
            this.tpRow.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkBox1,
            this.panel2});
            this.tpRow.Direction = Swebui.Controls.LayoutDirection.Row;
            this.tpRow.Flex = 1;
            this.tpRow.Name = "tpRow";
            this.tpRow.Size = new System.Drawing.Size(0, 100);
            this.tpRow.Touchable = true;
            //this.tpRow.Press += new System.EventHandler(this.touchPanel1_Press);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.BorderRadius = 0;
            this.checkBox1.DataMember = "IsChecked";
            this.checkBox1.DisplayMember = "IsChecked";
            this.checkBox1.Margin = new Swebui.Controls.Margin(10F);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 0);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgPicture,
            this.panel3});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // imgPicture
            // 
            this.imgPicture.DataMember = "Image";
            this.imgPicture.DisplayMember = "Image";
            this.imgPicture.Margin = new Swebui.Controls.Margin(0F, 5F, 0F, 5F);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.ResourceID = "";
            this.imgPicture.Size = new System.Drawing.Size(115, 0);
            this.imgPicture.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblID,
            this.lblName,
            this.panel1});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            // 
            // lblID
            // 
            this.lblID.DataMember = "AssId";
            this.lblID.DisplayMember = "AssId";
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 30);
            this.lblID.Text = "001";
            // 
            // lblName
            // 
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 30);
            this.lblName.Text = "炫彩皮肤";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.lblPrice});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "金额";
            // 
            // lblPrice
            // 
            this.lblPrice.DataMember = "Price";
            this.lblPrice.DisplayMember = "Price";
            this.lblPrice.Flex = 1;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 0);
            this.lblPrice.Text = "40元";
            // 
            // frmAssetsExLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.tpRow});
            this.Size = new System.Drawing.Size(0, 105);

        }
        #endregion

        private Panel tpRow;
        private CheckBox checkBox1;
        private Panel panel2;
        private Image imgPicture;
        private Panel panel3;
        private Label lblID;
        private Label lblName;
        private Panel panel1;
        private Label label3;
        private Label lblPrice;
    }
}