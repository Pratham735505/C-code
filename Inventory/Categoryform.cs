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
    public partial class Categoryform : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public Categoryform()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            Loadcategory();
        }

        private void Loadcategory()
        {


            conn = new SqlConnection(s);
            dgv1.Rows.Clear();
            cmd = new SqlCommand("Select * from [category]", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgv1.Rows.Add("CT000" + dr[0].ToString(), dr[1].ToString());

                }
            }
            dr.Close();
            cmd.Dispose();
            conn.Close();
        }
        private void Categoryform_Load(object sender, EventArgs e)
        {

        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            CategoryModule m = new CategoryModule();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category_Edit q = new Category_Edit();
            q.Show();
        }
    }
}
