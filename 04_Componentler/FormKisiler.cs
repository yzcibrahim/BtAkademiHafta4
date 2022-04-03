using _05_Tipler;
using _08_DosyaRepository;
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
    public partial class FormKisiler : Form
    {
        public FormKisiler()
        {
            InitializeComponent();
           
           
        }

        private void FormKisiler_Load(object sender, EventArgs e)
        {
            JsonRepository repository = new JsonRepository();
            List<KisiCls> kisiler= repository.Get();
            dataGridView1.DataSource = kisiler;
            //foreach (var item in kisiler)
            //{
            //    richKisiler.Text += $"{item.Yazdir()}\n";
            //}
        }
    }
}

