namespace switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            char op = Convert.ToChar(textBox3.Text);
            switch (op)
            {
                case '+': textBox4.Text = (x + y).ToString(); break;
                case '-': textBox4.Text = (x - y).ToString(); break;
                case '*': textBox4.Text = (x * y).ToString(); break;
                case '/': textBox4.Text = (x / y).ToString(); break;
                default: label1.Text="invalid syntax...";break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox1.Focus();
        }
    }
}