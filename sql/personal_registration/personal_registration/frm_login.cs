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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide the password";
            }
            else
            {
                txtpassword.UseSystemPasswordChar= true;
                checkBox1.Text = "Show the password";
            }
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9HIBIC6I\\SQLEXPRESS;Initial Catalog=personel_database;Integrated Security=True");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select *From Table_login Where username=@p1 and password=@p2",conn);
            cmd.Parameters.AddWithValue("@p1",txtusername.Text);
            cmd.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                FrmMain f = new FrmMain();
                f.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
            conn.Close();
        }
    }
}
