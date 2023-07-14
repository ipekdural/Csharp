using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_otomasyon_projesi
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_doktor_giris f = new frm_doktor_giris();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_sekreter_giris f = new frm_sekreter_giris();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_hasta_giris f = new frm_hasta_giris();
            f.Show();
            this.Hide();
        }
    }
}
