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
            Console.WriteLine("こんにちは世界1");
            Debug.WriteLine("こんにちは世界2");
            MessageBox.Show("こんにちは世界3");

            Application.Exit();
        }
    }
}