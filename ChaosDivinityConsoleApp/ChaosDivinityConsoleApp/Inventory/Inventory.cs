using ChaosDivinity.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Inventory
{
    public class BackPack
    {

        private Dictionary<string, InventorySlot> backPack = new Dictionary<string, InventorySlot> ();

        public Dictionary<string, InventorySlot> InventoryOfBackPack { get => backPack; }

        public BackPack()
        {
                        
        }

        
        public bool IsFull()
        {
            return false;
        }

        public bool ContainsItem()
        {
            if (backPack.Count == 0) return false;
            else return true;
        }
         

        public bool AddItem(InventorySlot item)
        {
            if (item != null && backPack.ContainsValue(item)) {
                backPack[item.ID].Tam+=1;
                backPack[item.ID] = item;
                return true;
            }
            else if (item != null )
            {
                backPack.Add(item.ID, item);
                return true;
            }else
            {
                backPack.Add(item.ID, item);
            }
            return false;
        }

        public bool RemoveItem(ItemGame item)
        {
            if (item != null && backPack.ContainsKey(item.ID))
            {
                backPack.Remove(item.ID);
                return true;
            }
            
            return false;
        }
    }
}
