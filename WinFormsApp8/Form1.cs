using System.Data.SqlClient;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        Random r;
        string str;
        string txt;
        public Form1()
        {
            InitializeComponent();
        }
        void refresh()
        {
            r = new Random();
            int d = r.Next(1, 20);
            // int d1 = Convert.ToInt32(d);
            str = "Data Source=Pratham;Initial Catalog=Employee;Integrated Security=True";
            conn = new SqlConnection(str);
            string sql = $"select imgpath,imgval from img_tab where id={d}";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string x = dr[0].ToString()!;
                    pictureBox1.Image = Image.FromFile(x); // can be used for using captcha
                    txt = dr[1].ToString()!;
                }
            }
            dr.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Visible = true;
            }
            else if(textBox1.Text == txt)
            {
                MessageBox.Show("Valid captcha");
            }
            else
            {
                label1.Visible = true;
                label1.Text = "Invalid Captcha";
            }
        }
    }
}
