namespace random_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible=true;
            label3.Visible=true;
            Random rd = new Random();
            int num1, num2, num3;
            num1= rd.Next(1,100);
            num2= rd.Next(1,100);
            num3= rd.Next(1,100);
            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();

        }
    }
}