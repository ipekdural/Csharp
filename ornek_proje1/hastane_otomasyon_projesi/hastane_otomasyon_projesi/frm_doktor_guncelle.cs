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
    public partial class frm_doktor_guncelle : Form
    {
        public string tc;
        sql_connection conn = new sql_connection();
        public frm_doktor_guncelle()
        {
            InitializeComponent();
        }

        private void frm_doktor_guncelle_Load(object sender, EventArgs e)
        {
            //comboboxa brans cekme
            SqlCommand cmd1 = new SqlCommand("Select brans_ad from Table_brans",conn.baglanti());
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cmb_brans.Items.Add(dr1[0]);
            }
            conn.baglanti().Close();

            maskedTextBoxtc.Text = tc;
            SqlCommand cmd = new SqlCommand("select *from Table_doktorr where doktor_tc=@p1 ",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",maskedTextBoxtc.Text);
            SqlDataReader dr =cmd.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmb_brans.Text = dr[3].ToString();
                maskedTextBoxtc.Text += dr[4].ToString();
                txtsifre.Text += dr[5].ToString();


            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Table_doktorr set doktor_name=@p1 ,doktor_soyad=@p2,doktor_brans=@p3,doktor_sifre=@p4 where doktor_tc=@p5",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtad.Text);
            cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmb_brans.Text);
            cmd.Parameters.AddWithValue("@p4", txtsifre.Text);
            cmd.Parameters.AddWithValue("@p5", maskedTextBoxtc.Text);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
