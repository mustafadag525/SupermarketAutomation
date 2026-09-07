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
    public partial class frmKullanıcıGiris : Form
    {
        public frmKullanıcıGiris()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //checkbox.CheckState==CheckeStake.Checked
            {
                txtParola.UseSystemPasswordChar = true;
                checkBox1.Text = "Hide";
            }
            else if (!checkBox1.Checked) //checkbox.CheckState==CheckeStake.UnChecked 2.yol
            {
                txtParola.UseSystemPasswordChar = false;
                checkBox1.Text = "Show";
            }
        }

        private void lblYeniKullanıcı_Click(object sender, EventArgs e)
        {
            frmYeniKullanıcı yk = new frmYeniKullanıcı();
            yk.ShowDialog();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Classlar.Kullanici k = new Classlar.Kullanici();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            k.KullaniciLogin(txtParola, txtKullanıcıAdı);
        }

        private void frmKullanıcıGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
