using System.Windows.Forms.VisualStyles;

namespace for_dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) { listBox1.Items.Add(i.ToString() + "- Hello  World!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 2; i < 10; i += 2)
            {
                toplam += i;

            }

            label2.Visible = true;
            label2.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            for (int j = 1; j <= sayi; j++)
            {
                if (sayi % j == 0)
                {
                    listBox2.Items.Add(j.ToString());
                }
            }

            int i = 1;
            while (i <= sayi)
            {
                if ((sayi % i) == 0)
                {
                    listBox3.Items.Add(i.ToString());
                }
                i++;
            }
            int k = 1;
            do
            {
                
                if ((sayi % k) == 0)
                {
                    listBox4.Items.Add(k.ToString());
                }
                k++;

            }while (k<sayi);

        }


    }
}