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
    public partial class AgencyDelEdit : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }

        public AgencyDelEdit()
        {
            InitializeComponent();
        }

        private void AgencyDelEdit_Load(object sender, EventArgs e)
        {
            var tablo = from ag in ctx.Agents
                        join us in ctx.Users
                        on ag.UserId equals us.RecId
                        select new
                        {
                            ag.RecId,
                            ag.Name,
                            ag.Phone,
                            ag.Address,
                            ag.Email,
                            ag.StatusType,
                            UserName = us.Name,
                        };

            dataGridView1.DataSource = tablo;

            comboBoxkullanici.DisplayMember = "Name";
            comboBoxkullanici.ValueMember = "RecId";
            comboBoxkullanici.DataSource = ctx.Users;

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
            acenta ac = new acenta();
            ac.yonetici = yonetici;
            this.Hide();
            ac.Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz ?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow == null) return;

                int id = (int)dataGridView1.CurrentRow.Cells["RecId"].Value;
                Agent ag = ctx.Agents.SingleOrDefault(t => t.RecId == id);
                ctx.Agents.DeleteOnSubmit(ag);
                ctx.SubmitChanges();

                acenta ac = new acenta();
                ac.yonetici = yonetici;
                this.Hide();
                ac.Show();
            }  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            textadı.Text = row.Cells["Name"].Value.ToString();
            texttelno.Text = row.Cells["Phone"].Value.ToString();
            textadres.Text = row.Cells["Address"].Value.ToString();
            textemail.Text = row.Cells["Email"].Value.ToString();
            comboBoxkullanici.SelectedValue = row.Cells["RecId"].Value;
            checkBoxstatus.Checked = (Boolean)row.Cells["StatusType"].Value;
            textadı.Tag = row.Cells["RecId"].Value;
        }

        private void btnup_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bu kaydı değiştirmek istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idTag = (int)textadı.Tag;

                Agent agt = ctx.Agents.SingleOrDefault(ag => ag.RecId == idTag);

                agt.Name = textadı.Text;
                agt.Phone = texttelno.Text;
                agt.Address = textadres.Text;
                agt.Email = textemail.Text;
                agt.UserId = (int)comboBoxkullanici.SelectedValue;
                agt.StatusType = checkBoxstatus.Checked;

                ctx.SubmitChanges();

                acenta ac = new acenta();
                ac.yonetici = yonetici;
                this.Hide();
                ac.Show();

            }
        }
    }
}
