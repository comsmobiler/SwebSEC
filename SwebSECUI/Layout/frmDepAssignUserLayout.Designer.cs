using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmDepAssignUserLayout : Swebui.Controls.SwebUserControl
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
            this.lblPortrait = new Swebui.Controls.Label();
            this.lblUser = new Swebui.Controls.Label();
            this.lblDep = new Swebui.Controls.Label();
            this.Check = new Swebui.Controls.CheckBox();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgPortrait,
            this.lblPortrait,
            this.lblUser,
            this.lblDep,
            this.Check});
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
            this.imgPortrait.Size = new System.Drawing.Size(100, 0);
            this.imgPortrait.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // lblPortrait
            // 
            this.lblPortrait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblPortrait.BorderRadius = 10;
            this.lblPortrait.ForeColor = System.Drawing.Color.White;
            this.lblPortrait.Name = "lblPortrait";
            this.lblPortrait.Size = new System.Drawing.Size(100, 0);
            this.lblPortrait.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.DataMember = "USER_ID";
            this.lblUser.DisplayMember = "USER_NAME";
            this.lblUser.Flex = 1;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 0);
            // 
            // lblDep
            // 
            this.lblDep.DataMember = "USER_DEPARTMENTID";
            this.lblDep.DisplayMember = "DepName";
            this.lblDep.Flex = 1;
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(100, 0);
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Transparent;
            this.Check.BorderColor = System.Drawing.Color.Black;
            this.Check.BorderRadius = 0;
            this.Check.DataMember = "SelectCheck";
            this.Check.DisplayMember = "SelectCheck";
            this.Check.Margin = new Swebui.Controls.Margin(5F);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(60, 0);
            // 
            // frmDepAssignUserLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 30);

        }
        #endregion

        private Panel panel1;
        private Image imgPortrait;
        private Label lblPortrait;
        public Label lblUser;
        public Label lblDep;
        public CheckBox Check;
    }
}