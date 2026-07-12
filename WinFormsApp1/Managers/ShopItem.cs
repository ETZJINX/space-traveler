using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Database
{
    public class ShopItem
    {
        public int Id { get; set; }

        public string ItemName { get; set; }

        public bool IsPurchased { get; set; }

        public bool IsEquipped { get; set; }
    }
}