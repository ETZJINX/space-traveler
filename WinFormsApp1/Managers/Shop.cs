using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Forms;

namespace WinFormsApp1.Managers;

//ببینید این پلیر الکیه فقط تا کارمو راه بندازه در اصل در پیاده سازی منطق بازی باید پیاده سازیش کنم و با دیتا بیس به سکه ها دسترسی داشته باشم 
public class player
{
    public static int coin = 1000;
}
internal enum ItemType 
{
    Ship = 1,
    BackGroundImage = 2,
    Bullet = 3
}
internal interface IItem
{
    string Name { get; set; }
    string Description { get; set; }
    int Price {  get; set; }
}
internal interface IDynamic
{
    float Damage { get; set; }
    int Speed {  get; set; }
}
internal interface IShopattitude
{
    bool Selled { get; set; }
    bool Equiped { get; set; }
    int Id { get; set; }
    bool SellItem();
    bool BuyItem(int Price);
    bool EquipItem();
    bool UnEquipItem();
}
internal class Item : IItem
{
    private string name;
    private string description;
    private int price;
    public string Name { get { return name; } set { name = value; } }
    public string Description { get { return description; } set { description = value; } }
    public int Price { get { return price; } set { price = value; } }
    public Item(string name, string description, int price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}
internal class ItemShip : Item, IDynamic
{
    private float damage;
    private int speed;
    public ItemType itemtype;
    public float Damage { get { return damage; } set { damage = value; } }
    public int Speed { get { return speed; } set { speed = value; } }
    public ItemShip(string name, string description, int price, float damage, int speed) : base(name, description, price)
    {
        Damage = damage;
        Speed = speed;
        itemtype = ItemType.Ship;
    }
}
internal class ItemBullet : Item, IDynamic
{
    private float damage;
    private int speed;
    public ItemType itemtype;
    public float Damage { get { return damage; } set { damage = value; } }
    public int Speed { get { return speed; } set { speed = value; } }
    public ItemBullet(string name, string description, int price, float damage, int speed) : base(name, description, price)
    {
        Damage = damage;
        Speed = speed;
        itemtype = ItemType.Bullet;
    }

}
internal class ItemBackGround : Item
{
    public ItemType itemtype;
    public ItemBackGround(string name, string description, int price) : base(name, description, price)
    {
        itemtype = ItemType.BackGroundImage;
    }
}

internal class ItemShop<T> : IShopattitude where T : Item
{
    private bool selled;
    private bool equiped;
    private int id;
    public bool Selled { get { return selled; } set { selled = value; } }
    public bool Equiped { get { return equiped; } set { equiped = value; } }
    public int Id { get { return id; } set { id = value; } }
    internal T item;
    public ItemShop(T item,int id)
    {
        this.item = item;
        Selled = false;
        Equiped = false;
        Id = id;
    }
    public bool SellItem()
    {
        player.coin += item.Price;  
        UnEquipItem();
        Selled = false;
        return true;
    }
    public bool BuyItem(int Price)
    {
        if (Selled)
        {
            return false;
        }
        else
        {
            if (player.coin < Price)
            {
                return false;
            }
            else
            {
                player.coin -= Price;
                Selled = true;
                return true;
            }
        }

    }
    public bool EquipItem()
    {
        if (Selled)
        {
            Equiped = true;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool UnEquipItem()
    {
        if (Selled)
        {
            Equiped = false;
            return true;
        }
        else
        {
            return false;
        }
    }

}
internal class ShopManager
{
    public static List<ItemShop<ItemShip>> ships = new List<ItemShop<ItemShip>>();
    public static List<ItemShop<ItemBackGround>> backGrounds = new List<ItemShop<ItemBackGround>>();
    public static List<ItemShop<ItemBullet>> bullets = new List<ItemShop<ItemBullet>>();
    public static bool AddShip(string name, string description, int price, float damage, int speed, int id)
    {
        ItemShip ship1 = new ItemShip(name, description, price, damage, speed);

        ItemShop<ItemShip> ship = new ItemShop<ItemShip>(ship1, id);
        ships.Add(ship);
        return true;
    }
    public static bool AddBackGround(string name, string description, int price, int id)
    {
        ItemBackGround background1 = new ItemBackGround(name, description, price);

        ItemShop<ItemBackGround> background = new ItemShop<ItemBackGround>(background1, id);
        backGrounds.Add(background);
        return true;
    }
    public static bool AddBullet(string name, string description, int price, float damage, int speed, int id)
    {
        ItemBullet bullet1 = new ItemBullet(name, description, price, damage, speed);
        ItemShop<ItemBullet> bullet = new ItemShop<ItemBullet>(bullet1, id);
        bullets.Add(bullet);
        return true;
    }
    public static bool SellShip(int id)
    {
        foreach (var item in ships)
        {
            if (item.Id == id)
            {
                item.SellItem();
                return true;
            }
        }
        return false;
    }
    public static bool SellBackGround(int id)
    {
        foreach (var item in backGrounds)
        {
            if (item.Id == id)
            {
                item.SellItem();
                return true;
            }
        }
        return false;
    }
    public static bool SellBullet(int id)
    {
        foreach (var item in bullets)
        {
            if (item.Id == id)
            {
                item.SellItem();
                return true;
            }
        }
        return false;
    }
    public static bool EQUIPITEM(int id)
    {
        foreach (var item in ships)
        {
            if (item.Id == id)
            {
                if (item.Selled && !item.Equiped)
                {
                    item.EquipItem();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        foreach (var item in bullets)
        {
            if (item.Id == id)
            {
                if (item.Selled && !item.Equiped)
                {
                    item.EquipItem();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        foreach (var item in backGrounds)
        {
            if (item.Id == id)
            {
                if (item.Selled && !item.Equiped)
                {
                    item.EquipItem();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        return false;

    }
    public static bool UNEQUIPITEM(int id)
    {
        foreach (var item in ships)
        {
            if (item.Id == id)
            {
                if (item.Selled && item.Equiped)
                {
                    item.UnEquipItem();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        foreach (var item in bullets)
        {
            if (item.Id == id)
            {
                if (item.Selled && item.Equiped)
                {
                    item.UnEquipItem();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        foreach (var item in backGrounds)
        {
            if (item.Id == id)
            {
                if (item.Selled && item.Equiped)
                {
                    item.UnEquipItem();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        return false;

    }
    public static void init()
    {
        // ===================== Ships =====================
        ShopManager.AddShip("Falcon", "Balanced starter ship", 250, 20f, 10, 1);
        ShopManager.AddShip("Phoenix", "Fast attack ship", 500, 35f, 18, 2);
        ShopManager.AddShip("Destroyer", "Heavy armored ship", 800, 60f, 7, 3);
        ShopManager.AddShip("Titan", "Ultimate battle ship", 1500, 90f, 5, 4);

        // ===================== Bullets =====================
        ShopManager.AddBullet("Normal Bullet", "Standard bullet", 100, 10f, 20, 101);
        ShopManager.AddBullet("Laser Beam", "High speed laser", 300, 25f, 35, 102);
        ShopManager.AddBullet("Plasma Shot", "Powerful plasma bullet", 600, 45f, 25, 103);
        ShopManager.AddBullet("Dark Matter", "Legendary projectile", 1200, 80f, 30, 104);

        // ===================== Backgrounds =====================
        ShopManager.AddBackGround("Earth Orbit", "Beautiful space view", 150, 201);
        ShopManager.AddBackGround("Nebula", "Colorful nebula background", 300, 202);
        ShopManager.AddBackGround("Galaxy Core", "Epic galaxy center", 600, 203);
        ShopManager.AddBackGround("Black Hole", "Dark mysterious background", 1000, 204);
    }

}
