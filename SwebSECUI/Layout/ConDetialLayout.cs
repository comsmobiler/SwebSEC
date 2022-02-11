using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ConDetialLayout : Swebui.Controls.SwebUserControl
    {
        public ConDetialLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        public string CONName { 
            set { txtName.Text = value; }
            get { return txtName.Text; }
        }
        public string TemplateID
        {
            set
            {
                templateid.Text = value;
            }
            get { return templateid.Text; }
        }
        public string NumQuant
        {
            set
            {
                numQuant.Text = value;
            }
            get { return numQuant.Text; }
        }
        public string NumPrice
        {
            set
            {
                numPrice.Text = value;
            }
            get { return numPrice.Text; }
        }
        public string Img
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
        public string TXTNote
        {
            set { txtNote.Text = value; }
            get { return txtNote.Text; }
        }
    }
}