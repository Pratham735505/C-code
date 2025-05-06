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

    public partial class Customerform : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public Customerform()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            Loadcust();
        }

        void Loadcust()
        {
            conn = new SqlConnection(s);
            dgv1.Rows.Clear();
            cmd = new SqlCommand("Select * from [Customers]", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgv1.Rows.Add("C0000" + dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

                }
            }
            dr.Close();
            cmd.Dispose();
            conn.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            CustomerModule m = new CustomerModule();
            m.Show();

        }

        private void Customerform_Load(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_edit customer_Edit = new Customer_edit();
            customer_Edit.Show();
        }
    }
}
