using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Logics
{
    public class Render
    {
        public static void drawplayer(Graphics g,player player2)
        {
            g.FillRectangle(Brushes.Red, player2.X, player2.Y, player2.Width /2, player2.Height / 2);
        }
    
        public static void drawenemy(Graphics g, template template)
        {
            if (template is StandardEnemy)
            {
                g.FillRectangle(Brushes.Blue, template.X, template.Y, template.Width / 2, template.Height / 2);
            }
            if (template is ScoutEnemy)
            {
                g.FillRectangle(Brushes.Green, template.X, template.Y, template.Width / 2, template.Height / 2);
            }
            if (template is ShooterEnemy)
            {
                g.FillRectangle(Brushes.Yellow, template.X, template.Y, template.Width/ 2, template.Height/2);
            }
            if (template is HeavyTankEnemy)
            {
                g.FillRectangle(Brushes.Orange, template.X, template.Y, template.Width / 2, template.Height / 2);
            }
            if (template is TerroristEnemy)
            {
                g.FillRectangle(Brushes.Brown, template.X, template.Y, template.Width / 2, template.Height / 2);
            }
        }
        public static void drawbullet(Graphics g,Bullet bullet)
        {
            g.FillRectangle(Brushes.Pink, bullet.X, bullet.Y, bullet.Width / 2, bullet.Height / 2);
        }
        public static void drawcoin(Graphics g,Coindrop coin)
        {
            g.FillEllipse(Brushes.DarkGoldenrod, coin.X, coin.Y, 10, 10);
        }
    
    }
}
