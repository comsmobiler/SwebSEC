﻿using Swebui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwebSECUI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class SwebUserControl2 : Swebui.Controls.SwebUserControl
    {
        public SwebUserControl2() : base()
        {
            //This call is required by theSwebUserControl.
            InitializeComponent();
        }
    }
}