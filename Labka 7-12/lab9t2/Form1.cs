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
            TDate dmy = new TDate(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)
                ,Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            textBox7.Text = dmy.magnificationDate().ToString();
            textBox8.Text = dmy.magnificationMonth().ToString();
            textBox9.Text = dmy.magnificationYear().ToString();

        }

    }
}
