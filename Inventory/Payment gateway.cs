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
    public partial class Payment_gateway : Form
    {
        public string cid;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public Payment_gateway()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            conn = new SqlConnection(s);
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("Order placed");
            if (amt.Text == "0")
            {
                MessageBox.Show("First Add items to cart");
                this.Close();
            }
            InsertOrder();
            this.Close();
        }

        private void InsertOrder()
        {
            try
            {
                // Fetch customer information from the Customers table
                string fetchCustomerQuery = "SELECT cname, address FROM Customers WHERE cid = @customerId";
                SqlCommand fetchCmd = new SqlCommand(fetchCustomerQuery, conn);
                fetchCmd.Parameters.AddWithValue("@customerId", cid);

                conn.Open();
                SqlDataReader dr = fetchCmd.ExecuteReader();

                string customerName = "";
                string address = "";

                if (dr.Read())
                {
                    // Retrieve customer details
                    customerName = dr["cname"].ToString();
                    address = dr["address"].ToString();
                }
                dr.Close();

                // Convert amount from label2.Text to decimal
                int amount = Convert.ToInt32(amt.Text);


                // Insert the order into the forder table
                string insertOrderQuery = "INSERT INTO forder (customername, customerid, date_of_order, address, amt) " +
                                          "VALUES (@customerName, @customerId, @dateOfOrder, @address, @amount)";

                SqlCommand insertCmd = new SqlCommand(insertOrderQuery, conn);
                insertCmd.Parameters.AddWithValue("@customerName", customerName);
                insertCmd.Parameters.AddWithValue("@customerId", cid);
                insertCmd.Parameters.AddWithValue("@dateOfOrder", DateTime.Now); // Sets current date for the order
                insertCmd.Parameters.AddWithValue("@address", address);
                insertCmd.Parameters.AddWithValue("@amount", amount);

                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order inserted successfully.");

                    // Now delete records from Orders table where cid matches customerId
                    string deleteOrderQuery = "DELETE FROM [Orders] WHERE cid = @customerId";
                    SqlCommand deleteCmd = new SqlCommand(deleteOrderQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@customerId", cid);

                    int deletedRows = deleteCmd.ExecuteNonQuery();
                    //  MessageBox.Show($"{deletedRows} record(s) deleted from Orders table.");
                }
                else
                {
                    MessageBox.Show("Failed to insert the order.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting order: " + ex);
            }
            finally
            {
                // Ensure the connection is closed
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void amt_Click(object sender, EventArgs e)
        {

        }

        private void Payment_gateway_Load(object sender, EventArgs e)
        {

        }
    }
}
