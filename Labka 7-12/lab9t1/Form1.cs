using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9t1
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
             textBox4.Text = trg.perimeterTriangle().ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TTriangle trg = new TTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            textBox5.Text = trg.areaTriangle().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TTriangle t1 = new TTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            TTriangle t2 = new TTriangle(Convert.ToDouble(rnd.Next(1, 10)), Convert.ToDouble(rnd.Next(1, 10)), Convert.ToDouble(rnd.Next(1, 10)));
            textBox6.Text = t2.comparisonTriangle(t1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TTriangle t1 = new TTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            TTriangle t2 = new TTriangle(Convert.ToDouble(rnd.Next(1, 10)), Convert.ToDouble(rnd.Next(1, 10)), Convert.ToDouble(rnd.Next(1, 10)));
            TTriangle s = t1 + t2;
            textBox7.Text = s.seedsTriangle().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TTriangle t1 = new TTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            TTriangle t2 = new TTriangle(Convert.ToDouble(rnd.Next(1, 10)), Convert.ToDouble(rnd.Next(1, 10)), Convert.ToDouble(rnd.Next(1, 10)));
            TTriangle s = t1 - t2;
            textBox8.Text = s.seedsTriangle().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TTriangle t1 = new TTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            double t2 = Convert.ToDouble(textBox9.Text);
            TTriangle s = t1 * t2;
            textBox10.Text = s.seedsTriangle().ToString();
        }
    }
}
