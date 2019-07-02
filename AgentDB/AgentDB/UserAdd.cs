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
    public partial class UserAdd : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }
        public UserAdd()
        {
            InitializeComponent();
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            try {
                User us = ctx.Users.FirstOrDefault(u => u.Username == textkullanıcıadı.Text);
                if (us != null)
                    throw new Exception("Aynı kullanıcı adı ile kullanıcı mevcut");

                us = new User();
                us.Name = textadı.Text;
                us.Surname = textsoyadı.Text;
                us.Email = textemail.Text;
                us.Phone = texttelno.Text;
                us.Username = textkullanıcıadı.Text;
                us.Password = textsifre.Text;
                us.StatusType = checkyonetici.Checked;
                us.Seller = false;

                ctx.Users.InsertOnSubmit(us);
                ctx.SubmitChanges();

                users srs = new users();
                srs.yonetici = yonetici;
                this.Hide();
                srs.Show();

            } catch(Exception ex) {

                MessageBox.Show(ex.Message, "Dikkat!!!");
            }
       
        }
    }
}
