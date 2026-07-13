using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Logics;
using WinFormsApp1.Logics.interfaces;

namespace WinFormsApp1.Managers
{
    public class GameWorldManager
    {
        public static ItemBullet itembullet = null;
        public static ItemShip itemship  = null;
        public static Bullet bullet = new Bullet(BulletMoveType.straghit, 0 ,0, 0, 0,15,15,Properties.Resources.playerbullet1);
        public static player player = new player(40, 40, GameWorld.Width / 2, GameWorld.Height / 2, 0, 0, 0, 500, 0, Xvextor.sabet, Yvector.sabet, Properties.Resources.ship1, bullet);
        public static void init()
        {

            ////bullet = new Bullet(BulletMoveType.straghit,0 0, itembullet.Damage, itembullet.Speed, 5, 5);
            //bullet.Movetype = BulletMoveType.straghit;
            //bullet.X = bullet.Y = 0;
            //bullet.Damage = itembullet.Damage;
            //bullet.Speed = itembullet.Speed;
            //bullet.Width = 5;
            //bullet.Height = 5;
            ////player = new player(40, 40, GameWorld.Width / 2, GameWorld.Height / 2, itemship.Damage, itemship.Speed, itemship.Health, 500, 0, Xvextor.sabet, Yvector.sabet, bullet);
            //player.Width = 40;
            //player.Height = 40;
            //player.X = GameWorld.Width / 2;
            //player.Y = GameWorld.Height / 2;
            //player.Damage = itemship.Damage;
            //player.Speed = itemship.Speed;
            //player.Health = itemship.Health;
            //player.Coin = 500;
            //player.Xp = 0;
            //player.jahatx = Xvextor.sabet;
            //player.jahaty = Yvector.sabet;
            //player.Weapon = bullet;

            GameWorld.player1 = player;
        }
        public static void update()
        {

            itembullet = ShopManager.getequipedbullet();
            itemship = ShopManager.getequipedship();
            if (GameWorld.player1 != null)
            {
                player.Damage = itemship.Damage;
                player.Speed = itemship.Speed;
                player.Health = itemship.Health;
                player.img = itemship.img;
                if (GameWorld.player1.Weapon != null)
                {
                    bullet.Damage = itembullet.Damage;
                    bullet.Speed = itembullet.Speed;
                    bullet.img = itembullet.img;
                }
                else
                {
                    bullet = new Bullet(BulletMoveType.straghit, 0, 0, 0, 0, 15, 15, Properties.Resources.playerbullet1);
                    bullet.Damage = itembullet.Damage;
                    bullet.Speed = itembullet.Speed;
                    bullet.img = itembullet.img;
                }
            }
            else
            {
                bullet = new Bullet(BulletMoveType.straghit, 0, 0, 0, 0, 15, 15, Properties.Resources.playerbullet1);
                player = new player(40, 40, GameWorld.Width / 2, GameWorld.Height / 2, 0, 0, 0, 500, 0, Xvextor.sabet, Yvector.sabet, Properties.Resources.ship1, bullet);
                init();
                player.Damage = itemship.Damage;
                player.Speed = itemship.Speed;
                player.Health = itemship.Health;
                player.img = itemship.img;
                bullet.Damage = itembullet.Damage;
                bullet.Speed = itembullet.Speed;
                bullet.img = itembullet.img;

            }
        }

}
}
