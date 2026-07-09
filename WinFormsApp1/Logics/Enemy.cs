using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Logics;
using WinFormsApp1.Logics.interfaces;

namespace WinFormsApp1.Logics
{
    public class StandardEnemy : template , IEnemyUpdate
    {
        public override void MoveX(float andaze)
        {
            if (BaresiharekatX(andaze))
            {
                X +=(int) (andaze * Speed);
                return;
            }
            else
            {
                MoveX(-andaze);
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
                MoveY(-andaze);
                return;
            }
        }     
        public StandardEnemy (int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp) : base(width, height, x, y, damage, speed, health, coin, xp)
        {

        }
        public void Update()
        {
            MoveX(0);
            MoveY(-1);
        }
        public StandardEnemy santens()
        {
            StandardEnemy sample;
            sample = new StandardEnemy(this.Width, Height, X, Y, Damage, Speed, Health, Coin, Xp);
            return sample;
        }
    }
    public class ScoutEnemy : template , IEnemyUpdate
    {
        public override void MoveX(float andaze)
        {
            if (BaresiharekatX(andaze))
            {
                X += (int)(andaze * Speed);
                return;
            }
            else
            {
                MoveX(-andaze);
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
                MoveY(-andaze);
                return;
            }
        }
        public ScoutEnemy(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp) : base(width, height, x, y, damage, speed, health, coin, xp)
        {

        }
        public void Update()
        {
            MoveX((float)Math.Sqrt(2) / 2);
            MoveY(-(float)Math.Sqrt(2) / 2);
            MoveX(-(float)Math.Sqrt(2) / 2);
        }
        public ScoutEnemy santens()
        {
            ScoutEnemy sample;
            sample = new ScoutEnemy(this.Width, Height, X, Y, Damage, Speed, Health, Coin, Xp);
            return sample;
        }
    }
    public class ShooterEnemy : template , IWeaponDamage,IEnemyUpdate
    {
        private Bullet MainBullet;
        private int timeshoot;
        public int Timeshoot { get { return timeshoot; } set { timeshoot = value; }  }
        private BulletMoveType movetypebullet;
        public Bullet Weapon { get { return MainBullet; } }
        public BulletMoveType BulletMoveType { get { return movetypebullet; } }
        public Bullet Shoot()
        {
            Bullet sample;
            if (Timeshoot >= 1500)
            {
                sample = Weapon.santes(X, Y - Height / 2);
                Timeshoot = 0;
                sample.Xvector = 0;
                sample.Yvector = -1;
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
                MoveX(-andaze);
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
                MoveY(-andaze);
                return;
            }
        }
        public ShooterEnemy(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp, Bullet mainbullet, BulletMoveType move) : base(width, height, x, y, damage, speed, health, coin, xp)
        {
            this.MainBullet = mainbullet;
            this.movetypebullet = move;
            timeshoot = 1500;
        }
        public void Update()
        {
            MoveX(0);
            MoveY(-1);
            Bullet sample;
            if (Shoot() != null)
            {
                sample = Shoot();
                GameWorld.Bullets.Add(sample);

            }
        }
        public ShooterEnemy santens()
        {
            ShooterEnemy sample;
            sample = new ShooterEnemy(this.Width, Height, X, Y, Damage, Speed, Health, Coin, Xp,MainBullet,movetypebullet);
            return sample;
        }

    }
    public class HeavyTankEnemy : template , IWeaponDamage,IEnemyUpdate
    {
        private Bullet MainBullet;
        private int timeshoot;
        public int Timeshoot { get { return timeshoot; } set { timeshoot = value; } }
        private BulletMoveType movetypebullet;
        public Bullet Weapon { get { return MainBullet; } }
        public BulletMoveType BulletMoveType { get { return movetypebullet; } }
        public Bullet Shoot()
        {
            Bullet sample1;
            if (Timeshoot >= 1500)
            {
                sample1 = Weapon.santes(X, Y - Height / 2);
                Timeshoot = 0;
                Bullet sample2 = sample1.santes(sample1.X, sample1.Y);

                Bullet sample3 = sample1.santes(sample1.X, sample1.Y);
                Bullet sample4 = sample1.santes(sample1.X, sample1.Y);
                Bullet sample5 = sample1.santes(sample1.X, sample1.Y);
                Bullet sample6 = sample1.santes(sample1.X, sample1.Y);
                Bullet sample7 = sample1.santes(sample1.X, sample1.Y);
                Bullet sample8 = sample1.santes(sample1.X, sample1.Y);
                sample1.Xvector = 1;
                sample1.Yvector = 0;
                sample2.Xvector = -1;
                sample2.Yvector = 0;
                sample3.Xvector = 0;
                sample3.Yvector = 1;
                sample4.Xvector = 0;
                sample4.Yvector = -1;
                sample5.Xvector = (float)Math.Sqrt(2) / 2;
                sample5.Yvector = (float)Math.Sqrt(2) / 2;
                sample6.Xvector = -(float)Math.Sqrt(2) / 2;
                sample6.Yvector = (float)Math.Sqrt(2) / 2;
                sample7.Xvector = (float)Math.Sqrt(2) / 2;
                sample7.Yvector = -(float)Math.Sqrt(2) / 2;
                sample8.Xvector = -(float)Math.Sqrt(2) / 2;
                sample8.Yvector = -(float)Math.Sqrt(2) / 2;
                GameWorld.Bullets.Add(sample1);
                GameWorld.Bullets.Add(sample2);
                GameWorld.Bullets.Add(sample3);
                GameWorld.Bullets.Add(sample4);
                GameWorld.Bullets.Add(sample5);
                GameWorld.Bullets.Add(sample6);
                GameWorld.Bullets.Add(sample7);
                GameWorld.Bullets.Add(sample8);

                return sample1;
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
                MoveX(-andaze);
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
                MoveY(-andaze);
                return;
            }
        }
        public HeavyTankEnemy(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp, Bullet mainbullet, BulletMoveType move) : base(width, height, x, y, damage, speed, health, coin, xp)
        {
            this.MainBullet = mainbullet;
            this.movetypebullet = move;
            timeshoot = 1500;
        }
        public void Update()
        {
            MoveX(0);
            MoveY(-1);
            Bullet sample1;
            if (Shoot() != null)
            {
                sample1 = Shoot();
              
            }
        }
        public HeavyTankEnemy santens()
        {
            HeavyTankEnemy sample;
            sample = new HeavyTankEnemy(this.Width, Height, X, Y, Damage, Speed, Health, Coin, Xp, MainBullet, movetypebullet);
            return sample;
        }
    }
    public class TerroristEnemy : template,IEnemyUpdate
    {
        private int raduosDamage;
        public bool explosion;
        public int RaduosDamage { get { return raduosDamage; } set { raduosDamage = value; }  }
        //بزای انمی انتحاری هستش 
        public override void MoveX(float andaze)
        {
            if (BaresiharekatX(andaze))
            {
                X += (int)(andaze * Speed);
                return;
            }
            else
            {
                explosion = true;
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
                explosion = true;
                return;
            }
        }
        public TerroristEnemy(int width, int height, int x, int y, float damage, int speed, int health, int coin, int xp) : base(width, height, x, y, damage, speed, health, coin, xp)
        {
            this.explosion = false;
            raduosDamage = 20;
        }
        public void Update()
        {
            MoveY(-1);
        }
        public TerroristEnemy santens()
        {
            TerroristEnemy sample;
            sample = new TerroristEnemy(this.Width, Height, X, Y, Damage, Speed, Health, Coin, Xp);
            return sample;
        }
    }
}
