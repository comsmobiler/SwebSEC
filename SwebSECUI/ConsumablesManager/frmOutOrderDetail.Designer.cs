﻿using Swebui.Controls;
using System;

namespace SwebSECUI.ConsumablesManager
{
    partial class frmOutOrderDetail : Swebui.Controls.SwebUserControl
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
            this.lblOrder = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.BackBtn = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.txtType = new Swebui.Controls.Label();
            this.DPickerCO = new Swebui.Controls.Label();
            this.txtLocation = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.label5 = new Swebui.Controls.Label();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.txtHMan = new Swebui.Controls.Label();
            this.txtNote = new Swebui.Controls.Label();
            this.textBox3 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label8 = new Swebui.Controls.Label();
            this.panel8 = new Swebui.Controls.Panel();
            this.label13 = new Swebui.Controls.Label();
            this.label14 = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            this.label16 = new Swebui.Controls.Label();
            this.label17 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.listPanel = new Swebui.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.lblOrder});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.FontSize = 18F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.Text = "出库单详情";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // lblOrder
            // 
            this.lblOrder.FontSize = 16F;
            this.lblOrder.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(0, 26);
            this.lblOrder.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.BackBtn});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 15F);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 46);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Border = new Swebui.Controls.Border(1F);
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.BackBtn.ForeColor = System.Drawing.Color.DimGray;
            this.BackBtn.IconName = "fa fa-angle-left";
            this.BackBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.NumberOfLines = 0;
            this.BackBtn.Padding = new Swebui.Controls.Padding(10F, 0F, 10F, 0F);
            this.BackBtn.Size = new System.Drawing.Size(0, 26);
            this.BackBtn.Text = "返回";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.label3,
            this.label4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 30);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "供应商";
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Flex = 1;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "业务日期";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "入库区域";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtType,
            this.DPickerCO,
            this.txtLocation});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 35);
            // 
            // txtType
            // 
            this.txtType.Flex = 1;
            this.txtType.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 35);
            this.txtType.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // DPickerCO
            // 
            this.DPickerCO.Flex = 1;
            this.DPickerCO.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.DPickerCO.Name = "DPickerCO";
            this.DPickerCO.Size = new System.Drawing.Size(100, 35);
            this.DPickerCO.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtLocation
            // 
            this.txtLocation.Flex = 1;
            this.txtLocation.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 35);
            this.txtLocation.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label5,
            this.label6,
            this.label7});
            this.panel5.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 30);
            // 
            // label5
            // 
            this.label5.Flex = 1;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "入库处理人";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Flex = 1;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "备注";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.txtHMan,
            this.txtNote,
            this.textBox3});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 35);
            // 
            // txtHMan
            // 
            this.txtHMan.Flex = 1;
            this.txtHMan.Margin = new Swebui.Controls.Margin(10F, 0F, 5F, 0F);
            this.txtHMan.Name = "txtHMan";
            this.txtHMan.Size = new System.Drawing.Size(100, 35);
            this.txtHMan.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // txtNote
            // 
            this.txtNote.Flex = 1;
            this.txtNote.Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 35);
            this.txtNote.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Flex = 1;
            this.textBox3.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 35);
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label8});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 30);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.Text = "订单明细";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Border = new Swebui.Controls.Border(1F);
            this.panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label13,
            this.label14,
            this.label15,
            this.label16,
            this.label17,
            this.label9});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 30);
            // 
            // label13
            // 
            this.label13.Flex = 1;
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 30);
            this.label13.Text = "物品名称";
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Flex = 1;
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 30);
            this.label14.Text = "物品编号";
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 30);
            this.label15.Text = "图片";
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Flex = 1;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 30);
            this.label16.Text = "数量";
            this.label16.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Flex = 1;
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 30);
            this.label17.Text = "金额";
            this.label17.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "备注";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // listPanel
            // 
            this.listPanel.Border = new Swebui.Controls.Border(1F, 0F, 1F, 1F);
            this.listPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.listPanel.Flex = 1;
            this.listPanel.Margin = new Swebui.Controls.Margin(10F, 0F, 10F, 10F);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(0, 100);
            // 
            // frmOutOrderDetail
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8,
            this.listPanel});
            this.Load += new System.EventHandler(this.frmOutOrderDetail_Load);

        }
        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblOrder;
        private Panel panel2;
        private Button BackBtn;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Label txtType;
        private Label DPickerCO;
        private Label txtLocation;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private Label txtHMan;
        private Label txtNote;
        private Label textBox3;
        private Panel panel7;
        private Label label8;
        private Panel panel8;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label9;
        private Panel listPanel;
    }
}