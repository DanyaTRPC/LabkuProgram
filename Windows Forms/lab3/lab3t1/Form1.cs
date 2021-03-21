using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3t1
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
            string[] arr = textBox2.Text.Split(' ');
            double[] a = new double[n];
            double min = 1000;
            for (int j = 0; j < n; j++)
            {
                a[j] = Convert.ToDouble(arr[j]);
            }

            for (int i = 0; i < n; i += 1)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            
            textBox3.Text = min.ToString();
             

        }
    }
}
