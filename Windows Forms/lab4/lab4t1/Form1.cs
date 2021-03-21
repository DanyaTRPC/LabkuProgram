using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4t1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random rand = new Random(DateTime.Now.Millisecond);
            double[,] matrix = new double[n, n];
            double s = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-10, 10);

                }
                
            }
            for (int t = 0; t >= 0 && t <= n - 1; t++)
            {
                for (int h = 0; h < n; h++)
                {
                    if (matrix[t, h] > 0)
                    {
                        s *= matrix[t, h];
                        textBox2.Text = s.ToString();
                    }
                }
            }
        }
    }
}