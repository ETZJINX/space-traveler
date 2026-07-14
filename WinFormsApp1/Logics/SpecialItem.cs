using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Logics
{
    public class SpecialItem
    {
        private int x;
        private int y;
        public bool active;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public SpecialItem(int x,int y)
        {
            active = true;
            this.X = x;
            this.Y = y;
        }
    }
    public class DoubleShoot : SpecialItem
    {
        public  int time;
        public DoubleShoot(int x,int y,int time) : base(x,y)
        {
            this.time = time;
        }
    }
    public class FastShoot : SpecialItem
    {
        public  int time ;
        public FastShoot(int x,int y,int time) : base(x, y)
        {
            this.time = time;
        }
    }
    public class Healinig : SpecialItem
    {
        public int heal;
        public Healinig(int x,int y,int healing) : base(x, y)
        {
            this.heal = healing;
        }
    }








}



