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
    public partial class Armstrong : Form
    {
        int n;
        public Armstrong()
        {
            InitializeComponent();
            n = 0;
        }

        private void Armstrong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            int d = 0;
            int g = Convert.ToInt32(n);
            while (g > 0)
            {
 
                d++;
                g = g / 10;
            }

            int s = 0;
            while (n > 0)
            {
                s = s + Convert.ToInt32(Math.Pow(n % 10,d));
                n = n / 10;
            }
            n=Convert.ToInt32(textBox1.Text);
            if (n == s)
            {
                label1.Text = "Armstrong number";
                label1.ForeColor = Color.YellowGreen;
            }
            else
            {
                label1.Text = "Not armstrong";
                label1.ForeColor = Color.Red;
            }
            label1.Visible = true;
        }
    }
}
