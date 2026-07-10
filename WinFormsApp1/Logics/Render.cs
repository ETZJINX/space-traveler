using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Logics
{
    public class Render
    {
        public static void drawplayer(Graphics g,player player2)
        {
            g.FillRectangle(Brushes.Red, player2.X - player2.Width / 2, player2.Y - player2.Height / 2 , player2.Width , player2.Height );
        }
    
        public static void drawenemy(Graphics g, template template)
        {
            //MessageBox.Show($"{template.X} {template.Y} {template.Width} {template.Height}");
            //تغییر دادم
            if (template is StandardEnemy)
            {
                g.FillRectangle(Brushes.Blue, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width , template.Height );
            }
            if (template is ScoutEnemy)
            {
                g.FillRectangle(Brushes.Green, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
            }
            if (template is ShooterEnemy)
            {
                g.FillRectangle(Brushes.Yellow, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
            }
            if (template is HeavyTankEnemy)
            {
                g.FillRectangle(Brushes.Orange, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
            }
            if (template is TerroristEnemy)
            {
                g.FillRectangle(Brushes.Brown, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
            }
        }
        public static void drawbullet(Graphics g,Bullet bullet)
        {
            //MessageBox.Show($"{bullet.X} {bullet.Y} {bullet.Width} {bullet.Height}");
            //MessageBox.Show("Bullet Draw");
            //تغییر دادم
            g.FillRectangle(Brushes.Black, bullet.X - bullet.Width / 2, bullet.Y - bullet.Height / 2, bullet.Width , bullet.Height );
        }
        public static void drawcoin(Graphics g,Coindrop coin)
        {
            g.FillEllipse(Brushes.DarkGoldenrod, coin.X - 5, coin.Y - 5, 10, 10);
        }
    
    }
}
