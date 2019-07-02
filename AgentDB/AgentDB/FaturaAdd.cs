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
    public partial class FaturaAdd : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }
        public bool seller { get; set; }
        public FaturaAdd()
        {
            InitializeComponent();
        }

        private void FaturaAdd_Load(object sender, EventArgs e)
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

        private void picSave_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            Invoice inv = new Invoice();

            inv.CompanyName = (int)comboacenta.SelectedValue;
            inv.Address = textaddress.Text;
            inv.City = textsehir.Text;
            inv.PostalCode = Convert.ToInt32(textposta.Text);
            inv.Seller = (int)combosatıcı.SelectedValue;
            inv.Date = DateTime.Today;
            inv.InvoiceNumber = rastgele.Next(1905, 5000);

            ctx.Invoices.InsertOnSubmit(inv);
            ctx.SubmitChanges();

            Faturalar fat = new Faturalar();
            fat.yonetici = yonetici;
            fat.seller = seller;
            this.Hide();
            fat.Show();

        }

        
    }
}
