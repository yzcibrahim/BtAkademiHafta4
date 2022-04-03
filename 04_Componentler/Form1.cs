using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Componentler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Butona Tıklandı");
            MessageBox.Show(checkBox1.Checked.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.Day.ToString());
            MessageBox.Show(dateTimePicker1.Value.DayOfWeek.ToString());
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("renke tııklandı");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            DialogResult clr=colorDialog1.ShowDialog();

            if (clr == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            contextMenuStrip1.Show(this.Location.X+15, this.Location.Y+25);
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başka Form Açılacak");
            Console.WriteLine("bu özelliğimi hala kullanabilir miyim?");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            // frm.Show();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormKisiler frm = new FormKisiler();
            frm.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            FormComponentMove frm = new FormComponentMove();
            frm.Show();
        }
    }
}
