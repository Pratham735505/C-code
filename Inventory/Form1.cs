using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s, x1, m1, x2, m2;
        Random r;
        Mainform form;
        public Form1()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            conn = new SqlConnection(s);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 3)
            {
                try
                {
                    if (string.IsNullOrEmpty(textBox1.Text))
                    {
                        MessageBox.Show("Enter username");
                        //  getcaptcha1();
                        return;
                    }

                    if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        MessageBox.Show("Enter Password");
                        //    getcaptcha1();
                        return;
                    }
                    if (string.IsNullOrEmpty(textBox3.Text))
                    {
                        MessageBox.Show("Enter captcha");
                        return;
                    }
                    string q = $"select username,pwd,Fullname from [User] where username='{textBox1.Text}'";
                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (dr[1].ToString() == textBox2.Text)
                            {
                                if (m1 == textBox3.Text)
                                {
                                    form = new Mainform();
                                    MessageBox.Show("Welcome Admin: " + dr[2].ToString());
                                    this.Hide();

                                    //   getcaptcha1();

                                    if (form.ShowDialog() == DialogResult.None)
                                    {
                                        this.Show();
                                    }
                                    textBox2.Clear();
                                }
                                else
                                {
                                    conn.Close();
                                    MessageBox.Show("Inavlid Captcha");
                                    getcaptcha1();
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Password");
                                conn.Close();
                                getcaptcha1();
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("User does not exists");
                        conn.Close();
                        getcaptcha1();
                        return;
                    }
                    conn.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
                finally { conn.Close(); }
            }
            else
            {
                button1.Enabled = false;

                getcaptcha1();
                MessageBox.Show("Reopen Again");
            }
            i++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getcaptcha1();
            getcaptcha2();
        }

        private void getcaptcha1()
        {
            try
            {
                r = new Random();
                int d = r.Next(1, 10);

                // Parameterized query to prevent SQL injection
                string query = "SELECT id, imgpath, imgval FROM img WHERE id = @id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", d);

                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())  // Only read a single row, since you're fetching one image
                {
                    x1 = dr["imgpath"].ToString();
                    m1 = dr["imgval"].ToString();

                    // Load the image without locking the file
                    if (!string.IsNullOrEmpty(x1))
                    {
                        using (var imgStream = new FileStream($"captcha/{x1}", FileMode.Open, FileAccess.Read))
                        {
                            pictureBox1.Image = Image.FromStream(imgStream);
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading captcha: " + ex.Message);
            }
            finally
            {
                // Ensure resources are properly closed
                if (dr != null && !dr.IsClosed) dr.Close();
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            }
        }



        private void getcaptcha2()
        {
            try
            {
                r = new Random();
                int d = r.Next(1, 10);

                // Parameterized query to prevent SQL injection
                string query = "SELECT id, imgpath, imgval FROM img WHERE id = @id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", d);

                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())  // Only read a single row, since you're fetching one image
                {
                    x2 = dr["imgpath"].ToString();
                    m2 = dr["imgval"].ToString();

                    // Load the image without locking the file
                    if (!string.IsNullOrEmpty(x1))
                    {
                        using (var imgStream = new FileStream($"captcha/{x2}", FileMode.Open, FileAccess.Read))
                        {
                            pictureBox2.Image = Image.FromStream(imgStream);
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading captcha: " + ex.Message);
            }
            finally
            {
                // Ensure resources are properly closed
                if (dr != null && !dr.IsClosed) dr.Close();
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox5.PasswordChar = '\0';
            }
            else
            {
                textBox5.PasswordChar = '*';
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        int j = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (j < 3)
            {
                try
                {
                    if (string.IsNullOrEmpty(textBox6.Text))
                    {
                        MessageBox.Show("Enter userId");
                        //getcaptcha2();
                        return;
                    }

                    if (string.IsNullOrEmpty(textBox5.Text))
                    {
                        MessageBox.Show("Enter Password");
                        //  getcaptcha2();
                        return;
                    }
                    if (string.IsNullOrEmpty(textBox6.Text))
                    {
                        MessageBox.Show("Enter captcha");
                        return;
                    }
                    string g = textBox6.Text.Substring(5);
                    string q = $"select cid,pwd,cname from Customers where cid={textBox6.Text.Substring(5)}";
                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (dr[1].ToString() == textBox5.Text)
                            {
                                if (textBox4.Text == m2)
                                {
                                    form = new Mainform();

                                    form.admin = false;
                                    form.cid = g;
                                    MessageBox.Show("Welcome to Customer Portal: " + dr[2].ToString());
                                    this.Hide();
                                    form.Text = "Customer Portal";
                                    //getcaptcha2();
                                    form.ShowDialog();
                                    if (form.IsDisposed)
                                    {
                                        this.Show();
                                    }
                                    textBox5.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid captcha");

                                    conn.Close();
                                    getcaptcha2();
                                    return;
                                }
                            }


                            else
                            {
                                MessageBox.Show("Invalid Password");
                                conn.Close();
                                getcaptcha2();
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer does not exists");
                        conn.Close();
                        getcaptcha2();
                        return;
                    }
                    conn.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
                finally { conn.Close(); }
            }
            else
            {
                button1.Enabled = false;
                MessageBox.Show("Reopen Again");
            }
            j++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerModule customerModule = new CustomerModule();
            customerModule.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            getcaptcha1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getcaptcha2();
        }
    }



}
