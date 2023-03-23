using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Satış Miktarı"].Points.AddXY("Ocak", 500);
            chart1.Series["Satış Miktarı"].Points.AddXY("Şubat", 400);
            chart1.Series["Satış Miktarı"].Points.AddXY("Mart", 600);
            chart1.Series["Satış Miktarı"].Points.AddXY("Nisan", 700);
        }
    }
}
