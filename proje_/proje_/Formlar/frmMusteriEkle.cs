using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_.Formlar
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        Classlar.Müsteri musteri = new Classlar.Müsteri();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.YeniMusteri(txtAdsoyad.Text, txtTelefon.Text, txtEmail.Text, txtAdres.Text);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
