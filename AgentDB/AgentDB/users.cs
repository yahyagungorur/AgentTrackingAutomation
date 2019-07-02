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
    public partial class users : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }

        public users()
        {
            InitializeComponent();
        }

        private void users_Load(object sender, EventArgs e)
        {
            var tablo = from us in ctx.Users
                        where us.Seller == false
                        select new {
                            us.Name,
                            us.Surname,
                            us.Username,
                            us.Email,
                            us.Phone,
                            Admin = us.StatusType,
                            AgencyName =string.Join("," , us.Agents.Select(t=>t.Name))
                        };

            dataGridViewuser.DataSource = tablo;

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
            if(MessageBox.Show("Çıkmak istediğinizden emin misiniz ?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            UserAdd ua = new UserAdd();
            ua.yonetici = yonetici;
            this.Hide();
            ua.Show();
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            UserDelUpd udu = new UserDelUpd();
            udu.yonetici = yonetici;
            this.Hide();
            udu.Show();
        }

        private void textboxara_TextChanged(object sender, EventArgs e)
        {
            var tablo = from us in ctx.Users
                        where us.Seller == false
                        select new
                        {
                            us.Name,
                            us.Surname,
                            us.Username,
                            us.Email,
                            us.Phone,
                            Admin = us.StatusType,
                            AgencyName = string.Join(",", us.Agents.Select(t => t.Name))
                        };

            dataGridViewuser.DataSource = tablo.Where(u => u.Username.Contains(textboxara.Text));
        }
    }
}
