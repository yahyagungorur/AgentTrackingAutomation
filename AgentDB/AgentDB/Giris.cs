    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace AgentDB
{
    public partial class Giris : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public int k { get; set; }
       
        public Giris()
        {
            k = 0;
            InitializeComponent();
          
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            login();
        }

        private void textusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void textpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }


        private void btnkapat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void login()
        {
            User user = ctx.Users.FirstOrDefault(u => u.Username == textusername.Text && u.Password == textpassword.Text);
            if (user != null)
            {
                UserManagement.user = user;
                bool type = user.StatusType;
                bool seller = (Boolean)user.Seller;
                Anasayfa ana = new Anasayfa();
                ana.yonetici = type;
                ana.seller = seller;
                this.Hide();
                ana.Show();

            }
            else
            {
                label5.Text = "Bilgiler Yanlış !";
                textpassword.Text = "";
            }
        }


        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void Splash()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(2500);
            t.Abort();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            if(k == 0)
                Splash();
        }
    }
}
