namespace AgentDB
{
    partial class agencyaddedit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agencyaddedit));
            this.btnsave = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texttelno = new System.Windows.Forms.TextBox();
            this.textadres = new System.Windows.Forms.TextBox();
            this.textadı = new System.Windows.Forms.TextBox();
            this.comboBoxkullanici = new System.Windows.Forms.ComboBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxstatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.White;
            this.btnsave.Image = global::AgentDB.Properties.Resources.save;
            this.btnsave.Location = new System.Drawing.Point(685, 317);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(51, 47);
            this.btnsave.TabIndex = 8;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btngeri
            // 
            this.btngeri.Image = ((System.Drawing.Image)(resources.GetObject("btngeri.Image")));
            this.btngeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngeri.Location = new System.Drawing.Point(8, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(66, 28);
            this.btngeri.TabIndex = 7;
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
            this.btnkapat.Location = new System.Drawing.Point(661, 12);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 28);
            this.btnkapat.TabIndex = 6;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Acenta Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefon No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(62, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(384, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(365, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kullanıcı :";
            // 
            // texttelno
            // 
            this.texttelno.Location = new System.Drawing.Point(125, 162);
            this.texttelno.MaxLength = 11;
            this.texttelno.Name = "texttelno";
            this.texttelno.Size = new System.Drawing.Size(127, 20);
            this.texttelno.TabIndex = 10;
            // 
            // textadres
            // 
            this.textadres.Location = new System.Drawing.Point(125, 223);
            this.textadres.MaxLength = 50;
            this.textadres.Multiline = true;
            this.textadres.Name = "textadres";
            this.textadres.Size = new System.Drawing.Size(127, 20);
            this.textadres.TabIndex = 10;
            // 
            // textadı
            // 
            this.textadı.Location = new System.Drawing.Point(125, 93);
            this.textadı.MaxLength = 50;
            this.textadı.Name = "textadı";
            this.textadı.Size = new System.Drawing.Size(127, 20);
            this.textadı.TabIndex = 10;
            // 
            // comboBoxkullanici
            // 
            this.comboBoxkullanici.FormattingEnabled = true;
            this.comboBoxkullanici.Location = new System.Drawing.Point(445, 165);
            this.comboBoxkullanici.Name = "comboBoxkullanici";
            this.comboBoxkullanici.Size = new System.Drawing.Size(121, 21);
            this.comboBoxkullanici.TabIndex = 11;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(445, 97);
            this.textemail.MaxLength = 50;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(127, 20);
            this.textemail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(339, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Durum(Aktif) :";
            // 
            // checkBoxstatus
            // 
            this.checkBoxstatus.AutoSize = true;
            this.checkBoxstatus.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxstatus.Location = new System.Drawing.Point(446, 227);
            this.checkBoxstatus.Name = "checkBoxstatus";
            this.checkBoxstatus.Size = new System.Drawing.Size(15, 14);
            this.checkBoxstatus.TabIndex = 12;
            this.checkBoxstatus.UseVisualStyleBackColor = false;
            // 
            // agencyaddedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgentDB.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(752, 376);
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
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnkapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agencyaddedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agencyaddedit";
            this.Load += new System.EventHandler(this.agencyaddedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texttelno;
        private System.Windows.Forms.TextBox textadres;
        private System.Windows.Forms.TextBox textadı;
        private System.Windows.Forms.ComboBox comboBoxkullanici;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxstatus;
    }
}