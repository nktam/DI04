﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class TotalVentasUC : UserControl
    {
        public TotalVentasUC()
        {
            InitializeComponent();
        }

        public void SetTotal(string text)
        {
            label2.Text = text;
        }
    }
}
