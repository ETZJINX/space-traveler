using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using WinFormsApp1.Logics;
using WinFormsApp1.Logics.interfaces;

namespace WinFormsApp1.Logics
{
    public class StandardEnemy : template ,IUpdate
    {
        Random random1 = new Random();
        //برای اسپان تصادفی در هنگام برخورد با دیوار 
        public int xfirst;
        public int yfirst;
        public override void MoveX()
        {
            //if (BaresiharekatX())
            //{
            //    X +=(int) (((int)jahatx) * Speed);
            //    return;
            //}
            //else
            //{
            //    //MoveX(-andaze);
            //    //Active = false;
            //    return;
            //}
            X += (int)(((int)jahatx) * Speed);
        }
        public override void MoveY()
        {
            //if (BaresiharekatY())
            //{
            //    Y += (int)(((int)jahaty) * Speed);
            //    return;
            //}
            //else
            //{
            //    //MoveY(-andaze);
            //    //Active = false;
            //    return;
            //}
            Y += (int)(((int)jahaty) * Speed);
        }     
        public StandardEnemy (int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp,Xvextor jahatx,Yvector jahaty) : base(width, height, x, y, damage, speed, health, coin, xp,jahatx,jahaty)
        {
            xfirst = x;
            yfirst = y;
        }
        public void Update()
        {
            //MessageBox.Show(Y.ToString());
            if (outofrange())
            {
                if (Y + Height / 2 > GameWorld.Width)
                {
                    Y = Height / 2;
                    X = random1.Next(Width / 2, GameWorld.Width - Width / 2);
                }
            }
            MoveX();
            MoveY();
        }
        public StandardEnemy santens()
        {
            StandardEnemy sample;
            sample = new StandardEnemy(Width, Height, X, Y, Damage, Speed, Health, Coin, Xp,jahatx,jahaty);
            return sample;
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

    }
    public class ScoutEnemy : template , IUpdate
    {
        public override void MoveX()
        {
            //if (BaresiharekatX())
            //{
            //    X +=(int) (((int)jahatx) * Speed);
            //    return;
            //}
            //else
            //{
            //    //MoveX(-andaze);
            //    //Active = false;
            //    return;
            //}
            X += (int)(((int)jahatx * Math.Sqrt(2) / 2) * Speed);
        }
        public override void MoveY()
        {
            //if (BaresiharekatY())
            //{
            //    Y += (int)(((int)jahaty) * Speed);
            //    return;
            //}
            //else
            //{
            //    //MoveY(-andaze);
            //    //Active = false;
            //    return;
            //}
            Y += (int)(((int)jahaty * Math.Sqrt(2) / 2) * Speed);
        }
        public ScoutEnemy(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp,Xvextor jahatx,Yvector jahaty) : base(width, height, x, y, damage, speed, health, coin, xp,jahatx,jahaty)
        {

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
            if (outofrange())
            {
                if (X - Width / 2 < 0)
                {
                    X = GameWorld.Width - Width / 2;
                }
                else if (X + Width / 2 > GameWorld.Width)
                {
                    X = Width / 2;
                }
                else if (Y + Height / 2 > GameWorld.Width)
                {
                    Y = Height / 2;
                }
                else if (Y - Height / 2 < 0)
                {
                    Y = GameWorld.Height - Height / 2;
                }

            }
            MoveX();
            MoveY();
        }
        public ScoutEnemy santens()
        {
            ScoutEnemy sample;
            sample = new ScoutEnemy(this.Width, Height, X, Y, Damage, Speed, Health, Coin, Xp,jahatx,jahaty);
            return sample;
        }
    }
    public class ShooterEnemy : template , IWeaponDamage,IUpdate
    {
        private  Random random1 = new Random();
        private int shootdelay;
        public int xfirst;
        public int yfirst;
        private Bullet MainBullet;
        private int timeshoot;
        public int Timeshoot { get { return timeshoot; } set { timeshoot = value; }  }
        //private BulletMoveType movetypebullet;
        public Bullet Weapon { get { return MainBullet; } }
        //public BulletMoveType BulletMoveType { get { return movetypebullet; } }
        public Bullet Shoot()
        {
            Bullet sample = null;
            if (Timeshoot >= shootdelay)
            {
                sample = Weapon.santes(X, Y + Height / 2 + 5);
                Timeshoot = 0;
                sample.jahatx = Xvextor.sabet;
                sample.jahaty = Yvector.down;
                //GameWorld.Bullets.Add(sample);
                return sample;
            }
            else
            {
                //timeshoot += 16;
                return null;
            }
        }
        public override void MoveX()
        {
            //if (BaresiharekatX(andaze))
            //{
            //    X += (int)(andaze * Speed);
            //    return;
            //}
            //else
            //{
            //    //MoveX(-andaze);
            //    //if (andaze > 0)
            //    //{
            //    //    X = GameWorld.Width - Width / 2;
            //    //}
            //    //else
            //    //{
            //    //    X = Width / 2;
            //    //}
            //    Active = false;
            //    return;
            //}
            //if (BaresiharekatX())
            //{
            //    X +=(int) (((int)jahatx) * Speed);
            //    return;
            //}
            //else
            //{
            //    //MoveX(-andaze);
            //    //Active = false;
            //    return;
            //}
            X += (int)(((int)jahatx) * Speed);

        }
        public override void MoveY()
        {
            //if (BaresiharekatY(andaze))
            //{
            //    Y += (int)(andaze * Speed);
            //    return;
            //}
            //else
            //{
            //    //MoveY(-andaze);
            //    //if (andaze > 0)
            //    //{
            //    //    Y = GameWorld.Height - Height / 2;
            //    //}
            //    //else
            //    //{
            //    //    Y = Height / 2;
            //    //}
            //    Active = false;
            //    return;
            //}
            Y += (int)(((int)jahaty) * Speed);
        }
        public ShooterEnemy(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp,Xvextor jahatx,Yvector jahaty, Bullet mainbullet) : base(width, height, x, y, damage, speed, health, coin, xp,jahatx,jahaty)
        {
            this.MainBullet = mainbullet;
            //this.movetypebullet = move;
            timeshoot = 800;
            shootdelay = 800;
            xfirst = x;
            yfirst = y;
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

            MoveX();
            MoveY();
            Bullet sample = null;
            if (Active)
            {
                sample = Shoot();
            }
            if (outofrange())
            {
                if (Y + Height / 2 > GameWorld.Width)
                {
                    Y = Height / 2;   
                    X = random1.Next(Width / 2, GameWorld.Width - Width / 2);
                }
            }
            if (sample != null)
            {

                GameWorld.Bullets.Add(sample);

            }
            Timeshoot += 16;
            //تغییر دادم 
        }
        public ShooterEnemy santens()
        {
            ShooterEnemy sample;
            sample = new ShooterEnemy(this.Width, Height, X, Y, Damage, Speed, Health, Coin, Xp,jahatx,jahaty,MainBullet);
            return sample;
        }

    }
    public class HeavyTankEnemy : template , IWeaponDamage,IUpdate
    {
        private Random random1 = new Random();
        private int shootdelay;
        public int xfirst;
        public int yfirst;
        private Bullet MainBullet;
        private int timeshoot;
        public int Timeshoot { get { return timeshoot; } set { timeshoot = value; } }
        private BulletMoveType movetypebullet;
        public Bullet Weapon { get { return MainBullet; } }
        public BulletMoveType BulletMoveType { get { return movetypebullet; } }
        public Bullet Shoot()
        {
            Bullet sample1;
            if (Timeshoot >= shootdelay)
            {
                sample1 = Weapon.santes(X, Y + (Height / 2) + 5 );
                Timeshoot = 0;
                Bullet sample6 = sample1.santes(X - Width / 2 - 5, Y + Height / 2 + 5);

                Bullet sample2 = sample1.santes(X - Width / 2 - 5,Y);
                Bullet sample3 = sample1.santes(X + Width / 2 + 5, Y);
                Bullet sample4 = sample1.santes(X, Y - (Height / 2) - 5);
                Bullet sample5 = sample1.santes(X + Width / 2 + 5,Y + Height / 2 + 5);
                Bullet sample7 = sample1.santes(X + Width / 2 + 5, Y - Height / 2 - 5);
                Bullet sample8 = sample1.santes(X - Width / 2 - 5, Y - Height / 2 - 5);
                sample1.jahatx = Xvextor.sabet;
                sample1.jahaty =Yvector.down;
                sample2.jahatx = Xvextor.left;
                sample2.jahaty = Yvector.sabet;
                sample3.jahatx = Xvextor.right;
                sample3.jahaty = Yvector.sabet;
                sample4.jahatx = Xvextor.sabet;
                sample4.jahaty = Yvector.up;
                sample5.jahatx = Xvextor.right;
                sample5.jahaty = Yvector.down;
                sample6.jahatx = Xvextor.left;
                sample6.jahaty = Yvector.down;
                sample7.jahatx = Xvextor.right;
                sample7.jahaty = Yvector.up;
                sample8.jahatx = Xvextor.left;
                sample8.jahaty = Yvector.up;
                //GameWorld.Bullets.Add(sample1);
                GameWorld.Bullets.Add(sample2);
                GameWorld.Bullets.Add(sample3);
                GameWorld.Bullets.Add(sample4);
                GameWorld.Bullets.Add(sample5);
                GameWorld.Bullets.Add(sample6);
                GameWorld.Bullets.Add(sample7);
                GameWorld.Bullets.Add(sample8);
                //چون فقط یکی بر میگردونه مجبوریم همینجا ادش کنیم 


                return sample1;
            }
            else
            {
                //Timeshoot += 16;
                return null;
            }
        }
        public override void MoveX()
        {
            //if (BaresiharekatX(andaze))
            //{
            //    X += (int)(andaze * Speed);
            //    return;
            //}
            //else
            //{
            //    //MoveX(-andaze);
            //    Active = false;
            //    return;
            //}
            X += (int)(((int)jahatx) * Speed);
        }
        public override void MoveY()
        {
            //if (BaresiharekatY(andaze))
            //{
            //    Y += (int)(andaze * Speed);
            //    return;
            //}
            //else
            //{
            //    //MoveY(-andaze);
            //    Active = false;
            //    return;
            //}
            Y += (int)(((int)jahaty) * Speed);
        }
        public HeavyTankEnemy(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp,Xvextor jahatx,Yvector jahaty, Bullet mainbullet) : base(width, height, x, y, damage, speed, health, coin, xp,jahatx,jahaty)
        {
            this.MainBullet = mainbullet;
            //this.movetypebullet = move;
            xfirst = x;
            yfirst = y;
            timeshoot = 800;
            shootdelay = 800;
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
            MoveX();
            MoveY();
            Bullet sample1 = null;
            if (Active)
            {
                sample1 = Shoot();
            }
            if (outofrange())
            {
                if (Y + Height / 2 > GameWorld.Width)
                {
                    Y = Height / 2;
                    X = random1.Next(Width / 2, GameWorld.Width - Width / 2);
                }
            }
            if (sample1 != null)
            {
                GameWorld.Bullets.Add(sample1);

            }
            Timeshoot += 16;
            //تغییر دادم 
        }
        public HeavyTankEnemy santens()
        {
            HeavyTankEnemy sample;
            sample = new HeavyTankEnemy(this.Width, Height, X, Y, Damage, Speed, Health, Coin, Xp,jahatx,jahaty, MainBullet);
            return sample;
        }
    }
    public class TerroristEnemy : template,IUpdate
    {
        private int raduosDamage;
        public bool explosion;
        public int RaduosDamage { get { return raduosDamage; } set { raduosDamage = value; }  }
        //بزای انمی انتحاری هستش 
        public override void MoveX()
        {
            //if (BaresiharekatX(andaze))
            //{
            //    X += (int)(andaze * Speed);
            //    return;
            //}
            //else
            //{
            //    explosion = true;
            //    Active = false;
            //    return;
            //}
            X += (int)(((int)jahatx) * Speed);
        }
        public override void MoveY()
        {
            //if (BaresiharekatY(andaze))
            //{
            //    Y += (int)(andaze * Speed);
            //    return;
            //}
            //else
            //{
            //    explosion = true;
            //    Active = false;
            //    return;
            //}
            Y += (int)(((int)jahaty) * Speed);
        }
        public TerroristEnemy(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp,Xvextor jahatx,Yvector jahaty) : base(width, height, x, y, damage, speed, health, coin, xp,jahatx,jahaty)
        {
            this.explosion = false;
            raduosDamage = 20;
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
            if (outofrange())
            {
                explosion = true;
                Active = false;
            }
            MoveX();
            MoveY();
        }
        public TerroristEnemy santens()
        {
            TerroristEnemy sample;
            sample = new TerroristEnemy(this.Width, Height, X, Y, Damage, Speed, Health, Coin, Xp,jahatx,jahaty);
            return sample;
        }
    }
}
