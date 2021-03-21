using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1t3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double y1 = Convert.ToDouble(textBox2.Text);
            double x2 = Convert.ToDouble(textBox3.Text);
            double y2 = Convert.ToDouble(textBox4.Text);
            double x3 = Convert.ToDouble(textBox5.Text);
            double y3 = Convert.ToDouble(textBox6.Text);
            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            if (Math.Pow(AB, 2) > Math.Pow(AC, 2) + Math.Pow(BC, 2) || Math.Pow(AC, 2) > Math.Pow(AB, 2) + Math.Pow(BC, 2) || Math.Pow(BC, 2) > Math.Pow(AC, 2) + Math.Pow(AB, 2))
            {
                textBox7.Text = ("Трикутник тупокутній");
            }
            else
            {
                textBox7.Text = ("Трикутний не буде тупокутнім");
            }
        }
    }
}
