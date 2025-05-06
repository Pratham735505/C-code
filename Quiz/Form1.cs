namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            label4.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(comboBox1.Text);
            if (age >= 1 && age <= 10)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Hindi");
                comboBox2.Items.Add("English");
                comboBox2.Items.Add("Maths");
                comboBox2.Items.Add("Science");

            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("C#");
                comboBox2.Items.Add("Discrete Maths");
                comboBox2.Items.Add("Software Testing");
                comboBox2.Items.Add("Computer Graphics");
            }
            //System.DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && comboBox1.Text.Length!=0 && comboBox2.Text.Length!=0)
            {
                Ques q = new Ques();
                q.ShowDialog();
               // this.Hide();
                this.Close();
            }
            else
            {
                label5.Visible = true;
                label5.Text = "Enter all entries";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval <= 1000)
            {
                label4.Visible = true;
                label4.Text = System.DateTime.Now.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
