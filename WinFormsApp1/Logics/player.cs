using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Logics.interfaces;

namespace WinFormsApp1.Logics
{
    public abstract class template : IMoveable,IDamagable,IHealth,IActive,IAchivments,ISizeVolum
    {
        private int width;
        private int height;
        public int Width { get { return width; } }
        public int Height { get { return height; } }
        private int x;
        private int y;
        private float damage;
        private int speed;
        private int health;
        private bool active;
        private int coin;
        private int xp;
        public int X { get {return x; } set { x = value; }  }
        public int Y { get {return y; } set { y = value; } }
        public float Damage { get { return damage; } set { damage = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int Health { get { return health; } set { health = value; } }
        public bool Active { get { return active; } set { active = value; } }
        public int Coin { get {return coin;  }set { coin = value; } }
        public int Xp { get { return xp; } set { xp = value; } }
        public abstract void MoveX(float andaze);
        public abstract void MoveY(float andaze);
        public bool BaresiharekatX(float andaze)
        {
            return (X + (andaze * Speed) + Width <= GameWorld.Width && X + (andaze * Speed) - Width >= 0);
        }
        public bool BaresiharekatY(float andaze)
        {
            return (Y + (andaze * Speed) + Height <= GameWorld.Height && Y + (andaze * Speed) - Height >= 0);
        }
        public template(int width,int height,int x,int y,float damage,int speed,int health,int coin,int xp)
        {
            this.width= width;
            this.height= height;
            X = x; 
            Y = y;
            Damage = damage;
            Speed = speed;
            Health = health;
            Active = true;
            this.coin = coin;
            Xp = xp;
        }
        public virtual void DamageTaken(float megdar)
        {
            if (Health <= megdar)
            {
                Health = 0;
                Active = false;
            }
            else
            {
                Health -= (int)megdar;
            }
        }

    }
    public class player : template , IWeaponDamage, IUpdate
    {
        private Bullet MainBullet;
        private int timeshoot;
        public int Timeshoot { get { return timeshoot; } set { timeshoot = value; }  }
        private BulletMoveType movetypebullet;
        public Bullet Weapon {  get { return MainBullet; } }
        public BulletMoveType BulletMoveType { get { return movetypebullet; } }
        public Bullet Shoot()
        {
            Bullet sample;
            if (Timeshoot >= 1500)
            {
                sample = Weapon.santes(X, Y + Height / 2);
                Timeshoot = 0;
                return sample;
            }
            else
            {
                return null;
            }

        }
        public override void MoveX(float andaze)
        {
            if (BaresiharekatX(andaze))
            {
                X += (int)(andaze * Speed);
                return;
            }
            else
            {
                return;
            }
        }
        public override void MoveY(float andaze)
        {
            if (BaresiharekatY(andaze))
            {
                Y += (int)(andaze * Speed);
                return;
            }
            else
            {
                return;
            }
        }
        public player(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp,Bullet mainbullet,BulletMoveType move) : base(width, height, x, y, damage, speed, health, coin, xp)
        {
            this.MainBullet = mainbullet;
            this.movetypebullet = move;
            timeshoot = 1500;
        }
        public void Cointaken(int megdar)
        {
            Coin += megdar;
        }
        public void XpTaken(int megdar)
        {
            Xp += megdar; 
        }
        public  void Update(float x,float y)
        {
            MoveX(x);
            MoveY(y);
            Bullet sample;
            sample = Shoot();
            sample.MoveX(0);
            sample.MoveY(1);
        }
    }
}
