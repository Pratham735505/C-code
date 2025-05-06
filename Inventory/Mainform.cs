using System.Data.SqlClient;

namespace Inventory
{
    public partial class Mainform : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string s;
        public bool admin;
        public string cid;
        public Mainform()
        {
            s = "Data Source=Pratham;Initial Catalog=Inventory_management;Integrated Security=True";
            InitializeComponent();
            main.BackgroundImage = Image.FromFile("images/0.png");
            admin = true;
            cid = "";
        }
        private void Mainform_Load(object sender, EventArgs e)
        {
            btncust.Visible = admin;
            btnuser.Visible = admin;
            button2.Visible = admin;
        }


        public Form Activeform = null;
        public void Openchild(Form child)
        {
            timer1.Stop();
            main.BackgroundImage = null;
            if (Activeform != null)
            {
                Activeform.Close();
            }
            Activeform = child;

            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            main.Controls.Add(child);
            main.Tag = child;
            child.BringToFront();
            child.Show();

        }
        private void btnuser_Click(object sender, EventArgs e)
        {
            Openchild(new Userform());
        }

        private void btncust_Click(object sender, EventArgs e)
        {

            Openchild(new Customerform());

        }

        private void btncate_Click(object sender, EventArgs e)
        {
            Categoryform c = new Categoryform();
            c.btnadd.Visible = admin;
            c.button1.Visible = admin;
            Openchild(c);
        }
        
        private void btnpr_Click(object sender, EventArgs e)
        {
            Productform p = new Productform();
            p.btnadd.Visible = admin;
            p.btnstk.Visible = admin;
            Openchild(p);
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            Orderform orderform = new Orderform();
            orderform.admin = admin;
            orderform.cid = cid;
            Openchild(orderform);

        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            main.BackgroundImage = Image.FromFile($"images/{i}.png");
            i = (i + 1) % 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                this.Hide();
                this.Close();
                form1.ShowDialog();
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Openchild(new Admin());
        }
    }
}
