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
    public partial class seller : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }

        public seller()
        {
            InitializeComponent();
        }

        private void seller_Load(object sender, EventArgs e)
        {

            var tablo = from sl in ctx.Sellers
                        join ag in ctx.Agents
                        on sl.AgentID equals ag.RecId
                        join us in ctx.Users
                        on sl.UserID equals us.RecId
                        select new {
                            Name = us.Name,
                            Surname = us.Surname,
                            Phone = us.Phone,
                            Email = us.Email,
                            AgentName = ag.Name,
                        };



            dataGridViewsatıcı.DataSource = tablo;
        }
        private void btngeri_Click(object sender, EventArgs e)
        {

            Anasayfa ana = new Anasayfa();
            ana.yonetici = yonetici;
            this.Hide();
            ana.Show();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picadd_Click(object sender, EventArgs e)
        {
            SellerAdd sa = new SellerAdd();
            sa.yonetici = yonetici;
            this.Hide();
            sa.Show();
        }

        private void picedit_Click(object sender, EventArgs e)
        {
            SellerDelUpd sdu = new SellerDelUpd();
            sdu.yonetici = yonetici;
            this.Hide();
            sdu.Show();
        }

        private void textboxara_TextChanged(object sender, EventArgs e)
        {

            var tablo = from sl in ctx.Sellers
                        join ag in ctx.Agents
                        on sl.AgentID equals ag.RecId
                        join us in ctx.Users
                        on sl.UserID equals us.RecId
                        select new
                        {
                            Name = us.Name,
                            Surname = us.Surname,
                            Phone = us.Phone,
                            Email = us.Email,
                            AgentName = ag.Name,
                        };

            dataGridViewsatıcı.DataSource = tablo.Where(s => s.Name.Contains(textboxara.Text));
        }
    }
}
