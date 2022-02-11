using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ConChooseLayout : Swebui.Controls.SwebUserControl
    {
        public ConChooseLayout() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
        private DataTable SelectSource;
        public ConChooseLayout(DataTable dt) : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
            SelectSource = dt;
        }

        private void treeSelect1_Press(object sender, TreeSelectPressEventArgs args)
        {
            templateid.Text = args.TreeID;
            foreach (DataRow row in SelectSource.Rows)
            {
                if (row["CID"].ToString() == args.TreeID)
                {
                    image1.ResourceID = row["IMAGE"].ToString();
                    break;
                }
            }
        }
        public string TemplateID
        {
            set
            {
                templateid.Text = value;
                treeSelect1.DefaultValue = new string[] { value };
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void ConChooseLayout_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in SelectSource.Rows)
            {
                treeSelect1.Nodes.Add(new TreeSelectNode(row["CID"].ToString(), row["NAME"].ToString()));
            }

        }
    }
}