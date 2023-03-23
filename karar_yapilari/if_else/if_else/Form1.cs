namespace if_else
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
            int number = Convert.ToInt32(textBox1.Text);
            if (number > 0)
            {
                label1.Text = "number is positive";
            }
            else if (number < 0)
            {
                label1.Text = "number is negative";
            }
            else { label1.Text = "number is zero"; }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox2.Text);
            if (number % 2 == 0) { label2.Text = "number is even"; }
            else { label2.Text = "number is odd"; }
        }

       
    }
}