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
    public partial class Addstock : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        int c;
        public Addstock()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();

            conn = new SqlConnection(s);

            c = 0;
            LoadCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cmd = new SqlCommand($"Select pname,price,pqty from [Product] where pid={comboBox1.Text.Substring(5)}", conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textname.Text = dr[0].ToString();
                    textBox1.Text = dr[1].ToString();
                    textamt.Text = (Convert.ToInt32(dr[1].ToString()) * numericUpDown1.Value).ToString();
                    c = Convert.ToInt32(dr[2].ToString());
                }
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
        void LoadCombo()
        {
            try
            {
                comboBox1.Items.Clear();
                cmd = new SqlCommand("Select pid from [Product]", conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add("P0000" + dr[0].ToString());
                }
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textamt_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textamt.Text = ((Convert.ToInt32(dr[1].ToString()) * numericUpDown1.Value) * 90 / 100).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Pay " + textamt.Text, "Buy Items?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int d = c + Convert.ToInt32(numericUpDown1.Value);
                    cmd = new SqlCommand($"Update [Product] set  pqty={d} where pid={comboBox1.Text.Substring(5)}", conn);
                    conn.Open();
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Successful");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                conn.Close();
            }
        }

        private void Addstock_Load(object sender, EventArgs e)
        {

        }
    }
}
