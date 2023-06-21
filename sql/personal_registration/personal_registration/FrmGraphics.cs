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

namespace personal_registration
{
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9HIBIC6I\\SQLEXPRESS;Initial Catalog=personel_database;Integrated Security=True");

        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand g1 = new SqlCommand("Select city,Count(*) From Table_1 Group By city",conn);
            SqlDataReader rd = g1.ExecuteReader();
            while (rd.Read()) 
            {
                chart1.Series["Cities"].Points.AddXY(rd[0], rd[1]);            
            }


            conn.Close();


            conn.Open();
            SqlCommand g2 = new SqlCommand("Select occupation ,Avg(salary) From Table_1 Group By occupation", conn);
            SqlDataReader rd2 = g2.ExecuteReader();
            while (rd2.Read())
            {
                chart2.Series["Occupations-Salary"].Points.AddXY(rd2[0], rd2[1]);
            }


            conn.Close();
        }
    }
}
