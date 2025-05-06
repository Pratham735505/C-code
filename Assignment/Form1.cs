namespace Assignment
{
    public partial class Form1 : Form
    {
        Button b;
        ComboBox c;
        TextBox t;
        public Form1()
        {
            InitializeComponent();
            c= new ComboBox();
            b= new Button();
            t= new TextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
           // =new Button();
            b.Location = new Point(430, 199);
            b.Size = new Size(50, 30);
            b.Text = "Go";
            this.Controls.Add(b);
           //  = new ComboBox();
            c.Items.Add("fact");
            c.Items.Add("replace");
            c.Items.Add("sum");
            c.Items.Add("average");
            c.Items.Add("if");
            c.Items.Add("count");
            c.Items.Add("max");
            c.Items.Add("sin");
            c.Location = new Point(286,199);
            this.Controls.Add(c);
            b.Click+=new EventHandler(button3_Click);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b.Visible = false;
            c.Visible = false;
            if (c.Text == "fact")
            {
               // TextBox t= new TextBox();
                t.PlaceholderText = "Enter number";
                t.Location = new Point(286, 199);

                this.Controls.Add (t);
                
                t.TextChanged+= new EventHandler(text1_c);
                
            }
        }
        private void text1_c(object sender,EventArgs e)
        {
            int d = Convert.ToInt32(t.Text);
            int s = 1;
            while (d > 1)
            {
                s = s * d;
                d--;
            }

            Label l = new Label();
            l.Text = Convert.ToString(s);
            l.Location = new Point(286, 250);
            this.Controls.Add(l);
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
