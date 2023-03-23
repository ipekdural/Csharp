namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strings = { "apple", "orange", "melon", "banana" };
            listBox1.Items.Add(strings[2]);

            char[] chars = { 'A', 'b', '+', '1', 'x' };
            listBox1.Items.Add((char)chars[0]);

            //formload a yazdigimiz kodlar kod calistirilinca ekrana otomatik yazdirilir.



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ints = { 1, 2, 3 };
            label1.Text = ints[2].ToString();
        }
    }
}