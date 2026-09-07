using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace proje_.Formlar
{
    public partial class frmBizeUlasin : Form
    {
        public frmBizeUlasin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome","mdag3054@gmail.com");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome", "https://www.linkedin.com/in/mustafa-da%C4%9F-1a2743213/");


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome", "https://discord.gg/WRRhQVh3");

        }
    }
}
