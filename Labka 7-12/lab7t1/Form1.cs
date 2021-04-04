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
            
            string s = textBox1.Text;
            List<int> list = new List<int>();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(Int32.Parse(new String(arr[i], 1)));

            }
            int sum1 = list.ToArray().Sum();
            textBox3.Text = sum1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            List<int> list = new List<int>();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(Int32.Parse(new String(arr[i], 1)));
            }
            int number1 = list.Count;
            textBox4.Text = number1.ToString();
        }
    }
}
