using System.Data.SqlClient;

namespace testing
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        public Form1()
        {
            conn = new SqlConnection("Data Source=Pratham;Initial Catalog=College;Integrated Security=True");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* string query = "select * from student";
            cmd=new SqlCommand(query,conn);
            conn.Open();
            dr= cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    MessageBox.Show(dr[0].ToString() + dr[1].ToString());
                }
            }
            conn.Close();
            cmd.Dispose();*/
            string query = "insert into student values('Vaibhav','BCA','gyfs',1,2,'Male','gfds','sgfs','hsgfsh',32)";
            cmd =new SqlCommand (query,conn);
            conn.Open();
            int d=cmd.ExecuteNonQuery();
            if (d > 0)
            {
                MessageBox.Show("Success");
            }
            conn.Close ();
            cmd.Dispose();
        }
    }
}
