using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Logics
{
    
    public class Render
    {
        public static void drawplayer(Graphics g,player player2)
        {
            //g.FillRectangle(Brushes.Red, player2.X - player2.Width / 2, player2.Y - player2.Height / 2 , player2.Width , player2.Height );
            g.DrawImage(player2.img, player2.X - player2.Width / 2, player2.Y - player2.Height / 2, player2.Width, player2.Height);
        }
    
        public static void drawenemy(Graphics g, template template)
        {
            //MessageBox.Show($"{template.X} {template.Y} {template.Width} {template.Height}");
            //تغییر دادم
            if (template is StandardEnemy)
            {
                //g.FillRectangle(Brushes.Blue, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width , template.Height );
                g.DrawImage(template.img, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
                g.FillRectangle(Brushes.Red, template.X - template.Width / 2, template.Y - template.Height / 2 , template.Health * template.Width / template.maxhealth, 5);
                g.DrawString( $"Health{template.Health}",new Font("Arial", 9),Brushes.Black,template.X - template.Width / 2,template.Y - template.Height / 2);
                
            }
            if (template is ScoutEnemy)
            {
                //g.FillRectangle(Brushes.Green, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
                g.DrawImage(template.img, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
                g.FillRectangle(Brushes.Red, template.X - template.Width / 2, template.Y - template.Height / 2, template.Health * template.Width / template.maxhealth, 5);
                g.DrawString($"Health{template.Health}", new Font("Arial", 9), Brushes.Black, template.X - template.Width / 2, template.Y - template.Height / 2);
            }
            if (template is ShooterEnemy)
            {
                //g.FillRectangle(Brushes.Yellow, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
                g.DrawImage(template.img, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
                g.FillRectangle(Brushes.Red, template.X - template.Width / 2, template.Y - template.Height / 2, template.Health * template.Width / template.maxhealth, 5);
                g.DrawString($"Health{template.Health}", new Font("Arial", 9), Brushes.Black, template.X - template.Width / 2, template.Y - template.Height / 2);
            }
            if (template is HeavyTankEnemy)
            {
                //g.FillRectangle(Brushes.Orange, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
                g.DrawImage(template.img, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
                g.FillRectangle(Brushes.Red, template.X - template.Width / 2, template.Y - template.Height / 2, template.Health * template.Width / template.maxhealth, 5);
                g.DrawString($"Health{template.Health}", new Font("Arial", 9), Brushes.Black, template.X - template.Width / 2, template.Y - template.Height / 2);
            }
            if (template is TerroristEnemy)
            {
                //g.FillRectangle(Brushes.Brown, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
                g.DrawImage(template.img, template.X - template.Width / 2, template.Y - template.Height / 2, template.Width, template.Height);
                g.FillRectangle(Brushes.Red, template.X - template.Width / 2, template.Y - template.Height / 2, template.Health * template.Width / template.maxhealth, 5);
                g.DrawString($"Health{template.Health}", new Font("Arial", 9), Brushes.Black, template.X - template.Width / 2, template.Y - template.Height / 2);
            }
        }
        public static void drawbullet(Graphics g,Bullet bullet)
        {
            //MessageBox.Show($"{bullet.X} {bullet.Y} {bullet.Width} {bullet.Height}");
            //MessageBox.Show("Bullet Draw");
    //        MessageBox.Show(
    //$"X={bullet.X}\nY={bullet.Y}\nW={bullet.Width}\nH={bullet.Height}");
            //تغییر دادم
            //g.FillRectangle(Brushes.Black, bullet.X - bullet.Width / 2, bullet.Y - bullet.Height / 2, bullet.Width, bullet.Height);
            g.DrawImage(bullet.img, bullet.X - bullet.Width / 2, bullet.Y - bullet.Height / 2, bullet.Width, bullet.Height);
            //        g.FillRectangle(
            //Brushes.Red,
            //100,
            //100,
            //40,
            //40);
            //g.FillRectangle(
            //Brushes.Red,
            //bullet.X,
            //bullet.Y,
            //40,
            //40);
        }
        public static void drawcoin(Graphics g,Coindrop coin)
        {
            //MessageBox.Show($"{coin.X} {coin.Y}");
            g.FillEllipse(Brushes.Gold, coin.X, coin.Y, 30, 30);
            //g.FillEllipse(Brushes.DarkGoldenrod, coin.X - 5, coin.Y - 5, 10, 10);
        }
        public static void drawdoubleshoot(Graphics g,DoubleShoot shot)
        {
            g.FillEllipse(Brushes.Red, shot.X, shot.Y, 30, 30);
        }
        public static void drawfastshoot(Graphics g, FastShoot fast)
        {
            g.FillEllipse(Brushes.Blue, fast.X, fast.Y, 30, 30);
        }
        public static void drawheal(Graphics g, Healinig heal)
        {
            g.FillEllipse(Brushes.Green, heal.X, heal.Y, 30, 30);
        }

    }
}
