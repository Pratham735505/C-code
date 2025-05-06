namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval <= 1000)
            {
                label1.Visible = false;

            }
            timer3.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer3.Interval <= 1000)
            {
                label1.Visible = true;

            }
            timer1.Enabled = true;
            timer3.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
