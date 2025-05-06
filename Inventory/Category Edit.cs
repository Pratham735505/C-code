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
    public partial class Category_Edit : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public Category_Edit()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);
        }

        private void Category_Edit_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            comboload();

        }

        void comboload()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                comboBox1.Items.Clear();
                string q = "select cat_id from [Category]";
                cmd = new SqlCommand(q, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add("CT000" + dr[0].ToString());
                }
                cmd.Dispose();
                conn.Close();
                textBox2.Clear();

            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string q = $"select * from [Category] where cat_id={comboBox1.Text.ToString()!.Substring(5)}";
                cmd = new SqlCommand(q, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    textBox2.Text = dr[1].ToString();


                }
                cmd.Dispose();
                conn.Close();
            }
            catch {}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Select Category");
                    return;
                }
                else
                {
                    string q = $"delete from [Category] where cat_id={comboBox1.Text.ToString().Substring(5)}";
                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    if (MessageBox.Show("Confirm", "Do you want to delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int d = cmd.ExecuteNonQuery();
                        if (d > 0)
                        {
                            MessageBox.Show("Deleted");
                            comboload();
                        }
                        else
                        {
                            MessageBox.Show("Some error occured");
                        }
                    }
                    conn.Close();
                }
            }catch { }

        }
    }
}
