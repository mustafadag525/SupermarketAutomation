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
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            panelSayfalar.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelSayfalar.Controls.Add(frm);
            frm.Show();



        }
        private void formAnaSayfa_Load(object sender, EventArgs e)
        {

        }
        private void btnMalEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmUrunEkle ekle = new Formlar.frmUrunEkle();
            FormGetir(ekle);

        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            frmYeniKullanıcı yeni = new frmYeniKullanıcı();
            FormGetir(yeni);
        }

        private void btnMalListele_Click(object sender, EventArgs e)
        {
            Formlar.frmUrunListele urunlistele = new Formlar.frmUrunListele();
            FormGetir(urunlistele);
        }

        private void btnMarkaekle_Click(object sender, EventArgs e)
        {
            Formlar.frmMarkaekle ekle = new Formlar.frmMarkaekle();
            ekle.Show();
        }

        private void btnUrunekle_Click(object sender, EventArgs e)
        {
            Formlar.frmUrunEkle ekle = new Formlar.frmUrunEkle();
            ekle.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("çıkmak istermisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnKullanıcıListele_Click(object sender, EventArgs e)
        {
            Formlar.frmKullanıcıListele liste = new Formlar.frmKullanıcıListele();
            FormGetir(liste);
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriEkle ekle = new Formlar.frmMusteriEkle();
            FormGetir(ekle);
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriListeleme listele = new Formlar.frmMusteriListeleme();
            FormGetir(listele);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlar.frmSatisYap satis = new Formlar.frmSatisYap();
            FormGetir(satis);
        }

        private void btnDoviz_Click(object sender, EventArgs e)
        {
            Formlar.frmDoviz doviz = new Formlar.frmDoviz();
            FormGetir(doviz);
        }

        private void btnUlas_Click(object sender, EventArgs e)
        {
            Formlar.frmBizeUlasin ulas = new Formlar.frmBizeUlasin();
            FormGetir(ulas);
        }
    }
}
