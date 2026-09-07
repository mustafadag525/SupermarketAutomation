using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_
{
    public partial class frmYeniKullanıcı : Form
    {
        public frmYeniKullanıcı()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Classlar.Kullanici k = new Classlar.Kullanici();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            k.YeniKullanici(txtAdsoyad.Text,txtTelefonno.Text,txtAdres.Text,txtEmail.Text,txtKullanıcıadı.Text,txtparola.Text,txtParolatekrar.Text,txtGorev.Text,pictureBoxresim.ImageLocation);

        }

        private void btnResimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            if(file.ShowDialog()==DialogResult.OK)
            {
                pictureBoxresim.ImageLocation = file.FileName;

            }
        }
    }
}
