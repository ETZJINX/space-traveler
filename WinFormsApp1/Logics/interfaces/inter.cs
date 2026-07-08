using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Logics.interfaces
{
    public enum BulletMoveType
    {
        straghit = 1,
        zigzag = 2,
        vazirshatrang = 3,
        balestic = 4
    }
    public interface IMoveable
    {
        int X { get; set; }
        int Y { get; set; }
        //MoveType Movetype {  get; set; }

        void MoveX(int andaze);
        void MoveY(int andaze);
    }
    public interface IDamagable
    {
        float Damage { get; set; }
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
        BulletMoveType BulletMoveType { get; }
        void Shoot();
    }
    public interface ISizeVolum
    {
        int Width { get; }
        int Height { get; }
    }
}
