using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_otomasyon_projesi
{
    public partial class frm_doktor_paneli : Form
    {
        public frm_doktor_paneli()
        {
            InitializeComponent();
        }
        sql_connection conn = new sql_connection();
        private void frm_doktor_paneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_doktorr ",conn.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //bransları comboboxa cekme
            SqlCommand cmd = new SqlCommand("Select brans_ad from Table_brans",conn.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_brans.Items.Add(dr[0]);
            }
            conn.baglanti().Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_doktorr (doktor_ad,doktor_soyad,doktor_brans,doktor_tc,doktor_sifre) values(@p1,@p2,@p3,@p4,@p5)",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",txt_ad.Text);
            cmd.Parameters.AddWithValue("@p2", txt_soyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmb_brans.Text);
            cmd.Parameters.AddWithValue("@p4", msk_tc.Text);
            cmd.Parameters.AddWithValue("@p5", txt_sifre.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt eklendi!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            conn.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msk_tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_delete = new SqlCommand("delete from Table_doktorr where doktor_tc=@p1",conn.baglanti());
            cmd_delete.Parameters.AddWithValue("@p1",msk_tc.Text);
            cmd_delete.ExecuteNonQuery();
            MessageBox.Show("Kayıt silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.baglanti().Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_update = new SqlCommand("update Table_doktorr set doktor_ad=@p1,doktor_soyad=@p2,doktor_brans=@p3,doktor_sifre=@p5 where doktor_tc=@p4   ",conn.baglanti());
            cmd_update.Parameters.AddWithValue("@p1", txt_ad.Text);
            cmd_update.Parameters.AddWithValue("@p2", txt_soyad.Text);
            cmd_update.Parameters.AddWithValue("@p3", cmb_brans.Text);
            cmd_update.Parameters.AddWithValue("@p4", msk_tc.Text);
            cmd_update.Parameters.AddWithValue("@p5", txt_sifre.Text);
            cmd_update.ExecuteNonQuery();
            MessageBox.Show("Kayıt güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.baglanti().Close();
        }
    }
}
