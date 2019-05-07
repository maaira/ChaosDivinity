using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Item;
using ChaosDivinity.Char;
using ChaosDivinity.Inventory;

namespace ChaosDivinity.Market
{
    public class MarketClass
    {
        public static bool SellItem(ItemGame item, Hero hero)
        {
            if (item != null && hero != null)
            {
                hero.Draquimas += item.SellValue;
                hero.BackPack.RemoveItem(item);
                return true;
            }
            return false;
        }

        public static bool BuyItem(ItemGame item, Hero hero)
        {

            if (item != null && hero != null && hero.Draquimas >= item.MarketValue)
            {

                hero.BackPack.AddItem(new InventorySlot(item));
                hero.Draquimas -= item.MarketValue;

                return true;
            }
            else return false;
        }

    }
}