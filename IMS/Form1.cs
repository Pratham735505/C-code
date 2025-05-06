
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace IMS
{



    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
      //  Validation v;
        string query;
        public Form1()
        {
      
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation.ValidatePassword(textBox2.Text))
            {
                textBox2.BackColor = Color.Red;
                MessageBox.Show("Password format wrong");
                return;
            }
            query = $"select * from Registration where username='{textBox1.Text}' and pwd='{textBox2.Text}'";
            cmd= new SqlCommand(query,conn);
            conn.Open();
            dr=cmd.ExecuteReader();
            if (dr.HasRows)
            {
                this.Hide();
                MDIParent1 mdi = new MDIParent1();
                mdi.Show();
                //MessageBox.Show("Login Successful");

            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True");
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            
        }
    }
    public class Validation
    {
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[\w-\.]+@(gmail\.com|yahoo\.com|[\w-]+\.[a-zA-Z]{2,})$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool ValidateContactNumber(string contact)
        {
            string pattern = @"^(\+?\d{1,3})?[-.\s]?\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$";
            return Regex.IsMatch(contact, pattern);
        }

        public static bool ValidatePassword(string password, int minLength = 8)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= minLength;
        }


        public static bool ValidateName(string name)
        {
            string pattern = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(name, pattern);
        }

        public static bool ValidateAddress(string address, int minLength = 5, int maxLength = 100)
        {
            return address.Length >= minLength && address.Length <= maxLength;
        }
    }
}
