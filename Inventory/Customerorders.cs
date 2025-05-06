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
    public partial class Customerorders : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public string cid;

        public Customerorders()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            Payment_gateway g = new Payment_gateway();
            g.amt.Text = textBox1.Text;
            g.cid = cid;
            g.Show();
            Bill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bill()
        {
            try
            {
                // Clear existing rows in DataGridView
                dataGridView1.Rows.Clear();

                // SQL query to fetch the required fields from the Orders table
                string query = $"SELECT pid, qty, price, amount FROM [Orders] where cid='{cid}'";
                cmd = new SqlCommand(query, conn);

                conn.Open();
                dr = cmd.ExecuteReader();

                int totalAmount = 0; // Variable to hold the sum of all amounts

                // Loop through each row in the result set
                while (dr.Read())
                {
                    // Retrieve data from the current row
                    string pid = dr["pid"].ToString();
                    int qty = Convert.ToInt32(dr["qty"]);
                    decimal price = Convert.ToDecimal(dr["price"]);
                    int amount = Convert.ToInt32(dr["amount"]);

                    // Add the row to the DataGridView
                    dataGridView1.Rows.Add(pid, qty, price, amount);

                    // Add the amount to the totalAmount
                    totalAmount += amount;
                }

                // Set the total amount in textBox1
                textBox1.Text = totalAmount.ToString(); // Format to 2 decimal places

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching bill data: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void Customerorders_Load(object sender, EventArgs e)
        {
            Bill();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
