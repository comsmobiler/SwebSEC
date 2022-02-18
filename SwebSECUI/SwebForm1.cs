using SwebSECUI.Layout;
using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI
{
    partial class SwebForm1 : Swebui.Controls.SwebForm
    {
        public SwebForm1() : base()
        {
            InitializeComponent();
        }

        private void SwebForm1_Load(object sender, EventArgs e)
        {
            tabPageView1.Titles = new string[] { "待盘点", "已盘点" };
            TabPageControl tabPage1 = new TabPageControl();
            tabPage1.Controls.Add(new SwebUserControl1() { Flex = 1 });
            tabPage1.Flex = 1;
            TabPageControl tabPage2 = new TabPageControl();
            tabPage2.Controls.Add(new SwebUserControl2() { Flex = 1 });
            tabPage2.Flex = 1;
            tabPageView1.Controls.Add(tabPage1);
            tabPageView1.Controls.Add(tabPage2);
        }
    }
}