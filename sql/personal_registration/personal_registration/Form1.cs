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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9HIBIC6I\\SQLEXPRESS;Initial Catalog=personel_database;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        void clear()
        {
            txt_id.Text = "";
            txt_lname.Text = "";
            txt_name.Text = "";
            txt_occ.Text = "";
            comboBox_city.Text = "";
            maskedTextBox_salary.Text = "";
            radioButton_married.Checked = false;
            radioButton_single.Checked = false;
            txt_name.Focus();

        }
        private void btn_save_Click(object sender, EventArgs e)//personel kayit
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into Table_1 (per_name,per_lastname,city,salary,condition,occupation) values (@p1,@p2,@p3,@p4,@p5,@p6)",conn);
            komut.Parameters.AddWithValue("@p1", txt_name.Text);
            komut.Parameters.AddWithValue("@p2", txt_lname.Text);
            komut.Parameters.AddWithValue("@p3", comboBox_city.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox_salary.Text);
            if(radioButton_married.Checked)
            {
                komut.Parameters.AddWithValue("@p5", 1);
            }
            if (radioButton_single.Checked)
            {
                komut.Parameters.AddWithValue("@p5", 0);
            }
            komut.Parameters.AddWithValue("@p6", txt_occ.Text);

            komut.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Personel has been added!");
        }

        private void btn_list_Click(object sender, EventArgs e)//listeleme
        {// TODO: This line of code loads data into the 'personel_databaseDataSet2.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.personel_databaseDataSet2.Table_1);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
