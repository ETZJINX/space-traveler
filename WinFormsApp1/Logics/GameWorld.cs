using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Logics.interfaces;

namespace WinFormsApp1.Logics
{
    public class Wavemanager
    {
        private static Random random = new Random();
        private static int currentwave = 1;
        private static int EnemyRemainingToSpawn = 10;
        private static int spawndelay = 0;
        private static int Wavedelay = 0;//ثانیه 
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
            StandardEnemy sample = new StandardEnemy(60, 80, 250, GameWorld.Height - 20, 40, 5, 100, 0, 150);
            ScoutEnemy sample1 = new ScoutEnemy(60, 80, 250, GameWorld.Height - 20, 45, 15, 100, 0, 250);
            ShooterEnemy sample2 = new ShooterEnemy(40, 60, 250, GameWorld.Height - 20, 20, 5, 150, 0, 350, GameWorld.player1.Weapon, BulletMoveType.straghit);
            HeavyTankEnemy sample3 = new HeavyTankEnemy(120, 100, 250, GameWorld.Height - 20, 150, 3, 700, 0, 550, GameWorld.player1.Weapon, BulletMoveType.vazirshatrang);
            TerroristEnemy sample4 = new TerroristEnemy(20, 40, 250, GameWorld.Height - 20, 280, 8, 500, 0, 800);
            //wave1
            for (int i = 0; i < 10; i++)
            {
                wave1.Add(sample.santens());
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
        public static void spawnenemy(List<template> templates)
        {
            if (templates.Count == 0)
            {
                return;
            }
            else
            {
                templates[0].X = random.Next(templates[0].Width / 2, GameWorld.Width - templates[0].Width / 2);
                if (templates[0] is StandardEnemy && random.Next(100) < 5)
                {
                    templates[0].Coin = 10;
                }
                else if (templates[0] is ScoutEnemy && random.Next(100) < 10)
                {
                    templates[0].Coin = 20;
                }
                else if (templates[0] is ShooterEnemy && random.Next(100) < 30)
                {
                    templates[0].Coin = 50;
                }
                else if (templates[0] is HeavyTankEnemy && random.Next(100) < 60 && templates[0].Coin != 2000)
                {
                    templates[0].Coin = 100;
                }
                else if (templates[0] is TerroristEnemy && random.Next(100) < 100)
                {
                    templates[0].Coin = 200;
                }
                GameWorld.enemies.Add(templates[0]);

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
            if (activewave.Count != 0)
            {
                spawndelay++;
                if (spawndelay > 4)
                {
                    spawnenemy(activewave);
                    activewave.RemoveAt(0);
                    //EnemyRemainingToSpawn--;
                    spawndelay = 0;
                }
            }
            else
            {
                if (GameWorld.enemies.Count == 0)
                {
                    if (currentwave != 10)
                    {
                        Wavedelay++;
                        if (Wavedelay > 14)
                        {
                            currentwave++;
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
        public void playercoincolision1()
        {
            if (coinsdrops.Count!= 0)
            {
                foreach (var item in coinsdrops)
                {
                    if (Collision.playercoincolision(player1,item))
                    {
                        player1.Cointaken(item.coin);
                        item.active = false;
                    }
                }
            }
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
                        if (item.Coin != 0)
                        {
                            Coindrop coin1 = new Coindrop(item.X, item.Y, item.Coin);
                            coinsdrops.Add(coin1);
                        }
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
        public void removecoin()
        {
            if (coinsdrops.Count != 0)
            {
                foreach (var item in coinsdrops)
                {
                    if (!item.active)
                    {
                        coinsdrops.Remove(item);
                    }
                }
            }
        }
        public bool Update()
        {
            Wavemanager.Update();
            playerupdate();
            enemyupdate();
            playershoot();
            bulletsupdate();
            bulletenemycolision();
            bulletplayer();
            enemyplayer();
            playercoincolision1();
            removebullets();
            removeenemy();
            removecoin();
            if (gameover1())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
