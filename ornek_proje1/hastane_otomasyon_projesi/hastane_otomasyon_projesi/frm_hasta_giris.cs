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
    public partial class frm_hasta_giris : Form
    {
        public frm_hasta_giris()
        {
            InitializeComponent();
        }
        sql_connection conn = new sql_connection();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * From Table_hasta where hasta_tc=@p1 and hasta_sifre=@p2",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                frm_hasta_bilgi f = new frm_hasta_bilgi();
                f.tc = mskTC.Text;
                f.Show();
                
             
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre!");
            }
            conn.baglanti().Close();
        }

        private void lnkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_hasta_kayit f= new frm_hasta_kayit();
            f.Show();
        }
    }
}
