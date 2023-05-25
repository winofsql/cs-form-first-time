using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ç±ÇÒÇ…ÇøÇÕê¢äE1");
            Debug.WriteLine("Ç±ÇÒÇ…ÇøÇÕê¢äE2");
            MessageBox.Show("Ç±ÇÒÇ…ÇøÇÕê¢äE3");

            Application.Exit();
        }
    }
}