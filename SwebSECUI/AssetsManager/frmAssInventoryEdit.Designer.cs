using Swebui.Controls;
using System;

namespace SwebSECUI.AssetsManager
{
    partial class frmAssInventoryEdit : Swebui.Controls.SwebUserControl
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
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.SaveBtn = new Swebui.Controls.Button();
            this.panel12 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.txtName = new Swebui.Controls.TextBox();
            this.treeSelect1 = new Swebui.Controls.TreeSelect();
            this.treeSelect2 = new Swebui.Controls.TreeSelect();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.treeSelect3 = new Swebui.Controls.TreeSelect();
            this.treeSelect4 = new Swebui.Controls.TreeSelect();
            this.label6 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Bold = true;
            this.label1.Flex = 1;
            this.label1.FontSize = 16F;
            this.label1.Margin = new Swebui.Controls.Margin(10F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.Text = "资产盘点单修改 ";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn,
            this.SaveBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 45);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Border = new Swebui.Controls.Border(1F);
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackBtn.BorderRadius = 5;
            this.BackBtn.ForeColor = System.Drawing.Color.DimGray;
            this.BackBtn.IconName = "fa fa-angle-left";
            this.BackBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.NumberOfLines = 0;
            this.BackBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.BackBtn.Size = new System.Drawing.Size(80, 35);
            this.BackBtn.Text = "返回";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.Border = new Swebui.Controls.Border(1F);
            this.SaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.SaveBtn.BorderRadius = 5;
            this.SaveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SaveBtn.IconName = "fa fa-floppy-o";
            this.SaveBtn.Margin = new Swebui.Controls.Margin(10F, 5F, 10F, 5F);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.NumberOfLines = 0;
            this.SaveBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.SaveBtn.Size = new System.Drawing.Size(80, 35);
            this.SaveBtn.Text = "保存";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label9,
            this.label10});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
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
            this.label5.Text = "盘点单名称";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "盘点人";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Flex = 1;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 0);
            this.label10.Text = "区域";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtName,
            this.treeSelect1,
            this.treeSelect2});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel13.Name = "panel13";
            this.panel13.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel13.Size = new System.Drawing.Size(0, 35);
            // 
            // txtName
            // 
            this.txtName.Flex = 1;
            this.txtName.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 0);
            this.txtName.WaterMarkText = "（必填）";
            // 
            // treeSelect1
            // 
            this.treeSelect1.DefaultValue = new string[0];
            this.treeSelect1.Flex = 1;
            this.treeSelect1.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect1.Name = "treeSelect1";
            this.treeSelect1.Size = new System.Drawing.Size(100, 0);
            this.treeSelect1.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect1_Press);
            // 
            // treeSelect2
            // 
            this.treeSelect2.DefaultValue = new string[0];
            this.treeSelect2.Flex = 1;
            this.treeSelect2.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect2.Name = "treeSelect2";
            this.treeSelect2.Size = new System.Drawing.Size(100, 0);
            this.treeSelect2.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect2_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label3,
            this.label4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "类型";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 0);
            this.label3.Text = "部门";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.treeSelect3,
            this.treeSelect4,
            this.label6});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // treeSelect3
            // 
            this.treeSelect3.DefaultValue = new string[0];
            this.treeSelect3.Flex = 1;
            this.treeSelect3.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect3.Name = "treeSelect3";
            this.treeSelect3.Placeholder = "选择（必填）   > ";
            this.treeSelect3.Size = new System.Drawing.Size(100, 0);
            this.treeSelect3.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect3_Press);
            // 
            // treeSelect4
            // 
            this.treeSelect4.DefaultValue = new string[0];
            this.treeSelect4.Flex = 1;
            this.treeSelect4.ListBackgroundColor = System.Drawing.Color.White;
            this.treeSelect4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.treeSelect4.Name = "treeSelect4";
            this.treeSelect4.Placeholder = "选择（必填）   > ";
            this.treeSelect4.Size = new System.Drawing.Size(100, 0);
            this.treeSelect4.Press += new Swebui.Controls.TreeSelect.TreeSelectOnPressEventHandler(this.treeSelect4_Press);
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 0);
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // frmAssInventoryEdit
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel12,
            this.panel13,
            this.panel3,
            this.panel4});
            this.Load += new System.EventHandler(this.frmAssInventoryEdit_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        internal Button BackBtn;
        internal Button SaveBtn;
        private Panel panel12;
        private Label label5;
        private Label label9;
        private Label label10;
        private Panel panel13;
        internal TextBox txtName;
        private TreeSelect treeSelect1;
        private TreeSelect treeSelect2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private TreeSelect treeSelect3;
        private TreeSelect treeSelect4;
        private Label label4;
        private Label label6;
    }
}