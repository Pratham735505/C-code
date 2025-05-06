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
    public partial class BMI : Form
    {
        double weight, height;
        public BMI()
        {
            InitializeComponent();
            weight = 0;
            height = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            weight= Convert.ToDouble(textBox1.Text);
            height = Convert.ToDouble(textBox2.Text);
            
            if(weight<0 || height < 0)
            {
                label2.Text = "Invalid entries";
                label2.ForeColor = Color.Red;
            }
            else
            {
                double d = weight / Math.Pow(height,2);
                label2.Text=Convert.ToString(d);
                if(d>0 && d < 18.5)
                {
                    label2.Text = label2.Text + "\nUnderweight";
                }
                else if (d > 18.5 && d < 25)
                {
                    label2.Text = label2.Text + "\nFit";
                }
                else
                {
                    label2.Text = label2.Text + "\nOverweight";
                }
                label2.ForeColor = Color.Green;
             
            }
            label2.Visible = true;
        }
    }
}
