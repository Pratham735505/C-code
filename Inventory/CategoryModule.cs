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
    public partial class CategoryModule : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public CategoryModule()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);
        }

        private void CategoryModule_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            load();
        }
        void load()
        {
            string query = "select max(cat_id) from Category";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int d = Convert.ToInt32(dr[0]) + 1;
                textuser.Text = "CT000" + d;
            }
            conn.Close();
            dr.Close();
            cmd.Dispose();
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            textBox2.Clear();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            load();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"insert into Category values('{textBox2.Text}')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                if (MessageBox.Show("Do you wwant to save?", "Confirm", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    int d = cmd.ExecuteNonQuery();
                    if (d > 0)
                    {
                        MessageBox.Show("Saved");
                        clear();
                    }
                }
                conn.Close();
                cmd.Dispose();
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
