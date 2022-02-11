using Swebui;

namespace SwebSECUI
{
    partial class SwebForm1 : Swebui.Controls.SwebForm
    {
        #region "SwebForm Designer generated code "

        //SwebForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SwebForm Designer
        //It can be modified using the SwebForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel4 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.gridUserData = new Swebui.Controls.ListView();
            // 
            // panel4
            // 
            this.panel4.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 45);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 45);
            this.label1.Text = "头像";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "成员名称";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // gridUserData
            // 
            this.gridUserData.Flex = 1;
            this.gridUserData.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.gridUserData.Name = "gridUserData";
            this.gridUserData.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridUserData.Size = new System.Drawing.Size(0, 300);
            this.gridUserData.TemplateControlName = "frmUserLayout";
            // 
            // SwebForm1
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel4,
            this.gridUserData});
            this.Load += new System.EventHandler(this.SwebForm1_Load);

        }
        #endregion

        private Swebui.Controls.Panel panel4;
        private Swebui.Controls.Label label1;
        private Swebui.Controls.Label label2;
        private Swebui.Controls.ListView gridUserData;
    }
}