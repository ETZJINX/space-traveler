using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Logics.interfaces;
namespace WinFormsApp1.Logics
{
    public class Bullet : IDamagable,IMoveable,IActive,ISizeVolum,IUpdate
    {
        public static List<Bullet> bulletswholegame = new List<Bullet>();
        public float Xvector;
        public float Yvector;
        private int width;
        private int height;
        public int Width {  get { return width; } }
        public int Height { get { return height; } }
        private BulletMoveType moveType;
        private int x, y;
        private float damage;
        private int speed;
        private bool active;
        public bool Active { get { return active; } set { active = value; } }
        public BulletMoveType Movetype { get { return moveType; } set { moveType = value; } }
        public int X { get { return x; } set { x = value ; } }
        public int Y { get { return y; } set { y = value ; } }
        public float Damage { get { return damage; } set { damage = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public Bullet(BulletMoveType moveType,int x,int y,float damage,int speed)
        {
            Movetype = moveType;
            X = x;
            Y = y;
            Damage = damage;
            Speed = speed;
            Active = true;
            bulletswholegame.Add(this);
        }
        public bool BaresiharekatX(float andaze)
        {
            return (X + (andaze * Speed) + Width / 2 <= GameWorld.Width && X + (andaze * Speed) - Width /2 >= 0) ;
        }
        public bool BaresiharekatY(float andaze)
        {
            return (Y + (andaze * Speed) + Height / 2 <= GameWorld.Height && Y + (andaze * Speed) - Height / 2 <= 0);
        }
        public void MoveX(float andaze)
        {
            if (BaresiharekatX(andaze))
            {
                X += (int)(andaze * Speed);
                return;
            }
            else
            {
                Active = false;
                return;
            }

        }
        public void MoveY(float andaze)
        {
            if (BaresiharekatY(andaze))
            {
                Y +=(int) (andaze * Speed);
                return;
            }
            else
            {
                Active = false;
                return;
            }
        }
        public Bullet santes(int x1 , int y1)
        {
            Bullet sample = new Bullet(this.Movetype,x1,y1,this.Damage,this.Speed);
            return sample;    
        }
        public void Update(float x,float y)
        {
            if (!Active)
            {
                MessageBox.Show("Inactive");
            }
            //تغییر دادم کد بالایی رو 
            if (active == true)
            {
                MoveX(x);
                MoveY(y);
            }
            //else
            //{
            //    GameWorld.Bullets.Remove(this);
            //}
            //تغییرش دادم 
        }
    }
}
