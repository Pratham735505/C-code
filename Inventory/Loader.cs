using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Loader : Form
    {
        int val;
        public Loader()
        {
            InitializeComponent();
            val = 0;
        }

        private void Loader_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
            val = val + 10;
            label2.Text ="Loading..."+ val.ToString() + "%";
            progressBar1.Value = val;
            if (val == 100)
            {
                this.Hide();
                timer1.Enabled = false;
                Form1 f= new Form1();
                
                f.ShowDialog();
                
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
