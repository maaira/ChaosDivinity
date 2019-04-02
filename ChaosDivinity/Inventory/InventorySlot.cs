using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Item;

namespace ChaosDivinity.Inventory
{
    public class InventorySlot
    {
        private ItemGame item;
        private int tam;
        private string slotid; // variavel que cotrola o tipo de item do slot
        private string type;
        public ItemGame Slot { get => item; }
        public string ID { get => slotid; }
        public string Type { get => type; }
        public int Tam { get => tam; set => tam = value; }

        public InventorySlot(ItemGame t)
        {
            this.tam = 0;
            this.type = "";
            this.slotid = "";
            this.item = t;
        }

        public bool AddItemToSlot(ItemGame it)
        {
            if (tam == 0)
            {
                tam++;
                this.item = it;

                return true;
            }
            if (tam != 0 && item != null && item.Name == it.Name)
            {
                tam++;
                return true;
            }
            return false;
        }

        public bool RemoveItemFromSlot(ItemGame item)
        {
            if (item != null)
            {
                tam--;
            }
            else if (tam == 0) return false;
            else if (item != null && tam == 1)
            {
                item = null;
                tam -= 1;
            }


            return false;
        }
    }
}
