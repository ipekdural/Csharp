using System.Windows.Forms.VisualStyles;

namespace arac_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text="ipek";
            label5.Text="dural";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}