namespace exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int e1, e2, p;
            double result;
            e1 = Convert.ToInt32(textBox1.Text);
            e2 = Convert.ToInt32(textBox2.Text);
            p = Convert.ToInt32(textBox3.Text);
            result = e1 * .25 + e2 * .25 + p * .50;
            if (result >= 50) { textBox4.Text = Convert.ToString(result) + "-passed"; }
            else { textBox4.Text = Convert.ToString(result) + "-failed"; }
        }

    }
}