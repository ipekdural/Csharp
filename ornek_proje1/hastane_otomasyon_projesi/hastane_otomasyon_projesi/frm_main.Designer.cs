namespace hastane_otomasyon_projesi
{
    partial class frm_main
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
            this.btn_hasta_giris = new System.Windows.Forms.Button();
            this.btn_doktor_giris = new System.Windows.Forms.Button();
            this.btn_sek_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hasta_giris
            // 
            this.btn_hasta_giris.Location = new System.Drawing.Point(65, 288);
            this.btn_hasta_giris.Name = "btn_hasta_giris";
            this.btn_hasta_giris.Size = new System.Drawing.Size(120, 63);
            this.btn_hasta_giris.TabIndex = 0;
            this.btn_hasta_giris.Text = "Hasta Girişi";
            this.btn_hasta_giris.UseVisualStyleBackColor = true;
            this.btn_hasta_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_doktor_giris
            // 
            this.btn_doktor_giris.Location = new System.Drawing.Point(293, 288);
            this.btn_doktor_giris.Name = "btn_doktor_giris";
            this.btn_doktor_giris.Size = new System.Drawing.Size(120, 63);
            this.btn_doktor_giris.TabIndex = 1;
            this.btn_doktor_giris.Text = "Doktor Girişi";
            this.btn_doktor_giris.UseVisualStyleBackColor = true;
            this.btn_doktor_giris.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sek_giris
            // 
            this.btn_sek_giris.Location = new System.Drawing.Point(521, 288);
            this.btn_sek_giris.Name = "btn_sek_giris";
            this.btn_sek_giris.Size = new System.Drawing.Size(120, 63);
            this.btn_sek_giris.TabIndex = 2;
            this.btn_sek_giris.Text = "Sekreter Girişi";
            this.btn_sek_giris.UseVisualStyleBackColor = true;
            this.btn_sek_giris.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sek_giris);
            this.Controls.Add(this.btn_doktor_giris);
            this.Controls.Add(this.btn_hasta_giris);
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hasta_giris;
        private System.Windows.Forms.Button btn_doktor_giris;
        private System.Windows.Forms.Button btn_sek_giris;
    }
}

