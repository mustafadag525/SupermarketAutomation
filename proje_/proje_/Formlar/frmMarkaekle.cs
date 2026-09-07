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
    public partial class frmMarkaekle : Form
    {
        public frmMarkaekle()
        {
            InitializeComponent();
        }
        Classlar.Mal mal = new Classlar.Mal();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into TBLmarka values('"+txtmarkaekle.Text+"')";
            SqlCommand cmd2 = new SqlCommand();
            mal.Malekle_Genel2(cmd2, sorgu2);

            
        }
    }
}
