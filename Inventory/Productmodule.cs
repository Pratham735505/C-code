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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory
{
    public partial class Productmodule : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public Productmodule()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);
        }
        void load()
        {
            string query = "select max(pid) from product";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int d = Convert.ToInt32(dr[0]) + 1;
                    textuser.Text = "P0000" + d;

                }
            }
            else
            {
                textuser.Text = "P00001";
            }
            conn.Close();
            dr.Close();
            cmd.Dispose();


        }
        void loadcategory()
        {
            comboBox1.Items.Clear();
            string query = "select cat_name  from category";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0].ToString()!);
                }
            }
            conn.Close();
            dr.Close();
            cmd.Dispose();

        }
        private void Productmodule_Load(object sender, EventArgs e)
        {
            load();
            loadcategory();
        }

        void clear()
        {
            textprice.Clear();
            textname.Clear();
            textdesc.Clear();
            textqty.Clear();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save?", "Confirm", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    string query = $"insert into [Product] values('{textname.Text}',{textqty.Text},{textprice.Text},'{textdesc.Text}','{comboBox1.Text}')";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    int r = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully saved");
                    clear();
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured" + ex);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
