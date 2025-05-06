namespace Progressbas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                label1.Text = "Loading..." + progressBar1.Value.ToString() + "%";
                label1.Visible = true;
                //timer4.Enabled = true;
                timer4.Start();
            }
            else if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login l = new Login();
                l.ShowDialog();
                timer1.Enabled = false;
                
                timer4.Stop();
                this.Close();

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Visible = true;
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            label1.Visible = false;
            timer4.Enabled = false;
        }
    }
}
