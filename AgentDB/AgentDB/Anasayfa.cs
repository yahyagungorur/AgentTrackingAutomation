using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentDB
{
    public partial class Anasayfa : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }
        public bool seller { get; set; }

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Dikkat ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Giris grs = new Giris();
                this.Hide();
                grs.k = 1;
                grs.Show();
            }
        }

        private void btnacenta_Click(object sender, EventArgs e)
        {
            acenta ace = new acenta();
            ace.yonetici = yonetici;
            this.Hide();
            ace.Show();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            users us = new users();
            us.yonetici = yonetici;
            this.Hide();
            us.Show();
        }

        private void btnseller_Click(object sender, EventArgs e)
        {
            seller slr = new seller();
            slr.yonetici = yonetici;
            this.Hide();
            slr.Show();
        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            Faturalar fat = new Faturalar();
            fat.yonetici = yonetici;
            fat.seller = seller;
            this.Hide();
            fat.Show();
        }

   

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            btnuser.Visible = false;
            btnacenta.Visible = false;
            if (yonetici == true)
            {
                btnuser.Visible = true;
                btnacenta.Visible = true;
            }

            if (seller == true)
            {
                btnacenta.Visible = false;
                btnuser.Visible = false;
                btnseller.Visible = false;
            }
        }
    }
}
