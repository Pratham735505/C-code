namespace Imageslidetimer
{
    public partial class Form1 : Form
    {

        string[] s;
        int i;
        public Form1()
        {
            i = 0;
            s = new string[] {
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 175305.png",
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 175222.png",
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 174936.png",
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 174854.png",
    @"C:\Users\Lenovo\source\repos\Imageslidebutton\Screenshot 2024-09-22 174811.png"
};
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(s[i]);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = (i + 1) % s.Length;
            pictureBox1.Image = Image.FromFile(s[i]);
            progressBar1.Value = 20 * (i+1);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
                
        }
    }
}
