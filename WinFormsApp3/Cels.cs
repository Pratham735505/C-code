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
    public partial class Cels : Form
    {
        public Cels()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                     

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string s = textBox1.Text;
                double c = Convert.ToDouble(s);
                double f = 9.0 / 5 * c + 32;
                textBox2.Text = f.ToString();
            }
            else
            {
                string s = textBox2.Text;
                double f = Convert.ToDouble(s);
                double c = (f - 32) * 5.0 / 9;
                textBox1.Text = c.ToString();
            }
        }
    }
}
