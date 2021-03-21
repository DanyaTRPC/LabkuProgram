using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2t3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double a = Convert.ToDouble(textBox2.Text);
            int n = Convert.ToInt32(textBox3.Text);
            double s = 1;
            if (n > 0 && a > 0)
            {



                for (int j = 0; 1 < j && j < n + 1; j++)
                {
                    double factorial = 1;
                    double factorial1 = factorial * j;
                    double f = Math.Pow(x * Math.Log(a - 1), j) / factorial * j;
                    s += f;

                }
                double p = Math.Pow(x, a) - s;
                textBox4.Text = p.ToString();
            }


            else
            {
                textBox4.Text = ("Рівняння не виконується");
            }

        }
    }
}
