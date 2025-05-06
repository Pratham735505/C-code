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
    public partial class Orderform : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public string cid;
        public bool admin;

        public Orderform()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);

            admin = true;
            cid = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Ordermodule m = new Ordermodule();
            m.cid = cid;
            m.Show();
        }

        private void Orderform_Load(object sender, EventArgs e)
        {
            if (admin)
            {
                btnadd.Visible = false;
                btnorder.Visible = false;
                btn_cart.Visible = false;
            }
            loadorder();
        }


        void loadorder()
        {
            // Ensure the connection is closed before starting
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                // Clear the DataGridView rows to avoid duplications
                dgv1.Rows.Clear();

                // Define the SQL query based on the user's role
                string query;
                if (admin == true)
                {
                    query = "SELECT order_id, date_of_order, customerid, amt, address FROM forder";
                }
                else
                {
                    query = $"SELECT order_id, date_of_order, customerid, amt, address FROM forder WHERE customerid = @customerId";
                }

                // Create and set up the SQL command
                cmd = new SqlCommand(query, conn);

                if (admin == false)
                {
                    // Add customer ID parameter if not an admin
                    cmd.Parameters.AddWithValue("@customerId", cid);
                }

                // Open the connection and execute the query
                conn.Open();
                dr = cmd.ExecuteReader();

                // Check if there are rows to read
                if (dr.HasRows)
                {
                    // Loop through each row and add it to the DataGridView
                    while (dr.Read())
                    {
                        dgv1.Rows.Add(
                            "OR000" + dr["order_id"].ToString(),          // order_id with prefix
                            Convert.ToDateTime(dr["date_of_order"]).ToString("yyyy-MM-dd"),  // formatted date_of_order
                            "C0000" + dr["customerid"].ToString(),         // customer_id with prefix
                            dr["amt"].ToString(),                          // amount
                            dr["address"].ToString()                       // address
                        );
                    }
                }

                // Clean up
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                // Show any errors that occur
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
            finally
            {
                // Close the connection in the finally block to ensure it is closed
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    
    

    private void button1_Click(object sender, EventArgs e)
        {
            Customerorders customerorders = new Customerorders();
            customerorders.cid = cid;
            customerorders.Show();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.cid = cid;
            cart.Show();
        }
    }
}
