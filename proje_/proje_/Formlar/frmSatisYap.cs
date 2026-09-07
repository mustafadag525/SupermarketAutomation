using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_.Formlar
{
    public partial class frmSatisYap : Form
    {
        public frmSatisYap()
        {
            InitializeComponent();
        }

        private void panelUrun_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMusteriIdAra.Text = "";
            txtMalId.Text = "";

        }

        Classlar.Sepet_Satis satis = new Classlar.Sepet_Satis();
        string telefon;
        private void txtMusteriIdAra_TextChanged(object sender, EventArgs e)
        {
            if(txtMusteriIdAra.Text=="")
            {
                foreach (Control item in this.panelMusteri.Controls) if (item is TextBox) item.Text = "";
            }
            SqlCommand cmd2 = new SqlCommand();
            satis.MusteriIDAra(cmd2, txtMusteriIdAra, txtAdSoyad, telefon, txtEmail);
        }

        private void Yenile()
        {
            satis.Sepet_Listele(dataGridView1, "select *from sepet");
            lblKayitSayisi.Text = "toplam " + (dataGridView1.Rows.Count - 1) + " kayıt listelendi";
            double tutar = 0;
            for(int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                tutar += double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyati"].Value.ToString());
                
            }
            lblToplamTutar.Text = tutar.ToString();


            double geneltutarkdv = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                double toplamfiyati = double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString());
                double kdv = double.Parse(dataGridView1.Rows[i].Cells["kdv"].Value.ToString());
                double kdvtutar = toplamfiyati * kdv/100;
                geneltutarkdv += kdvtutar;
            }
            lblKdv.Text = geneltutarkdv.ToString("C2");
        }
        private void txtMalId_TextChanged(object sender, EventArgs e)
        {
            if (txtMalId.Text == "")
            {
                foreach (Control item in this.panelMusteri.Controls) if (item is TextBox) item.Text = "";
                txtMiktar.Text = "1";
            }
            SqlCommand cmd2 = new SqlCommand();
            satis.MalIdAra(cmd2, txtMalId, txtMarka, txtUrun, txtBirimFiyat,txtKdv,txtToplamFiyat,txtMiktar);

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
           try
            {
                double toplamfiyat = double.Parse(txtMiktar.Text) * double.Parse(txtBirimFiyat.Text);
                txtToplamFiyat.Text = toplamfiyat.ToString("0.00");
            }
            catch
            {

            }
        }

        private void frmSatisYap_Load(object sender, EventArgs e)
        {
            satis.Sepet_Listele(dataGridView1, "select *from sepet");
            Yenile();
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sepet values('" + txtMusteriIdAra.Text + "','" + txtAdSoyad.Text + "','" + txtMarka.Text + "','" + txtUrun.Text + "',@BirimFiyati,'" + int.Parse(txtMiktar.Text) + "',@Toplamiyati,'" + int.Parse(txtKdv.Text) + "','" + double.Parse(txtMalId.Text) + "')";

            SqlCommand cmd2 = new SqlCommand();

            cmd2.Parameters.AddWithValue("@BirimFiyati", double.Parse(txtBirimFiyat.Text));
            cmd2.Parameters.AddWithValue("@ToplamFiyati", double.Parse(txtToplamFiyat.Text));
            satis.Sepet_Ekle(cmd2, sorgu2);
            satis.Sepet_Listele(dataGridView1, "select *from sepet");


        }

        private void txtOdenen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double tutar=0, odenen=0;
                tutar = double.Parse(lblToplamTutar.Text);
                odenen = double.Parse(txtParaUstu.Text);
                double paraustu = odenen-tutar;
                txtParaUstu.Text = paraustu.ToString("C2");
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)

            {
                string sorgu2 ="delete from sepet where id='"+dataGridView1.CurrentRow.Cells["Id"].Value.ToString()+"'";
                SqlCommand cmd2 = new SqlCommand();
                satis.Sepet_Ekle(cmd2, sorgu2);
                Yenile();
            }
            if (e.ColumnIndex == 1)

            {
                string sorgu2 = "update sepet set miktar=miktar+1 where id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'";
                SqlCommand cmd2 = new SqlCommand();
                satis.Sepet_Ekle(cmd2, sorgu2);
                string sorgu3 = "update sepet set toplamfiyati=birimfiyati*miktar where id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'";
                SqlCommand cmd3 = new SqlCommand();
                satis.Sepet_Ekle(cmd3, sorgu3);
                Yenile();
            }
            if (e.ColumnIndex == 0)

            {
                string sorgu2 = "update sepet set miktar=miktar-1 where id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'";
                SqlCommand cmd2 = new SqlCommand();
                satis.Sepet_Ekle(cmd2, sorgu2);
                string sorgu3 = "update sepet set toplamfiyati=birimfiyati*miktar where id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'";
                SqlCommand cmd3 = new SqlCommand();
                satis.Sepet_Ekle(cmd3, sorgu3);
                Yenile();
            }
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            string sorgu2 = "truncate from sepet";
            SqlCommand cmd2 = new SqlCommand();
            satis.Sepet_Ekle(cmd2, sorgu2);
            Yenile();
        }

        private void btnSatisOnay_Click(object sender, EventArgs e)
        {
            satis.Satisyap(dataGridView1);
        }

        private void frmSatisYap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F1)
            {
                comboOdeme.SelectedIndex = 0;
                txtOdenen.Focus();

            }
            if (e.KeyCode == Keys.F2)
            {
                comboOdeme.SelectedIndex = 1;
                txtOdenen.Text = lblToplamTutar.Text;
                txtParaUstu.Text = "0.00";
            }



        }
    }
}
