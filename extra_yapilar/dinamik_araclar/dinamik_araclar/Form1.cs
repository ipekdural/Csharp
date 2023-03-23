namespace dinamik_araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //CREATIN TOOLS MANUALLY
            Button bt1 = new Button();
            Point lc = new Point(20, 20);
            bt1.Name = "button";
            bt1.Text = "press";
            bt1.Height = 50;
            bt1.Width = 100;
            bt1.BackColor = Color.BlueViolet;

            bt1.Location = lc;
            this.Controls.Add(bt1);

            Label lbl1 = new Label();
            Point lc2 = new Point(100, 100);
            lbl1.Location = lc2;
            lbl1.Text = "label1";
            lbl1.AutoSize = true;
            this.Controls.Add(lbl1);

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CREATIN TOOLS MULTIPLE TÝMES
            for (int i = 0; i < 10; i++)
            {
                Button bt = new Button();
                Point lc1 = new Point(500, 40 * i);
                bt.Name = "button";
                bt.Text = "press";
                bt.Height = 40;
                bt.Width = 100;
                bt.ForeColor = Color.White;
                bt.Text = "hello world";
                bt.BackColor = Color.CadetBlue;

                bt.Location = lc1;
                this.Controls.Add(bt);
            }
        }
    }
}