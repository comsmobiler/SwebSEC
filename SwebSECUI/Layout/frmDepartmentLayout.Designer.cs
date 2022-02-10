using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmDepartmentLayout : Swebui.Controls.SwebUserControl
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
            this.panel2 = new Swebui.Controls.Panel();
            this.lblId = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.imgPortrait,
            this.panel2});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // imgPortrait
            // 
            this.imgPortrait.DataMember = "IMAGEID";
            this.imgPortrait.DisplayMember = "IMAGEID";
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "";
            this.imgPortrait.Size = new System.Drawing.Size(150, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.lblId,
            this.label2});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // lblId
            // 
            this.lblId.DataMember = "DEPARTMENTID";
            this.lblId.DisplayMember = "NAME";
            this.lblId.Flex = 1;
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 35);
            // 
            // label2
            // 
            this.label2.DataMember = "MANAGER";
            this.label2.DisplayMember = "MANAGERNAME";
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            // 
            // frmDepartmentLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(0, 50);

        }
        #endregion

        private Panel panel1;
        private Image imgPortrait;
        private Panel panel2;
        private Label lblId;
        private Label label2;
    }
}