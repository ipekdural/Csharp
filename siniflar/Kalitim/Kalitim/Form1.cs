namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            student student1 = new student();
            student1.Name = "marie curie";
            student1.Id = 122333;
            student1.Age = -12;
            student1.Exam1 = 100;
            student1.Exam2 = 90;

            label1.Text = student1.Name;
            label2.Text = student1.Id.ToString();
            label3.Text = student1.Age.ToString();
            label4.Text = student1.Exam1.ToString();
            label5.Text = student1.Exam2.ToString();
        }
    }
}