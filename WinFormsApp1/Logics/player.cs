using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WinFormsApp1.Logics.interfaces;

namespace WinFormsApp1.Logics
{
    public abstract class template : IMoveable,IDamagable,IHealth,IActive,IAchivments,ISizeVolum,ISpeed
    {
        private int width;
        private int height;
        private Xvextor JAHATX;
        private Yvector JAHATY;
        public Xvextor jahatx { get { return JAHATX; } set { JAHATX = value; } }
        public Yvector jahaty { get { return JAHATY; } set { JAHATY = value; } }

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
        public abstract void MoveX();
        public abstract void MoveY();
        public bool BaresiharekatX()
        {
            return (X + (((int)jahatx) * Speed) + this.Width / 2 <= GameWorld.Width && X + (((int)jahatx) * Speed) - this.Width /2 >= 0) ;
        }
        public bool BaresiharekatY()
        {
            return (Y + (((int)jahaty) * Speed) + Height / 2 <= GameWorld.Height && Y + (((int)jahaty) * Speed) - Height / 2 >= 0) ;
        }
        
        public template(int width,int height,int x,int y,float damage,int speed,int health,int coin,int xp,Xvextor jahatx,Yvector jahaty)
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
            this.jahatx = jahatx;
            this.jahaty = jahaty;
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
        //private BulletMoveType movetypebullet;
        public Bullet Weapon {  get { return MainBullet; } }
        //public BulletMoveType BulletMoveType { get { return movetypebullet; } }
        public Bullet Shoot()
        {
            Bullet sample = null;
            //Debug.WriteLine($"Shoot: {GetHashCode()}  Timeshoot={Timeshoot}");
            //MessageBox.Show($"Shoot: {GetHashCode()}  Timeshoot={Timeshoot}");
            //تغییر دادم
            //Debug.WriteLine(Timeshoot);
            //MessageBox.Show(Timeshoot.ToString());
            //تغییر دادم
            if (Timeshoot >= 500)
            {
                
                sample = Weapon.santes(X, Y - (Height / 2) - Weapon.Height / 2 - 1 );
                sample.jahatx = Xvextor.sabet;
                sample.jahaty = Yvector.up;
                Timeshoot = 0;
                //if (sample != null)
                //{
                //    GameWorld.Bullets.Add(sample);
                //}
                //تغییر دادمن 
                return sample;
            }
            else
            {
                return sample;
            }

        }
        public override void MoveX()
        {
            if (BaresiharekatX())
            {
                X += (int)(((int)jahatx) * Speed);
                return;
            }
            else
            {
                return;
            }
            //X += (int)(((int)jahatx) * Speed);
        }
        public override void MoveY()
        {
            if (BaresiharekatY())
            {
                Y += (int)(((int)jahaty) * Speed);
                return;
            }
            else
            {
                return;
            }
            //Y += (int)(((int)jahaty) * Speed);
        }
        public player(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp,Xvextor jahatx,Yvector jahaty,Bullet mainbullet) : base(width, height, x, y, damage, speed, health, coin, xp,jahatx,jahaty)
        {
            this.MainBullet = mainbullet;
            //this.movetypebullet = move;
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
        public bool outofrange()
        {
            if (!BaresiharekatX() || !BaresiharekatY())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update()
        {
            //Debug.WriteLine($"Update: {GetHashCode()}  Timeshoot={Timeshoot}");
            //MessageBox.Show($"Update: {GetHashCode()}  Timeshoot={Timeshoot}");
            //تغییر دادم
            timeshoot += 16;
            if (outofrange())
            {
                
            }
            else
            {
                MoveX();
                MoveY();
            }
        }
        public void tagirjahatx(Xvextor jahatx)
        {
            this.jahatx = jahatx;
        }
        public void tagirjahaty(Yvector jahaty)
        {
            this.jahaty = jahaty;
        }
    }
}
