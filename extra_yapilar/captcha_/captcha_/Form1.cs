using System.Security.Cryptography.X509Certificates;

namespace captcha_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            string[] s1 = { "A", "X", "T", "Ð", "W", "Q" };
            string[] s2 = { "v", "k", "s", "b", "h" };
            string[] s3 = { "!", "0", "G", "P", "R" };
            int[] i1 = { 1, 2, 3, 4, 5, 6, 0, 7, 9 };
            Random rnd = new Random();
            int j1, j2, j3, j4;
            j1 = rnd.Next(0, s1.Length);
            j2 = rnd.Next(0, s2.Length);
            j3 = rnd.Next(0, s3.Length);
            j4 = rnd.Next(0, i1.Length);

            label1.Text = s1[j1] + s2[j2] + s3[j3] + i1[j4].ToString();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            string[] s1 = { "A", "X", "T", "Ð", "W", "Q" };
            string[] s2 = { "v", "k", "s", "b", "h" };
            string[] s3 = { "!", "0", "G", "P", "R" };
            int[] i1 = { 1, 2, 3, 4, 5, 6, 0, 7, 9 };
            Random rnd = new Random();
            int j1, j2, j3, j4;
            j1 = rnd.Next(0, s1.Length);
            j2 = rnd.Next(0, s2.Length);
            j3 = rnd.Next(0, s3.Length);
            j4 = rnd.Next(0, i1.Length);
            label1.Text = s1[j1] + s2[j2] + s3[j3] + i1[j4].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label1.Text)
            {
                Application.Exit();
            }
            else
            {
                textBox1.Text = "";
                label3.Visible = true;
                label3.Text = "Try again!";
                radioButton1.Checked = false;
                button1.Enabled = false;

                string[] s1 = { "A", "X", "T", "Ð", "W", "Q" };
                string[] s2 = { "v", "k", "s", "b", "h" };
                string[] s3 = { "!", "B", "G", "P", "R" };
                int[] i1 = { 1, 2, 3, 4, 5, 6, 0, 7, 9 };
                Random rnd = new Random();
                int j1, j2, j3, j4;
                j1 = rnd.Next(0, s1.Length);
                j2 = rnd.Next(0, s2.Length);
                j3 = rnd.Next(0, s3.Length);
                j4 = rnd.Next(0, i1.Length);
                label1.Text = s1[j1] + s2[j2] + s3[j3] + i1[j4].ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            radioButton1.Enabled = true;
        }
    }


}