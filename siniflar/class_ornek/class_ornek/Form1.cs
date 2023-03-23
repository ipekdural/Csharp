namespace class_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba araba1 = new araba();
            araba1.motor = 123.123;
            araba1.renk = "Kýrmýzý";
            araba1.hiz = 120;
            araba1.fiyat = 500000;
            araba1.durum = 'i';
 
                
            label1.Text=araba1.motor.ToString();
            label2.Text=araba1.renk;
            label3.Text=araba1.hiz.ToString();
            label4.Text=araba1.fiyat.ToString();
            label5.Text=araba1.durum.ToString();
        }
    }
}