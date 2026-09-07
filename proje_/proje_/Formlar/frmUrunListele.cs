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
    public partial class frmUrunListele : Form
    {
        public frmUrunListele()
        {
            InitializeComponent();
        }
        
        gıdaDataSetTableAdapters.UrunTableAdapter ds = new gıdaDataSetTableAdapters.UrunTableAdapter();

        void Hesapla1()
        {
            double geneltutar = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                double miktar = double.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString());
                double alisfiyati = double.Parse(dataGridView1.Rows[i].Cells["alisfiyati"].Value.ToString());
                double tutar = miktar * alisfiyati;
                geneltutar += tutar;
            }
            lblToplamkayit.Text = "toplam maliyet=" + geneltutar.ToString("c2");
        }



        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gıdaDataSet.TBLModel' table. You can move, or remove it, as needed.
            this.tBLModelTableAdapter.Fill(this.gıdaDataSet.TBLModel);
            // TODO: This line of code loads data into the 'gıdaDataSet.TBLMarka' table. You can move, or remove it, as needed.
            this.tBLMarkaTableAdapter.Fill(this.gıdaDataSet.TBLMarka);
            dataGridView1.DataSource = ds.listele2();
            KayitSayisi();
           
           

        }
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblYenimarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblYeniurun.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAlisfiyati.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtsatisfiyati.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtkdv.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtMiktar.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();



        }
        void KayitSayisi()
        {
            lbltoplammaliyet.Text = "Toplam " + (dataGridView1.Rows.Count - 1) + " kayıt listelendi";
        }




        private void btnResimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
        }

        private void btnMarkamodelGuncelle_Click(object sender, EventArgs e)
        {
            lblYenimarka.Text = comboMarka.Text;
            lblYeniurun.Text = comboUrunadi.Text;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Classlar.Mal mal = new Classlar.Mal();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update urun set marka='" + lblYenimarka.Text + "',model='" + lblYeniurun.Text + "',alisfiyati='" + double.Parse(txtAlisfiyati.Text) + "',satisfiyati='" + double.Parse(txtsatisfiyati.Text) + "',miktar='" + double.Parse(txtMiktar.Text) + "' where ID='" + txtID.Text + "'";
            SqlCommand cmd2 = new SqlCommand();
            mal.Malekle_Genel2(cmd2, sorgu2);

            dataGridView1.DataSource = ds.listele2();
            
            KayitSayisi();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu2 = "delete from urun where ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
            SqlCommand cmd2 = new SqlCommand();
            mal.Malekle_Genel2(cmd2, sorgu2);

            dataGridView1.DataSource = ds.listele2();
            
            KayitSayisi();
        }

        private void txtTelefonara_TextChanged(object sender, EventArgs e)
        {
            mal.Telefonara(dataGridView1, txtTelefonara);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
