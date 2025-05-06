using System.Data.SqlClient;
namespace Teachingsessionform
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        string str;
        Random r;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Random();
            long d = r.NextInt64(2);  
            int d1=Convert.ToInt32(d);
            str = "Data Source=Pratham;Initial Catalog=Employee;Integrated Security=True";
            conn = new SqlConnection(str);
            string sql = $"select id,imgpath from img_tab where id={d1}";
            cmd=new SqlCommand(sql, conn);
            conn.Open();
            dr= cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string x = dr[1].ToString()!;
                    pictureBox1.Image = Image.FromFile(x); // can be used for using captcha
                }
            }
            dr.Close();
            cmd.Dispose();
            conn.Close();
        }
    }
}
