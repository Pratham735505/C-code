namespace Traffic
{
    public partial class Form1 : Form
    {
        int x = 0;
        int i;
        public Form1()
        {
            i = 0;
            InitializeComponent();
            x = 77;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i == 0)
            {
                label2.BackColor = Color.Black;
                label1.BackColor = Color.Red;
                label3.BackColor = Color.Black;

            }
            //  label2.Location
            else if (i == 1)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Yellow;
                label3.BackColor = Color.Black;
            }
            else
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Green;

            }
            i = (i + 1) % 3;
          //  timer1.Enabled = false;
            //timer2.Enabled = true;
            //tim8er3.Enabled = false;
        }
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
