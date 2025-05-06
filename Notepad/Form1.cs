using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        private int childFormNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*   MDIParent1 parent1 = new MDIParent1();
               parent1.ShowDialog();
               this.Controls.Add(parent1);*/
            //richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form();
            //  childForm.Parent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Cut();
        }
    }
}
