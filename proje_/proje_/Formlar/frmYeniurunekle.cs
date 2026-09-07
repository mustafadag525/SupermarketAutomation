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
    public partial class frmYeniurunekle : Form
    {
        public frmYeniurunekle()
        {
            InitializeComponent();
        }

        Classlar.Mal mal = new Classlar.Mal();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into TBLurun values('"+comboMarka.SelectedValue+"','"+txturun.Text+"')";
            SqlCommand cmd2 = new SqlCommand();
            mal.Malekle_Genel2(cmd2, sorgu2);
        }
    }
}
