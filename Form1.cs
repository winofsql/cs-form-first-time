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
            Console.WriteLine("����ɂ��͐��E1");
            Debug.WriteLine("����ɂ��͐��E2");
            MessageBox.Show("����ɂ��͐��E3");

            Application.Exit();
        }
    }
}