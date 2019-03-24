using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Item;

namespace ChaosDivinity.Inventory
{
    class InventorySlot
    {
        private Dictionary<string , ItemGame > slot = new Dictionary<string, ItemGame>();
        private string slotid ="";
        public Dictionary<string, ItemGame> Slot { get => slot; }
        public string ID { get => slotid; }
        public bool AddItemToSlot(ItemGame item)
        {
            if(slot.Count == 0 )
            {
                slot.Add("00", item);
                return true;
            }
            if(slot.Count <= 40 && slotid == item.ID)
            {
                slot.Add("00", item);
            }
            return false;
        }

        public bool RemoveItemFromSlot(ItemGame item)
        {
            slot.Remove(item.ID);
            return false;
        }
    }
}
