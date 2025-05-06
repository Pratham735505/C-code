using System;
using System.Windows.Forms;
using AssDbmslib;
using System.Data.SqlClient;
namespace Asssignment
{
    public partial class Form1 : Form
    {
        //Login l;
        private string user, pass;
        public Form1()
        {

            InitializeComponent();
            // l = new Login();
            user = "pg123";
            pass = "123456";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;


            if (string.IsNullOrEmpty(username))
            {
                label1.Text = "Username cannot be empty!";
                label1.Visible = true;
                return;
            }
            else
            {
                label1.Visible = false;
            }

            if (string.IsNullOrEmpty(password))
            {
                label2.Text = "Password cannot be empty!";
                label2.Visible = true;
                return;
            }
            else
            {
                label2.Visible = false;
            }


            if (password.Length < 6)
            {
                label2.Text = "Password must be at least 6 characters!";
                label2.Visible = true;
                return;
            }
            else
            {
                label2.Visible = false;
            }


            if (username!=user)
            {
                label1.Text = "User does not exist!";
                label1.Visible = true;
                return;
            }
            else
            {
                label1.Visible = false;
            }


            if (!(username==user && pass==password))
            {
                label2.Text = "Incorrect password!";
                label2.Visible = true;
                return;
            }
            else
            {
                label2.Visible = false;
            }

            textBox2.Text = "";
            Menu m = new Menu(this);
            m.ShowDialog();
            //this.Hide();
        }


        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) {
            if (textBox2.Text != null)
            {
                button2.Enabled = true;
            }
        }


        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0') textBox2.PasswordChar = '*';
            else textBox2.PasswordChar = '\0';
        }
    }
}
