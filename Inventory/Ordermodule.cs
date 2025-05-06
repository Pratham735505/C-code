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

    public partial class Ordermodule : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public string cid;
        public Ordermodule()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);



        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void Loadcust()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                cmd = new SqlCommand($"SELECT cid, cname FROM [Customers] WHERE cid = '{cid}'", conn);
                // MessageBox.Show(cid+"ordermodule");
                //cmd.Parameters.AddWithValue("@cid", cid);

                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // Assuming you want to set values in text boxes
                        textBox1.Text = "C0000" + dr["cid"].ToString();
                        textBox2.Text = dr["cname"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Show the error message
            }
            finally
            {
                // Ensure DataReader and Connection are closed in finally block
                if (dr != null && !dr.IsClosed) dr.Close();
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            }
        }


        private void LoadProduct()
        {


            conn = new SqlConnection(s);
            dgv2.Rows.Clear();
            cmd = new SqlCommand($"Select * from [Product] where concat(pid,pname,price,pdescription,pcategory) like '%{textprod.Text}%'", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgv2.Rows.Add("P0000" + dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            dr.Close();
            cmd.Dispose();
            conn.Close();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textcust_TextChanged(object sender, EventArgs e)
        {
            Loadcust();
        }

        private void textprod_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox3.Text = dgv2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox4.Text = dgv2.Rows[e.RowIndex].Cells[1].Value.ToString();

                numericUpDown1.Maximum = Convert.ToInt32(dgv2.Rows[e.RowIndex].Cells[2].Value.ToString());
                textBox5.Text = dgv2.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox6.Text = (Convert.ToInt32(numericUpDown1.Value) * Convert.ToInt32(textBox5.Text)).ToString();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Select customer details by clicking on its data");
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Select customer details by clicking on its data");
                return;
            }
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Please select some quantity");
                return;
            }
            else
            {
                try
                {

                    string sql = $"insert into orders values(@OrderDate,{textBox3.Text.Substring(5)},{textBox1.Text.Substring(5)},{numericUpDown1.Value},{textBox5.Text},{textBox6.Text})";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);
                    conn.Open();
                    int d = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (d > 0)
                    {
                        MessageBox.Show("Order placed successfully");

                        int q = Convert.ToInt32(numericUpDown1.Maximum) - Convert.ToInt32(numericUpDown1.Value);

                        sql = $"update product set pqty={q} where pid={textBox3.Text.Substring(5)}";
                        cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        d = cmd.ExecuteNonQuery();
                        conn.Close();
                        cmd.Dispose();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Some error occurred");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");

                }
            }

        }
        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Ordermodule_Load(object sender, EventArgs e)
        {
            Loadcust();
            LoadProduct();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
