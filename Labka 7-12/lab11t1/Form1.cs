using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11t1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBody bd = new TBody(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            textBox5.Text = bd.areaParallelepiped().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBody bd = new TBody(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            textBox6.Text = bd.capacityParallelepiped().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TBody bd = new TBody(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            textBox7.Text = bd.areaBall().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TBody bd = new TBody(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            textBox8.Text = bd.capacityBall().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            TParallelepiped bp = new TParallelepiped(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                            Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToInt32(textBox9.Text));

            textBox10.Text = bp.areaParallelepiped().ToString();

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            TBall bl = new TBall(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                            Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToInt32(textBox9.Text));
            textBox11.Text = bl.areaBall().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TBall bl = new TBall(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                            Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToInt32(textBox9.Text));
            TParallelepiped bp = new TParallelepiped(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                            Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToInt32(textBox9.Text));
            textBox12.Text = (bl.areaBall() + bp.areaParallelepiped()).ToString();
        }
    }
}
