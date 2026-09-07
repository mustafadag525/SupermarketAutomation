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
    public partial class frmKullanıcıListele : Form
    {
        public frmKullanıcıListele()
        {
            InitializeComponent();
        }

        private void frmKullanıcıListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tumTablolarDataset.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.tumTablolarDataset.Kullanici);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTelefonno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtKullanıcıadı.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            txtGorev.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();



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
                e.Graphics.DrawString("Kullanıcı Listesi", font, firca, 350, 75);
                e.Graphics.DrawLine(kalem, 50, 110, 770, 110);

                font = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString("Ad Soyad ", font, firca, 60, 118);
                e.Graphics.DrawString("Telefon", font, firca, 160, 118);
                e.Graphics.DrawString("Adres", font, firca, 300, 118);
                e.Graphics.DrawString("Email", font, firca, 440, 118);
                e.Graphics.DrawString("Görev", font, firca, 640, 118);
                e.Graphics.DrawLine(kalem, 50, 150, 770, 150);
                ////////////////////////////////////////////////////////
                e.Graphics.DrawString(txtAdsoyad.Text, font, firca, 80, 208);
                e.Graphics.DrawString(txtTelefonno.Text, font, firca, 150, 208);
                e.Graphics.DrawString(txtAdres.Text, font, firca, 290, 208);
                e.Graphics.DrawString(txtEmail.Text, font, firca, 420, 208);
                e.Graphics.DrawString(txtGorev.Text, font, firca, 620, 208);

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

        private void txtAdsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
