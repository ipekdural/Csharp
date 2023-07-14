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
    public partial class frm_sekreter_giris : Form
    {
        public frm_sekreter_giris()
        {
            InitializeComponent();
        }
        sql_connection conn = new sql_connection();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Table_sekreter where sekreter_tc=@p1 and sekreter_sifre=@p2 ",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            cmd.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frm_sekreter_bilgi f = new frm_sekreter_bilgi();
             
                f.tc=mskTC.Text;
                f.Show(); this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı şifre veya TC no!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            conn.baglanti().Close();

        }
    }
}
