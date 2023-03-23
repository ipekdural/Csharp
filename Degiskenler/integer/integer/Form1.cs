namespace integer
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

        private void button1_Click(object sender, EventArgs e)
        {
            int number=10;
            label1.Text=number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1, number2,sum;
            number1=12;
            number2=34;
            sum=number1+number2;
            label2.Text=sum.ToString();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int edge, area, perimeter;
            edge=12;
            area=edge*edge;
            perimeter=4*edge;
            label3.Text="Area:"+ area+" "+"Perimeter:"+ perimeter;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num;
            num=Convert.ToInt16(textBox1.Text);
            label4.Text=num.ToString();

        }

       
    }
}