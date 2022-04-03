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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KisiCls kisi = new KisiCls();
            kisi.Ad = txtName.Text;
            kisi.Soyad = txtSurname.Text;
            kisi.Yas = int.Parse(txtAge.Text);
            kisi.Cinsiyet = (CinsiyetEnum)cmbGender.SelectedItem;

            var _repository = new JsonRepository();

            _repository.Add(kisi);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add(CinsiyetEnum.Kadın);
            cmbGender.Items.Add(CinsiyetEnum.Erkek);
            cmbGender.Items.Add(CinsiyetEnum.BelirtmekIstemiyor);
        }
    }
}

