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
            this.tabPageView1 = new Swebui.Controls.TabPageView();
            // 
            // tabPageView1
            // 
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndex = 0;
            this.tabPageView1.PageIndicator = Swebui.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(0, 282);
            // 
            // SwebForm1
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.tabPageView1});
            this.Load += new System.EventHandler(this.SwebForm1_Load);

        }
        #endregion

        private Swebui.Controls.TabPageView tabPageView1;
    }
}