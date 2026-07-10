using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Logics.interfaces;

namespace WinFormsApp1.Logics
{
    public class Wavemanager
    {
        public static bool showmessage = false;
        private static Random random = new Random();
        public static int currentwave = 1;
        private static int EnemyRemainingToSpawn = 10;
        private static int spawndelay = 0;
        private static int Wavedelay = 0;//ثانیه 
        private static int index = 0;
        private static List<template> wave1 = new List<template>();
        private static List<template> wave2 = new List<template>();
        private static List<template> wave3 = new List<template>();
        private static List<template> wave4 = new List<template>();
        private static List<template> wave5 = new List<template>();
        private static List<template> wave6 = new List<template>();
        private static List<template> wave7 = new List<template>();
        private static List<template> wave8 = new List<template>();
        private static List<template> wave9 = new List<template>();
        private static List<template> wave10 = new List<template>();
        private static List<List<template>> allwave = new List<List<template>>();
        public static void init()
        {
            StandardEnemy sample = new StandardEnemy(60, 80, 250, GameWorld.Height - 20, 40, 5, 100, 0, 150,Xvextor.sabet,Yvector.down);
            ScoutEnemy sample1 = new ScoutEnemy(60, 80, 250, GameWorld.Height - 20, 45, 15, 100, 0, 250,Xvextor.right,Yvector.down);
            ShooterEnemy sample2 = new ShooterEnemy(40, 60, 250, GameWorld.Height - 20, 20, 5, 150, 0, 350,Xvextor.sabet,Yvector.down, GameWorld.player1.Weapon);
            HeavyTankEnemy sample3 = new HeavyTankEnemy(120, 100, 250, GameWorld.Height - 20, 150, 3, 700, 0, 550,Xvextor.sabet,Yvector.down, GameWorld.player1.Weapon);
            TerroristEnemy sample4 = new TerroristEnemy(20, 40, 250, GameWorld.Height - 20, 280, 8, 500, 0, 800,Xvextor.sabet,Yvector.down);
            //wave1
            for (int i = 0; i < 10; i++)
            {
                wave1.Add(sample.santens());
                //MessageBox.Show(sample.santens().Active.ToString());
                //بررسی میکنمش 
            
            }
            allwave.Add(wave1);
            //wave2
            for (int i = 0; i < 5; i++)
            {
                wave2.Add(sample.santens());
            }
            for (int i = 0; i < 5; i++)
            {
                wave2.Add(sample1.santens());
            }
            allwave.Add(wave2);
            //wave3
            for (int i = 0; i < 5; i++)
            {
                wave3.Add(sample.santens());
            }
            for (int i = 0; i < 8; i++)
            {
                wave3.Add(sample1.santens());
            }
            for (int i = 0; i < 2; i++)
            {
                wave3.Add(sample2.santens());
            }
            allwave.Add(wave3);
            //wave4
            for (int i = 0; i < 8; i++)
            {
                wave4.Add(sample1.santens());
            }
            for (int i = 0; i < 5; i++)
            {
                wave4.Add(sample2.santens());
            }
            for (int i = 0; i < 2; i++)
            {
                wave4.Add(sample3.santens());
            }
            allwave.Add(wave4);
            //wave5
            for (int i = 0; i < 5; i++)
            {
                wave5.Add(sample.santens());
            }
            for (int i = 0; i < 10; i++)
            {
                wave5.Add(sample1.santens());
            }
            for (int i = 0; i < 5; i++)
            {
                wave5.Add(sample2.santens());
            }
            allwave.Add(wave5);
            //wave6
            for (int i = 0; i < 5; i++)
            {
                wave6.Add(sample1.santens());
            }
            for (int i = 0; i < 10; i++)
            {
                wave6.Add(sample2.santens());
            }
            for (int i = 0; i < 5; i++)
            {
                wave6.Add(sample3.santens());
            }
            allwave.Add(wave6);
            //wave7
            for (int i = 0; i < 8; i++)
            {
                wave7.Add(sample2.santens());
            }
            for (int i = 0; i < 3; i++)
            {
                wave7.Add(sample3.santens());
            }
            for (int i = 0; i < 5; i++)
            {
                wave7.Add(sample1.santens());
            }
            for (int i = 0; i < 1; i++)
            {
                wave7.Add(sample4.santens());
            }
            allwave.Add(wave7);
            //wave8
            for (int i = 0; i < 10; i++)
            {
                wave8.Add(sample1.santens());
            }
            for (int i = 0; i < 8; i++)
            {
                wave8.Add(sample2.santens());
            }
            for (int i = 0; i < 5; i++)
            {
                wave8.Add(sample3.santens());
            }
            allwave.Add(wave8);
            //ave9
            for (int i = 0; i < 20; i++)
            {
                wave9.Add(sample2.santens());
            }
            for (int i = 0; i < 5; i++)
            {
                wave9.Add(sample3.santens());
            }
            for (int i = 0; i < 5; i++)
            {
                wave9.Add(sample4.santens());
            }
            allwave.Add(wave9);
            //wave10
            HeavyTankEnemy sample5 = sample3.santens();
            sample5.Health = 3500;
            sample5.Speed = 1;
            sample5.Coin = 2000;
            sample5.Xp = 10000;
            wave10.Add(sample5);
            allwave.Add(wave10);
            
        }
        //اسپان انمی هنوز مشکوکه
        public static void spawnenemy(List<template> templates,int index)
        {
            if (templates.Count == 0)
            {
                return;
            }
            else
            {
                if (templates.Count != 0)
                {
                    templates[index].X = random.Next(templates[index].Width / 2, GameWorld.Width - templates[index].Width / 2);
                    templates[index].Y = templates[index].Height / 2;
                    
                    //خط مهم و مشتی 
                    if (templates[index] is StandardEnemy && random.Next(100) < 5)
                    {
                        templates[index].Coin = 10;
                    }
                    else if (templates[index] is ScoutEnemy && random.Next(100) < 10)
                    {
                        templates[index].Coin = 20;
                    }
                    else if (templates[index] is ShooterEnemy && random.Next(100) < 30)
                    {
                        templates[index].Coin = 50;
                    }
                    else if (templates[index] is HeavyTankEnemy && random.Next(100) < 60 && templates[index].Coin != 2000)
                    {
                        templates[index].Coin = 100;
                    }
                    else if (templates[index] is TerroristEnemy && random.Next(100) < 100)
                    {
                        templates[index].Coin = 200;
                    }
                    GameWorld.enemies.Add(templates[index]);

                    //templates.RemoveAt(index);
                    //MessageBox.Show(GameWorld.enemies[GameWorld.enemies.Count - 1].Active.ToString());
                    //تغییر دادم 

                }
            }
        }
        public static void sakhty(List<template> templates)
        {
            if (templates.Count == 0)
            {
                return;
            }
            else
            {
                foreach (var item in templates)
                {
                    item.Health += 5 * currentwave;
                    //nothing for speed
                }
            }
        }
        public static void Update()
        {
            List<template> activewave = allwave[currentwave - 1];
            if (activewave.Count != 0 && index < activewave.Count)
            {
                
                spawndelay += 16;
                if (spawndelay >= 5000)
                {
                    spawnenemy(activewave,index);
                    //activewave.RemoveAt(0);
                    //activewave[0].Active = false;
                    //MessageBox.Show(GameWorld.enemies[GameWorld.enemies.Count - 1].Active.ToString());
                    //تغییر دادم

                    //EnemyRemainingToSpawn--;
                    spawndelay = 0;
                    index++;
                }
            }
            else
            {
                if (GameWorld.baresiinactiveenemy())
                {
                    if (currentwave != 10)
                    {
                        showmessage = true;
                        Wavedelay += 16;
                        if (Wavedelay > 8000)
                        {
                            currentwave++;
                            index = 0;
                            showmessage = false;
                            sakhty(allwave[currentwave - 1]);
                            Wavedelay = 0;
                        }
                    }
                    else
                    {
                        GameWorld.gameover = true;
                    }
                }
            }
        //    if (currentwave == 1)
        //    {
        //        if (activewave.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave1);
        //                wave1.Remove(wave1[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                Wavedelay++;
        //                if (Wavedelay > 14)
        //                {
        //                    currentwave = 2;
        //                    Wavedelay = 0;
        //                }
        //            }
        //        }
        //    }
        //    if (currentwave == 2)
        //    {
        //        if (wave2.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave2);
        //                wave2.Remove(wave2[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                Wavedelay++;
        //                if (Wavedelay > 14)
        //                {
        //                    currentwave = 3;
        //                    Wavedelay = 0;
        //                }
        //            }
        //        }
        //    }
        //    if (currentwave == 3)
        //    {
        //        if (wave3.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave3);
        //                wave3.Remove(wave3[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                Wavedelay++;
        //                if (Wavedelay > 14)
        //                {
        //                    currentwave = 4;
        //                    Wavedelay = 0;
        //                }
        //            }
        //        }
        //    }
        //    if (currentwave == 4)
        //    {
        //        if (wave4.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave4);
        //                wave4.Remove(wave4[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                Wavedelay++;
        //                if (Wavedelay > 14)
        //                {
        //                    currentwave = 5;
        //                    Wavedelay = 0;
        //                }
        //            }
        //        }
        //    }
        //    if (currentwave == 5)
        //    {
        //        if (wave5.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave5);
        //                wave5.Remove(wave5[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                Wavedelay++;
        //                if (Wavedelay > 14)
        //                {
        //                    currentwave = 6;
        //                    Wavedelay = 0;
        //                }
        //            }
        //        }
        //    }
        //    if (currentwave == 6)
        //    {
        //        if (wave6.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave6);
        //                wave6.Remove(wave6[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                Wavedelay++;
        //                if (Wavedelay > 14)
        //                {
        //                    currentwave = 7;
        //                    Wavedelay = 0;
        //                }
        //            }
        //        }
        //    }
        //    if (currentwave == 7)
        //    {
        //        if (wave7.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave7);
        //                wave7.Remove(wave7[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                Wavedelay++;
        //                if (Wavedelay > 14)
        //                {
        //                    currentwave = 8;
        //                    Wavedelay = 0;
        //                }
        //            }
        //        }
        //    }
        //    if (currentwave == 8)
        //    {
        //        if (wave8.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave8);
        //                wave8.Remove(wave8[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                Wavedelay++;
        //                if (Wavedelay > 14)
        //                {
        //                    currentwave = 9;
        //                    Wavedelay = 0;
        //                }
        //            }
        //        }
        //    }
        //    if (currentwave == 9)
        //    {
        //        if (wave9.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave9);
        //                wave9.Remove(wave9[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                Wavedelay++;
        //                if (Wavedelay > 14)
        //                {
        //                    currentwave = 10;
        //                    Wavedelay = 0;
        //                }
        //            }
        //        }
        //    }
        //    if (currentwave == 10)
        //    {
        //        if (wave10.Count != 0)
        //        {
        //            spawndelay++;
        //            if (spawndelay > 4)
        //            {
        //                spawnenemy(wave10);
        //                wave10.Remove(wave10[0]);
        //                EnemyRemainingToSpawn--;
        //                spawndelay = 0;
        //            }
        //        }
        //        else
        //        {
        //            if (GameWorld.enemies.Count == 0)
        //            {
        //                GameWorld.gameover = true;
        //            }
        //        }
        //    }
        }
        //اپدیتم شک دارم 
    
    }
    public class Coindrop
    {
        public bool active;
        public int X;
        public int Y;
        public int coin;
        public Coindrop(int x,int y, int coin)
        {
            this.X = x;
            this.Y = y;
            this.coin = coin;
            active = true;
        }
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
        public static List<Coindrop> coinsdrops = new List<Coindrop>();
        //private static List<StandardEnemy> standardEnemies = new List<StandardEnemy>();
        //private static List<ScoutEnemy> scoutEnemies = new List<ScoutEnemy>();
        //private static List<ShooterEnemy> shooterEnemies = new List<ShooterEnemy>();
        //private static List<HeavyTankEnemy> heavyTankEnemies = new List<HeavyTankEnemy>();
        //private static List<TerroristEnemy> terroristEnemies = new List<TerroristEnemy>();
        public static List<template> enemies = new List<template>();
        public static bool gameover = false;
        //public static Random Random = new Random();
        //public static int stagelevel = 1;

        public static int Width = 1033; 
        public static int Height = 540;
        //public int xplayervector = 0;
        //public int yplayervector = 0;
        public static bool baresiinactiveenemy()
        {
            if (enemies.Count != 0)
            {
                foreach (var item in enemies)
                {
                    if (item.Active)
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
        public void playerupdate(bool left,bool right,bool up,bool down)
        {
            if (left)
            {
                //yplayervector = 0;
                //xplayervector = -1;
                player1.tagirjahatx(Xvextor.left);
                player1.tagirjahaty(Yvector.sabet);
                player1.Update();
            }
            else if (right)
            {
                player1.tagirjahatx(Xvextor.right);
                player1.tagirjahaty(Yvector.sabet);
                player1.Update();
            }
            else if (up)
            {
                player1.tagirjahatx(Xvextor.sabet);
                player1.tagirjahaty(Yvector.up);
                player1.Update();
            }
            else if (down)
            {
                player1.tagirjahatx(Xvextor.sabet);
                player1.tagirjahaty(Yvector.down);
                player1.Update();
            }
            else
            {
                player1.tagirjahatx(Xvextor.sabet);
                player1.tagirjahaty(Yvector.sabet);
                player1.Update();
            }
        }
        public void enemyupdate()
        {
            //MessageBox.Show(enemies.Count.ToString());
            if (enemies.Count != 0)
            {
                foreach (var item in enemies)
                {
                    if (item is StandardEnemy)
                    {
                        if (item != null)
                        {
                            StandardEnemy sample = item as StandardEnemy;
                            sample.Update();
                        }
                    }
                    if (item is ScoutEnemy)
                    {
                        if (item != null)
                        {
                            ScoutEnemy sample = item as ScoutEnemy;
                            sample.Update();
                        }
                        
                    }
                    if (item is ShooterEnemy)
                    {
                        if (item != null)
                        {
                            ShooterEnemy sample = item as ShooterEnemy;
                            sample.Update();
                        }
                    }
                    if (item is HeavyTankEnemy)
                    {
                        if (item != null)
                        {
                            HeavyTankEnemy sample = item as HeavyTankEnemy;
                            sample.Update();
                        }
                    }
                    if (item is TerroristEnemy)
                    {
                        if (item != null)
                        {
                            TerroristEnemy sample = item as TerroristEnemy;
                            sample.Update();
                        }
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
        public void playershoot(bool shoot)
        {
            if (shoot)
            {
                //Input.shoot = false;
                //MessageBox.Show("theplayershoot is working");
                Bullet sample =  player1.Shoot();
                //MessageBox.Show(sample == null ? "NULL" : "NOT NULL");

                if (sample != null)
                {
                    //MessageBox.Show(GameWorld.Bullets.Count.ToString() + " tedad bullet ha ");
                    for (int i = 0; i < GameWorld.Bullets.Count; i++)
                    {
                        //MessageBox.Show(GameWorld.Bullets[i].Active.ToString() + $"{i}");
                    }
                    //MessageBox.Show("bullet is not null from playershoot");
                    //MessageBox.Show("theplayershoot is working");
                    //MessageBox.Show(Bullets.Count.ToString());
                    //تغییر دادم
                    Bullets.Add(sample);
                }
                Input.shoot = false;
            }
        }
        public void bulletsupdate()
        {
            if (Bullets.Count != 0)
            {
                //foreach (var item in Bullets)
                //{
                //     item.Update(item.Xvector, item.Yvector);
                //}
                //for (int i = Bullets.Count - 1; i >= 0; i--)
                //{
                //    //MessageBox.Show("Bullet Update");
                //    //تغییر دادم
                //    Bullets[i].Update(Bullets[i].Xvector, Bullets[i].Yvector);
                //    //تغییر دادم 
                //}
                foreach (var item in Bullets)
                {
                    if (item.Active)
                    {
                        //MessageBox.Show("from bulletupdate");
                        item.Update();
                    }
                }
            }
        }
        public void bulletenemycolision()
        {
            if (Bullets.Count != 0)
            {
                foreach (var item in Bullets)
                {
                    if (enemies.Count != 0 && item.Active)
                    {
                        foreach (var item1 in enemies)
                        {
                            //MessageBox.Show("counting inactive bullets");
                            if (Collision.BulletEnemy(item,item1.X,item1.Y,item1.Width,item1.Height) && item1.Active)
                            {
                                //MessageBox.Show("counting inactive bullets");
                                item1.DamageTaken(item.Damage);
                                GameWorld.player1.XpTaken(item1.Xp);
                                //MessageBox.Show("from bulletenemy it has been touched");
                                item.Active = false;
                                break;
                            }
                            //else
                            //{
                            //    continue;
                            //}
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
                    if (Collision.Bulletplayer(item, player1) && item.Active)
                    {
                        //MessageBox.Show("counting inactive bullets2");
                        //تغییر دادم          
                        player1.DamageTaken(item.Damage);
                        player1.XpTaken(50);
                        player1.Cointaken(1);
                        MessageBox.Show("from bulletplayerw it has been touched");
                        item.Active = false;
                        break;
                    }
                    //else
                    //{
                    //    continue ;
                    //}
                }
            }
        }
        public void enemyplayer()
        {
            if (enemies.Count != 0)
            {
                foreach (var item1 in enemies)
                {
                    if (Collision.playerenemy(player1, item1.X, item1.Y, item1.Width, item1.Height) && item1.Active)
                    {
                        player1.DamageTaken(item1.Damage);
                        player1.XpTaken(50);
                        player1.Cointaken(1);
                        item1.DamageTaken(player1.Damage);
                        break;
                    }
                    //else
                    //{
                    //    continue;
                    //}
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
        public void playercoincolision1()
        {
            if (coinsdrops.Count!= 0)
            {
                foreach (var item in coinsdrops)
                {
                    if (Collision.playercoincolision(player1,item) && item.active)
                    {
                        player1.Cointaken(item.coin);
                        item.active = false;
                    }
                }
            }
        }
        //public void removebullets()
        //{
        //    if (Bullets.Count != 0)
        //    {
        //        //for (int i = Bullets.Count - 1; i >= 0; i--)
        //        //{
        //        //    if (!Bullets[i].Active)
        //        //        //Bullets[i].Active = false;
        //        //    //تغییر دادم 
        //        //        Bullets.RemoveAt(i);

        //        //}
        //        foreach (var item in Bullets)
        //        {

        //        }
        //    }
        //}
        //public void removeenemy()
        //{
        //    if (enemies.Count != 0)
        //    {
        //        //foreach (var item in enemies)
        //        //{
        //        //    if (item.Active == false)
        //        //    {
        //        //        if (item.Coin != 0)
        //        //        {
        //        //            Coindrop coin1 = new Coindrop(item.X, item.Y, item.Coin);
        //        //            coinsdrops.Add(coin1);
        //        //        }
        //        //        enemies.Remove(item);

        //        //    }
        //        //}
        //        for (int i = enemies.Count - 1; i >= 0; i--)
        //        {
        //            var item = enemies[i];
        //            if (item.Active == false)
        //            {
        //                if (item.Coin != 0)
        //                {
        //                    Coindrop coin1 = new Coindrop(item.X, item.Y, item.Coin);
        //                    coinsdrops.Add(coin1);
        //                }
        //                //enemies.Remove(item);
        //                item.Active = false;

        //            }
        //        }
        //    }
        //}
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
        //public void removecoin()
        //{
        //    if (coinsdrops.Count != 0)
        //    {
        //        //foreach (var item in coinsdrops)
        //        //{
        //        //    if (!item.active)
        //        //    {
        //        //        coinsdrops.Remove(item);
        //        //    }
        //        //}
        //        for (int i = coinsdrops.Count - 1; i >= 0; i--)
        //        {
        //            var item = coinsdrops[i];
        //            if (!item.active)
        //            {
        //                //coinsdrops.Remove(item);
        //                item.active = false;
        //            }
        //        }
        //    }
        //}
        public bool Update()
        {
            //MessageBox.Show("Update");
            //Wavemanager.Update();

            //enemyupdate();
            ////playershoot();
            //bulletsupdate();
            //bulletenemycolision();
            //bulletplayer();
            //enemyplayer();
            //playercoincolision1();
            ////MessageBox.Show(Bullets[0].Active.ToString());
            ////تغییر دادم 
            ////removebullets();
            ////removeenemy();
            ////removecoin();
            if (gameover1())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //برای دیباگ ساختم 
        //public void initbullet()
        //{
        //    Bullet bullet1 = new Bullet(BulletMoveType.straghit, 300, 300, 160, 8, 20, 20);
        //    bullet1.jahatx = Xvextor.right;
        //    bullet1.jahaty = Yvector.sabet;
        //    Bullets.Add(bullet1);
        //    Bullet bullet2 = new Bullet(BulletMoveType.straghit, 400, 400, 160, 8, 20, 20);
        //    bullet2.jahatx = Xvextor.left;
        //    bullet2.jahaty = Yvector.sabet;
        //    Bullets.Add(bullet2);
        //    Bullet bullet3 = new Bullet(BulletMoveType.straghit, 300, 100, 160, 8, 20, 20);
        //    bullet3.jahatx = Xvextor.sabet;
        //    bullet3.jahaty = Yvector.down;
        //    Bullets.Add(bullet3);
        //}
    }
}
