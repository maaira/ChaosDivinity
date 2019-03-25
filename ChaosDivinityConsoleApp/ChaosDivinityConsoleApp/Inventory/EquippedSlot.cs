using ChaosDivinity.Char;
using ChaosDivinity.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Inventory
{
    public class EquippedSlot
    {
        private Equipment equipment;
        private string equipmentType;
        private Hero hero;

        public Equipment Equip { get => equipment; }
        public string Type { get => equipmentType; set => equipmentType = value; }

        public EquippedSlot(string type, Hero hero)
        {
            this.equipmentType = type;
            this.hero = hero;
        }

        public bool EquipItem(ItemGame equip)
        {
            if ((equip != null) && (equipment.Category == hero.ClassName) && (equipment.Level <= hero.Lvl) && (equipmentType == equip.Category) )
            {
                if (equipment.Name == equip.Name) return true;
                else
                {
                    hero.BackPack.RemoveItem(equip);
                    hero.BackPack.AddItem(new InventorySlot(equipment));
                    this.equipment = (Equipment)equip;
                    DistributeStatus();
                    
                    return true;
                }                
            }
            else return false;
        }

        public bool UnequipItem()
        {
            if (equipment != null)
            {
                hero.BackPack.AddItem(new InventorySlot(equipment));
                RemoveStatus();
                equipment = null;
                return true;
            }
            else return true;
        }

        public void DistributeStatus()
        {
            if(equipment != null)
            {
                hero.Agility += equipment.Agility;
                hero.Intelligence += equipment.Intelligence;
                hero.Power += equipment.Power;
                hero.Vitality += equipment.Vitality;
                hero.Sort += equipment.Sort;
            }
        }

        public void RemoveStatus()
        {
            if (equipment != null)
            {
                hero.Agility -= equipment.Agility;
                hero.Intelligence -= equipment.Intelligence;
                hero.Power -= equipment.Power;
                hero.Vitality -= equipment.Vitality;
                hero.Sort -= equipment.Sort;
            }
        }

    }
}
