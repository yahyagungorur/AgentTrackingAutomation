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
    public partial class Faturalar : Form
    {
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public bool yonetici { get; set; }

        public Faturalar()
        {
            InitializeComponent();
        }

        private void Faturalar_Load(object sender, EventArgs e)
        {
            dataGridViewfatura.DataSource = ctx.Invoices;
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
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
