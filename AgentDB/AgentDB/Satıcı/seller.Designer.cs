﻿namespace AgentDB
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatıcı)).BeginInit();
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
            // seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgentDB.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(752, 376);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.DataGridView dataGridViewsatıcı;
    }
}