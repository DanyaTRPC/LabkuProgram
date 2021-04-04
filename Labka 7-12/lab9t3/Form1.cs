using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9t3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TTriangle trg = new TTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            listBox1.Items.Add(trg.seedsTriangle());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TTriangle trg = new TTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            textBox7.Text = trg.perimeterTriangle().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TTriangle area = new TTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            textBox8.Text = area.areaTriangle().ToString();
        }
    }
}
