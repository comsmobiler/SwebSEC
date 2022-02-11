using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmLcoationRowsLayout : Swebui.Controls.SwebUserControl
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
            this.lblName = new Swebui.Controls.Label();
            this.plEdit = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.label1 = new Swebui.Controls.Label();
            this.plDelete = new Swebui.Controls.Panel();
            this.fontIcon2 = new Swebui.Controls.FontIcon();
            this.label2 = new Swebui.Controls.Label();
            this.plEnable = new Swebui.Controls.Panel();
            this.image2 = new Swebui.Controls.Image();
            this.lblEnable = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.plEdit,
            this.plDelete,
            this.plEnable});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.lblName});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 0);
            // 
            // image1
            // 
            this.image1.Name = "image1";
            this.image1.ResourceID = "quyu";
            this.image1.Size = new System.Drawing.Size(30, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // lblName
            // 
            this.lblName.DataMember = "LOCATIONID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Flex = 1;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(300, 0);
            this.lblName.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // plEdit
            // 
            this.plEdit.Border = new Swebui.Controls.Border(1F);
            this.plEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.plEdit.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.label1});
            this.plEdit.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plEdit.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.plEdit.Name = "plEdit";
            this.plEdit.Size = new System.Drawing.Size(160, 0);
            this.plEdit.Touchable = true;
            this.plEdit.Press += new System.EventHandler(this.plEdit_Press);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(181)))), ((int)(((byte)(231)))));
            this.fontIcon1.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "pencil";
            this.fontIcon1.Size = new System.Drawing.Size(30, 45);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.Text = "编辑";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // plDelete
            // 
            this.plDelete.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon2,
            this.label2});
            this.plDelete.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plDelete.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.plDelete.Name = "plDelete";
            this.plDelete.Size = new System.Drawing.Size(160, 0);
            this.plDelete.Touchable = true;
            this.plDelete.Press += new System.EventHandler(this.plDelete_Press);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(181)))), ((int)(((byte)(231)))));
            this.fontIcon2.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "pencil";
            this.fontIcon2.Size = new System.Drawing.Size(30, 45);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "删除";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // plEnable
            // 
            this.plEnable.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image2,
            this.lblEnable});
            this.plEnable.Direction = Swebui.Controls.LayoutDirection.Row;
            this.plEnable.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.plEnable.Name = "plEnable";
            this.plEnable.Size = new System.Drawing.Size(160, 0);
            this.plEnable.Touchable = true;
            this.plEnable.Press += new System.EventHandler(this.plEnable_Press);
            // 
            // image2
            // 
            this.image2.DisplayMember = "IMGENABLE";
            this.image2.Name = "image2";
            this.image2.ResourceID = "on";
            this.image2.Size = new System.Drawing.Size(45, 45);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // lblEnable
            // 
            this.lblEnable.DisplayMember = "TEXTENABLE";
            this.lblEnable.Flex = 1;
            this.lblEnable.ForeColor = System.Drawing.Color.DimGray;
            this.lblEnable.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(100, 0);
            this.lblEnable.Text = "启用";
            this.lblEnable.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmLcoationRowsLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(685, 45);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        internal Image image1;
        internal Label lblName;
        internal Panel plEdit;
        internal FontIcon fontIcon1;
        private Label label1;
        internal Panel plDelete;
        internal FontIcon fontIcon2;
        private Label label2;
        internal Panel plEnable;
        private Image image2;
        internal Label lblEnable;
    }
}