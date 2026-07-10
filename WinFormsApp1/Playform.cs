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
namespace WinFormsApp1
{
    public partial class Playform : Form
    {
        GameWorld gameWorld;
        bool up, down, left, right, shoot;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Playform()
        {
            InitializeComponent();
            
            gameWorld = new GameWorld();
            //gameWorld.initbullet();
            Bullet bullet = new Bullet(BulletMoveType.straghit, 360, 150, 1000, 5, 100, 100);
            //bullet.jahatx = Xvextor.right;
            //bullet.jahaty = Yvector.down;
            //GameWorld.Bullets.Add(bullet);
            //GameWorld.Bullets.Add(bullet);
            //bullet.Update(0, 1);
            player player = new player(25, 25, 100, 515, 50, 2,140, 700, 0, Xvextor.sabet, Yvector.sabet, bullet);
            GameWorld.player1 = player;
            Wavemanager.init();
            //this.Size = new Size(1075, 633);
            PlayPanl.Size = new Size(GameWorld.Width, GameWorld.Height);
            this.DoubleBuffered = true;
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
            panel1.Size = new Size(140, 20);
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
            //MessageBox.Show("Paint");
            //MessageBox.Show(GameWorld.enemies.Count.ToString());
            Graphics g = e.Graphics;


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
                //if (bullet.Active)
                //{
                    Render.drawbullet(g, bullet);
                //}
            }

            //g.DrawRectangle(Pens.Pink, 250, 600, 15, 15);
            //هیچی داخل بالتس نیستش 

            if (GameWorld.coinsdrops.Count != 0)
            {
                foreach (var coin in GameWorld.coinsdrops)
                {
                    if (coin.active)
                    {
                        Render.drawcoin(g, coin);
                    }
                }

            }
            if (Wavemanager.showmessage)
            {
                g.DrawString(
                $"Wave{Wavemanager.currentwave}",
                new Font("Arial", 30),
                Brushes.Pink,
                250,
                200);
            }
            if (GameWorld.gameover)
            {
                g.DrawString(
                    "GAME OVER",
                    new Font("Arial", 40),
                    Brushes.Red,
                    180,
                    180);
                timer.Stop();
            }
        }

        private void Playform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) up = true;
            if (e.KeyCode == Keys.S) down = true;
            if (e.KeyCode == Keys.A) left = true;
            if (e.KeyCode == Keys.D) right = true;
            if (e.KeyCode == Keys.Space)
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
            if (e.KeyCode == Keys.W) up = false;
            if (e.KeyCode == Keys.S) down = false;
            if (e.KeyCode == Keys.A) left = false;
            if (e.KeyCode == Keys.D) right = false;
            if (e.KeyCode == Keys.Space)
            {
                //MessageBox.Show("keyup");
                //Debug.WriteLine("KeyUp");
                Input.shoot = false;
            }


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
