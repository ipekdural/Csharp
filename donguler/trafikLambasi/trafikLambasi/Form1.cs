namespace trafikLambasi
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
         
            i++;
            label1.Text = i.ToString();
            if (i == 1) 
            {
                panel2.BackColor = Color.Red;
            }
            if (i == 31)
            {
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.Yellow;
            }
            if (i == 61)
            {
                panel3.BackColor = Color.White;
                panel4.BackColor = Color.Green;
            }
            if(i ==91)
            {
                panel4.BackColor = Color.White;
                i = 0;

            }

        }
    }
}