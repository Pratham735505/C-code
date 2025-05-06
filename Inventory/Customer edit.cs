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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory
{
    public partial class Customer_edit : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public Customer_edit()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);
        }
        void comboload()
        {
            try
            {
                comboBox1.Items.Clear();
                string q = "select cid from [Customers]";
                cmd = new SqlCommand(q, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add("C0000" + dr[0].ToString());
                }
                cmd.Dispose();
                conn.Close();

                textBox2.Clear();

                textBox4.Clear();
            }
            catch { }
        }
        private void Customer_edit_Load(object sender, EventArgs e)
        {
            comboload();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string q = $"select * from [Customers] where cid={comboBox1.Text.ToString()!.Substring(5)}";
                cmd = new SqlCommand(q, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    textBox2.Text = dr[1].ToString();

                    textBox4.Text = dr[2].ToString();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Select Customer");
                    return;
                }
                else
                {
                    string q = $"delete from [Customers] where cid={comboBox1.Text.ToString().Substring(5)}";
                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    if (MessageBox.Show("Confirm", "Do you want to delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int d = cmd.ExecuteNonQuery();
                        if (d > 0)
                        {
                            MessageBox.Show("Deleted");
                            comboload();
                        }
                        else
                        {
                            MessageBox.Show("Some error occured");
                        }
                    }
                    conn.Close();
                }
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Select Customer");
                    return;
                }
                if (textBox4.Text.Length != 8)
                {
                    MessageBox.Show("Contact must be of 10 digits");
                }
                else
                {
                    string q = $"update [Customers] set cphone='{textBox4.Text}' where cid={comboBox1.Text.ToString().Substring(5)}";
                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    if (MessageBox.Show("Confirm", "Do you want to Update?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int d = cmd.ExecuteNonQuery();
                        if (d > 0)
                        {
                            MessageBox.Show("Updated");
                            comboload();
                        }
                        else
                        {
                            MessageBox.Show("Some error occured");
                        }
                    }
                    conn.Close();
                }
            }
            catch { }
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
