namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            // for exiting
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 aboutus = new Form2();
            aboutus.Show();
        }

        
    }
}
