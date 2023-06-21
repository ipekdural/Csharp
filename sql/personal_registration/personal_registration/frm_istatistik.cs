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
using System.Data.SqlClient;

namespace personal_registration
{
    public partial class frm_istatistik : Form
    {
        public frm_istatistik()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9HIBIC6I\\SQLEXPRESS;Initial Catalog=personel_database;Integrated Security=True");

        private void frm_istatistik_Load(object sender, EventArgs e)
        {
            //toplam personel sayisi 
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(*) From Table_1",conn);
             SqlDataReader dr1 = cmd1.ExecuteReader();//veri okuyucu
            while (dr1.Read())//dr1 reader veri okuma islemi yaptigi surece dongu devam eder 
            {
                lbl_per.Text = dr1[0].ToString();
            }
            conn.Close();

            //toplam evli personel sayisi
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select Count(*) From Table_1 Where condition=1", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();//veri okuyucu
            while (dr2.Read())//dr1 reader veri okuma islemi yaptigi surece dongu devam eder 
            {
                lbl_married.Text = dr2[0].ToString();
            }
            conn.Close();

            //toplam bekar personel sayisi
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("Select Count(*) From Table_1 Where condition=0", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();//veri okuyucu
            while (dr3.Read())//dr1 reader veri okuma islemi yaptigi surece dongu devam eder 
            {
                lbl_single.Text = dr3[0].ToString();
            }
            conn.Close();

            //kac farkli sehir var
            //distinct tekrarsiz sayar
            conn.Open();
            SqlCommand cmd4 = new SqlCommand("Select count(distinct(city)) From Table_1 ", conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();//veri okuyucu
            while (dr4.Read())//dr1 reader veri okuma islemi yaptigi surece dongu devam eder 
            {
                lbl_city.Text = dr4[0].ToString();
            }
            conn.Close();

            //toplam maas bulma

            conn.Open();
            SqlCommand cmd5 = new SqlCommand("Select Sum(salary) From Table_1",conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read()) { 
                lbl_total.Text = dr5[0].ToString();
            }
            conn.Close ();

            //ORTALAMA MAAS BULMA   
            conn.Open();
            SqlCommand cmd6 = new SqlCommand("Select Avg(salary) From Table_1", conn);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                lbl_avarage.Text = dr6[0].ToString();
            }
            conn.Close();


        }
    }
}
