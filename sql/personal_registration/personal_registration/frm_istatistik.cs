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
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(*) From Table_1",conn);
             SqlDataReader dr1 = cmd1.ExecuteReader();//veri okuyucu
            while (dr1.Read())//dr1 reader veri okuma islemi yaptigi surece dongu devam eder 
            {
                lbl_per.Text = dr1[0].ToString();
            }
            conn.Close();
        }
    }
}
