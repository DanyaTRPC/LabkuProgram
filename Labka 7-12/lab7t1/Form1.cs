using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7t1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text; 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Number nmb = new Number(Convert.ToInt32(textBox1.Text));
            textBox3.Text = nmb.Sum().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number nmb = new Number(Convert.ToInt32(textBox1.Text));
            textBox4.Text = nmb.Main().ToString();
        }
    }
}
