namespace Userlogin
{
    public partial class Form1 : Form
    {
        string[] user;
        string[] pass;
        int c;
        public Form1()
        {
            InitializeComponent();
            user = new string[100];
            pass = new string[100];
            c = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = textBox1.Text;
            string p = textBox2.Text;
            int flag = 0;
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i] == u && pass[i] == p)
                {
                    label1.Visible = true;
                    label1.Text = "Login successful";
                    label1.ForeColor = Color.Green;
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                label1.Visible = true;
                label1.Text = "Invalid id or pass";
                label1.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string u = textBox3.Text;
            string p = textBox4.Text;
            int flag = 0;
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i] == u)
                {
                    label2.Visible = true;
                    label2.Text = "User already exists";
                    label2.ForeColor = Color.Red;
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                label2.Visible = true;
                label2.Text = "User registered";
                label2.ForeColor = Color.Green;
                user[c] = u;
                pass[c++] = p;
            }
        }
    }
}
