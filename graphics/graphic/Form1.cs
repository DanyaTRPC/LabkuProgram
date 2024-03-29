﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 1, b = 2, h = 0.1, x, y;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Cos(x) / Math.Sin(x) / Math.Sqrt(x);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }
    }
}
