using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Managers
{
    public class Inputmanager
    {
        public static List<Keys> keys = new List<Keys>();
        public static Keys Moveforward = Keys.W;
        public static Keys Movebackward = Keys.S;
        public static Keys Moveleft = Keys.A;
        public static Keys Moveright = Keys.D;
        public static Keys Shoot = Keys.Space;
        public static void init()
        {
            if (keys.Count != 0)
            {
                return;
            }
            else
            {
                keys.Add(Keys.W);
                keys.Add(Keys.S);
                keys.Add(Keys.A);
                keys.Add(Keys.D);
                keys.Add(Keys.Space);
                keys.Add(Keys.PageUp);
                keys.Add(Keys.PageDown);
                keys.Add(Keys.Left);
                keys.Add(Keys.Right);
                keys.Add(Keys.H);
            }
        }
    }
}
