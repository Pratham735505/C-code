using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Ques : Form
    {
        int correct, marks;
        int[] a = new int[10];
        int count;
        string[] q = new string[10]
        {"A) What is the national animal of India?",
           "B) Highest peak of India ",
           "C) 1 nibble =?",
           "D) Height of Mt. Everest",
           "E) How many colors does a rainbow has?",
           "F) Which country won the WTC 2021?",
           "G) Which studio owns the Spirited Away anime?",
           "H) Which company developed the first mobile phone?",
           "I) Which country did first Nuclear attack?","J) In which year Pokhran atom bomb test happen?"
        };
        string[,] options = new string[10, 4]
        {
            {"Peacock","Tiger","Cat Fish","Great Indian Bastard"},
            {"K2", "Everest", "kilimanjaro","Great Australian Range"},
            {"4 bits", "4 byte", "4 mB", "4 kB"},
            {"8587 km", "8757 m","5676 m","8965 cm"},
            {"8","9","7","10"},
            {"India","Australia","New Zealand","South Africa"},
            {"Nintendo","TokyoGhouls","Greengold","Ghibli"}
            {"Microsoft","Nvidia","IBM","Apple"},
            {"USA","USSR","Japan","Germany"},
            {"1999","1998","1997","1996" }
        };
        public Ques()
        {
            
            count = 0;
            InitializeComponent();
            progressBar1.Value = 10;
            label1.Text = q[count];
            radioButton1.Text = q[count, 0];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                progressBar1.Value = (count) * 10;
                count--;
                label1.Text = q[count];
                
            }
            if (count != 9)
            {
                button3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count != 9)
            {
                count++;
                label1.Text = q[count];
                
                
                progressBar1.Value = (count+1) * 10;
                button3.Visible = false;
            }
            if (count == 9)
            {
                button3.Visible = true;
            }
        }

        private void Ques_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
