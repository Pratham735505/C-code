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

    public partial class Form2 : Form
    {
        int d;
        Converter c;
        public Form2()
        {
            InitializeComponent();
            d = 1;
            c = new Converter();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            d = 3;
            textBox1.PlaceholderText = "Enter kph";
            textBox2.PlaceholderText = "Enter m/s";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            d = 1;
            textBox1.PlaceholderText = "Enter kg";
            textBox2.PlaceholderText = "Enter Grams";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d = 2;
            textBox1.PlaceholderText = "Enter kilometre";
            textBox2.PlaceholderText = "Enter miles";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (d == 1)
                {
                    double s = c.kgtog(Convert.ToDouble(textBox1.Text));
                    if (s == -1)
                    {
                        label1.Text = "Invalid entry";
                        label1.Visible = true;
                    }
                    else
                    {
                        textBox2.Text = Convert.ToString(s);
                    }

                }

                else if (d == 2)
                {
                    double s = c.ktom(Convert.ToDouble(textBox1.Text));
                    if (s == -1)
                    {
                        label1.Text = "Invalid entry";
                        label1.Visible = true;
                    }
                    else
                    {
                        textBox2.Text = Convert.ToString(s);
                    }

                }

                else if (d == 3)
                {
                    double s = c.kptomp(Convert.ToDouble(textBox1.Text));
                    if (s == -1)
                    {
                        label1.Text = "Invalid entry";
                        label1.Visible = true;
                    }
                    else
                    {
                        textBox2.Text = Convert.ToString(s);
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (d == 1)
                {
                    double s = c.gtokg(Convert.ToDouble(textBox2.Text));
                    if (s == -1)
                    {
                        label1.Text = "Invalid entry";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(s);
                    }

                }

                else if (d == 2)
                {

                    double s = c.mtok(Convert.ToDouble(textBox2.Text));
                    if (s == -1)
                    {
                        label1.Text = "Invalid entry";
                        label1.Visible = true;
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(s);
                    }

                }

                else if (d == 3)
                {
                    double s = c.mptok(Convert.ToDouble(textBox2.Text));
                    if (s == -1)
                    {
                        label1.Text = "Invalid entry";
                        label1.Visible = true;
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(s);
                    }

                }

            }
            catch (Exception)
            {

            }
        }
    }
    class Converter
    {
        public double kgtog(double kg)
        {
            if (kg < 0)
            {
                return -1;
            }
            return kg * 1000;
        }
        public double gtokg(double g)
        {
            if (g < 0)
            {
                return -1;
            }
            return g / 1000;
        }

        public double ktom(double k)
        {
            if (k < 0)
            {
                return -1;
            }
            return k / 1.602;
        }
        public double mtok(double m)
        {
            if (m < 0)
            {
                return -1;
            }
            return m * 1.602;
        }

        public double kptomp(double kp)
        {
            return kp * 5.0 / 18;
        }

        public double mptok(double kp)
        {
            return kp / 5.0 * 18;
        }
    }
}
