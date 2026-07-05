using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Managers;

namespace WinFormsApp1.Forms
{
    public partial class Shop11 : Form
    {
        internal ItemType itemType;
        internal int Index1;
        internal ItemShop<ItemShip> sample;
        internal ItemShop<ItemBackGround> sample1;
        internal ItemShop<ItemBullet> sample2;
        public Shop11()
        {
            InitializeComponent();
            itemType = ItemType.Ship;
            //sample = new ItemShop1(ShopManager.ships[0]);
            Index1 = 0;
            sample = null;
            sample1 = null;
            sample2 = null;
            ShopManager.init();
        }
        internal void LoadItem()
        {
            switch (itemType)
            {
                case ItemType.Ship:

                    sample = ShopManager.ships[Index1];
                    break;
                case ItemType.BackGroundImage:

                    sample1 = ShopManager.backGrounds[Index1];
                    break;
                case ItemType.Bullet:

                    sample2 = ShopManager.bullets[Index1];
                    break;
            }
        }

        private void Shop11_Load(object sender, EventArgs e)
        {
            LoadItem();
            info();
        }

        private void Shipslist_Click(object sender, EventArgs e)
        {
            itemType = ItemType.Ship;
            LoadItem();
            info();
        }

        private void Backgroundlist_Click(object sender, EventArgs e)
        {
            itemType = ItemType.BackGroundImage;
            LoadItem();
            info();
        }

        private void Bulletlist_Click(object sender, EventArgs e)
        {
            itemType = ItemType.Bullet;
            LoadItem();
            info();
        }

        private void info()
        {
            switch (itemType)
            {
                case ItemType.Ship:
                    Itemtype12.Text = sample.item.Description;
                    Itemname.Text = sample.item.Name;
                    Itemprice.Text = sample.item.Price.ToString();
                    Itemdamage.Text = sample.item.Damage.ToString();
                    Itemspeed.Text = sample.item.Speed.ToString();
                    if (sample.Selled)
                    {
                        Buybutton.Enabled = false;
                        Buybutton.BackColor = Color.Gray;
                        Sellbutton.Enabled = true;
                        Sellbutton.BackColor = Color.Green;
                        if (sample.Equiped)
                        {
                            Equipbutton.BackColor = Color.Green;
                            Equipbutton.Enabled = false;
                            Equipbutton.Text = "Equiped";
                        }
                        else
                        {
                            Equipbutton.BackColor = Color.Red;
                            Equipbutton.Enabled = true;
                            Equipbutton.Text = "Equip";
                        }
                    }
                    else
                    {
                        Sellbutton.Enabled = false;
                        Sellbutton.BackColor = Color.Gray;
                        Equipbutton.Enabled = false;
                        Equipbutton.BackColor = Color.Gray;
                        Buybutton.Enabled = true;
                        Buybutton.BackColor = Color.Green;
                    }
                    break;
                case ItemType.BackGroundImage:
                    Itemtype12.Text = sample1.item.Description;
                    Itemname.Text = sample1.item.Name;
                    Itemprice.Text = sample1.item.Price.ToString();
                    Itemdamage.Enabled = false;
                    Itemspeed.Enabled = false;
                    if (sample1.Selled)
                    {
                        Buybutton.Enabled = false;
                        Buybutton.BackColor = Color.Gray;
                        Sellbutton.Enabled = true;
                        Sellbutton.BackColor = Color.Green;
                        if (sample1.Equiped)
                        {
                            Equipbutton.BackColor = Color.Green;
                            Equipbutton.Enabled = false;
                            Equipbutton.Text = "Equiped";
                        }
                        else
                        {
                            Equipbutton.BackColor = Color.Red;
                            Equipbutton.Enabled = true;
                            Equipbutton.Text = "Equip";
                        }
                    }
                    else
                    {
                        Sellbutton.Enabled = false;
                        Sellbutton.BackColor = Color.Gray;
                        Equipbutton.Enabled = false;
                        Equipbutton.BackColor = Color.Gray;
                        Buybutton.Enabled = true;
                        Buybutton.BackColor = Color.Green;
                    }
                    break;
                case ItemType.Bullet:
                    Itemtype12.Text = sample2.item.Description;
                    Itemname.Text = sample2.item.Name;
                    Itemprice.Text = sample2.item.Price.ToString();
                    Itemdamage.Text = sample2.item.Damage.ToString();
                    Itemspeed.Text = sample2.item.Speed.ToString();
                    if (sample2.Selled)
                    {
                        Buybutton.Enabled = false;
                        Buybutton.BackColor = Color.Gray;
                        Sellbutton.Enabled = true;
                        Sellbutton.BackColor = Color.Green;
                        if (sample2.Equiped)
                        {
                            Equipbutton.BackColor = Color.Green;
                            Equipbutton.Enabled = false;
                            Equipbutton.Text = "Equiped";
                        }
                        else
                        {
                            Equipbutton.BackColor = Color.Red;
                            Equipbutton.Enabled = true;
                            Equipbutton.Text = "Equip";
                        }
                    }
                    else
                    {
                        Sellbutton.Enabled = false;
                        Sellbutton.BackColor = Color.Gray;
                        Equipbutton.Enabled = false;
                        Equipbutton.BackColor = Color.Gray;
                        Buybutton.Enabled = true;
                        Buybutton.BackColor = Color.Green;
                    }
                    break;

            }
        }

        private void Buybutton_Click(object sender, EventArgs e)
        {
            switch (itemType)
            {
                case ItemType.Ship:
                    sample.BuyItem(sample.item.Price);
                    info();
                    break;
                case ItemType.BackGroundImage:
                    sample1.BuyItem(sample1.item.Price);
                    info();
                    break;
                case ItemType.Bullet:
                    sample2.BuyItem(sample2.item.Price);
                    info();
                    break;
            }
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            Index1++;
            switch (itemType)
            {
                case ItemType.Ship:
                    Index1 %= ShopManager.ships.Count;
                    LoadItem();
                    info();
                    break;
                case ItemType.BackGroundImage:
                    Index1 %= ShopManager.backGrounds.Count;
                    LoadItem();
                    info();
                    break;
                case ItemType.Bullet:
                    Index1 %= ShopManager.bullets.Count;
                    LoadItem();
                    info();
                    break;
            }
        }

        private void prebutton_Click(object sender, EventArgs e)
        {
            Index1--;
            switch (itemType)
            {
                case ItemType.Ship:
                    if (Index1 < 0 && Index1 >= -ShopManager.ships.Count)
                    {
                        Index1 += ShopManager.ships.Count;
                    }
                    else
                    {
                        Index1 %= ShopManager.ships.Count;
                    }
                    LoadItem();
                    info();
                    break;
                case ItemType.BackGroundImage:
                    if (Index1 < 0 && Index1 >= -ShopManager.backGrounds.Count)
                    {
                        Index1 += ShopManager.backGrounds.Count;
                    }
                    else
                    {
                        Index1 %= ShopManager.backGrounds.Count;
                    }
                    LoadItem();
                    info();
                    break;
                case ItemType.Bullet:
                    if (Index1 < 0 && Index1 >= -ShopManager.bullets.Count)
                    {
                        Index1 += ShopManager.bullets.Count;
                    }
                    else
                    {
                        Index1 %= ShopManager.bullets.Count;
                    }
                    LoadItem();
                    info();
                    break;
            }
        }

        private void Sellbutton_Click(object sender, EventArgs e)
        {
            switch (itemType)
            {
                case ItemType.Ship:
                    sample.SellItem();
                    info();
                    break;
                case ItemType.BackGroundImage:
                    sample1.SellItem();
                    info();
                    break;
                case ItemType.Bullet:
                    sample2.SellItem();
                    info();
                    break;
            }
        }

        private void Equipbutton_Click(object sender, EventArgs e)
        {
            switch (itemType)
            {
                case ItemType.Ship:
                    ItemShop<ItemShip> sample4 = null;
                    foreach (var item in ShopManager.ships)
                    {
                        if (item.Equiped)
                        {
                            sample4 = item;
                            break;
                        }
                    }
                    if (sample4 != null)
                    {
                        sample4.UnEquipItem();
                    }
                    sample.EquipItem();
                    break;
                case ItemType.BackGroundImage:
                    ItemShop<ItemBackGround> sample5 = null;
                    foreach (var item in ShopManager.backGrounds)
                    {
                        if (item.Equiped)
                        {
                            sample5 = item;
                            break;
                        }
                    }
                    if (sample5 != null)
                    {
                        sample5.UnEquipItem();
                    }
                    sample1.EquipItem();
                    break;
                case ItemType.Bullet:
                    ItemShop<ItemBullet> sample6 = null;
                    foreach (var item in ShopManager.bullets)
                    {
                        if (item.Equiped)
                        {
                            sample6 = item;
                            break;
                        }
                    }
                    if (sample6 != null)
                    {
                        sample6.UnEquipItem();
                    }
                    sample2.EquipItem();
                    break;
            }
        }
    }
}
