using System.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
namespace captcha
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataReader dr;
        SqlCommand cmd;
        string str, query, x, m;
        //int x;
        Random r;


        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            pictureBox1.Image = Image.FromFile("1.jpg");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            str = "Data Source=pratham;Initial Catalog=images;Integrated Security=True;";

            r = new Random();
            conn = new SqlConnection(str);

            int d = r.Next(1, 10);
            //int d1 = Convert.ToInt32(d);
            query = $"Select id,imgpath, imgval from img where id={d};";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            while (dr.HasRows)
            {
                x = dr[1].ToString()!;
                m = dr[2].ToString()!;
                pictureBox1.Image = Image.FromFile(x);
            }
            dr.Close();
            conn.Close();
            //getcaptcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox1.Clear();
            getcaptcha();
        }
        private void getcaptcha()
        {
            conn = new SqlConnection(str);

            int d = r.Next(1, 10);
            //int d1 = Convert.ToInt32(d);
            query = $"Select id,imgpath, imgval from img where id={d};";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            while (dr.HasRows)
            {
                x = dr[1].ToString();
                m = dr[2].ToString();
                pictureBox1.Image = Image.FromFile(x);
            }
            dr.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            if (textBox1.Text == "")
            {
                if (textBox1.Text == m)
                {
                    label2.Visible = true;
                    label2.Text = "Correct Captcha Matched!";
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = "Incorrect Captcha!";
                }
            }
            else
            {
                label2.Visible = true;
                label2.Text = "Invalid input!";
            }
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
