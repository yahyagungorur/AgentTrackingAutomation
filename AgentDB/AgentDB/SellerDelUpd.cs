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
    public partial class SellerDelUpd : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }

        public SellerDelUpd()
        {
            InitializeComponent();
        }

        private void SellerDelUpd_Load(object sender, EventArgs e)
        {
            var tablo = from sl in ctx.Sellers
                        join ag in ctx.Agents
                        on sl.AgentID equals ag.RecId
                        join us in ctx.Users
                        on sl.UserID equals us.RecId
                        select new
                        {
                            sl.RecId,
                            us.Name,
                            us.Surname,
                            us.Phone,
                            us.Email,
                            us.Username,
                            us.Password,
                            AgentName = ag.Name,
                        };



            dataGridView1.DataSource = tablo;

            comboAgenta.DisplayMember = "Name";
            comboAgenta.ValueMember = "RecId";
            comboAgenta.DataSource = ctx.Agents;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {

            seller sel = new seller();
            sel.yonetici = yonetici;
            this.Hide();
            sel.Show();
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
                if (dataGridView1.CurrentRow == null) return;

                int id = (int)dataGridView1.CurrentRow.Cells["RecId"].Value;

                Seller seller = ctx.Sellers.SingleOrDefault(s => s.RecId == id);
                User us = ctx.Users.SingleOrDefault(u => u.RecId == seller.UserID);
                var inv = ctx.Invoices.Where(i => i.Seller == id);

                ctx.Invoices.DeleteAllOnSubmit(inv);
                ctx.Users.DeleteOnSubmit(us);
                ctx.Sellers.DeleteOnSubmit(seller);
                ctx.SubmitChanges();
                seller sel = new seller();
                sel.yonetici = yonetici;
                this.Hide();
                sel.Show();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            textadı.Text = row.Cells["Name"].Value.ToString();
            textsoyadı.Text = row.Cells["Surname"].Value.ToString();
            textemail.Text = row.Cells["Email"].Value.ToString();
            texttelno.Text = row.Cells["Phone"].Value.ToString();
            textkullanıcıadı.Text = row.Cells["Username"].Value.ToString();
            textsifre.Text = row.Cells["Password"].Value.ToString();
            comboAgenta.SelectedValue = row.Cells["AgentName"].Value.ToString();
            textadı.Tag = row.Cells["RecId"].Value;

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı değiştirmek istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idTag = (int)textadı.Tag;

                Seller seller = ctx.Sellers.SingleOrDefault(s => s.RecId == idTag);
                User us = ctx.Users.SingleOrDefault(u => u.RecId == seller.UserID);

                us.Name = textadı.Text;
                us.Surname = textsoyadı.Text;
                us.Email = textemail.Text;
                us.Phone = texttelno.Text;
                us.Username = textkullanıcıadı.Text;
                us.Password = textsifre.Text;
                us.Seller = true;

                seller.AgentID = (int)comboAgenta.SelectedValue;
                seller.UserID = us.RecId;

                ctx.SubmitChanges();
                seller sel = new seller();
                sel.yonetici = yonetici;
                this.Hide();
                sel.Show();

            }
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
                            sl.RecId,
                            us.Name,
                            us.Surname,
                            us.Phone,
                            us.Email,
                            us.Username,
                            us.Password,
                            AgentName = ag.Name,
                        };

            dataGridView1.DataSource = tablo.Where(s => s.Name.Contains(textboxara.Text));
        }
    }
}
