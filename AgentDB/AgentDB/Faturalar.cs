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
    public partial class Faturalar : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }
        public bool seller { get; set; }

        public Faturalar()
        {
            InitializeComponent();
        }

        private void Faturalar_Load(object sender, EventArgs e)
        {
            var tablo = from inv in ctx.Invoices
                        join ag in ctx.Agents
                        on inv.CompanyName equals ag.RecId
                        join sel in ctx.Sellers
                        on inv.Seller equals sel.RecId
                        join us in ctx.Users
                        on sel.UserID equals us.RecId
                        select new
                        {
                            inv.InvoiceNumber,
                            AgentName = ag.Name,
                            SellerName = us.Name,
                            inv.Address,
                            inv.City,
                            inv.PostalCode,
                            inv.Date

                        };

            dataGridViewfatura.DataSource = tablo;

        }


        private void btngeri_Click(object sender, EventArgs e)
        {

            Anasayfa ana = new Anasayfa();
            ana.yonetici = yonetici;
            ana.seller = seller;
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
            FaturaAdd fa = new FaturaAdd();
            fa.yonetici = yonetici;
            fa.seller = seller;
            this.Hide();
            fa.Show();
        }

        private void picedit_Click(object sender, EventArgs e)
        {
            FaturaDelUpd fdu = new FaturaDelUpd();
            fdu.yonetici = yonetici;
            fdu.seller = seller;
            this.Hide();
            fdu.Show();
        }

        private void textboxara_TextChanged(object sender, EventArgs e)
        {
            var tablo = from inv in ctx.Invoices
                        join ag in ctx.Agents
                        on inv.CompanyName equals ag.RecId
                        join sel in ctx.Sellers
                        on inv.Seller equals sel.RecId
                        join us in ctx.Users
                        on sel.UserID equals us.RecId
                        select new
                        {
                            inv.InvoiceNumber,
                            AgentName = ag.Name,
                            SellerName = us.Name,
                            inv.Address,
                            inv.City,
                            inv.PostalCode,
                            inv.Date

                        };
            dataGridViewfatura.DataSource = tablo.Where(i => i.SellerName.Contains(textboxara.Text) || i.AgentName.Contains(textboxara.Text));
        }
    }
}
