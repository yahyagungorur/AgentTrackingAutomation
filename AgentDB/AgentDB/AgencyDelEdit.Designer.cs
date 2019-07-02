namespace AgentDB
{
    partial class AgencyDelEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgencyDelEdit));
            this.btndel = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.checkBoxstatus = new System.Windows.Forms.CheckBox();
            this.comboBoxkullanici = new System.Windows.Forms.ComboBox();
            this.textadres = new System.Windows.Forms.TextBox();
            this.textadı = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.texttelno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnup = new System.Windows.Forms.Button();
            this.textboxara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.White;
            this.btndel.Image = global::AgentDB.Properties.Resources.del;
            this.btndel.Location = new System.Drawing.Point(704, 334);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(36, 30);
            this.btndel.TabIndex = 11;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btngeri
            // 
            this.btngeri.Image = ((System.Drawing.Image)(resources.GetObject("btngeri.Image")));
            this.btngeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngeri.Location = new System.Drawing.Point(12, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(66, 28);
            this.btngeri.TabIndex = 10;
            this.btngeri.Text = "Geri ";
            this.btngeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.Red;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnkapat.Location = new System.Drawing.Point(665, 12);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 28);
            this.btnkapat.TabIndex = 9;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // checkBoxstatus
            // 
            this.checkBoxstatus.AutoSize = true;
            this.checkBoxstatus.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxstatus.Location = new System.Drawing.Point(476, 79);
            this.checkBoxstatus.Name = "checkBoxstatus";
            this.checkBoxstatus.Size = new System.Drawing.Size(15, 14);
            this.checkBoxstatus.TabIndex = 24;
            this.checkBoxstatus.UseVisualStyleBackColor = false;
            // 
            // comboBoxkullanici
            // 
            this.comboBoxkullanici.FormattingEnabled = true;
            this.comboBoxkullanici.Location = new System.Drawing.Point(475, 39);
            this.comboBoxkullanici.Name = "comboBoxkullanici";
            this.comboBoxkullanici.Size = new System.Drawing.Size(121, 21);
            this.comboBoxkullanici.TabIndex = 23;
            // 
            // textadres
            // 
            this.textadres.Location = new System.Drawing.Point(234, 75);
            this.textadres.MaxLength = 50;
            this.textadres.Multiline = true;
            this.textadres.Name = "textadres";
            this.textadres.Size = new System.Drawing.Size(127, 20);
            this.textadres.TabIndex = 19;
            // 
            // textadı
            // 
            this.textadı.Location = new System.Drawing.Point(232, 5);
            this.textadı.MaxLength = 50;
            this.textadı.Name = "textadı";
            this.textadı.Size = new System.Drawing.Size(127, 20);
            this.textadı.TabIndex = 20;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(475, 5);
            this.textemail.MaxLength = 50;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(127, 20);
            this.textemail.TabIndex = 21;
            // 
            // texttelno
            // 
            this.texttelno.Location = new System.Drawing.Point(234, 40);
            this.texttelno.MaxLength = 11;
            this.texttelno.Name = "texttelno";
            this.texttelno.Size = new System.Drawing.Size(127, 20);
            this.texttelno.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(369, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Durum(Aktif) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(395, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Yönetici  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(414, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(171, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(139, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Telefon No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Acenta Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(671, 263);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.White;
            this.btnup.Image = global::AgentDB.Properties.Resources.up;
            this.btnup.Location = new System.Drawing.Point(704, 298);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(36, 30);
            this.btnup.TabIndex = 11;
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // textboxara
            // 
            this.textboxara.Location = new System.Drawing.Point(648, 78);
            this.textboxara.Name = "textboxara";
            this.textboxara.Size = new System.Drawing.Size(100, 20);
            this.textboxara.TabIndex = 27;
            this.textboxara.TextChanged += new System.EventHandler(this.textboxara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(562, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Acenta Ara : ";
            // 
            // AgencyDelEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgentDB.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(752, 376);
            this.Controls.Add(this.textboxara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxstatus);
            this.Controls.Add(this.comboBoxkullanici);
            this.Controls.Add(this.textadres);
            this.Controls.Add(this.textadı);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.texttelno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnkapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgencyDelEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgencyDelEdit";
            this.Load += new System.EventHandler(this.AgencyDelEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.CheckBox checkBoxstatus;
        private System.Windows.Forms.ComboBox comboBoxkullanici;
        private System.Windows.Forms.TextBox textadres;
        private System.Windows.Forms.TextBox textadı;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox texttelno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.TextBox textboxara;
        private System.Windows.Forms.Label label7;
    }
}