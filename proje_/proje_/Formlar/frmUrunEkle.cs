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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sondataset.TBLModel' table. You can move, or remove it, as needed.
            this.tBLModelTableAdapter2.Fill(this.sondataset.TBLModel);
            // TODO: This line of code loads data into the 'sondataset.TBLMarka' table. You can move, or remove it, as needed.
            this.tBLMarkaTableAdapter2.Fill(this.sondataset.TBLMarka);
            // TODO: This line of code loads data into the 'tumTablolarDataset.TBLMarka' table. You can move, or remove it, as needed.
            this.tBLMarkaTableAdapter1.Fill(this.tumTablolarDataset.TBLMarka);
            // TODO: This line of code loads data into the 'tumTablolarDataset.TBLModel' table. You can move, or remove it, as needed.
            this.tBLModelTableAdapter1.Fill(this.tumTablolarDataset.TBLModel);
            // TODO: This line of code loads data into the 'tumTablolarDataset.Urun' table. You can move, or remove it, as needed.
            this.urunTableAdapter1.Fill(this.tumTablolarDataset.Urun);
            // TODO: This line of code loads data into the 'gıdaDataSet.Urun' table. You can move, or remove it, as needed.
            this.urunTableAdapter.listele(this.gıdaDataSet.Urun);
            // TODO: This line of code loads data into the 'gıdaDataSet.TBLModel' table. You can move, or remove it, as needed.
            this.tBLModelTableAdapter.Fill(this.gıdaDataSet.TBLModel);
            // TODO: This line of code loads data into the 'gıdaDataSet.TBLMarka' table. You can move, or remove it, as needed.
            this.tBLMarkaTableAdapter.Fill(this.gıdaDataSet.TBLMarka);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
        }

        Classlar.Mal mal = new Classlar.Mal();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            string sorgu2 = "insert into urun values('"+comboMarka+"','"+comboUrunadi+"',@uretimtarihi,@alistarihi,@alisfiyati,@satisfiyati,'"+int.Parse(txtkdv.Text)+"','"+pictureBox1.ImageLocation+"','"+int.Parse(txtMiktar.Text)+"')";
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Parameters.AddWithValue("@uretimtarihi", dateUretim.Value);
            cmd2.Parameters.AddWithValue("@alistarihi", dateGelis.Value);
            cmd2.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlisfiyati.Text));
            cmd2.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsatisfiyati.Text));
            mal.Malekle_Genel(cmd2, sorgu2, comboMarka, comboUrunadi, dateUretim, dateGelis, txtAlisfiyati, txtsatisfiyati, txtkdv, pictureBox1);


        }
    }
}
