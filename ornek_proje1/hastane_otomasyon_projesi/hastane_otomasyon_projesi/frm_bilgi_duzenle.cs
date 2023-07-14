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

namespace hastane_otomasyon_projesi
{
    public partial class frm_bilgi_duzenle : Form
    {
        public string tc;
        public frm_bilgi_duzenle()
        {
            InitializeComponent();
        }
        sql_connection conn= new sql_connection();
        private void frm_bilgi_duzenle_Load(object sender, EventArgs e)
        {
            maskedTextBoxtc.Enabled= false;
            maskedTextBoxtc.Text = tc;
            SqlCommand cmd = new SqlCommand("Select * from Table_hasta where hasta_tc=@p1",conn.baglanti());

            cmd.Parameters.AddWithValue("@p1", maskedTextBoxtc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                maskedTextBoxtelefon.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                textBox1.Text = dr[5].ToString();
                comboBox1.Text = dr[6].ToString();

            }


            conn.baglanti().Close();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Table_hasta set hasta_ad=@p1 , hasta_soyad=@p2,hasta_tel=@p3,hasta_sifre=@p4,hasta_cinsiyet=@p5 where hasta_tc=@p6",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtad.Text);
            cmd.Parameters.AddWithValue("@p2",txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", maskedTextBoxtelefon.Text);
            cmd.Parameters.AddWithValue("@p4",txtsifre.Text);
            cmd.Parameters.AddWithValue("@p5", comboBox1.Text);
            cmd.Parameters.AddWithValue("@p6", maskedTextBoxtc.Text);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi!","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
