using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class UserModule : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public UserModule()
        {

            InitializeComponent();
        }

        private void UserModule_Load(object sender, EventArgs e)
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            conn = new SqlConnection(s);
            string query = $"select max(u_id) from [User]";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int d = Convert.ToInt32(dr[0]) + 1;
                textBox5.Text = "U0000" + d.ToString();
            }
            conn.Close();

            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox2.Text)){
                    MessageBox.Show("Enter Fullname");
                    return;
                }
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Enter F");
                    return;
                }
                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Enter Contact");
                    return;
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Enter password");
                    return;
                }
                if (textBox3.Text.Length < 8) 
                {
                    MessageBox.Show("Password can't be of less than 8");
                    return;
                }
                if (textBox4.Text.Length != 10)
                {
                    MessageBox.Show("Invalid contact length");
                    return;
                }
                if (MessageBox.Show("Do you want to save?", "Confirm", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    string query = $"insert into [User] values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}')";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    int r = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully saved");
                    clear();
                    s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
                    conn = new SqlConnection(s);
                    query = $"select max(u_id) from [User]";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int d = Convert.ToInt32(dr[0]) + 1;
                        textBox5.Text = "U0000" + d.ToString();
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured" + ex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBox4.Text;

            
            string numericText = new string(currentText.Where(char.IsDigit).ToArray());

            
            if (numericText != currentText)
            {
                textBox4.Text = numericText;
                textBox4.SelectionStart = textBox4.Text.Length; 
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
