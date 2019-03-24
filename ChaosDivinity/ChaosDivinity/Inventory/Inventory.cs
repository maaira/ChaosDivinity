using ChaosDivinity.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Inventory
{
    class Inventory
    {
        private InventorySlot[,] backPack = new InventorySlot[4,4];

        public InventorySlot[,] BackPack { get => backPack; }

        public bool AddItem(ItemGame item)
        {
            bool key = false;
            foreach(InventorySlot slot in backPack)
            {
                if(slot.ID == item.ID)
                {
                    key = slot.AddItemToSlot(item);
                }
            }
            return key;

        }

        public bool RemoveItem(ItemGame item)
        {
            bool key = false;
            foreach (InventorySlot slot in backPack)
            {
                if (slot.ID == item.ID)
                {
                    key = slot.RemoveItemFromSlot(item);
                }
            }
            return key;
        }
    }
}
