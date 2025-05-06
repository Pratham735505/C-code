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
    public partial class Productform : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;

        public Productform()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            LoadProduct();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Productmodule m = new Productmodule();
            m.Show();
            LoadProduct();
        }

        private void Productform_Load(object sender, EventArgs e)
        {

        }
        private void LoadProduct()
        {


            conn = new SqlConnection(s);
            dgv1.Rows.Clear();
            cmd = new SqlCommand("Select * from [Product]", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgv1.Rows.Add("P0000" + dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            dr.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Addstock addstock = new Addstock();
            addstock.Show();

            LoadProduct();
        }
    }
}
