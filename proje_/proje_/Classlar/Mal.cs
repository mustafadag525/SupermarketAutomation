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
    public class Mal
    {
        SqlConnection connection = new SqlConnection(Veritabanı.strbaglanti);



        public void Telefonara(DataGridView grid,TextBox txtara)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where ID='" + txtara.Text + "'", connection);
            adtr.Fill(tbl);
            grid.DataSource = tbl;

            
        }

        public void MusteriAra(DataGridView grid, TextBox txtara)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteri where ID='" + txtara.Text + "'", connection);
            adtr.Fill(tbl);
            grid.DataSource = tbl;


        }

        public DataTable tbl = new DataTable();
        public DataTable Listele(DataGridView dgrid,string sorgu)
        {
            tbl.Clear();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from musteri", connection);
            adtr.Fill(tbl);
            dgrid.DataSource = tbl;
            return tbl;
        }



       public int Malekle_Genel(SqlCommand cmd,string sorgu,ComboBox marka,ComboBox urun,DateTimePicker dateUretim,DateTimePicker dateGelis,TextBox alisfiyat,TextBox satisfiyati,TextBox kdv,PictureBox resim)
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
            catch(Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return sonuc;
            
        }

        public int Malekle_Genel2(SqlCommand cmd, string sorgu)
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


    }
}
