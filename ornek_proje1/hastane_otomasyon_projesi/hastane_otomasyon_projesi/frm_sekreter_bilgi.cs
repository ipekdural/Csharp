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
using Microsoft.SqlServer.Server;

namespace hastane_otomasyon_projesi
{
    public partial class frm_sekreter_bilgi : Form
    {
        public string tc;
        public frm_sekreter_bilgi()
        {
            InitializeComponent();
        }
        sql_connection conn =new sql_connection();
        private void frm_sekreter_bilgi_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            SqlCommand cmd = new SqlCommand("select sekreter_ad from Table_sekreter where sekreter_tc=@p1",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",tc);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }
            conn.baglanti().Close();

            //branslari datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select brans_id as İD,brans_ad as BRANŞ from Table_brans",conn.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //doktroları datagride cekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doktor_ad +' '+doktor_soyad) as DOKTOR,doktor_brans AS BRANŞ from Table_doktorr ", conn.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            //comboboxa veri cekme

            SqlCommand cmd1 = new SqlCommand("Select brans_ad from Table_brans",conn.baglanti());
            SqlDataReader dr2 = cmd1.ExecuteReader();
            while (dr2.Read())
            {
                cmb_brans.Items.Add(dr2[0]);
            }
            
        }

        //randevu kaydetme
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_randevu (randevu_tarih,randevu_saat,randevu_brans,randevu_doktor) values (@p1,@p2,@p3,@p4)",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskTarih.Text);
            cmd.Parameters.AddWithValue("@p2",mskSaat.Text);
            cmd.Parameters.AddWithValue("@p3", cmb_brans.Text);
            cmd.Parameters.AddWithValue("@p4",cmb_doktor.Text);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand cmd2 = new SqlCommand("Select doktor_ad,doktor_soyad from Table_doktorr where doktor_brans=@p1", conn.baglanti());
            cmd2.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr3 = cmd2.ExecuteReader();
            while (dr3.Read())
            {
                cmb_doktor.Items.Add(dr3[0] +" "+ dr3[1]);
            }
            conn.baglanti().Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_duyuru(duyuru) values (@p1)",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", richTextBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Duyuru oluşturuldu!","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.baglanti().Close();

        }

        private void btn_doktor_paneli_Click(object sender, EventArgs e)
        {
            frm_doktor_paneli f = new frm_doktor_paneli();
            f.Show();
        }

        private void btn_brans_paneli_Click(object sender, EventArgs e)
        {
            frm_brans_paneli f = new frm_brans_paneli();
            f.Show();
           
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            frm_randevu_listesi f = new frm_randevu_listesi();
            f.Show();
        }
    }
}
