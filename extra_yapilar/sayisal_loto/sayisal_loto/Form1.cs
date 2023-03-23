namespace sayisal_loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            Random rd = new Random();
            int num1,num2,num3;
            num1 = rd.Next(1,5);
            num2 = rd.Next(1,5);
            num3 = rd.Next(1,5);
            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();

            if (label1.Text == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
                i++;
            }
            else { textBox1.BackColor = Color.Red; }

            if (label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
                i++;
            }
            else { textBox2.BackColor = Color.Red; }

            if (label3.Text == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
                i++;
            }
            else { textBox3.BackColor = Color.Red; }

            if(i==2) { this.BackColor = Color.Green; }
            else { this.BackColor = Color.Red; }
            i = 0;
        }
    }
}