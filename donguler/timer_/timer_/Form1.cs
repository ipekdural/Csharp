namespace timer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = i.ToString();
            i++;
            if (i == 2)
            {
                this.BackColor = Color.Blue;
            }
            if (i == 4)
            {
                this.BackColor = Color.Red;
                i = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.BackColor= Color.White;
        }
    }
}