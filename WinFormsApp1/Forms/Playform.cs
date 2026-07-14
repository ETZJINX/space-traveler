using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Logics;
using WinFormsApp1.Logics.interfaces;
using WinFormsApp1.Managers;
namespace WinFormsApp1
{
    public partial class Playform : Form
    {
        private readonly Font waveFont = new Font("Arial", 30);
        private readonly Font gameOverFont = new Font("Arial", 40);
        public static Music music;
         GameWorld gameWorld;
        bool up, down, left, right, shoot;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Playform()
        {
            InitializeComponent();
            Audio.backmusic.Stop();
            music = Audio.theme;
            music.Play();
            //GameWorld.gameover = false;
            this.DoubleBuffered = true;
            gameWorld = new GameWorld();
            //gameWorld.initbullet();
            //Bullet bullet = new Bullet(BulletMoveType.straghit, 360, 150, 75, 25, 5, 5);


            //bullet.jahatx = Xvextor.right;
            //bullet.jahaty = Yvector.down;
            //GameWorld.Bullets.Add(bullet);
            //GameWorld.Bullets.Add(bullet);
            //bullet.Update(0, 1);


            //player player = new player(25, 25, 100, 515, 50, 15, 140, 700, 0, Xvextor.sabet, Yvector.sabet, bullet);
            //GameWorld.player1 = player;

            FORMMANAGER.setbackground(PlayPanl);
            GameWorldManager.update();
            Wavemanager.init();
            //this.Size = new Size(1075, 633);
            PlayPanl.Size = new Size(GameWorld.Width, GameWorld.Height);
            
            this.BackColor = Color.White;
            this.KeyPreview = true;
            up = down = left = right = shoot = false;

            timer.Interval = 16;

            timer.Tick += Timer_Tick;
            //timer.Tick += PlayPanl_Paint;

            timer.Start();




        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            enemyremain.Text = "enemyremain : " + Wavemanager.EnemyRemainingToSpawn.ToString();
            playerhealth.Text = GameWorld.player1.Health.ToString();
            panel1.Size = new Size(GameWorld.player1.maxhealth, 20);
            healthbar.BackColor = Color.Green;
            healthbar.Size = new Size(GameWorld.player1.Health, 20);
            coinamount.Text = GameWorld.player1.Coin.ToString();
            scoreamount.Text = GameWorld.player1.Xp.ToString();

            gameWorld.playerupdate(left, right, up, down);
            //if (Input.shoot)
            //{
            gameWorld.playershoot(Input.shoot);
            //GameWorld.player1.Shoot();
            //MessageBox.Show("Shoot");
            //}
            try
            {
                if (gameWorld.Update())
                {
                    Wavemanager.Update();

                    gameWorld.enemyupdate();
                    //playershoot();
                    gameWorld.bulletsupdate();
                    gameWorld.bulletenemycolision();
                    gameWorld.bulletplayer();
                    gameWorld.enemyplayer();
                    gameWorld.playercoincolision1();
                    gameWorld.playerDoublecolision();
                    gameWorld.playerfastshootcollision();
                    gameWorld.playerhealcollision();
                    //MessageBox.Show(Bullets[0].Active.ToString());
                    //تغییر دادم 
                    //removebullets();
                    //removeenemy();
                    //removecoin();
                }
                else
                {
                    timer.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            PlayPanl.Invalidate();
            //Invalidate();
        }


        private void PlayPanl_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.Black);
            //MessageBox.Show("Paint Start");
            //MessageBox.Show("Paint");
            //MessageBox.Show(GameWorld.enemies.Count.ToString());
            Graphics g = e.Graphics;
            //g.FillEllipse(Brushes.Gold, 200, 200, 10, 10);


            if (GameWorld.player1.Active)
            {
                Render.drawplayer(g, GameWorld.player1);
            }

            foreach (var enemy in GameWorld.enemies)
            {

                if (enemy.Active)
                {
                    Render.drawenemy(g, enemy);

                }
            }


            foreach (var bullet in GameWorld.Bullets)
            {
                if (bullet.Active)
                {
                    Render.drawbullet(g, bullet);
                }
            }

            //g.DrawRectangle(Pens.Pink, 250, 600, 15, 15);
            //هیچی داخل بالتس نیستش 
            //MessageBox.Show(GameWorld.coinsdrops.Count.ToString());
            //MessageBox.Show(GameWorld.coinsdrops.Count.ToString());
            if (GameWorld.coinsdrops.Count != 0)
            {
                //MessageBox.Show("Has Coins");
                foreach (var coin in GameWorld.coinsdrops)
                {
                    //MessageBox.Show(GameWorld.coinsdrops.Count.ToString());
                    //MessageBox.Show(coin.active.ToString());
                    if (coin.active)
                    {
                        //MessageBox.Show("Calling DrawCoin");
                        Render.drawcoin(g, coin);
                    }
                }
            }
            if (GameWorld.specialitems.Count != 0)
            {
                foreach (var item in GameWorld.specialitems)
                {
                    if (item.active && item is DoubleShoot)
                    {
                        DoubleShoot sample = item as DoubleShoot;
                        Render.drawdoubleshoot(g, sample);
                    }
                }
            }
            if (GameWorld.specialitems.Count != 0)
            {
                foreach (var item in GameWorld.specialitems)
                {
                    if (item.active && item is FastShoot)
                    {
                        FastShoot sample1 = item as FastShoot;
                        Render.drawfastshoot(g, sample1);
                    }
                }
            }
            if (GameWorld.specialitems.Count != 0)
            {
                foreach (var item in GameWorld.specialitems)
                {
                    if (item.active && item is Healinig)
                    {
                        Healinig sample = item as Healinig;
                        Render.drawheal(g, sample);
                    }
                }
            }


            if (Wavemanager.showmessage)
            {
                g.DrawString(
                $"Wave{Wavemanager.currentwave + 1}",
                waveFont,
                Brushes.Black,
                GameWorld.Width / 2,
                GameWorld.Height / 2);
            }
            if (GameWorld.gameover)
            {
                g.DrawString(
                    "GAME OVER",
                    gameOverFont,
                    Brushes.Red,
                    180,
                    180);
                timer.Stop();
            }
        }

        private void Playform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Inputmanager.Moveforward) up = true;
            if (e.KeyCode == Inputmanager.Movebackward) down = true;
            if (e.KeyCode == Inputmanager.Moveleft) left = true;
            if (e.KeyCode == Inputmanager.Moveright) right = true;
            if (e.KeyCode == Inputmanager.Shoot)
            {
                //MessageBox.Show("keydown");
                //Debug.WriteLine("KeyDown");
                Input.shoot = true;
            }

            {

            }
        }

        private void Playform_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Inputmanager.Moveforward) up = false;
            if (e.KeyCode == Inputmanager.Movebackward) down = false;
            if (e.KeyCode == Inputmanager.Moveleft) left = false;
            if (e.KeyCode == Inputmanager.Moveright) right = false;
            if (e.KeyCode == Inputmanager.Shoot)
            {
                //MessageBox.Show("keyup");
                //Debug.WriteLine("KeyUp");
                Input.shoot = false;
            }


        }

        private void Playform_FormClosed(object sender, FormClosedEventArgs e)
        {
            //GameWorld.gameover = false;
            //Wavemanager.currentwave = 1;
            //Wavemanager.resettheworls();
            Wavemanager.Reset();
            GameWorld.Reset();


        }




        //private void Playform_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Input.shoot = true;
        //}

        //private void Playform_MouseUp(object sender, MouseEventArgs e)
        //{
        //    Input.shoot = false;
        //}
    }
}
