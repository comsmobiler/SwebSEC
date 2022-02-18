using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ConTransDetailLayout : Swebui.Controls.SwebUserControl
    {
        public ConTransDetailLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string Image
        {
            set
            {
                image1.ResourceID = value;
            }
            get
            {
                return image1.ResourceID;
            }
        }
        public string INTRANSFERQTY
        {
            set
            {
                label1.Text = value;
            }
            get
            {
                return label1.Text;
            }
        }
        public string NAME
        {
            set { label2.Text = value; }
            get
            {
                return label2.Text;
            }
        }
        public string CID { set; get; }
        public string Status
        {
            set
            {
                label3.Text = value;
            }
            get
            {
                return label3.Text;
            }
        }
    }
}