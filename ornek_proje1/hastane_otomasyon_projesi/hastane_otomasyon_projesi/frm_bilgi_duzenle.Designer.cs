namespace hastane_otomasyon_projesi
{
    partial class frm_bilgi_duzenle
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
            this.btnguncelle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.maskedTextBoxtc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxtelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(171, 484);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(104, 31);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Şifre(Tekrar):";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(148, 345);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(166, 22);
            this.txtsifre.TabIndex = 5;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // maskedTextBoxtc
            // 
            this.maskedTextBoxtc.Location = new System.Drawing.Point(148, 251);
            this.maskedTextBoxtc.Mask = "00000000000";
            this.maskedTextBoxtc.Name = "maskedTextBoxtc";
            this.maskedTextBoxtc.Size = new System.Drawing.Size(166, 22);
            this.maskedTextBoxtc.TabIndex = 3;
            this.maskedTextBoxtc.ValidatingType = typeof(int);
            // 
            // maskedTextBoxtelefon
            // 
            this.maskedTextBoxtelefon.Location = new System.Drawing.Point(148, 298);
            this.maskedTextBoxtelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxtelefon.Name = "maskedTextBoxtelefon";
            this.maskedTextBoxtelefon.Size = new System.Drawing.Size(166, 22);
            this.maskedTextBoxtelefon.TabIndex = 4;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(148, 208);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(166, 22);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(148, 161);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(166, 22);
            this.txtad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kadın ",
            "Erkek",
            "Belirtmek İstemiyorum"});
            this.comboBox1.Location = new System.Drawing.Point(148, 429);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 34;
            // 
            // frm_bilgi_duzenle
            // 
            this.AcceptButton = this.btnguncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 689);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.maskedTextBoxtc);
            this.Controls.Add(this.maskedTextBoxtelefon);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_bilgi_duzenle";
            this.Text = "Hasta Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.frm_bilgi_duzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtelefon;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}