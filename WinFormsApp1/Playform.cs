using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //this.Size = new Size(1075, 633);
            PlayPanl.Size = new Size(GameWorld.Width, GameWorld.Height);
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.KeyPreview = true;
            up = down = left = right = shoot = false;

            timer.Interval = 16;

            timer.Tick += Timer_Tick;

            timer.Start();
            Bullet bullet = new Bullet(BulletMoveType.straghit, 360, 150, 5, 30);
            GameWorld.Bullets.Add(bullet);
            bullet.Update(0, 1);
            player player = new player(25, 25, 100, 0, 50, 20, 140, 700, 0, bullet, BulletMoveType.straghit);
            GameWorld.player1 = player;
            Wavemanager.init();

            gameWorld = new GameWorld();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            gameWorld.playerupdate(left, right, up, down);
            if (Input.shoot)
            {
                gameWorld.playershoot();
                //GameWorld.player1.Shoot();
                //MessageBox.Show("Shoot");
            }
            gameWorld.Update();

            PlayPanl.Invalidate();
            //Invalidate();
        }


        private void PlayPanl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Render.drawplayer(g, GameWorld.player1);

            foreach (var enemy in GameWorld.enemies)
                Render.drawenemy(g, enemy);

            foreach (var bullet in GameWorld.Bullets)
                Render.drawbullet(g, bullet);

            foreach (var coin in GameWorld.coinsdrops)
                Render.drawcoin(g, coin);
            if (Wavemanager.showmessage)
            {
                g.DrawString(
                $"Wave{Wavemanager.currentwave}",
                new Font("Arial", 30),
                Brushes.White,
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
            if (e.KeyCode == Keys.Space) Input.shoot = true;
            {
                
            }
        }

        private void Playform_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) up = false;
            if (e.KeyCode == Keys.S) down = false;
            if (e.KeyCode == Keys.A) left = false;
            if (e.KeyCode == Keys.D) right = false;
            if (e.KeyCode == Keys.Space) Input.shoot = false;
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
