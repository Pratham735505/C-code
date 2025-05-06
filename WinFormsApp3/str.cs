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
    public partial class str : Form
    {
        string s,y;
        public str()
        {
            InitializeComponent();
            s = "";
            y = "";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
           
            for (int i = 0; i < s.Length; i++)
            {
                char c = Convert.ToChar(s[i] + 32);
                y = y+Convert.ToString(c);
            }
            textBox1.Text = y;
        }
    }
}
