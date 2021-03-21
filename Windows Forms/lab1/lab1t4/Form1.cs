using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1t4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            if (a < b && b < c)
            {
                textBox4.Text = ("y = 1");
            }
            else if (a == b && b == c)
            {
                textBox4.Text = ("y = 2");
            }
            else if (b < a && a < c)
            {
                textBox4.Text = ("y = 3");
            }
            else if (c < a && a < b)
            {
                textBox4.Text = ("y = 4");
            }
            else
            {
                textBox4.Text = ("y = 0");
            }
        }
    }
}
