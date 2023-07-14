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
    public partial class frm_brans_paneli : Form
    {
        public frm_brans_paneli()
        {
            InitializeComponent();
        }
        sql_connection conn = new sql_connection();
        private void frm_brans_paneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_brans", conn.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_brans(brans_ad) values (@p1)",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",txt_ad.Text);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Branş eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Table_brans where brans_id=@p1",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", txt_id.Text);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Branş silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Table_brans set brans_ad=@p1 where brans_id=@p2", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", txt_ad.Text);
            cmd.Parameters.AddWithValue("@p2",txt_id.Text);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Branş güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
