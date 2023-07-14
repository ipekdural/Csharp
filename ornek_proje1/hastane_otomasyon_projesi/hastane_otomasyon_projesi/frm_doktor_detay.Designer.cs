namespace hastane_otomasyon_projesi
{
    partial class frm_doktor_detay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_duyuru = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(117, 88);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(56, 16);
            this.lbl_adsoyad.TabIndex = 3;
            this.lbl_adsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(117, 48);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(84, 16);
            this.lbl_tc.TabIndex = 1;
            this.lbl_tc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(263, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cikis);
            this.groupBox3.Controls.Add(this.btn_duyuru);
            this.groupBox3.Controls.Add(this.btn_guncelle);
            this.groupBox3.Location = new System.Drawing.Point(13, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 209);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(11, 134);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(263, 39);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_duyuru
            // 
            this.btn_duyuru.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_duyuru.Location = new System.Drawing.Point(11, 82);
            this.btn_duyuru.Name = "btn_duyuru";
            this.btn_duyuru.Size = new System.Drawing.Size(263, 39);
            this.btn_duyuru.TabIndex = 4;
            this.btn_duyuru.Text = "Duyurular";
            this.btn_duyuru.UseVisualStyleBackColor = true;
            this.btn_duyuru.Click += new System.EventHandler(this.btn_duyuru_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(11, 31);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(263, 39);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Bilgilerimi Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(331, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(840, 534);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(834, 513);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frm_doktor_detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 586);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_doktor_detay";
            this.Text = "Doktor Bilgi Paneli";
            this.Load += new System.EventHandler(this.frm_doktor_detay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_duyuru;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}