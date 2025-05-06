using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class CustomerModule : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public CustomerModule()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);
        }
        void load()
        {
            conn.Close();
            try
            {
                string query = "select max(cid) from Customers";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int d = Convert.ToInt32(dr[0]) + 1;
                        textuser.Text = "C0000" + d;
                    }
                }
                else
                {
                    textuser.Text = "C00001";
                }
                conn.Close();
                dr.Close();
                cmd.Dispose();

            }
            catch
            {
                conn.Close();
            }

        }

        private void CustomerModule_Load(object sender, EventArgs e)
        {
            load();
            conn.Close();
        }

        void clear()
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Enter Name");
                    return;
                }

                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Enter Contact");
                    return;
                }

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Enter Password");
                    return;
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Enter Address");
                    return;
                }

                if (textBox1.Text.Length < 8)
                {
                    MessageBox.Show("Password must be of 8 characters");
                }
                if (textBox4.Text.Length != 10)
                {
                    MessageBox.Show("Invalid contact length");
                    return;
                }

                string query = $"insert into Customers values('{textBox2.Text}','{textBox4.Text}','{textBox1.Text}','{textBox3.Text}')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                if (MessageBox.Show("Do you want to save?", "Confirm", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        MessageBox.Show("Saved");
                        clear();
                    }
                }

                conn.Close();
                cmd.Dispose();
            }
            catch(Exception ex)
            {

                conn.Close();
                MessageBox.Show(ex+"");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBox4.Text;

            // Use LINQ to filter only digits from the text
            string numericText = new string(currentText.Where(char.IsDigit).ToArray());

            // If the filtered text is different from the current text, update the TextBox
            if (numericText != currentText)
            {
                textBox4.Text = numericText;
                textBox4.SelectionStart = textBox4.Text.Length; // Move cursor to the end
            }
        }
    }
}
