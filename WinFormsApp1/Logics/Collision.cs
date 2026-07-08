using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Logics
{
    public class Collision
    {
        public static bool BulletEnemy(Bullet bullet,int x,int y,int width ,int height)
        {
            if (bullet.X + bullet.Width / 2 >= x - width/2 && bullet.X - bullet.Width/2 <= x + width/2 && (bullet.Y - bullet.Height /2 <= y + height / 2 && bullet.Y + bullet.Height / 2 >= y - height / 2 ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Bulletplayer(Bullet bullet, player player)
        {
            if (bullet.X + bullet.Width / 2 >= player.X - player.Width / 2 && bullet.X - bullet.Width / 2 <= player.X + player.Width / 2 && (bullet.Y - bullet.Height / 2 <= player.Y + player.Height / 2 && bullet.Y + bullet.Height / 2 >= player.Y - player.Height / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool playerenemy(player bullet, int x, int y, int width, int height)
        {
            if (bullet.X + bullet.Width / 2 >= x - width / 2 && bullet.X - bullet.Width / 2 <= x + width / 2 && (bullet.Y - bullet.Height / 2 <= y + height / 2 && bullet.Y + bullet.Height / 2 >= y - height / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
