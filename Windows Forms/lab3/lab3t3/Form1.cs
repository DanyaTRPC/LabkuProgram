using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3t3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(textBox1.Text);
            double a2 = Convert.ToDouble(textBox2.Text);
            double a3 = Convert.ToDouble(textBox3.Text);
            double b1 = Convert.ToDouble(textBox4.Text);
            double b2 = Convert.ToDouble(textBox5.Text);
            double b3 = Convert.ToDouble(textBox6.Text);
            double A = a2 * b3 - a3 * b2;
            double B = a3 * b1 - a1 * b3;
            double C = a1 * b2 - a2 * b1;
            textBox7.Text = A.ToString();
            textBox8.Text = B.ToString();
            textBox9.Text = C.ToString();
        }
    }
}
