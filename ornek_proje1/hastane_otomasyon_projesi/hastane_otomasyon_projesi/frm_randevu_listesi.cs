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
    public partial class frm_randevu_listesi : Form
    {
        sql_connection conn= new sql_connection();
        public frm_randevu_listesi()
        {
            InitializeComponent();
        }

        private void frm_randevu_listesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *from Table_randevu ",conn.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
