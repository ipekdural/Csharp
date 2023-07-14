using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hastane_otomasyon_projesi
{
    public partial class frm_hasta_kayit : Form
    {
        public frm_hasta_kayit()
        {
            InitializeComponent();
        }

        private void frm_hasta_kayit_Load(object sender, EventArgs e)
        {

        }
        sql_connection conn = new sql_connection();
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            if (txtad.Text.Length==0 || txtsoyad.Text.Length == 0 || maskedTextBoxtc.Text.Length != 11 || maskedTextBoxtelefon.Text.Length != 14 || (comboBox1.Text != "Kadın" && comboBox1.Text != "Erkek" && comboBox1.Text != "Belirtmek İstemiyorum"))
            {
                MessageBox.Show("Lütfen boş bırakılan alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (txtsifre.Text != textBox1.Text)
                {
                    MessageBox.Show("Şifreler uyuşmamaktadır. Lütfen tekrar deneyiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtsifre.Text.Length < 8)
                    {
                        MessageBox.Show("Şifre en az 8 karakterden oluşmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


    
                            SqlCommand cmd = new SqlCommand("insert into Table_hasta (hasta_ad,hasta_soyad,hasta_tc,hasta_tel,hasta_sifre,hasta_cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn.baglanti());
                            cmd.Parameters.AddWithValue("@p1", txtad.Text);
                            cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
                            cmd.Parameters.AddWithValue("@p3", maskedTextBoxtc.Text);
                            cmd.Parameters.AddWithValue("@p4", maskedTextBoxtelefon.Text);
                            cmd.Parameters.AddWithValue("@p5", txtsifre.Text);
                            cmd.Parameters.AddWithValue("@p6", comboBox1.Text);
                            cmd.ExecuteNonQuery();
                            conn.baglanti().Close();
                            MessageBox.Show("Kayıt Gerçekleşti!", "Bilgilendirme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                    }
                }
            }

        }
    }
}
