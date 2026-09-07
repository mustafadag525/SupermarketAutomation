using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proje_.Classlar
{
    public class Kullanici
    {
        
        SqlConnection connection = new SqlConnection(Veritabanı.strbaglanti);

        private String adSoyad;
        private String kullaniciadi;
        private String telefon_no;
        private String email;
        private String adres;
        private String parola;
        private String gorev;
        private String resim;

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string Kullaniciadi { get => kullaniciadi; set => kullaniciadi = value; }
        public string Telefon_no { get => telefon_no; set => telefon_no = value; }
        public string Email { get => email; set => email = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Parola { get => parola; set => parola = value; }





        public void KullaniciLogin(TextBox txtParola, TextBox txtKullanıcıAdı)
        {
            if(txtKullanıcıAdı.Text=="" || txtParola.Text=="")
            {
                MessageBox.Show("kullanıcı adı veya parola boş bırakılmaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select *from kullanici where kullaniciadi='"+txtKullanıcıAdı.Text+"' and parola='"+txtParola.Text+"'",connection);
                SqlDataReader dr = cmd.ExecuteReader(); //birden fazla sonuç dönderme
                if(dr.Read())
                {
                    formAnaSayfa anaSayfa = new formAnaSayfa();
                    frmKullanıcıGiris.ActiveForm.Visible = false;

                    anaSayfa.Show();
                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya parolayı kontrol ediniz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connection.Close();
            }
        }


        public void YeniKullanici(string _adsoyad,string _telno,string _adres,string _email, string _kullaniciadi,string _parola, string _parolatekrar,string _gorev,string _resim)
        {
            AdSoyad = _adsoyad;
            Telefon_no = _telno;
            Adres = _adres;
            Email = _email;
            Kullaniciadi = _kullaniciadi;
            Parola = _parola;
            gorev = _gorev;
            resim = _resim;
           
            if(parola==_parolatekrar)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into kullanici values('" + AdSoyad + "','" + Telefon_no + "','" + Adres + "','" + Email + "','" + Kullaniciadi + "','" + Parola + "','" + gorev + "','" + resim + "')", connection);
                cmd.ExecuteNonQuery();// veri tabanı nesne oluşturma
                connection.Close();
                MessageBox.Show("yeni kullanıcı eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("şifreler uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }
}
