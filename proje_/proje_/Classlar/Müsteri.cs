using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_.Classlar
{
    internal class Müsteri
    {
        SqlConnection connection = new SqlConnection(Veritabanı.strbaglanti);

        private String adSoyad;
        private String telefon_no;
        private String email;
        private String adres;

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string Telefon_no { get => telefon_no; set => telefon_no = value; }
        public string Email { get => email; set => email = value; }
        public string Adres { get => adres; set => adres = value; }


        public void YeniMusteri(string AdSoyad, string Telefon_no, string Email, string Adres)
        {
            adSoyad = AdSoyad;
            telefon_no = Telefon_no;
            adres = Adres;
            email = Email;



            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into musteri values('"+adSoyad+"','"+telefon_no+"','"+email+"','"+adres+"')", connection);
            cmd.ExecuteNonQuery(); //dml işlemleri için kullandım update ,insert ...
            connection.Close();
            MessageBox.Show("Yeni bir müşteri eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
