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
    public partial class agencyaddedit : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }

        public agencyaddedit()
        {
            InitializeComponent();
        }

        private void agencyaddedit_Load(object sender, EventArgs e)
        {
            comboBoxkullanici.DisplayMember = "Name";
            comboBoxkullanici.ValueMember = "RecId";
            comboBoxkullanici.DataSource = ctx.Users.Where(u=>u.Seller == false);

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

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                Agent ag = ctx.Agents.FirstOrDefault(a => a.Name == textadı.Text);

                if (ag != null)
                    throw new Exception("Aynı isimde acenta mevcut");
                            
                ag = new Agent();
                ag.Name = textadı.Text;
                ag.Phone = texttelno.Text;
                ag.Address = textadres.Text;
                ag.Email = textemail.Text;
                ag.UserId = (int)comboBoxkullanici.SelectedValue;
                ag.StatusType = true;

                ctx.Agents.InsertOnSubmit(ag);
                ctx.SubmitChanges();

                acenta ac = new acenta();
                ac.yonetici = yonetici;
                this.Hide();
                ac.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Dikkat!!!");
            }
        }
    }
}
