using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3t2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            double[] listA = new double[] { };
            double[] listB = new double[] { };
            double a;
            double s1 = 0;
            double s2 = 0;
            for (int i = 0; i >= 1 && i <= n + 1; i++)
            {
                double radL = i / 180 * Math.PI;
                a = ((2 * i - 1) * Math.Cos(i)) / Math.Pow(i, 2);
                if (a > 0)
                {
                    listA[i] = a;
                    for (int j = 0; j < n; j++)
                    {
                        s1 += Math.Pow(j, 2);
                    }
                }
                else
                {
                    listB[i] = a;
                    for (int t = 0; t < n; t++)
                    {
                        s2 += Math.Pow(t, 2);
                    }
                }
                if (s2 < s1)
                {
                    int z = -1;
                    textBox2.Text = z.ToString();
                }
                else
                {
                    int z = 1;
                    textBox2.Text = z.ToString();

                }
            }
        }
    }
}
