namespace String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameSurname;
            nameSurname=textBox1.Text;
            label2.Text=nameSurname;

        }
    }
}