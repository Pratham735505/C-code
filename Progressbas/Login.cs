using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progressbas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            if (s1== "Pg123" && s2 == "123456")
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Login Successful";
                label1.Visible = true;
                Form2 f=new Form2();
                f.ShowDialog();
                this.Close();
            }
            else if(s1!="Pg123" && s2 == "123456")
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Username not found";
                label1.Visible = true;
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Invalid Password";
                label1.Visible = true;
            }
        }
    }
}
