using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Prime : Form
    {
        public Prime()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            if (check(n))
            {
                label1.Text = "Prime Number";
                label1.ForeColor = Color.Green;

            }
            else
            {
                label1.Text = "Not prime";
                label1.BorderStyle = BorderStyle.FixedSingle;
                label1.ForeColor = Color.Red;
            }
            label1.Visible = true;

        }

        public bool check(int n){

            if (n < 1)
            {
                return false;
            }
            if(n==1 || n == 2)
            {
                return true;
            }
            else
            {
                for(int i = 2; i * i < n + 1; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
