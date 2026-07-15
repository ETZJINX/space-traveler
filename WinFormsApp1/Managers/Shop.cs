using SpaceShooter.Database;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Forms;
using WinFormsApp1.Logics;

namespace WinFormsApp1.Managers;

//ببینید این پلیر الکیه فقط تا کارمو راه بندازه در اصل در پیاده سازی منطق بازی باید پیاده سازیش کنم و با دیتا بیس به سکه ها دسترسی داشته باشم 
//public class player
//{
//    public static int coin = 1000;
//}
public enum ItemType 
{
    Ship = 1,
    BackGroundImage = 2,
    Bullet = 3
}
public interface IItem
{
    string Name { get; set; }
    string Description { get; set; }
    int Price {  get; set; }
}
public interface IDynamic
{
    float Damage { get; set; }
    int Speed {  get; set; }
}
public interface IShopattitude
{
    bool Selled { get; set; }
    bool Equiped { get; set; }
    int Id { get; set; }
    bool SellItem();
    bool BuyItem(int Price);
    bool EquipItem();
    bool UnEquipItem();
}
public class Item : IItem
{
    public Image img;
    private string name;
    private string description;
    private int price;
    public string Name { get { return name; } set { name = value; } }
    public string Description { get { return description; } set { description = value; } }
    public int Price { get { return price; } set { price = value; } }
    public Item(string name, string description, int price,Image img)
    {
        Name = name;
        Description = description;
        Price = price;
        this.img = img;
    }
}
public class ItemShip : Item, IDynamic
{
    private float damage;
    private int speed;
    private int health;
    public int Health { get { return health;  } set { health = value; }  }
    public ItemType itemtype;
    public float Damage { get { return damage; } set { damage = value; } }
    public int Speed { get { return speed; } set { speed = value; } }
    public ItemShip(string name, string description, int price,Image img, float damage, int speed,int health) : base(name, description, price,img)
    {
        Damage = damage;
        Speed = speed;
        Health = health;
        itemtype = ItemType.Ship;
    }
}
public class ItemBullet : Item, IDynamic
{
    private float damage;
    private int speed;
    public ItemType itemtype;
    public float Damage { get { return damage; } set { damage = value; } }
    public int Speed { get { return speed; } set { speed = value; } }
    public ItemBullet(string name, string description, int price,Image img, float damage, int speed) : base(name, description, price,img)
    {
        Damage = damage;
        Speed = speed;
        itemtype = ItemType.Bullet;
    }

}
public class ItemBackGround : Item
{
    public ItemType itemtype;
    public ItemBackGround(string name, string description, int price,Image img) : base(name, description, price,img)
    {
        itemtype = ItemType.BackGroundImage;
    }
}

public class ItemShop<T> : IShopattitude where T : Item
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
        GameWorld.player1.Coin += item.Price;
        Database databasse = new Database();
        databasse.UpdateCoins(GameWorld.player1.Coin);
        UnEquipItem();
        Selled = false;
        databasse.SellItem(id);
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
            if (GameWorld.player1.Coin < Price)
            {
                return false;
            }
            else
            {
                GameWorld.player1.Coin -= Price;
                Database database = new Database();
                database.UpdateCoins(GameWorld.player1.Coin);
                Selled = true;
                database.SellItem(id);
                return true;
            }
        }

    }
    public bool EquipItem()
    {
        if (Selled)
        {
            Equiped = true;
            Database database = new Database();
            database.EquipItem(id);
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
            Database database = new Database();
            database.UnEquipItem(id);

            return true;
        }
        else
        {
            return false;
        }
    }

}
public class ShopManager
{
    private static bool initialized = false;
    public static List<ItemShop<ItemShip>> ships = new List<ItemShop<ItemShip>>();
    public static List<ItemShop<ItemBackGround>> backGrounds = new List<ItemShop<ItemBackGround>>();
    public static List<ItemShop<ItemBullet>> bullets = new List<ItemShop<ItemBullet>>();
    public static bool AddShip(string name, string description, int price, float damage, int speed,int health,Image img, int id)
    {
        ItemShip ship1 = new ItemShip(name, description, price,img, damage, speed,health);

        ItemShop<ItemShip> ship = new ItemShop<ItemShip>(ship1, id);
        ships.Add(ship);
        return true;
    }
    public static bool AddBackGround(string name, string description, int price,Image img, int id)
    {
        ItemBackGround background1 = new ItemBackGround(name, description, price,img);

        ItemShop<ItemBackGround> background = new ItemShop<ItemBackGround>(background1, id);
        backGrounds.Add(background);
        return true;
    }
    public static bool AddBullet(string name, string description, int price, float damage, int speed,Image img, int id)
    {
        ItemBullet bullet1 = new ItemBullet(name, description, price,img, damage, speed);
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
        if (initialized)
        {
            return;
        }
        initialized = true;
        // ===================== Ships =====================
        ShopManager.AddShip("Falcon", "Balanced starter ship", 250, 20f, 10, 200,Properties.Resources.ship1,1);
        foreach (var item in ships)
        {
            if (item.Id == 1)
            {
                item.Equiped = true;
                item.Selled = true;
            }
        }
        ShopManager.AddShip("Phoenix", "Fast attack ship", 500, 35f, 18, 150,Properties.Resources.ship2,2);
        ShopManager.AddShip("Destroyer", "Heavy armored ship", 800, 60f, 25, 100, Properties.Resources.ship3, 3);
        ShopManager.AddShip("Titan", "Ultimate battle ship", 1500, 90f, 15, 300, Properties.Resources.ship4, 4);

        // ===================== Bullets =====================
        ShopManager.AddBullet("Normal Bullet", "Standard bullet", 100, 75f, 20, Properties.Resources.playerbullet1, 101);
        foreach (var item in bullets)
        {
            if (item.Id == 101)
            {
                item.Equiped = true;
                item.Selled = true;
            }
        }
        ShopManager.AddBullet("Laser Beam", "High speed laser", 300, 100f, 35, Properties.Resources.playerbullet2, 102);
        ShopManager.AddBullet("Plasma Shot", "Powerful plasma bullet", 600, 160f, 25, Properties.Resources.playerbullet3, 103);
        ShopManager.AddBullet("Dark Matter", "Legendary projectile", 1200, 200f, 40, Properties.Resources.playerbullet4, 104);

        // ===================== Backgrounds =====================
        ShopManager.AddBackGround("Earth Orbit", "Beautiful space view", 150, Properties.Resources.background1, 201);
        foreach (var item in backGrounds)
        {
            if (item.Id == 201)
            {
                item.Equiped = true;
                item.Selled = true;
            }
        }
        ShopManager.AddBackGround("Nebula", "Colorful nebula background", 300, Properties.Resources.background2, 202);
        ShopManager.AddBackGround("Galaxy Core", "Epic galaxy center", 600, Properties.Resources.background3, 203);
        ShopManager.AddBackGround("Black Hole", "Dark mysterious background", 1000, Properties.Resources.background4, 204);
    }
    //اینارو برای کارای خودم اضافه کردم 
    public static Image getequipedbackground()
    {
        foreach (var item in backGrounds)
        {
            if (item.Equiped)
            {
                return item.item.img;
            }
        }
        return null;
    }
    public static ItemShip getequipedship()
    {
        foreach (var item in ships)
        {
            if (item.Equiped)
            {
                return item.item;
            }
        }
        return null;
    }
    public static ItemBullet getequipedbullet()
    {
        foreach (var item in bullets)
        {
            if (item.Equiped)
            {
                return item.item;
            }
        }
        return null;
    }
}
