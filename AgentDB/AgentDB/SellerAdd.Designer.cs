namespace AgentDB
{
    partial class SellerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerAdd));
            this.btngeri = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboAgenta = new System.Windows.Forms.ComboBox();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.textkullanıcıadı = new System.Windows.Forms.TextBox();
            this.texttelno = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textsoyadı = new System.Windows.Forms.TextBox();
            this.textadı = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngeri.Image = ((System.Drawing.Image)(resources.GetObject("btngeri.Image")));
            this.btngeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngeri.Location = new System.Drawing.Point(12, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(66, 28);
            this.btngeri.TabIndex = 9;
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
            this.btnkapat.TabIndex = 8;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // picSave
            // 
            this.picSave.BackColor = System.Drawing.Color.Transparent;
            this.picSave.Image = ((System.Drawing.Image)(resources.GetObject("picSave.Image")));
            this.picSave.Location = new System.Drawing.Point(699, 323);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(41, 41);
            this.picSave.TabIndex = 26;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(440, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Acenta :";
            // 
            // comboAgenta
            // 
            this.comboAgenta.FormattingEnabled = true;
            this.comboAgenta.Location = new System.Drawing.Point(511, 288);
            this.comboAgenta.Name = "comboAgenta";
            this.comboAgenta.Size = new System.Drawing.Size(121, 21);
            this.comboAgenta.TabIndex = 27;
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(511, 228);
            this.textsifre.MaxLength = 50;
            this.textsifre.Name = "textsifre";
            this.textsifre.PasswordChar = '*';
            this.textsifre.Size = new System.Drawing.Size(100, 20);
            this.textsifre.TabIndex = 35;
            // 
            // textkullanıcıadı
            // 
            this.textkullanıcıadı.Location = new System.Drawing.Point(511, 154);
            this.textkullanıcıadı.MaxLength = 50;
            this.textkullanıcıadı.Name = "textkullanıcıadı";
            this.textkullanıcıadı.Size = new System.Drawing.Size(100, 20);
            this.textkullanıcıadı.TabIndex = 36;
            // 
            // texttelno
            // 
            this.texttelno.Location = new System.Drawing.Point(511, 78);
            this.texttelno.MaxLength = 11;
            this.texttelno.Name = "texttelno";
            this.texttelno.Size = new System.Drawing.Size(100, 20);
            this.texttelno.TabIndex = 37;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(224, 228);
            this.textemail.MaxLength = 50;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(100, 20);
            this.textemail.TabIndex = 38;
            // 
            // textsoyadı
            // 
            this.textsoyadı.Location = new System.Drawing.Point(224, 154);
            this.textsoyadı.MaxLength = 50;
            this.textsoyadı.Name = "textsoyadı";
            this.textsoyadı.Size = new System.Drawing.Size(100, 20);
            this.textsoyadı.TabIndex = 39;
            // 
            // textadı
            // 
            this.textadı.Location = new System.Drawing.Point(224, 78);
            this.textadı.MaxLength = 50;
            this.textadı.Name = "textadı";
            this.textadı.Size = new System.Drawing.Size(100, 20);
            this.textadı.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(454, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(404, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kullanıcı Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(408, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Telefon No  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(167, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(141, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Soyisim :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(167, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "İsim  :";
            // 
            // SellerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 376);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.textkullanıcıadı);
            this.Controls.Add(this.texttelno);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textsoyadı);
            this.Controls.Add(this.textadı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboAgenta);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnkapat);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "SellerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerAdd";
            this.Load += new System.EventHandler(this.SellerAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboAgenta;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.TextBox textkullanıcıadı;
        private System.Windows.Forms.TextBox texttelno;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textsoyadı;
        private System.Windows.Forms.TextBox textadı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}