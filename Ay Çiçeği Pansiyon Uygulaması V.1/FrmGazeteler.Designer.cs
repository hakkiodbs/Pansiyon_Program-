namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    partial class FrmGazeteler
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnHurriyet = new System.Windows.Forms.Button();
            this.BtnMilliyet = new System.Windows.Forms.Button();
            this.BtnSözcü = new System.Windows.Forms.Button();
            this.BtnHaberTurk = new System.Windows.Forms.Button();
            this.BtnFanatik = new System.Windows.Forms.Button();
            this.BtnOnedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 42);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1246, 682);
            this.webBrowser1.TabIndex = 0;
            // 
            // BtnHurriyet
            // 
            this.BtnHurriyet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHurriyet.Location = new System.Drawing.Point(4, 5);
            this.BtnHurriyet.Name = "BtnHurriyet";
            this.BtnHurriyet.Size = new System.Drawing.Size(91, 31);
            this.BtnHurriyet.TabIndex = 1;
            this.BtnHurriyet.Text = "Hürriyet";
            this.BtnHurriyet.UseVisualStyleBackColor = true;
            this.BtnHurriyet.Click += new System.EventHandler(this.BtnHurriyet_Click);
            // 
            // BtnMilliyet
            // 
            this.BtnMilliyet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMilliyet.Location = new System.Drawing.Point(101, 5);
            this.BtnMilliyet.Name = "BtnMilliyet";
            this.BtnMilliyet.Size = new System.Drawing.Size(91, 31);
            this.BtnMilliyet.TabIndex = 2;
            this.BtnMilliyet.Text = "Milliyet";
            this.BtnMilliyet.UseVisualStyleBackColor = true;
            this.BtnMilliyet.Click += new System.EventHandler(this.BtnMilliyet_Click);
            // 
            // BtnSözcü
            // 
            this.BtnSözcü.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSözcü.Location = new System.Drawing.Point(198, 5);
            this.BtnSözcü.Name = "BtnSözcü";
            this.BtnSözcü.Size = new System.Drawing.Size(91, 31);
            this.BtnSözcü.TabIndex = 3;
            this.BtnSözcü.Text = "Sözcü";
            this.BtnSözcü.UseVisualStyleBackColor = true;
            this.BtnSözcü.Click += new System.EventHandler(this.BtnSözcü_Click);
            // 
            // BtnHaberTurk
            // 
            this.BtnHaberTurk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHaberTurk.Location = new System.Drawing.Point(295, 5);
            this.BtnHaberTurk.Name = "BtnHaberTurk";
            this.BtnHaberTurk.Size = new System.Drawing.Size(91, 31);
            this.BtnHaberTurk.TabIndex = 4;
            this.BtnHaberTurk.Text = "HaberTürk";
            this.BtnHaberTurk.UseVisualStyleBackColor = true;
            this.BtnHaberTurk.Click += new System.EventHandler(this.BtnHaberTurk_Click);
            // 
            // BtnFanatik
            // 
            this.BtnFanatik.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFanatik.Location = new System.Drawing.Point(392, 5);
            this.BtnFanatik.Name = "BtnFanatik";
            this.BtnFanatik.Size = new System.Drawing.Size(91, 31);
            this.BtnFanatik.TabIndex = 5;
            this.BtnFanatik.Text = "Fanatik";
            this.BtnFanatik.UseVisualStyleBackColor = true;
            this.BtnFanatik.Click += new System.EventHandler(this.BtnFanatik_Click);
            // 
            // BtnOnedio
            // 
            this.BtnOnedio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOnedio.Location = new System.Drawing.Point(489, 5);
            this.BtnOnedio.Name = "BtnOnedio";
            this.BtnOnedio.Size = new System.Drawing.Size(91, 31);
            this.BtnOnedio.TabIndex = 6;
            this.BtnOnedio.Text = "Onedio";
            this.BtnOnedio.UseVisualStyleBackColor = true;
            this.BtnOnedio.Click += new System.EventHandler(this.BtnOnedio_Click);
            // 
            // FrmGazeteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 726);
            this.Controls.Add(this.BtnOnedio);
            this.Controls.Add(this.BtnFanatik);
            this.Controls.Add(this.BtnHaberTurk);
            this.Controls.Add(this.BtnSözcü);
            this.Controls.Add(this.BtnMilliyet);
            this.Controls.Add(this.BtnHurriyet);
            this.Controls.Add(this.webBrowser1);
            this.Name = "FrmGazeteler";
            this.Text = "Gazeteler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnHurriyet;
        private System.Windows.Forms.Button BtnMilliyet;
        private System.Windows.Forms.Button BtnSözcü;
        private System.Windows.Forms.Button BtnHaberTurk;
        private System.Windows.Forms.Button BtnFanatik;
        private System.Windows.Forms.Button BtnOnedio;
    }
}