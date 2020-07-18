namespace OgrenciOtomasyonu
{
    partial class frmNotGirisi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBolumListe = new System.Windows.Forms.ComboBox();
            this.cmbTCKimlikNoListe = new System.Windows.Forms.ComboBox();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.msktxtFinal = new System.Windows.Forms.MaskedTextBox();
            this.msktxtVize = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vize:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ortalama:";
            // 
            // cmbBolumListe
            // 
            this.cmbBolumListe.FormattingEnabled = true;
            this.cmbBolumListe.Items.AddRange(new object[] {
            "Bilgisayar",
            "Elektronik",
            "Elektrik",
            "Makina",
            "İnşaat",
            "Enerji",
            "Maden",
            "Yazılım",
            "Haberleşme",
            "Ziraat"});
            this.cmbBolumListe.Location = new System.Drawing.Point(146, 35);
            this.cmbBolumListe.Name = "cmbBolumListe";
            this.cmbBolumListe.Size = new System.Drawing.Size(165, 21);
            this.cmbBolumListe.TabIndex = 1;
            this.cmbBolumListe.SelectedIndexChanged += new System.EventHandler(this.cmbBolumListe_SelectedIndexChanged);
            this.cmbBolumListe.TextChanged += new System.EventHandler(this.cmbBolumListe_TextChanged);
            // 
            // cmbTCKimlikNoListe
            // 
            this.cmbTCKimlikNoListe.FormattingEnabled = true;
            this.cmbTCKimlikNoListe.Location = new System.Drawing.Point(146, 68);
            this.cmbTCKimlikNoListe.Name = "cmbTCKimlikNoListe";
            this.cmbTCKimlikNoListe.Size = new System.Drawing.Size(165, 21);
            this.cmbTCKimlikNoListe.TabIndex = 2;
            this.cmbTCKimlikNoListe.TextChanged += new System.EventHandler(this.cmbTCKimlikNoListe_TextChanged);
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(146, 208);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(0, 13);
            this.lblOrtalama.TabIndex = 5;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(146, 106);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 13);
            this.lblAdSoyad.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(146, 237);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(165, 43);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // msktxtFinal
            // 
            this.msktxtFinal.Location = new System.Drawing.Point(146, 173);
            this.msktxtFinal.Mask = "000";
            this.msktxtFinal.Name = "msktxtFinal";
            this.msktxtFinal.Size = new System.Drawing.Size(100, 20);
            this.msktxtFinal.TabIndex = 8;
            // 
            // msktxtVize
            // 
            this.msktxtVize.Location = new System.Drawing.Point(146, 128);
            this.msktxtVize.Mask = "000";
            this.msktxtVize.Name = "msktxtVize";
            this.msktxtVize.Size = new System.Drawing.Size(100, 20);
            this.msktxtVize.TabIndex = 9;
            // 
            // frmNotGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(329, 300);
            this.Controls.Add(this.msktxtVize);
            this.Controls.Add(this.msktxtFinal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.cmbTCKimlikNoListe);
            this.Controls.Add(this.cmbBolumListe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNotGirisi";
            this.Text = "Not Girişi";
            this.Load += new System.EventHandler(this.frmNotGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBolumListe;
        private System.Windows.Forms.ComboBox cmbTCKimlikNoListe;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox msktxtFinal;
        private System.Windows.Forms.MaskedTextBox msktxtVize;
    }
}