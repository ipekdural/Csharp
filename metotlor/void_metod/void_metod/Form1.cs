namespace void_metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void clear()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
        void color()
        {
            textBox1.BackColor = Color.DarkBlue;
            textBox2.BackColor = Color.Magenta;
            textBox3.BackColor = Color.SaddleBrown;
            textBox4.BackColor = Color.Tan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            color();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}