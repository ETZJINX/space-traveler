using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Logics.interfaces
{
    public enum Xvextor
    {
        sabet = 0,
        right = 1,
        left = -1,
    }
    public enum Yvector
    {
        sabet = 0,
        up = -1,
        down = 1
    }
    public enum BulletMoveType
    {
        straghit = 1,
        zigzag = 2,
        vazirshatrang = 3,
        //balestic = 4
    }
    public interface IMoveable
    {
        int X { get; set; }
        int Y { get; set; }
        Xvextor jahatx {  get; set; }
        Yvector jahaty { get; set; }

        //MoveType Movetype {  get; set; }

        void MoveX();
        void MoveY();
    }
    public interface IDamagable
    {
        float Damage { get; set; }
    }
    public interface ISpeed
    {
        int Speed { get; set; }
    }
    public interface IHealth
    {
        int Health { get; set; }
    }
    public interface IActive
    {
        bool Active { get; set; }
    }
    public interface IAchivments
    {
        int Coin { get; set; }
        int Xp { get; set; }
    }
    internal interface IWeaponDamage
    {
        Bullet Weapon { get; }
        //BulletMoveType BulletMoveType { get; }
        int Timeshoot {  get; set; }
        Bullet Shoot();
    }
    public interface ISizeVolum
    {
        int Width { get; }
        int Height { get; }
    }
    public interface IUpdate
    {
        void Update();
    }
    //public interface IEnemyUpdate
    //{
    //    void Update();
    //}
}
