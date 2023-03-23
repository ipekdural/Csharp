namespace kapsulleme
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
            araba1.km = 1000;
            araba1.Brand = "audi";
            araba1.Age = -10;
            label1.Text=araba1.km.ToString();
            label2.Text=araba1.Brand;
            label3.Text=araba1.Age.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}