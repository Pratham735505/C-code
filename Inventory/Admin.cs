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
    public partial class Admin : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        string q;
        public Admin()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);
            lbltime.Text = DateTime.Now.ToString();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString();
            //loaddata();
        }
        private void loaddata()
        {
            try
            {
                // SQL query to count rows from three tables and sum the amount from 'forder'
                string query = @"
            SELECT 
                (SELECT COUNT(*) FROM forder) AS ForOrderCount, 
                (SELECT COUNT(*) FROM customers) AS CustomerCount, 
                (SELECT COUNT(*) FROM product) AS ProductCount, 
                (SELECT SUM(amt) FROM forder) AS TotalAmount";

                // Create a SqlCommand using the query and the open connection
                cmd = new SqlCommand(query, conn);
                conn.Open();

                // Execute the query and get the data
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    // Read the data from the reader
                    while (dr.Read())
                    {
                        int forOrderCount = dr.GetInt32(0);  // ForOrderCount
                        int customerCount = dr.GetInt32(1);  // CustomerCount
                        int productCount = dr.GetInt32(2);   // ProductCount
                        int totalAmount = Convert.ToInt32(dr[3].ToString());// TotalAmount (ensure nulls are handled)

                        // Display or use the fetched data
                       // MessageBox.Show($"ForOrder Count: {forOrderCount}\n" +
                                        // $"Customer Count: {customerCount}\n" +
                                         //$"Product Count: {productCount}\n" +
                                         //$"Total Amount: {totalAmount:C}");
                        lbl_cust.Text = Convert.ToString(customerCount);
                        llbcust.Text = Convert.ToString(forOrderCount);
                        lblp.Text = Convert.ToString(productCount);
                        lblearn.Text = Convert.ToString(totalAmount);
                        lblprofit.Text=Convert.ToString(totalAmount/10);
                    }

                }

                // Close the reader and connection
                dr.Close();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void llbcust_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cust_Click(object sender, EventArgs e)
        {

        }

        private void lblp_Click(object sender, EventArgs e)
        {

        }

        private void lblearn_Click(object sender, EventArgs e)
        {

        }
    }
}
