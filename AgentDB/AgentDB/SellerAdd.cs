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
    public partial class SellerAdd : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }
        public SellerAdd()
        {
            InitializeComponent();
        }

        private void SellerAdd_Load(object sender, EventArgs e)
        {

            comboAgenta.DisplayMember = "Name";
            comboAgenta.ValueMember = "RecId";
            comboAgenta.DataSource = ctx.Agents;

        }

        private void btngeri_Click(object sender, EventArgs e)
        {

            seller sel = new seller ();
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

        private void picSave_Click(object sender, EventArgs e)
        {
            try
            {
                User us = ctx.Users.FirstOrDefault(u => u.Username == textkullanıcıadı.Text);
                if (us != null)
                    throw new Exception("Aynı kullanıcı adı ile satıcı mevcut");

                us = new User();
                us.Name = textadı.Text;
                us.Surname = textsoyadı.Text;
                us.Email = textemail.Text;
                us.Phone = texttelno.Text;
                us.Username = textkullanıcıadı.Text;
                us.Password = textsifre.Text;
                us.Seller = true;

                ctx.Users.InsertOnSubmit(us);
                ctx.SubmitChanges();

                Seller sel = new Seller();
                sel.AgentID = (int)comboAgenta.SelectedValue;
                sel.UserID = us.RecId;

                ctx.Sellers.InsertOnSubmit(sel);
                ctx.SubmitChanges();

                seller satıcı = new seller();
                satıcı.yonetici = yonetici;
                this.Hide();
                satıcı.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat!!!");
            }

        }

       
    }
}
