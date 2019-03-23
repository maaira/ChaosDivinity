using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Item;
using ChaosDivinity.Char;

namespace ChaosDivinity.Market
{
    class MarketClass
    {
        bool SellItem(ItemGame item, Character hero)
        {
            if(item != null && hero != null)
            {
                hero.Draquimas += item.MarketValue;
                hero.BackPack.AddItem(item);
                return true;
            }
            return false;
        }

        bool BuyItem(ItemGame item, Character hero)
        {
            if(item != null && hero != null && hero.Draquimas >= item.MarketValue)
            {
                hero.Draquimas -= item.MarketValue;
                hero.BackPack.AddItem(item);
            }
            return false;

        }

    }
}
