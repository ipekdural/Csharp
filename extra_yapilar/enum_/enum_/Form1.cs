namespace enum_
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
        enum days { monday, tuesday, wednesday, thursday, friday, saturday, sunday };
    

        private void button1_Click_1(object sender, EventArgs e)
        {

            label1.Visible = true;
            int num = Convert.ToInt32(textBox1.Text) - 1;
            days day;
            day = (days)num;
            label1.Text = day.ToString();
        }
    }
}