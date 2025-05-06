using System.Globalization;

namespace Testclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // testbox is a class
            TextBox t = new TextBox();
            t.Location = new Point(150, 150); //x,y

            t.BackColor = Color.Red;
            t.Text = "Hello NPGC";
            this.Controls.Add(t);// for adding text box on our form this represents text box
            //similarly we can add any other component dynamically using these
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding items in combobox
            comboBox1.Items.Add("Lucknow");
            comboBox1.Items.Add("Gonda");
            comboBox1.Items.Add("Gorakhpur");
            comboBox1.Items.Add("Lakheempur");
            comboBox1.Items.Add("Sitapur");
            comboBox1.Items.Add("Hardoi");
            comboBox1.Items.Add("Kanpur");
            comboBox1.Items.Add("Unnao");
            comboBox1.Items.Add("Noida");
            comboBox1.Items.Add("Ghaziabad");
            comboBox1.Items.Add("Sultanpur");
            comboBox1.Items.Add("Kakori");
            comboBox1.Items.Add("Agra");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = comboBox1.Text;
            string x = textBox1.Text;
            if (x == "Lucknow")
            {
                comboBox1.ForeColor = Color.Red;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            Label l = new Label();
            l.Text = "Added";
            l.Location = new Point(100, 100);
            l.BackColor = Color.Gainsboro;
            this.Controls.Add(l);
        }

        private void button3_Click(object sender, EventArgs e)
        {
         //   comboBox1.Items.Remove(comboBox1.Text);
            // for removing
            comboBox1.Items.Clear();// removes completely

        }
    }
}
