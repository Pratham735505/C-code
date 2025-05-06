namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("323");
            listBox1.Items.Add("123");
            listBox1.Items.Add("223"); listBox1.Items.Add("823");
            listBox1.Items.Add("423");
            listBox1.Items.Add("523");
            listBox1.Items.Add("623");
            listBox1.Items.Add("723");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            foreach (var item in listBox1.SelectedItems)
            {
                list.Add(item);
            }
            foreach (var item in list)
            {
                listBox1.Items.Remove(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        /*   Label label = new Label();
           label.Text=Convert.ToString(listBox1.Items.Contains(textBox1.Text));
            this.Controls.Add(label);*/
        //checks whether our listbox contains an element or not
        }
    }
}
