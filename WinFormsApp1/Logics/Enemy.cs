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
                sample.MoveX(0);
                sample.MoveY(-1);

            }
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
            Bullet sample1, sample2, sample3, sample4, sample5, sample6, sample7, sample8;
            if (Shoot() != null)
            {
                sample1 = Shoot();
                sample2 = sample1.santes(sample1.X,sample1.Y);
                sample3 = sample1.santes(sample1.X, sample1.Y);
                sample4 = sample1.santes(sample1.X, sample1.Y);
                sample5 = sample1.santes(sample1.X, sample1.Y);
                sample6 = sample1.santes(sample1.X, sample1.Y);
                sample7 = sample1.santes(sample1.X, sample1.Y);
                sample8 = sample1.santes(sample1.X, sample1.Y);
                sample1.Update(1, 0);
                sample2.Update(-1,0);
                sample3.Update(0, 1);
                sample4.Update(0, -1);
                sample5.Update((float)Math.Sqrt(2) / 2, (float)Math.Sqrt(2) / 2);
                sample6.Update(-(float)Math.Sqrt(2) / 2, (float)Math.Sqrt(2) / 2);
                sample7.Update((float)Math.Sqrt(2) / 2, -(float)Math.Sqrt(2) / 2);
                sample8.Update(-(float)Math.Sqrt(2) / 2, -(float)Math.Sqrt(2) / 2);              
            }
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
    }
}
