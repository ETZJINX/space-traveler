using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Logics.interfaces;
namespace WinFormsApp1.Logics
{
    public class Bullet : IDamagable,IMoveable,IActive,ISizeVolum,IUpdate,ISpeed
    {
        //public static List<Bullet> bulletswholegame = new List<Bullet>();
        public Image img;
        private Xvextor JAHATX;
        private Yvector JAHATY;
        private int width;
        private int height;
        public int Width {  get { return width; } }
        public int Height { get { return height; } }
        public Xvextor jahatx{  get { return JAHATX; } set { JAHATX = value; } }
        public Yvector jahaty { get { return JAHATY; }set { JAHATY = value; } }
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
        public Bullet(BulletMoveType moveType,int x,int y,float damage,int speed,int width,int heghit,Image img)
        {
            Movetype = moveType;
            X = x;
            Y = y;
            Damage = damage;
            Speed = speed;
            Active = true;
            this.width = width;
            this.height = heghit;
            this.img = img;
            //bulletswholegame.Add(this);
            //MessageBox.Show("bullet succesfull added");
        }
        public bool BaresiharekatX()
        {
            return (X + (((int)jahatx) * Speed) + this.Width / 2 <= GameWorld.Width && X + (((int)jahatx) * Speed) - this.Width /2 >= 0) ;
        }
        public bool BaresiharekatY()
        {
            return (Y + (((int)jahaty) * Speed) + Height / 2 <= GameWorld.Height && Y + (((int)jahaty) * Speed) - Height / 2 >= 0) ;
        }
        public void MoveX()
        {
            //if (BaresiharekatX())
            //{
            //    X += (int)(((int)jahatx) * Speed);
            //    return;
            //}
            //else
            //{
            //    //Active = false;
            //    //تغییر دادم
            //    return;
            //}
            X += (int)(((int)jahatx) * Speed);

        }
        public void MoveY()
        {
            //if (BaresiharekatY())
            //{
            //    Y +=(int) (((int)jahaty) * Speed);
            //    return;
            //}
            //else
            //{
            //    //Active = false;
            //    //تغیییردادم
            //    return;
            //}
            Y += (int)(((int)jahaty) * Speed);
        }
        public Bullet santes(int x1 , int y1)
        {
            Bullet sample = new Bullet(this.Movetype,x1,y1,this.Damage,this.Speed,Width,Height,img);
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
        public void Update()
        {
            //MessageBox.Show($"{X} , {Y}");
            //تغییر دادم
            //if (!Active)
            //{
            //    MessageBox.Show("Inactive");
            //}
            //تغییر دادم کد بالایی رو 
            //if (active == true)
            //{
            //    MoveX();
            //    MoveY();
            //}
            MoveX();
            MoveY();
            if (outofrange())
            {
                Active = false;
            }
            //else
            //{
            //    GameWorld.Bullets.Remove(this);
            //}
            //تغییرش دادم 
        }
    }
}
