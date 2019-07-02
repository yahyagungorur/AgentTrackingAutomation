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
    public partial class UserDelUpd : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }
        public UserDelUpd()
        {
            InitializeComponent();
        }

        private void UserDelUpd_Load(object sender, EventArgs e)
        {
            var tablo = from us in ctx.Users
                        where us.Seller == false
                        select new
                        {
                            us.RecId,
                            us.Name,
                            us.Surname,
                            us.Username,
                            us.Password,
                            us.Email,
                            us.Phone,
                            Admin = us.StatusType,
                            AgentaAdı = string.Join(" / ", us.Agents.Select(t => t.Name))
                        };

            dataGridView1.DataSource = tablo;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            users us = new users();
            us.yonetici = yonetici;
            this.Hide();
            us.Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow == null) return;
                int id = (int)dataGridView1.CurrentRow.Cells["RecId"].Value;
                User us = ctx.Users.SingleOrDefault(u => u.RecId == id);
                var acenta = ctx.Agents.Where(t => t.UserId == id);
                var satıcı = ctx.Sellers.Where(s => s.UserID == id);

                ctx.Users.DeleteOnSubmit(us);

                if(acenta != null)
                    ctx.Agents.DeleteAllOnSubmit(acenta);

                if (satıcı != null)
                    ctx.Sellers.DeleteAllOnSubmit(satıcı);

                ctx.SubmitChanges();

                users users = new users();
                users.yonetici = yonetici;
                this.Hide();
                users.Show();
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
            checkyonetici.Checked = (Boolean)row.Cells["Admin"].Value;
            textadı.Tag = row.Cells["RecId"].Value;

        }

        private void btnup_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bu kaydı değiştirmek istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idTag = (int)textadı.Tag;

                User us = ctx.Users.SingleOrDefault(u => u.RecId == idTag);

                us.Name = textadı.Text;
                us.Surname = textsoyadı.Text;
                us.Email = textemail.Text;
                us.Phone = texttelno.Text;
                us.Username = textkullanıcıadı.Text;
                us.Password = textsifre.Text;
                us.StatusType = checkyonetici.Checked;

                ctx.SubmitChanges();

                users users = new users();
                users.yonetici = yonetici;
                this.Hide();
                users.Show();
            }
        }

        private void textboxara_TextChanged(object sender, EventArgs e)
        {
            var tablo = from us in ctx.Users
                        where us.Seller == false
                        select new
                        {
                            us.RecId,
                            us.Name,
                            us.Surname,
                            us.Username,
                            us.Password,
                            us.Email,
                            us.Phone,
                            Admin = us.StatusType,
                            AgentaAdı = string.Join(" / ", us.Agents.Select(t => t.Name))
                        };

            dataGridView1.DataSource = tablo.Where(u => u.Username.Contains(textboxara.Text));

        }
    }
}
