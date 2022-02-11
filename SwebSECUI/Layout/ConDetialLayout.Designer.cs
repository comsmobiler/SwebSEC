using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class ConDetialLayout : Swebui.Controls.SwebUserControl
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
            this.txtName = new Swebui.Controls.Label();
            this.templateid = new Swebui.Controls.Label();
            this.image1 = new Swebui.Controls.Image();
            this.numQuant = new Swebui.Controls.Label();
            this.numPrice = new Swebui.Controls.Label();
            this.txtNote = new Swebui.Controls.Label();
            // 
            // txtName
            // 
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 35);
            // 
            // templateid
            // 
            this.templateid.Flex = 1;
            this.templateid.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.templateid.Name = "templateid";
            this.templateid.Size = new System.Drawing.Size(0, 35);
            this.templateid.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // image1
            // 
            this.image1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(45, 45);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image1.Zooming = true;
            // 
            // numQuant
            // 
            this.numQuant.Flex = 1;
            this.numQuant.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(0, 35);
            // 
            // numPrice
            // 
            this.numPrice.Flex = 1;
            this.numPrice.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(0, 35);
            // 
            // txtNote
            // 
            this.txtNote.Flex = 1;
            this.txtNote.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(0, 35);
            // 
            // ConDetialLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.templateid,
            this.image1,
            this.numQuant,
            this.numPrice,
            this.txtNote});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Size = new System.Drawing.Size(0, 50);

        }
        #endregion

        private Label txtName;
        private Label templateid;
        private Image image1;
        private Label numQuant;
        private Label numPrice;
        private Label txtNote;
    }
}