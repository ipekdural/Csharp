namespace formlararasi_veritasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr= new Form2();
            fr.name1=textBox1.Text;
            fr.name2=textBox2.Text;
            fr.name3=textBox3.Text;
            fr.Show();
            this.Hide();
            
        }
    }
}