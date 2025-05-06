using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;
namespace Database2
{
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader dr;
        SqlDataAdapter da;
        string str, sql;
        DataTable dt;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            str = "Data Source=Pratham;Initial Catalog=Employee;Integrated Security=True;";
            conn = new SqlConnection(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(textBox1.Text);
            sql = $"select * from emp where empid={id}";
            da = new SqlDataAdapter(sql, conn);

            ds = new DataSet("emp");
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            // No need to open or close this
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            sql = $"select * from emp where ename like '{name}%'";
            da = new SqlDataAdapter(sql, conn);
            ds = new DataSet("emp");
            //dt = new DataTable("emp");
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string name = dataGridView1["ename", 0].Value.ToString()!; // for updating the rows
            int id = Convert.ToInt32(dataGridView1["empid", 0].Value);
            object ob=dataGridView1.RowCount;// displays number of rows+1
            //object o = dataGridView1.Columns["empid"];
            //MessageBox.Show(o.ToString());
            MessageBox.Show(ob.ToString());
            sql = $"update emp set ename='{name}' where empid={id}";
            conn.Open();
            cmd= new SqlCommand(sql, conn);
            DialogResult d=
                MessageBox.Show("Confirm", "Do you want to update", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Updated");
                }
            }
            
          //  ds = new DataSet("emp");
            //object o=dataGridView1.DataSource;
            conn.Close();
        
        }
    }
}
