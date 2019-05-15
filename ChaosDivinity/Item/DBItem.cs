using ChaosDivinity.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Interface;

namespace ChaosDivinity.Item
{

    public class DBItem
    {
        static private Dictionary<int, InventorySlot> ListOfItem;
        
        public static Dictionary<int, InventorySlot> DBItens()
        {
            ListOfItem = new Dictionary<int , InventorySlot>();
            ListOfItem.Add(1, new InventorySlot(new Equipment("Espada dos Mil Relampagos", "", 10, 10, 10, 10, 10, false, Classification.Perso.Warrior, 100, 100, Classification.TypeOf.Weapon, 1, "0001")));
            ListOfItem.Add(2, new InventorySlot(new Equipment("Espada de Pandora", "", 10, 10, 10, 10, 10, false, Classification.Perso.Warrior, 10, 500, Classification.TypeOf.Weapon, 1, "0002")));
            ListOfItem.Add(3, new InventorySlot(new Equipment("Arco de Artemis", "", 10, 10, 10, 10, 10, false, Classification.Perso.Rogue, 100, 100, Classification.TypeOf.Weapon, 1, "0003")));
            ListOfItem.Add(4, new InventorySlot(new Equipment("Sombras das Noites", "", 10, 10, 10, 10, 10, false, Classification.Perso.Rogue, 100, 100, Classification.TypeOf.Weapon, 1, "0004")));
            ListOfItem.Add(5, new InventorySlot(new Equipment("Cajado de Demetris", "", 10, 10, 10, 10, 10, false, Classification.Perso.Mage, 100, 100, Classification.TypeOf.Weapon, 1, "0005")));
            ListOfItem.Add(6, new InventorySlot(new Equipment("Raio de Zeus", "", 10, 10, 10, 10, 10, false, Classification.Perso.Mage, 100, 100, Classification.TypeOf.Weapon, 1, "0006")));
            ListOfItem.Add(7, new InventorySlot(new Consumable("Nectar", "", 50, 50, 10, 0, 1, "0007")));
            ListOfItem.Add(8, new InventorySlot(new Consumable("Ambrosia", "", 10, 10, 0, 10, 1, "0008")));
            ListOfItem.Add(9, new InventorySlot(new ItemGame("Toque de Ouro", "", 10, 10, 1, "0009")));
            ListOfItem.Add(10, new InventorySlot(new ItemGame("Oraculo  de Delfus", "", 10, 10, 1, "0010")));

            return ListOfItem;
        }

    }
}