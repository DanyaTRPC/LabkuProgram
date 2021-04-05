using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9t2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TDate date1 = new TDate(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text),
                Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            textBox7.Text = date1.magnificationDays().ToString();
            textBox8.Text = date1.magnificationMonth().ToString();
            textBox9.Text = date1.magnificationYear().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TDate date1 = new TDate(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text),
    Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            textBox10.Text = date1.Tostring();
        }
    }
}
