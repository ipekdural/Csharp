namespace hastane_otomasyon_projesi
{
    partial class frm_doktor_guncelle
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
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.maskedTextBoxtc = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(146, 299);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(104, 31);
            this.btnguncelle.TabIndex = 51;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(118, 225);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(166, 22);
            this.txtsifre.TabIndex = 46;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // maskedTextBoxtc
            // 
            this.maskedTextBoxtc.Location = new System.Drawing.Point(118, 131);
            this.maskedTextBoxtc.Mask = "00000000000";
            this.maskedTextBoxtc.Name = "maskedTextBoxtc";
            this.maskedTextBoxtc.Size = new System.Drawing.Size(166, 22);
            this.maskedTextBoxtc.TabIndex = 45;
            this.maskedTextBoxtc.ValidatingType = typeof(int);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(118, 85);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(166, 22);
            this.txtsoyad.TabIndex = 43;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(118, 41);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(166, 22);
            this.txtad.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Branş:";
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(118, 176);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(166, 24);
            this.cmb_brans.TabIndex = 53;
            // 
            // frm_doktor_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 402);
            this.Controls.Add(this.cmb_brans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.maskedTextBoxtc);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_doktor_guncelle";
            this.Text = "Doktor Bilgi Güncelleme Paneli";
            this.Load += new System.EventHandler(this.frm_doktor_guncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_brans;
    }
}