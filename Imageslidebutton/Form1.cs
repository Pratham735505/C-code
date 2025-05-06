using System.Data.SqlClient;

namespace Imageslidebutton
{
    public partial class Form1 : Form
    {
        string[] s;
        int i;
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Form1()
        {
            i = 0;
            s = new string[] {
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 175305.png",
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 175222.png",
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 174936.png",
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 174854.png",
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 174811.png"
};          
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(s[i]);
            string str = "Data Source=PRATHAM;Initial Catalog=pg;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            con = new SqlConnection(str);
            con.Open();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = (i + 1) % s.Length;
            pictureBox1.Image = Image.FromFile(s[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = (i - 1) % s.Length;
            pictureBox1.Image = Image.FromFile(s[i]);
        }
    }
}
