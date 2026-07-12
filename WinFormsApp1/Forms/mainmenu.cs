namespace WinFormsApp1
{
    using WinFormsApp1.Forms;
    using WinFormsApp1.Managers;
    public partial class MAINMENU : Form
    {
        internal Sound clicksound;
        internal Music backmusic;
        public MAINMENU()
        {
            InitializeComponent();
            ShopManager.init();
            FORMMANAGER.setbackground(this);

            Audio.backmusic.reader.Volume = 0.2f;
            Audio.clicksound.reader1.Volume = 1f;
            //Audio.Playmusic(Audio.backmusic);
            Audio.backmusic.Play();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Audio.disposeall();
            System.Windows.Forms.Application.Exit();
           
            // for exiting
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Audio.clicksound.Play();
            FORMMANAGER.handleform(this, new aboutus());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Audio.clicksound.Play();
            Option option = new Option();
            FORMMANAGER.handleform(this, option);
        }

        private void MAINMENU_FormClosing(object sender, FormClosingEventArgs e)
        {
            Audio.disposeall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Audio.clicksound.Play();
            FORMMANAGER.handleform(this, new Shop11());

        }
    }
}
