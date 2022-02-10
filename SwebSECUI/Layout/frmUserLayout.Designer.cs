using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmUserLayout : Swebui.Controls.SwebUserControl
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
            this.imgPortrait = new Swebui.Controls.Image();
            this.lblUser = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgPortrait,
            this.lblUser});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // imgPortrait
            // 
            this.imgPortrait.DataMember = "USER_IMAGEID";
            this.imgPortrait.DisplayMember = "USER_IMAGEID";
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "";
            this.imgPortrait.Size = new System.Drawing.Size(257, 45);
            // 
            // lblUser
            // 
            this.lblUser.DataMember = "USER_ID";
            this.lblUser.DisplayMember = "USER_NAME";
            this.lblUser.Flex = 1;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 0);
            // 
            // frmUserLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 40);

        }
        #endregion

        private Panel panel1;
        private Image imgPortrait;
        private Label lblUser;
    }
}