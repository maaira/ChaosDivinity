using ChaosDivinity.Item;
using ChaosDivinity.Physics;

namespace ChaosDivinity.Inventory
{
    public class InventorySlot 
    {
        public ItemGame Slot { get; set; }
        public string ID { get; set; }
        public string Type { get; set; }
        public int Tam { get; set; }
        public object Item { get; internal set; }
        public string Path { get; set; }

        public InventorySlot(ItemGame t)
        {
            this.Tam = 0;
            this.Type = "";
            this.ID = "";
            this.Slot= t;
        }

        public bool AddItemToSlot(ItemGame it)
        {
            if (Tam == 0)
            {
                Tam++;
                this.Slot = it;

                return true;
            }
            if (Tam != 0 && Slot != null && Slot.Name == it.Name)
            {
                Tam++;
                return true;
            }
            return false;
        }

        public bool RemoveItemFromSlot(ItemGame item)
        {
            if (item != null)
            {
                Tam--;
            }
            else if (Tam == 0) return false;
            else if (item != null && Tam == 1)
            {
                item = null;
                Tam -= 1;
            }


            return false;
        }
    }
}
