namespace AgentDB
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            this.dataGridViewuser = new System.Windows.Forms.DataGridView();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picedit = new System.Windows.Forms.PictureBox();
            this.picadd = new System.Windows.Forms.PictureBox();
            this.textboxara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewuser
            // 
            this.dataGridViewuser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewuser.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewuser.Name = "dataGridViewuser";
            this.dataGridViewuser.Size = new System.Drawing.Size(679, 284);
            this.dataGridViewuser.TabIndex = 0;
            // 
            // btngeri
            // 
            this.btngeri.Image = ((System.Drawing.Image)(resources.GetObject("btngeri.Image")));
            this.btngeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngeri.Location = new System.Drawing.Point(12, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(66, 28);
            this.btngeri.TabIndex = 5;
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
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Bilgileri";
            // 
            // picedit
            // 
            this.picedit.BackColor = System.Drawing.Color.Transparent;
            this.picedit.Image = ((System.Drawing.Image)(resources.GetObject("picedit.Image")));
            this.picedit.Location = new System.Drawing.Point(697, 135);
            this.picedit.Name = "picedit";
            this.picedit.Size = new System.Drawing.Size(48, 45);
            this.picedit.TabIndex = 17;
            this.picedit.TabStop = false;
            this.picedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // picadd
            // 
            this.picadd.BackColor = System.Drawing.Color.Transparent;
            this.picadd.Image = ((System.Drawing.Image)(resources.GetObject("picadd.Image")));
            this.picadd.Location = new System.Drawing.Point(697, 80);
            this.picadd.Name = "picadd";
            this.picadd.Size = new System.Drawing.Size(48, 50);
            this.picadd.TabIndex = 18;
            this.picadd.TabStop = false;
            this.picadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // textboxara
            // 
            this.textboxara.Location = new System.Drawing.Point(593, 57);
            this.textboxara.Name = "textboxara";
            this.textboxara.Size = new System.Drawing.Size(100, 20);
            this.textboxara.TabIndex = 20;
            this.textboxara.TextChanged += new System.EventHandler(this.textboxara_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(507, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kullanıcı Ara : ";
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 376);
            this.Controls.Add(this.textboxara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picedit);
            this.Controls.Add(this.picadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.dataGridViewuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "users";
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewuser;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picedit;
        private System.Windows.Forms.PictureBox picadd;
        private System.Windows.Forms.TextBox textboxara;
        private System.Windows.Forms.Label label3;
    }
}