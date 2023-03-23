namespace math_functions
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
            label1.Visible = true;
            double number;
            number = Convert.ToDouble(textBox1.Text);
            // label1.Text=Math.Abs(number).ToString();
            // label1.Text=Math.Ceiling(number).ToString();
            // label1.Text = Math.Floor(number).ToString();
            // label1.Text= Math.Pow(number, 2).ToString();
            //  label1.Text= Math.Round(number).ToString(); 
            //label1.Text=Math.Sqrt(number).ToString();
            //label1.Text = Math.PI.ToString();
            //label1.Text = Math.E.ToString();
            //label1.Text=Math.Cos(number).ToString();
            label1.Text=Math.Tan(number).ToString();




        }
    }
}