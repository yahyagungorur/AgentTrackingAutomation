namespace AgentDB
{
    partial class seller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seller));
            this.btngeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkapat = new System.Windows.Forms.Button();
            this.dataGridViewsatıcı = new System.Windows.Forms.DataGridView();
            this.picadd = new System.Windows.Forms.PictureBox();
            this.picedit = new System.Windows.Forms.PictureBox();
            this.textboxara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatıcı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picedit)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.Image = ((System.Drawing.Image)(resources.GetObject("btngeri.Image")));
            this.btngeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngeri.Location = new System.Drawing.Point(12, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(66, 28);
            this.btngeri.TabIndex = 7;
            this.btngeri.Text = "Geri ";
            this.btngeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Satıcı Bilgileri";
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.Red;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnkapat.Location = new System.Drawing.Point(665, 12);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(75, 28);
            this.btnkapat.TabIndex = 5;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // dataGridViewsatıcı
            // 
            this.dataGridViewsatıcı.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewsatıcı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsatıcı.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewsatıcı.Name = "dataGridViewsatıcı";
            this.dataGridViewsatıcı.Size = new System.Drawing.Size(679, 284);
            this.dataGridViewsatıcı.TabIndex = 4;
            // 
            // picadd
            // 
            this.picadd.BackColor = System.Drawing.Color.Transparent;
            this.picadd.Image = ((System.Drawing.Image)(resources.GetObject("picadd.Image")));
            this.picadd.InitialImage = ((System.Drawing.Image)(resources.GetObject("picadd.InitialImage")));
            this.picadd.Location = new System.Drawing.Point(700, 80);
            this.picadd.Name = "picadd";
            this.picadd.Size = new System.Drawing.Size(48, 50);
            this.picadd.TabIndex = 12;
            this.picadd.TabStop = false;
            this.picadd.Click += new System.EventHandler(this.picadd_Click);
            // 
            // picedit
            // 
            this.picedit.BackColor = System.Drawing.Color.Transparent;
            this.picedit.Image = ((System.Drawing.Image)(resources.GetObject("picedit.Image")));
            this.picedit.Location = new System.Drawing.Point(700, 135);
            this.picedit.Name = "picedit";
            this.picedit.Size = new System.Drawing.Size(48, 45);
            this.picedit.TabIndex = 12;
            this.picedit.TabStop = false;
            this.picedit.Click += new System.EventHandler(this.picedit_Click);
            // 
            // textboxara
            // 
            this.textboxara.Location = new System.Drawing.Point(590, 55);
            this.textboxara.Name = "textboxara";
            this.textboxara.Size = new System.Drawing.Size(100, 20);
            this.textboxara.TabIndex = 22;
            this.textboxara.TextChanged += new System.EventHandler(this.textboxara_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(504, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Satıcı Ara : ";
            // 
            // seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 376);
            this.ControlBox = false;
            this.Controls.Add(this.textboxara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picedit);
            this.Controls.Add(this.picadd);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.dataGridViewsatıcı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "seller";
            this.Load += new System.EventHandler(this.seller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatıcı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picedit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.DataGridView dataGridViewsatıcı;
        private System.Windows.Forms.PictureBox picadd;
        private System.Windows.Forms.PictureBox picedit;
        private System.Windows.Forms.TextBox textboxara;
        private System.Windows.Forms.Label label3;
    }
}