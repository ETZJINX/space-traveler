namespace WinFormsApp1
{
    using WinFormsApp1.Forms;
    using WinFormsApp1.Managers;
    using WinFormsApp1.Logics;
    using SpaceShooter.Database;
    public partial class MAINMENU : Form
    {
        internal Sound clicksound;
        internal Music backmusic;
        public MAINMENU()
        {
            InitializeComponent();
            GameWorldManager.init();
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
            // Persist audio and player data
            Audio.disposeall();
            try
            {
                var db = new Database();
                db.InitializeDatabase();
                if (GameWorld.player1 != null)
                {
                    db.UpdateCoins(GameWorld.player1.Coin);
                    try
                    {
                        var current = db.GetPlayerData();
                        if (current != null && GameWorld.player1.Xp > current.HighScore)
                        {
                            db.UpdateHighScore(GameWorld.player1.Xp);
                        }
                    }
                    catch
                    {
                        // ignore
                    }
                }
            }
            catch
            {
                // ignore persistence errors to avoid blocking shutdown
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Audio.clicksound.Play();
            FORMMANAGER.handleform(this, new Shop11());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORMMANAGER.handleform(this, new ControlForm());
            Audio.clicksound.Play();
        }
    }
}
