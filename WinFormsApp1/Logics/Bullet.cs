using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Logics.interfaces;
namespace WinFormsApp1.Logics
{
    internal class Bullet : IDamagable,IMoveable,IActive
    {
        private MoveType moveType;
        private int x, y;
        private float damage;
        private int speed;
        private bool active;
        public bool Active { get { return active; } set { active = value; } }
        public MoveType Movetype { get { return moveType; } set { moveType = value; } }
        public int X { get { return x; } set { x = value ; } }
        public int Y { get { return y; } set { y = value ; } }
        public float Damage { get { return damage; } set { damage = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public Bullet(MoveType moveType,int x,int y,float damage,int speed)
        {
            Movetype = moveType;
            X = x;
            Y = y;
            Damage = damage;
            Speed = speed;
            Active = true;
        }
        public bool BaresiharekatX(int andaze)
        {
            return (X + (andaze * Speed) + 10 <= GameWorld.Width && X + (andaze * Speed) - 10 >= 0) ;
        }
        public bool BaresiharekatY(int andaze)
        {
            return (Y + (andaze * Speed) + 10 <= GameWorld.Height && Y + (andaze * Speed) - 10 >= 0);
        }
        public void MoveX(int andaze)
        {
            if (BaresiharekatX(andaze))
            {
                X += andaze * Speed;
                return;
            }
            else
            {
                Active = false;
                return;
            }

        }
        public void MoveY(int andaze)
        {
            if (BaresiharekatY(andaze))
            {
                Y += andaze * Speed;
                return;
            }
            else
            {
                Active = false;
                return;
            }
        }
    }
}
