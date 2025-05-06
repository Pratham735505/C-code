namespace Groupboxxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "checked";

            }
            else
            {
                label1.Text = "Unchecked";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.Text = "checked";

            }
            else
            {
                label2.Text = "Unchecked";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sort the error
            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Google Chrome.lnk"));
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Image image = new Image();
            image.ShowDialog();
        }
    }
}
