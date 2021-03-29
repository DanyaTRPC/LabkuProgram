using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fraction frct = new Fraction(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            textBox3.Text = frct.abbreviation().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox7.Text);


            string[] ar = textBox8.Text.Split(' ');
            int[] z = new int[n];
            for (int i = 0; i < n; i++)
            {
                z[i] = Convert.ToInt32(ar[i]);
                for (int j = 0; j < n; j++)
                {
                    int p = 0;
                    int m = 0;
                    if (z[i]/2==0)
                    {
                        p += 1; 
                    }
                    else
                    {
                        m -= 1; 
                    }
                    if (p > m)
                    {
                        textBox6.Text = p.ToString();
                    }
                    else
                    {
                        textBox6.Text = m.ToString();
                    }
            }
            }
            
        }
    }
}
