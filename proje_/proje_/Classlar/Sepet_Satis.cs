using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_.Classlar
{
    public class Sepet_Satis
    {
        SqlConnection connection = new SqlConnection(Veritabanı.strbaglanti);

        public SqlDataReader MusteriIDAra(SqlCommand cmd,TextBox musteriid,TextBox adsoyad,string telefon,TextBox email)
        {
            string sorgu = "select *from musteri where Id='"+musteriid.Text+"'";
            cmd.CommandText = sorgu;
            cmd.Connection = connection;
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                adsoyad.Text = dr["adsoyad"].ToString();
                telefon = dr["telefon"].ToString();
                email.Text = dr["email"].ToString();
            }
            connection.Close();


            return dr;
        }

        public SqlDataReader MalIdAra(SqlCommand cmd,TextBox urunid,TextBox marka,TextBox urun,TextBox birimfiyati,TextBox miktari,TextBox toplamfiyati,TextBox kdv)
        {
            string sorgu = "select *from urun where Id='" + urunid.Text + "'";
            cmd.CommandText = sorgu;
            cmd.Connection = connection;
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                urunid.Text = dr["Id"].ToString();
                marka.Text = dr["marka"].ToString();
                urun.Text = dr["urun"].ToString();
                birimfiyati.Text = dr["satisfiyati"].ToString();
                miktari.Text = dr["kdv"].ToString();

                kdv.Text = dr["kdv"].ToString();
                double miktar = double.Parse(miktari.Text);
                double birimfiyat = double.Parse(birimfiyati.Text);
                double toplamfiyat = miktar * birimfiyat;
                toplamfiyati.Text = toplamfiyat.ToString("0.00");




            }
            connection.Close();


            return dr;
        }
        public DataTable Sepet_Listele(DataGridView dgrid, string sorgu)
        {
            DataTable tbl = new DataTable();

            tbl.Clear();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", connection);
            adtr.Fill(tbl);
            dgrid.DataSource = tbl;
            return tbl;
        }
        public int Sepet_Ekle(SqlCommand cmd, string sorgu)
        {
            int sonuc = 0;
            cmd.CommandText = sorgu;
            cmd.Connection = connection;
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            try
            {
                sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show("işlem başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return sonuc;

        }
        public void Satisyap(DataGridView dgrid)
        {
            try
            {
                for (int i = 0; i < dgrid.Rows.Count - 1; i++)
                {

                    int MusteriID = int.Parse(dgrid.Rows[i].Cells["MusteriID"].Value.ToString());
                    string adisoyadi = dgrid.Rows[i].Cells["adisoyadi"].Value.ToString();
                    string marka = dgrid.Rows[i].Cells["marka"].Value.ToString();
                    string urunad = dgrid.Rows[i].Cells["urunad"].Value.ToString();
                    double birimfiyati = double.Parse(dgrid.Rows[i].Cells["birimfiyati"].Value.ToString());
                    int miktari = int.Parse(dgrid.Rows[i].Cells["miktari"].Value.ToString());
                    double toplamfiyati = double.Parse(dgrid.Rows[i].Cells["toplamfiyati"].Value.ToString());
                    int kdv = int.Parse(dgrid.Rows[i].Cells["kdv"].Value.ToString());
                    int UrunID = int.Parse(dgrid.Rows[i].Cells["UrunID"].Value.ToString());






                    string sorgu = "insert into satis values('"+MusteriID+"','"+adisoyadi+"','"+UrunID+"','"+marka+"','"+urunad+"',@birimfiyati,'"+miktari+"',@toplamfiyati,'"+kdv+"',@tarih,@saat)";
                    SqlCommand cmd = new SqlCommand(sorgu, connection);

                    cmd.Parameters.AddWithValue("@birimfiyati", birimfiyati);
                    cmd.Parameters.AddWithValue("@toplamfiyati", toplamfiyati);
                    cmd.Parameters.AddWithValue("@tarih",DateTime.Parse(DateTime.Now.ToShortTimeString()));
                    cmd.Parameters.AddWithValue("@saat", DateTime.Parse(DateTime.Now.ToString()));


                    if (connection.State == System.Data.ConnectionState.Closed)
                        connection.Open();
                    cmd.ExecuteNonQuery();
                }

                SqlCommand cmd2 = new SqlCommand("delete from sepet", connection);
                cmd2.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("hata=" + ex.Message);

            }
            finally
            {
                connection.Close();

            }
        }
    }
}
