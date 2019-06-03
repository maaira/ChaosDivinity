using ChaosDivinity.Char;
using ChaosDivinity.Item;
using ChaosDivinity.Interface;

namespace ChaosDivinity.Inventory
{
    public class EquippedSlot
    {

        private Hero hero;
        public Equipment Equip { get; set; }
        public Classification.TypeOf  Type{ get ; set; }

        public EquippedSlot(Classification.TypeOf type, Hero hero)
        {
            this.Type = type;
            this.hero = hero;
        }

        public bool EquipItem(ItemGame equip)
        {
            if ((equip != null) && (Equip.Class == hero.ClassGroup) && (Equip.Level <= hero.Lvl) )
            {
                if (Equip.Name == equip.Name) return true;
                else
                {
                    hero.BackPack.RemoveItem(equip);
                    hero.BackPack.AddItem(new InventorySlot(Equip));
                    Equip = (Equipment)equip;
                    DistributeStatus();

                    return true;
                }
            }
            else return false;
        }

        public bool UnequipItem()
        {
            if (Equip != null)
            {
                hero.BackPack.AddItem(new InventorySlot(Equip));
                RemoveStatus();
                Equip = null;
                return true;
            }
            else return true;
        }

        public void DistributeStatus()
        {
            if (Equip != null)
            {
                hero.Agility += Equip.Agility;
                hero.Intelligence += Equip.Intelligence;
                hero.Power += Equip.Power;
                hero.Vitality += Equip.Vitality;
                hero.Sort += Equip.Sort;
            }
        }

        public void RemoveStatus()
        {
            if ( Equip!= null)
            {
                hero.Agility -= Equip.Agility;
                hero.Intelligence -= Equip.Intelligence;
                hero.Power -= Equip.Power;
                hero.Vitality -= Equip.Vitality;
                hero.Sort -= Equip.Sort;
            }
        }

    }
}
