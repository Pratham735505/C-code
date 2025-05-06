
using System.Data.SqlClient;
namespace Database2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string str;
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void refresh()
        {
            listBox1.Items.Clear();
            str = "Data Source=Pratham;Initial Catalog=Employee;Integrated Security=True";
            conn = new SqlConnection(str);
            string sql = "select empid from emp;";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows) //returns true or false
            {
                while (dr.Read())
                {
                    listBox1.Items.Add("E00" + dr[0]);
                }
            }
            conn.Close();
            cmd.Dispose();
            dr.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            str = "Data Source=Pratham;Initial Catalog=Employee;Integrated Security=True";
            conn = new SqlConnection(str);
            string sql = "select empid from emp;";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows) //returns true or false
            {
                while (dr.Read())
                {
                    listBox1.Items.Add("E00" + dr[0]);
                }
            }
            conn.Close();
            cmd.Dispose();
            dr.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Enter all the fields");
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str = "Data Source=Pratham;Initial Catalog=Employee;Integrated Security=True";
            conn = new SqlConnection(str);

            string sql = "select max(empid) from emp;";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //listBox1.Items.Add(dr[0]);
                    int x = Convert.ToInt32(dr[0]) + 1;
                    textBox1.Text = "E00" + (x).ToString();
                    button1.Enabled = true;
                }

            }

            conn.Close();
            cmd.Dispose();
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            string s = listBox1.Text.Substring(3);

            x = Convert.ToInt32(s);
            str = "Data Source=Pratham;Initial Catalog=Employee;Integrated Security=True";
            conn = new SqlConnection(str);

            string sql = "select * from emp where empid=" + x + " ";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //listBox1.Items.Add(dr[0]);
                    textBox1.Text = "E00" + dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                }
                button4.Enabled = true;
                button5.Enabled = true;

            }
            else
            {
                MessageBox.Show("Record Not found");
            }
            conn.Close();
            cmd.Dispose();
            dr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Address can't be empty");
                return;
            }
            int id = Convert.ToInt32(textBox1.Text.Substring(3));
            string sql = $"update emp set eaddress='{textBox3.Text}' where empid={id}";

            cmd = new SqlCommand(sql, conn);
            conn.Open();

            DialogResult result = MessageBox.Show("Do you want to update?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Updated");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    refresh();
                }
                else
                {
                    MessageBox.Show("Error occurred");
                }
            }
            conn.Close();
            cmd.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            int id = Convert.ToInt32(textBox1.Text.Substring(3));
            string sql = $"delete from emp where empid={id}";

            cmd = new SqlCommand(sql, conn);
            conn.Open();

            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Deleted");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    refresh();
                }
                else
                {
                    MessageBox.Show("Error occurred");
                }
            }
            conn.Close();
            cmd.Dispose();
            dr.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
