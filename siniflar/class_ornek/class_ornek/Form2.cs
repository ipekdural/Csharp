using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_ornek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            araba araba2 = new araba();
            araba2.motor = 456.234;
            araba2.renk = "Mavi";
            araba2.hiz = 130;
            araba2.fiyat = 800000;
            araba2.durum = 's';

            
            label1.Text = araba2.motor.ToString();
            label2.Text = araba2.renk;
            label3.Text = araba2.hiz.ToString();
            label4.Text = araba2.fiyat.ToString();
            label5.Text = araba2.durum.ToString();
        }
    }
}
