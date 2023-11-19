namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    partial class FrmFiyat_Guncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGuncelFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFiyatGuncelle = new System.Windows.Forms.Button();
            this.BtnEskiFiyat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncel Oda Fiyatları :";
            // 
            // TxtGuncelFiyat
            // 
            this.TxtGuncelFiyat.BackColor = System.Drawing.SystemColors.Info;
            this.TxtGuncelFiyat.Location = new System.Drawing.Point(180, 72);
            this.TxtGuncelFiyat.Name = "TxtGuncelFiyat";
            this.TxtGuncelFiyat.Size = new System.Drawing.Size(107, 20);
            this.TxtGuncelFiyat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şuanki Fiyat :";
            // 
            // BtnFiyatGuncelle
            // 
            this.BtnFiyatGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFiyatGuncelle.Location = new System.Drawing.Point(189, 113);
            this.BtnFiyatGuncelle.Name = "BtnFiyatGuncelle";
            this.BtnFiyatGuncelle.Size = new System.Drawing.Size(98, 59);
            this.BtnFiyatGuncelle.TabIndex = 3;
            this.BtnFiyatGuncelle.Text = "Fiyatı Güncelle";
            this.BtnFiyatGuncelle.UseVisualStyleBackColor = true;
            this.BtnFiyatGuncelle.Click += new System.EventHandler(this.BtnFiyatGuncelle_Click);
            // 
            // BtnEskiFiyat
            // 
            this.BtnEskiFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(189)))), ((int)(((byte)(190)))));
            this.BtnEskiFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEskiFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(197)))), ((int)(((byte)(32)))));
            this.BtnEskiFiyat.Location = new System.Drawing.Point(180, 11);
            this.BtnEskiFiyat.Name = "BtnEskiFiyat";
            this.BtnEskiFiyat.Size = new System.Drawing.Size(107, 40);
            this.BtnEskiFiyat.TabIndex = 4;
            this.BtnEskiFiyat.UseVisualStyleBackColor = false;
            this.BtnEskiFiyat.Click += new System.EventHandler(this.BtnEskiFiyat_Click);
            // 
            // FrmFiyat_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(294, 187);
            this.Controls.Add(this.BtnEskiFiyat);
            this.Controls.Add(this.BtnFiyatGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtGuncelFiyat);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFiyat_Guncelle";
            this.Text = "Fiyat Güncelle";
            this.Load += new System.EventHandler(this.FrmFiyat_Guncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGuncelFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFiyatGuncelle;
        private System.Windows.Forms.Button BtnEskiFiyat;
    }
}