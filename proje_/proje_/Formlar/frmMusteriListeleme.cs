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
    public partial class frmMusteriListeleme : Form
    {
        public frmMusteriListeleme()
        {
            InitializeComponent();
        }

        Classlar.Mal mal = new Classlar.Mal();
        private void frmMusteriListeleme_Load(object sender, EventArgs e)
        {
            mal.Listele(dataGridView1, "select *from musteri");
            txtId.DataBindings.Add("text", mal.tbl, "id");//Veri bağlama kavramı oldukça basittir; Bir nesnede bulunan verileri görsel bir kontrole 'bağlamanıza' izin verir
            txtAdsoyad.DataBindings.Add("text", mal.tbl, "adsoyad");
            txtTelefon.DataBindings.Add("text", mal.tbl, "telefon");
            txtEmail.DataBindings.Add("text", mal.tbl, "email");
            txtAdres.DataBindings.Add("text", mal.tbl, "adres");
            KayitSayisi();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

             txtAdsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
             txtTelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
             txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
             txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();*/

        }

        void KayitSayisi()
        {
            lblToplamkayıt.Text = "Toplam " + (dataGridView1.Rows.Count - 1) + " kayıt listelendi";
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update musteri set adsoyad='"+txtAdsoyad.Text+"',telefon='"+txtTelefon.Text+"',email='"+txtEmail.Text+"',adres='"+txtAdres.Text+"' where Id='"+txtId.Text+"'";
            SqlCommand cmd2 = new SqlCommand();
            mal.Malekle_Genel2(cmd2, sorgu2);
            mal.Listele(dataGridView1, "select *from musteri");

            foreach(Control item in this.Controls)

            {
                if (item is TextBox) item.Text = "";
                if (item is MaskedTextBox) item.Text = "";
            }
            KayitSayisi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu2 = "delete from musteri where Id='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'";
            SqlCommand cmd2 = new SqlCommand();
            mal.Malekle_Genel2(cmd2, sorgu2);
            mal.Listele(dataGridView1, "select *from musteri");

            foreach (Control item in this.Controls)

            {
                if (item is TextBox) item.Text = "";
                if (item is MaskedTextBox) item.Text = "";
            }
            KayitSayisi();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            mal.MusteriAra(dataGridView1, txtAra);


            KayitSayisi();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int satirsayisi = 0;
            try
            {
                Font font = new Font("Arial", 20);
                SolidBrush firca = new SolidBrush(Color.Black);
                Pen kalem = new Pen(Color.Black);

                e.Graphics.DrawString("Düzenlenme Tarihi: " + DateTime.Now.ToLongDateString() + " " +
                        "" + DateTime.Now.ToLongTimeString(), font, firca, 50, 25);
                e.Graphics.DrawLine(kalem, 50, 65, 770, 65);
                e.Graphics.DrawLine(kalem, 50, 1000, 50, 65);

                e.Graphics.DrawLine(kalem, 50, 1000, 770, 1000);
                e.Graphics.DrawLine(kalem, 770, 1000, 770, 65);
                ////////////////////////////////////////////////////
                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString("Müşteri Listesi", font, firca, 350, 75);
                e.Graphics.DrawLine(kalem, 50, 110, 770, 110);

                font = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString("İD ", font, firca, 60, 118);
                e.Graphics.DrawString("Ad Soyad", font, firca, 130, 118);
                e.Graphics.DrawString("Telefon", font, firca, 270, 118);
                e.Graphics.DrawString("Email", font, firca, 410, 118);
                e.Graphics.DrawString("Adres", font, firca, 600, 118);
                e.Graphics.DrawLine(kalem, 50, 150, 770, 150);
                ////////////////////////////////////////////////////////
                e.Graphics.DrawString( txtId.Text ,font, firca, 60, 208);
                e.Graphics.DrawString( txtAdsoyad.Text , font, firca, 130, 208);
                e.Graphics.DrawString(txtTelefon.Text, font, firca, 270, 208);
                e.Graphics.DrawString( txtEmail.Text , font, firca, 400, 208);
                e.Graphics.DrawString( txtAdres.Text , font, firca, 600, 208);

                /////////////////////////////////////////////////////////
                int y = 160;

                font = new Font("Arial", 15);
                int i = 0;
                while (i <= dataGridView1.Rows.Count - 2)
                {
                    e.Graphics.DrawString((i + 1) + ".", font, firca, 60, y);
                    e.Graphics.DrawString(dataGridView1[7, i].Value.ToString(), font, firca, 130, y);
                    e.Graphics.DrawString(dataGridView1[9, i].Value.ToString(), font, firca, 250, y);
                    e.Graphics.DrawString(dataGridView1[11, i].Value.ToString(), font, firca, 360, y);
                    e.Graphics.DrawString(dataGridView1[12, i].Value.ToString(), font, firca, 510, y);
                    e.Graphics.DrawString(dataGridView1[13, i].Value.ToString(), font, firca, 620, y);
                    y = y + 25;
                    i = i + 1;

                    if (y > 1000)
                    {
                        e.Graphics.DrawString("Devamı Diğer Sayfada---->", font, firca, 700, y + 50);
                        y = 50;
                        break;

                    }
                }
                if (i < satirsayisi)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                    i = 0;
                }


                StringFormat strformat = new StringFormat();
                strformat.Alignment = StringAlignment.Far;
                return;

            }
            catch
            {
                ;

            }


        }

        private void btnExcelaktar_Click(object sender, EventArgs e)
        {


            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                range.Value2 = dataGridView1.Columns[i].HeaderText;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range range1 = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    range.Value2 = dataGridView1[i, j].Value;
                }
            }

        }
    }
}
