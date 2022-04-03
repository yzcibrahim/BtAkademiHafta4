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
    public partial class FormComponentMove : Form
    {
        public FormComponentMove()
        {
            InitializeComponent();
           
           
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = btnKisiler.Location.X;
            p.Y = btnKisiler.Location.Y - 5;
            btnKisiler.Location = p;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = btnKisiler.Location.X;
            p.Y = btnKisiler.Location.Y + 5;
            btnKisiler.Location = p;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = btnKisiler.Location.X-5;
            p.Y = btnKisiler.Location.Y;
            btnKisiler.Location = p;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = btnKisiler.Location.X+5;
            p.Y = btnKisiler.Location.Y;
            btnKisiler.Location = p;
        }
    }
}

