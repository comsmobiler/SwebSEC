using Swebui.Controls;
using System;

namespace SwebSECUI.Layout
{
    partial class frmUserChangeLayout : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.treeSelect1 = new Swebui.Controls.TreeSelect();
            this.panel3 = new Swebui.Controls.Panel();
            this.SaveBtn = new Swebui.Controls.Button();
            this.CancelBtn = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.treeSelect1});
            this.panel2.Flex = 6;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 5F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.label1.FontSize = 16F;
            this.label1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "使用者变更";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // treeSelect1
            // 
            this.treeSelect1.Border = new Swebui.Controls.Border(1F);
            this.treeSelect1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.treeSelect1.DefaultValue = new string[0];
            this.treeSelect1.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect1.Margin = new Swebui.Controls.Margin(10F);
            this.treeSelect1.Name = "treeSelect1";
            this.treeSelect1.Placeholder = "请选择";
            this.treeSelect1.Size = new System.Drawing.Size(0, 35);
            this.treeSelect1.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect1_Press);
            // 
            // panel3
            // 
            this.panel3.Border = new Swebui.Controls.Border(0F, 1F, 0F, 0F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.SaveBtn,
            this.CancelBtn});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 50);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.Border = new Swebui.Controls.Border(1F);
            this.SaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.SaveBtn.Flex = 1;
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Margin = new Swebui.Controls.Margin(10F);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.NumberOfLines = 0;
            this.SaveBtn.Size = new System.Drawing.Size(100, 0);
            this.SaveBtn.Text = "确认";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.White;
            this.CancelBtn.Border = new Swebui.Controls.Border(1F);
            this.CancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.CancelBtn.Flex = 1;
            this.CancelBtn.ForeColor = System.Drawing.Color.DimGray;
            this.CancelBtn.Margin = new Swebui.Controls.Margin(10F);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.NumberOfLines = 0;
            this.CancelBtn.Size = new System.Drawing.Size(100, 0);
            this.CancelBtn.Text = "取消";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // frmUserChangeLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(400, 200);
            this.Load += new System.EventHandler(this.frmUserChangeLayout_Load);

        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button SaveBtn;
        private Button CancelBtn;
        private Label label1;
        private TreeSelect treeSelect1;
    }
}