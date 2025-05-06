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
    public partial class Userform : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public Userform()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            Loaduser();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Userform_Load(object sender, EventArgs e)
        {
        }
        private void Loaduser()
        {


            conn = new SqlConnection(s);
            dgv1.Rows.Clear();
            cmd = new SqlCommand("Select * from [User]", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgv1.Rows.Add("U0000" + dr[4].ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());

                }
            }
            dr.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            UserModule n = new UserModule();
            
            
            n.ShowDialog();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_delete u= new User_delete();
            u.Show();
        }
    }
}
