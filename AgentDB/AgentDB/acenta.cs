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
    public partial class acenta : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }
        public acenta()
        {
            InitializeComponent();
        }

        private void acenta_Load(object sender, EventArgs e)
        {
            var tablo = from ag in ctx.Agents
                        join us in ctx.Users
                        on ag.UserId equals us.RecId
                        select new
                        {
      
                            ag.Name,
                            ag.Phone,
                            ag.Address,
                            ag.Email,
                            ag.StatusType,
                            ManagerName = us.Name,
                        };

            dataGridViewacenta.DataSource = tablo;

            if(yonetici == true)
            {
                picadd.Visible = true;
                picedit.Visible = true;
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istediğinizden emin misiniz ?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {

            Anasayfa ana = new Anasayfa();
            ana.yonetici = yonetici;
            this.Hide();
            ana.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            agencyaddedit ag = new agencyaddedit();
            ag.yonetici = yonetici;
            this.Hide();
            ag.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            AgencyDelEdit ade = new AgencyDelEdit();
            ade.yonetici = yonetici;
            this.Hide();
            ade.Show();
        }

        private void textboxara_TextChanged(object sender, EventArgs e)
        {
            var tablo = from ag in ctx.Agents
                        join us in ctx.Users
                        on ag.UserId equals us.RecId
                        select new
                        {
                            ag.Name,
                            ag.Phone,
                            ag.Address,
                            ag.Email,
                            ag.StatusType,
                            ManagerName = us.Name,
                        };

            dataGridViewacenta.DataSource = tablo.Where(a => a.Name.Contains(textboxara.Text));
        }
    }
}
