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
    public partial class frm_doktor_giris : Form
    {
        public frm_doktor_giris()
        {
            InitializeComponent();
        }
        sql_connection conn = new sql_connection();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select *from Table_doktorr where doktor_tc=@p1 and doktor_sifre=@p2",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            cmd.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frm_doktor_detay f = new frm_doktor_detay();
                f.tc = mskTC.Text;
                f.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı şifre veya TC kimlik numarası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.baglanti().Close();
        }
    }
}
