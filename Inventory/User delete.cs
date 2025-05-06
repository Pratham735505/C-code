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
    public partial class User_delete : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        int count = 0;
        public User_delete()
        {

            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(count <= 1))
                {
                    if (string.IsNullOrEmpty(comboBox1.Text))
                    {
                        MessageBox.Show("Select user");
                        return;
                    }
                    else
                    {
                        string q = $"delete from [User] where u_id={comboBox1.Text.ToString().Substring(5)}";
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
                else
                {
                    MessageBox.Show("Can't delete, only 1 admin left");
                    return;
                }
            }
            catch { }
        }

        private void User_delete_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboload();
        }

        void comboload()
        {
            try
            {
                comboBox1.Items.Clear();
                string q = "select u_id from [User]";
                cmd = new SqlCommand(q, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count++;
                    comboBox1.Items.Add("U0000" + dr[0].ToString());
                }
                cmd.Dispose();
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string q = $"select * from [User] where u_id={comboBox1.Text.ToString()!.Substring(5)}";
                cmd = new SqlCommand(q, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                    textBox4.Text = dr[3].ToString();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Select user");
                    return;
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Password can't be empty");
                    return;

                }
                if (textBox3.Text.Length < 8)
                {
                    MessageBox.Show("Password must be of 8 digits");
                }
                else
                {
                    string q = $"update [User] set pwd='{textBox3.Text}' where u_id={comboBox1.Text.ToString().Substring(5)}";
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
            catch (Exception ex) { MessageBox.Show(ex + ""); }
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
