namespace return_metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int add(int x, int y)
        {
            int z = x + y;

            return z;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = add(23, 45).ToString();
        }
        int kupHesapla(int x)
        {
            int z = x * x * x;
            return z;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
          label2.Text=  kupHesapla(Convert.ToInt32(textBox1.Text)).ToString();
        }
    }
}