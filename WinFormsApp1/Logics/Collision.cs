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
        public static bool playercoincolision(player player,Coindrop coin)
        {
            if (player.X - player.Width / 2 < coin.X + 30/ 2 && player.X + player.Width / 2 > coin.X - 30/2 && player.Y + player.Height / 2 > coin.Y - 30/2 && player.Y - player.Height / 2 < coin.Y + 30 / 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //اضافه کردن برخورد با ایتم خاص 
        public static bool playerdoubleshoot(player player, SpecialItem doubleShoot)
        {
            if (doubleShoot is DoubleShoot)
            {
                if (player.X - player.Width / 2 < doubleShoot.X + 30 / 2 && player.X + player.Width / 2 > doubleShoot.X - 30 / 2 && player.Y + player.Height / 2 > doubleShoot.Y - 30 / 2 && player.Y - player.Height / 2 < doubleShoot.Y + 30 / 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool playerfastshoot(player player, SpecialItem fastShoot)
        {
            if (fastShoot is FastShoot)
            {
                if (player.X - player.Width / 2 < fastShoot.X + 30 / 2 && player.X + player.Width / 2 > fastShoot.X - 30 / 2 && player.Y + player.Height / 2 > fastShoot.Y - 30 / 2 && player.Y - player.Height / 2 < fastShoot.Y + 30 / 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool playerheal(player player, SpecialItem heal)
        {
            if (heal is Healinig)
            {
                if (player.X - player.Width / 2 < heal.X + 30 / 2 && player.X + player.Width / 2 > heal.X - 30 / 2 && player.Y + player.Height / 2 > heal.Y - 30 / 2 && player.Y - player.Height / 2 < heal.Y + 30 / 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
