namespace dijital_saat
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int i = 0, j = 0, k = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString("00");
            if (i == 59)
            {
                label1.Text = "00";
                i = 0;
                j++;
                label2.Text = j.ToString("00");

                if (j == 59)
                {
                    label2.Text = "00";
                    j = 0;
                    k++;
                    label3.Text = k.ToString("00");
                    if (k == 24)
                    {
                        label3.Text = "00";
                        label2.Text = "00";
                        label1.Text = "00";
                        k = 0;
                    }

                }

            }
        }
    }
}