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
    public partial class FaturaDelUpd : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }
        public bool seller { get; set; }
        public FaturaDelUpd()
        {
            InitializeComponent();
        }

        private void FaturaDelUpd_Load(object sender, EventArgs e)
        {
            var tablo = from sl in ctx.Sellers
                        join ag in ctx.Agents
                        on sl.AgentID equals ag.RecId
                        join us in ctx.Users
                        on sl.UserID equals us.RecId
                        select new
                        {
                            sl.RecId,
                            Name = us.Name,
                            Surname = us.Surname,
                            Phone = us.Phone,
                            Email = us.Email,
                            AgentName = ag.Name,
                        };

            comboacenta.DisplayMember = "Name";
            comboacenta.ValueMember = "RecId";
            comboacenta.DataSource = ctx.Agents;


            combosatıcı.DisplayMember = "Name";
            combosatıcı.ValueMember = "RecId";
            combosatıcı.DataSource = tablo;

            var tablo2 = from inv in ctx.Invoices
                        join ag in ctx.Agents
                        on inv.CompanyName equals ag.RecId
                        join sel in ctx.Sellers
                        on inv.Seller equals sel.RecId
                        join us in ctx.Users
                        on sel.UserID equals us.RecId
                        select new
                        {
                            inv.RecId,
                            inv.InvoiceNumber,
                            AgentName = ag.Name,
                            SellerName = us.Name,
                            inv.Address,
                            inv.City,
                            inv.PostalCode,
                            inv.Date

                        };

            dataGridViewfatura.DataSource = tablo2;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {

            Faturalar fat = new Faturalar();
            fat.yonetici = yonetici;
            fat.seller = seller;
            this.Hide();
            fat.Show();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewfatura.CurrentRow == null) return;

                int id = (int)dataGridViewfatura.CurrentRow.Cells["RecId"].Value;

                Invoice inv = ctx.Invoices.SingleOrDefault(i => i.RecId == id);

                ctx.Invoices.DeleteOnSubmit(inv);
                ctx.SubmitChanges();

                Faturalar fat = new Faturalar();
                fat.yonetici = yonetici;
                fat.seller = seller;
                this.Hide();
                fat.Show();
            }
        }

        private void textboxara_TextChanged(object sender, EventArgs e)
        {
            var tablo2 = from inv in ctx.Invoices
                         join ag in ctx.Agents
                         on inv.CompanyName equals ag.RecId
                         join sel in ctx.Sellers
                         on inv.Seller equals sel.RecId
                         join us in ctx.Users
                         on sel.UserID equals us.RecId
                         select new
                         {
                             inv.RecId,
                             inv.InvoiceNumber,
                             AgentName = ag.Name,
                             SellerName = us.Name,
                             inv.Address,
                             inv.City,
                             inv.PostalCode,
                             inv.Date

                         };
            dataGridViewfatura.DataSource = tablo2.Where(i => i.SellerName.Contains(textboxara.Text) || i.AgentName.Contains(textboxara.Text));
        }
    }
}
