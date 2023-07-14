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
 
    public partial class frm_hasta_bilgi : Form
    {
        public string tc;
        public frm_hasta_bilgi()
        {
            InitializeComponent();
        }

     sql_connection conn = new sql_connection();

        private void frm_hasta_bilgi_Load(object sender, EventArgs e)
        {
            //Ad-Soyad cekme
            lbltc.Text = tc;
            SqlCommand cmd = new SqlCommand("select hasta_ad,hasta_soyad from Table_hasta where hasta_tc=@p1",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0] + " " + dr[1];
            }
            conn.baglanti().Close();

            //randevu gecmisi goruntuleme
           DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_randevu where hasta_tc="+tc,conn.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //bransları cekme
            SqlCommand cmd2 = new SqlCommand("Select brans_ad from Table_brans",conn.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read()) 
            {
                comboBoxbrans.Items.Add(dr2[0]);
            }
            conn.baglanti().Close();

          
        }

        private void comboBoxbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxdoktor.Items.Clear();
            //doktor cekme
            SqlCommand cmd3 = new SqlCommand("Select doktor_ad,doktor_soyad from Table_doktorr where doktor_brans=@p1 ", conn.baglanti());
            cmd3.Parameters.AddWithValue("@p1", comboBoxbrans.Text);
            
            SqlDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                comboBoxdoktor.Items.Add(dr3[0]+" " + dr3[1]);
            }
            conn.baglanti().Close();
        }

        private void comboBoxdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_randevu where randevu_brans='" + comboBoxbrans.Text + "'" + "and randevu_doktor= '"+comboBoxdoktor.Text + "'and randevu_durum=0", conn.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_bilgi_duzenle f = new frm_bilgi_duzenle();
            f.tc = lbltc.Text;
            f.Show();
          
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
                 
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Table_randevu set randevu_durum=1, hasta_tc=@p1,hasta_sikayet=@p2 where randevu_id=@p3",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",lbltc.Text);
            cmd.Parameters.AddWithValue("@p2",richTextBoxsikayet.Text);
            cmd.Parameters.AddWithValue("@p3",txt_id.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Randevu Alındı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.baglanti().Close();
        }
    }
}
