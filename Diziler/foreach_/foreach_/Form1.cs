namespace foreach_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ints = { 1, 2, 3 ,4,5,6};
            foreach(int i in ints)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}