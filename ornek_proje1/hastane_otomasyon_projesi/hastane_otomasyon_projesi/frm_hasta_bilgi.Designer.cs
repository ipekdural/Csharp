namespace hastane_otomasyon_projesi
{
    partial class frm_hasta_bilgi
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.richTextBoxsikayet = new System.Windows.Forms.RichTextBox();
            this.comboBoxbrans = new System.Windows.Forms.ComboBox();
            this.comboBoxdoktor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_randevu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Location = new System.Drawing.Point(37, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(296, 153);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bilgilerimi Düzenle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC Kimlik No:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(174, 73);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(84, 16);
            this.lbltc.TabIndex = 3;
            this.lbltc.Text = "00000000000";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(174, 122);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(56, 16);
            this.lbl_adsoyad.TabIndex = 4;
            this.lbl_adsoyad.Text = "Null Null";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.richTextBoxsikayet);
            this.groupBox2.Controls.Add(this.comboBoxbrans);
            this.groupBox2.Controls.Add(this.comboBoxdoktor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(37, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu İşlemi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "İd:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(104, 73);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(49, 22);
            this.txt_id.TabIndex = 10;
            // 
            // richTextBoxsikayet
            // 
            this.richTextBoxsikayet.Location = new System.Drawing.Point(104, 222);
            this.richTextBoxsikayet.Name = "richTextBoxsikayet";
            this.richTextBoxsikayet.Size = new System.Drawing.Size(200, 96);
            this.richTextBoxsikayet.TabIndex = 9;
            this.richTextBoxsikayet.Text = "";
            // 
            // comboBoxbrans
            // 
            this.comboBoxbrans.FormattingEnabled = true;
            this.comboBoxbrans.Location = new System.Drawing.Point(104, 109);
            this.comboBoxbrans.Name = "comboBoxbrans";
            this.comboBoxbrans.Size = new System.Drawing.Size(200, 24);
            this.comboBoxbrans.TabIndex = 7;
            this.comboBoxbrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxbrans_SelectedIndexChanged);
            // 
            // comboBoxdoktor
            // 
            this.comboBoxdoktor.FormattingEnabled = true;
            this.comboBoxdoktor.Location = new System.Drawing.Point(104, 155);
            this.comboBoxdoktor.Name = "comboBoxdoktor";
            this.comboBoxdoktor.Size = new System.Drawing.Size(200, 24);
            this.comboBoxdoktor.TabIndex = 6;
            this.comboBoxdoktor.SelectedIndexChanged += new System.EventHandler(this.comboBoxdoktor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Şikayet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Branş:";
            // 
            // btn_randevu
            // 
            this.btn_randevu.Location = new System.Drawing.Point(171, 646);
            this.btn_randevu.Name = "btn_randevu";
            this.btn_randevu.Size = new System.Drawing.Size(142, 31);
            this.btn_randevu.TabIndex = 10;
            this.btn_randevu.Text = "Randevu Oluştur";
            this.btn_randevu.UseVisualStyleBackColor = true;
            this.btn_randevu.Click += new System.EventHandler(this.btn_randevu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(543, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 293);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geçmiş Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(523, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(543, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(519, 287);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(513, 266);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // frm_hasta_bilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 742);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_randevu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_hasta_bilgi";
            this.Text = "Randevu Oluşturma Paneli";
            this.Load += new System.EventHandler(this.frm_hasta_bilgi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxbrans;
        private System.Windows.Forms.ComboBox comboBoxdoktor;
        private System.Windows.Forms.RichTextBox richTextBoxsikayet;
        private System.Windows.Forms.Button btn_randevu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
    }
}