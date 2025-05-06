using System.Diagnostics;

namespace WinFormsApp3
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
            str s = new str();
            s.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cels c = new Cels();
            c.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prime p = new Prime();
            p.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Armstrong a = new Armstrong();
            a.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BMI b = new BMI();
            b.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f= new Form2();
            f.ShowDialog();

        }
    }
}
