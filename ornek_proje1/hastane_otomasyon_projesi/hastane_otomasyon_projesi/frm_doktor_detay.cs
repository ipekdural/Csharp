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
    public partial class frm_doktor_detay : Form
    {
        public string tc;
        public frm_doktor_detay()
        {
            InitializeComponent();
        }
        sql_connection conn= new sql_connection();

        private void frm_doktor_detay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;
            SqlCommand cmd = new SqlCommand("Select doktor_ad,doktor_soyad from Table_doktorr where doktor_tc=@p1",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",lbl_tc.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbl_adsoyad.Text = reader[0] + " " + reader[1];
            }
            conn.baglanti().Close();

            //randevulari cekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_randevu where randevu_doktor= '" +lbl_adsoyad.Text + "'",conn.baglanti());
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            frm_doktor_guncelle f = new frm_doktor_guncelle();
            f.tc = lbl_tc.Text;
            f.Show();
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            frm_duyurular f = new frm_duyurular();
            f.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
