namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        int t;
        public Form1()
        {
            InitializeComponent();
            t = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t == 0)
            {
                label3.BackColor = Color.Black;
                label1.BackColor = Color.Red;
                t++;
            }
            else if (t == 1)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Yellow;
                t++;
            }
            else
            {
                t = 0;
                label2.BackColor = Color.Black ;
                label3.BackColor= Color.Green ;
            }
        }
    }
}
