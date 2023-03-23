using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlararasi_veritasima
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string name1;
        public string name2;
        public string name3;
        public string name4 = "hello world";

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(name1);
            comboBox1.Items.Add(name2);
            comboBox1.Items.Add(name3);
            label1.Text = name4;
            label1.Visible = true;


        }
    }
}
