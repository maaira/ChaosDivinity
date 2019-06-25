using System.Collections.Generic;
using ChaosDivinity.Inventory;
using ChaosDivinity.Item;

namespace ChaosDivinity.NPCNamespace
{
    public class ListItemShopDB
    {
        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Loja de Poções *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        static private Dictionary<int, InventorySlot> PotsShop;

        public static Dictionary<int, InventorySlot> DBPotsShop()
        {
            PotsShop = new Dictionary<int, InventorySlot>();

            PotsShop.Add(1, DBItem.DBItens()[1]);
            PotsShop.Add(2, DBItem.DBItens()[2]);
            PotsShop.Add(3, DBItem.DBItens()[3]);
            PotsShop.Add(4, DBItem.DBItens()[4]);
            PotsShop.Add(5, DBItem.DBItens()[5]);
            PotsShop.Add(6, DBItem.DBItens()[6]);

            return PotsShop;
        }

        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Loja de Armaduras *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        static private Dictionary<int, InventorySlot> ArmorShop;

        public static Dictionary<int, InventorySlot> DBArmorShop()
        {
            ArmorShop = new Dictionary<int, InventorySlot>();

            ArmorShop.Add(1, DBItem.DBItens()[31]);
            ArmorShop.Add(2, DBItem.DBItens()[32]);
            ArmorShop.Add(3, DBItem.DBItens()[33]);
            //34 eh quest
            return ArmorShop;
        }

        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Loja de Espadas *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        static private Dictionary<int, InventorySlot> WeaponShop;

        public static Dictionary<int, InventorySlot> DBWeaponShop()
        {
            WeaponShop = new Dictionary<int, InventorySlot>();

            WeaponShop.Add(1, DBItem.DBItens()[7]);
            WeaponShop.Add(2, DBItem.DBItens()[8]);
            WeaponShop.Add(3, DBItem.DBItens()[9]);
            WeaponShop.Add(4, DBItem.DBItens()[10]);
            WeaponShop.Add(5, DBItem.DBItens()[11]);
            WeaponShop.Add(6, DBItem.DBItens()[12]);
            //13 e 14 são quests

            return WeaponShop;
        }

        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Loja de Cajados *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        static private Dictionary<int, InventorySlot> StaffShop;

        public static Dictionary<int, InventorySlot> DBStaffShop()
        {
            StaffShop = new Dictionary<int, InventorySlot>();

            StaffShop.Add(1, DBItem.DBItens()[23]);
            StaffShop.Add(2, DBItem.DBItens()[24]);
            StaffShop.Add(3, DBItem.DBItens()[25]);
            StaffShop.Add(4, DBItem.DBItens()[26]);
            StaffShop.Add(5, DBItem.DBItens()[27]);
            StaffShop.Add(6, DBItem.DBItens()[28]);
            //29 e 30 são quests

            return StaffShop;
        }

        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Loja de Adagas *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        static private Dictionary<int, InventorySlot> DaggerShop;

        public static Dictionary<int, InventorySlot> DBDaggerShop()
        {
            DaggerShop = new Dictionary<int, InventorySlot>();

            DaggerShop.Add(1, DBItem.DBItens()[15]);
            DaggerShop.Add(2, DBItem.DBItens()[16]);
            DaggerShop.Add(3, DBItem.DBItens()[17]);
            DaggerShop.Add(4, DBItem.DBItens()[18]);
            DaggerShop.Add(5, DBItem.DBItens()[19]);
            DaggerShop.Add(6, DBItem.DBItens()[20]);
            //21 e 22 são quests

            return DaggerShop;
        }

        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Loja de Acessórios *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        static private Dictionary<int, InventorySlot> AccessoryShop;

        public static Dictionary<int, InventorySlot> DBAccessoryShop()
        {
            AccessoryShop = new Dictionary<int, InventorySlot>();

            AccessoryShop.Add(1, DBItem.DBItens()[35]);
            AccessoryShop.Add(2, DBItem.DBItens()[36]);
            AccessoryShop.Add(3, DBItem.DBItens()[37]);
            AccessoryShop.Add(4, DBItem.DBItens()[38]);
            AccessoryShop.Add(5, DBItem.DBItens()[39]);
            AccessoryShop.Add(6, DBItem.DBItens()[40]);
            //41 e 42 são quests

            return AccessoryShop;
        }

        public enum TypeShop { PotsShop, ArmorShop, WeaponShop, StaffShop, DaggerShop, AccessoryShop };

    }
}
