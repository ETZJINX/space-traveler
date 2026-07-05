namespace WinFormsApp1
{
    using WinFormsApp1.Forms;
    using WinFormsApp1.Managers;
    public partial class MAINMENU : Form
    {
        public MAINMENU()
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
            FORMMANAGER.handleform(this, new aboutus());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORMMANAGER.handleform(this, new Shop11());
        }
    }
}
