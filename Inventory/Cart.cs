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
    public partial class Cart : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public string cid;
        public Cart()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);

            
            cid = "";
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            loadcart();
        }

        void loadcart()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                dgv1.Rows.Clear();
                string q;
                
                    q = $"SELECT * FROM [Orders] WHERE cid = '{cid}'";

                
                cmd = new SqlCommand(q, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        dgv1.Rows.Add("CR000" + dr[0].ToString(), dr[1].ToString(), dr[4].ToString(), "P0000" + dr[2].ToString(), "C0000" + dr[3].ToString(), dr[5].ToString(), dr[6].ToString());

                    }
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

        }
    }
}
