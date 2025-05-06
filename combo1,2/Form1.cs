namespace combo1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox2.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Lucknow");
            comboBox1.Items.Add("Sitapur");
            comboBox2.Items.Add("Lucknow");
            comboBox2.Items.Add("Sitapur");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string j in comboBox1.Items)
            {
                comboBox2.Items.Add(j);
            }
            comboBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string j in comboBox2.Items)
            {
                comboBox1.Items.Add(j);
            }
            comboBox2.Items.Clear();
        }
    }
}
