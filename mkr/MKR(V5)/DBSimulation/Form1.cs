using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DBSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show(_db.GetAll());
        }

        private competitionDatabase _db = new competitionDatabase();
        

        private void Show(List<competition> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Введіть дані ");
                return;
            }
            dataGridView1.RowCount = list.Count;
            for (int i=0;i<list.Count;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = list[i].surName;
                dataGridView1.Rows[i].Cells[1].Value = list[i].age;
                dataGridView1.Rows[i].Cells[2].Value = list[i].specialty;
                dataGridView1.Rows[i].Cells[3].Value = list[i].rating;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            competition newCompetition = new competition(
                textBoxName.Text,
                int.Parse(textBoxWork.Text),
                textBoxNumber1.Text,
                int.Parse(textBoxNumber2.Text)
                );
            _db.Add(newCompetition);
            Show(_db.GetAll());
            tabControl1.SelectedIndex = 0;

            
            StreamWriter sw = new StreamWriter("text.txt",true);
            sw.WriteLine(textBoxName.Text);
            sw.WriteLine(textBoxWork.Text);
            sw.WriteLine(textBoxNumber1.Text);
            sw.WriteLine(textBoxNumber2.Text);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            competition PcToDelete = _db.GetByIndex(i);
            _db.Remove(PcToDelete);
            Show(_db.GetAll());
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StreamReader sw = new StreamReader("text.txt",true);

            competition newCompetition = new competition(
                 sw.ReadLine(),
                 Convert.ToInt32(sw.ReadLine()),
                 sw.ReadLine(),
                 Convert.ToInt32(sw.ReadLine())
                );

            sw.Close();
            _db.Add(newCompetition);
            Show(_db.GetAll());
            tabControl1.SelectedIndex = 0;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = _db.medRating().ToString();
        }
    }
}
