using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2t1
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
            double n = Convert.ToDouble(textBox3.Text);
            if (n > 0)
            {
                double k = Math.Pow(x + a, 2);
                n -= 1;
                while (n > 0)
                {
                    k = Math.Pow(k + a, 2);
                    n -= 1;
                }
                k += a;
                textBox4.Text = k.ToString();

            }
            else
            {
                textBox4.Text = ("Рівняння не виконується");
            }
        }
    }
}
