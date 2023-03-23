namespace exercise2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(textBox1.Text);
            x += 1;
            textBox1.Text = x.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            double cost = num * 10;
            if (num <= 20) { cost = Convert.ToDouble(cost * .8); textBox2.Text = cost.ToString() + "tl"; }
            if (num > 20 && num <= 40) { cost = Convert.ToDouble(cost * .6); textBox2.Text = cost.ToString() + "tl"; }
            if (num > 40) { cost = Convert.ToDouble(cost * .5); textBox2.Text = cost.ToString() + "tl"; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(textBox1.Text);
            x -= 1;
            textBox1.Text = x.ToString();
        }
    }
}