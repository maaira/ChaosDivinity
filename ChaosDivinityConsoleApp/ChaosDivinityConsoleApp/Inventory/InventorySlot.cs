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
        private string slotid =""; // variavel que cotrola o tipo de item do slot
        public Dictionary<string, ItemGame> Slot { get => slot; }
        public string ID { get => slotid; }
        public bool AddItemToSlot(ItemGame item)
        {
            if(slot.Count == 0 )
            {
                slot.Add(item.ID, item);
                slotid = item.Name;
                return true;
            }
            if(slot.Count <= 40 && slotid == item.ID)
            {
                slot.Add(item.ID, item);
            }
            return false;
        }

        public bool RemoveItemFromSlot(ItemGame item)
        {
            if(item != null)
            {
                slot.Remove(item.ID);
                if (slot.Count == 0)
                {
                    slotid = "";
                }
                return true;
            }
            

            return false;
        }
    }   
}
