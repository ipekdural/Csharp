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
    public partial class FrmMain : Form
    {
        public FrmMain()
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
            MessageBox.Show("Registration has been added!");
        }

        private void btn_list_Click(object sender, EventArgs e)//listeleme
        {// TODO: This line of code loads data into the 'personel_databaseDataSet2.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.personel_databaseDataSet2.Table_1);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//datagridden verileri araclara tasima
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txt_lname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            comboBox_city.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            maskedTextBox_salary.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            string condition= dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            if(condition=="True"){
                radioButton_married.Checked = true;
            }
            if (condition == "False")
            {
                radioButton_single.Checked = true;
            }
            txt_occ.Text= dataGridView1.Rows[chosen].Cells[6].Value.ToString();

        }

        private void btn_delete_Click(object sender, EventArgs e)//veri silme
        {
            conn.Open();
            SqlCommand deletecmd = new SqlCommand("Delete From Table_1 Where per_id=@k1",conn);
            deletecmd.Parameters.AddWithValue("@k1",txt_id.Text);
            deletecmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Registration has been deleted!");
        }

        private void btn_update_Click(object sender, EventArgs e)//update komutu
        {
            conn.Open();
            SqlCommand updatecmd = new SqlCommand("Update Table_1 Set per_name=@a1,per_lastname=@a2 ,city=@a3,salary=@a4,[condition]=@a5,occupation=@a6 Where per_id=@a7",conn);
            updatecmd.Parameters.AddWithValue("@a1", txt_name.Text);
            updatecmd.Parameters.AddWithValue("@a2", txt_lname.Text);
            updatecmd.Parameters.AddWithValue("@a3", comboBox_city.Text);
            updatecmd.Parameters.AddWithValue("@a4",maskedTextBox_salary.Text);

            bool isMarried = radioButton_married.Checked;
            updatecmd.Parameters.AddWithValue("@a5", isMarried);
            updatecmd.Parameters.AddWithValue("@a6", txt_occ.Text);
            updatecmd.Parameters.AddWithValue("@a7", txt_id.Text);
            updatecmd.ExecuteNonQuery();
            MessageBox.Show("Registration has been updated!");
            conn.Close();
        }

        private void btn_statics_Click(object sender, EventArgs e)
        {
            frm_istatistik f = new frm_istatistik();
            f.Show();
        }

        private void btn_graphics_Click(object sender, EventArgs e)
        {
            FrmGraphics f = new FrmGraphics();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
