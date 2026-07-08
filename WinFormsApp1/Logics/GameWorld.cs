using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Logics
{
    public class Coindrop
    {
        public int X;
        public int Y;
        public int coin;
    }
    public class Input
    {
        public static int Moveup = 0;
        public static int Movedown = 0;
        public static int MoveLeft = 0;
        public static int Moveright = 0;
        public static bool shoot = false;
    }
    public class GameWorld
    {
        public static player player1;
        public static List<Bullet> Bullets = new List<Bullet>();
        //private static List<StandardEnemy> standardEnemies = new List<StandardEnemy>();
        //private static List<ScoutEnemy> scoutEnemies = new List<ScoutEnemy>();
        //private static List<ShooterEnemy> shooterEnemies = new List<ShooterEnemy>();
        //private static List<HeavyTankEnemy> heavyTankEnemies = new List<HeavyTankEnemy>();
        //private static List<TerroristEnemy> terroristEnemies = new List<TerroristEnemy>();
        private static List<template> enemies = new List<template>();
        public static bool gameover = false;
        public static Random Random = new Random();
        public static int stagelevel = 1;

        public static int Width = 720;
        public static int Height = 1000;
        public int xplayervector = 0;
        public int yplayervector = 0;
        public void playerupdate()
        {
            player1.Update(xplayervector, yplayervector);
        }
        public void enemyupdate()
        {
            if (enemies.Count != 0)
            {
                foreach (var item in enemies)
                {
                    if (item is StandardEnemy)
                    {
                        StandardEnemy sample = item as StandardEnemy;
                        sample.Update();
                    }
                    if (item is ScoutEnemy)
                    {
                        ScoutEnemy sample = item as ScoutEnemy;
                        sample.Update();
                    }
                    if (item is ShooterEnemy)
                    {
                        ShooterEnemy sample = item as ShooterEnemy;
                        sample.Update();
                    }
                    if (item is HeavyTankEnemy)
                    {
                        HeavyTankEnemy sample = item as HeavyTankEnemy;
                        sample.Update();
                    }
                    if (item is TerroristEnemy)
                    {
                        TerroristEnemy sample = item as TerroristEnemy;
                        sample.Update();
                    }
                }
            }
            //if (scoutEnemies.Count != 0)
            //{
            //    foreach (var item in scoutEnemies)
            //    {
            //        item.Update();
            //    }
            //}
            //if (shooterEnemies.Count != 0)
            //{
            //    foreach (var item in shooterEnemies)
            //    {
            //        item.Update();
            //    }
            //}
            //if (heavyTankEnemies.Count != 0)
            //{
            //    foreach (var item in heavyTankEnemies)
            //    {
            //        item.Update();
            //    }
            //}
            //if (terroristEnemies.Count != 0)
            //{
            //    foreach (var item in terroristEnemies)
            //    {
            //        item.Update();
            //    }
            //}
        }
        public void playershoot()
        {
            if (Input.shoot)
            {
                Bullet sample;
                sample =  player1.Shoot();
                Bullets.Add(sample);
                Input.shoot = false;
            }
        }
        public void bulletsupdate()
        {
            if (Bullets.Count != 0)
            {
                foreach (var item in Bullets)
                {
                    item.Update(item.Xvector, item.Yvector);
                }
            }
        }
        public void bulletenemycolision()
        {
            if (Bullets.Count != 0)
            {
                foreach (var item in Bullets)
                {
                    if (enemies.Count != 0)
                    {
                        foreach (var item1 in enemies)
                        {
                            if (Collision.BulletEnemy(item,item1.X,item1.Y,item1.Width,item1.Height) && item.Active == true && item1.Active == true)
                            {
                                item.Active = false;
                                item1.DamageTaken(item.Damage);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    //if (scoutEnemies.Count != 0)
                    //{
                    //    foreach (var item1 in scoutEnemies)
                    //    {
                    //        if (Collision.BulletEnemy(item, item1.X, item1.Y, item1.Width, item1.Height))
                    //        {
                    //            item.Active = false;
                    //            item1.DamageTaken(item.Damage);
                    //        }
                    //        else
                    //        {
                    //            continue;
                    //        }
                    //    }
                    //}
                    //if (shooterEnemies.Count != 0)
                    //{
                    //    foreach (var item1 in shooterEnemies)
                    //    {
                    //        if (Collision.BulletEnemy(item, item1.X, item1.Y, item1.Width, item1.Height))
                    //        {
                    //            item.Active = false;
                    //            item1.DamageTaken(item.Damage);
                    //        }
                    //        else
                    //        {
                    //            continue;
                    //        }
                    //    }
                    //}
                    //if (heavyTankEnemies.Count != 0)
                    //{
                    //    foreach (var item1 in heavyTankEnemies)
                    //    {
                    //        if (Collision.BulletEnemy(item, item1.X, item1.Y, item1.Width, item1.Height))
                    //        {
                    //            item.Active = false;
                    //            item1.DamageTaken(item.Damage);
                    //        }
                    //        else
                    //        {
                    //            continue;
                    //        }
                    //    }
                    //}
                    //if (terroristEnemies.Count != 0)
                    //{
                    //    foreach (var item1 in terroristEnemies)
                    //    {
                    //        if (Collision.BulletEnemy(item, item1.X, item1.Y, item1.Width, item1.Height))
                    //        {
                    //            item.Active = false;
                    //            item1.DamageTaken(item.Damage);
                    //        }
                    //        else
                    //        {
                    //            continue;
                    //        }
                    //    }
                    //}
                }
            }
        }
        public void bulletplayer()
        {
            if (Bullets.Count != 0)
            {
                foreach (var item in Bullets)
                {
                    if (Collision.Bulletplayer(item, player1) && item.Active == true)
                    {
                        item.Active = false;
                        player1.DamageTaken(item.Damage);
                        player1.XpTaken(50);
                        player1.Cointaken(1);
                        break;
                    }
                    else
                    {
                        continue ;
                    }
                }
            }
        }
        public void enemyplayer()
        {
            if (enemies.Count != 0)
            {
                foreach (var item1 in enemies)
                {
                    if (Collision.playerenemy(player1, item1.X, item1.Y, item1.Width, item1.Height) && item1.Active == true)
                    {
                        player1.DamageTaken(item1.Damage);
                        player1.XpTaken(50);
                        player1.Cointaken(1);
                        item1.DamageTaken(player1.Damage);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            //if (scoutEnemies.Count != 0)
            //{
            //    foreach (var item1 in scoutEnemies)
            //    {
            //        if (Collision.playerenemy(player1, item1.X, item1.Y, item1.Width, item1.Height))
            //        {
            //            player1.DamageTaken(item1.Damage);
            //            player1.XpTaken(50);
            //            player1.Cointaken(1);
            //            item1.DamageTaken(player1.Damage);
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}
            //if (shooterEnemies.Count != 0)
            //{
            //    foreach (var item1 in shooterEnemies)
            //    {
            //        if (Collision.playerenemy(player1, item1.X, item1.Y, item1.Width, item1.Height))
            //        {
            //            player1.DamageTaken(item1.Damage);
            //            player1.XpTaken(50);
            //            player1.Cointaken(1);
            //            item1.DamageTaken(player1.Damage);
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}
            //if (heavyTankEnemies.Count != 0)
            //{
            //    foreach (var item1 in heavyTankEnemies)
            //    {
            //        if (Collision.playerenemy(player1, item1.X, item1.Y, item1.Width, item1.Height))
            //        {
            //            player1.DamageTaken(item1.Damage);
            //            player1.XpTaken(50);
            //            player1.Cointaken(1);
            //            item1.DamageTaken(player1.Damage);
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}
            //if (terroristEnemies.Count != 0)
            //{
            //    foreach (var item1 in terroristEnemies)
            //    {
            //        if (Collision.playerenemy(player1, item1.X, item1.Y, item1.Width, item1.Height))
            //        {
            //            player1.DamageTaken(item1.Damage);
            //            player1.XpTaken(50);
            //            player1.Cointaken(1);
            //            item1.DamageTaken(player1.Damage);
            //            item1.explosion = true;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}
        }
        public void removebullets()
        {
            if (Bullets.Count != 0)
            {
                foreach (var item in Bullets)
                {
                    if (item.Active == false)
                    {
                        Bullets.Remove(item);
                    }
                }
            }
        }
        public void removeenemy()
        {
            if (enemies.Count != 0)
            {
                foreach (var item in enemies)
                {
                    if (item.Active == false)
                    {
                        enemies.Remove(item);
                    }
                }
            }
        }
        public bool gameover1()
        {
            if (player1.Active == false)
            {
                gameover = true;
                return gameover;
            }
            else
            {
                return gameover;
            }
        }
        
    
    
    
    }
}
