namespace textboxtan_eleman_ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] x = new int[10];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                x[i] = Convert.ToInt32(textBox1.Text);
                i++;
            }
            else { textBox1.Enabled=false;button1.Enabled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(x[i]);
            }
        }
    }
}