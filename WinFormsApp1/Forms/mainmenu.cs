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
            clicksound = new Sound("Assets/Audio/click3.wav");
            backmusic = new Music("Assets/Audio/music/backmusic.mp3");
            backmusic.reader.Volume = 0.2f;
            clicksound.reader1.Volume = 1f;
            Audio.Playmusic(backmusic);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clicksound.dispose();
            backmusic.dispose();
            System.Windows.Forms.Application.Exit();
           
            // for exiting
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clicksound.Play();
            FORMMANAGER.handleform(this, new aboutus());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clicksound.Play();
            Option option = new Option();
            FORMMANAGER.handleform(this, option);
        }

        private void MAINMENU_FormClosing(object sender, FormClosingEventArgs e)
        {
            clicksound.dispose();
            backmusic.dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORMMANAGER.handleform(this, new Shop11());

        }
    }
}
