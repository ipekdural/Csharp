namespace _char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char x;
            x = 'a';
            label1.Text = x.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char y;
            y = Convert.ToChar(textBox1.Text);
            label2.Text = y.ToString();

        }
    }
}