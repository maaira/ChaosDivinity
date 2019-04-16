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
        static private Dictionary<string, InventorySlot> ListOfItem;
        static private string[] person = { "Guerreiro", "Ladino", "Mago", "All" };
        private static string[] type = { "Arma", "Acessorio", "Coleção", "Armadura" };
        private static string[] categoryType = { "", "Espada", "Adaga", "Cajado", "Acessorio", "Escudo" };


        public static Dictionary<string, InventorySlot> DBItens()
        {
            ListOfItem = new Dictionary<string, InventorySlot>();
            ListOfItem.Add("0001", new InventorySlot(new Equipment("Espada dos Mil Relampagos", "", 10, 10, 10, 10, 10, false, Classification.Perso.Warrior, 100, 100, Classification.TypeOf.Weapon, 1, "0001")));
            ListOfItem.Add("0002", new InventorySlot(new Equipment("Espada de Pandora", "", 10, 10, 10, 10, 10, false, Classification.Perso.Warrior, 10, 500, Classification.TypeOf.Weapon, 1, "0002")));
            ListOfItem.Add("0003", new InventorySlot(new Equipment("Arco de Artemis", "", 10, 10, 10, 10, 10, false, Classification.Perso.Rogue, 100, 100, Classification.TypeOf.Weapon, 1, "0003")));
            ListOfItem.Add("0004", new InventorySlot(new Equipment("Sombras das Noites", "", 10, 10, 10, 10, 10, false, Classification.Perso.Rogue, 100, 100, Classification.TypeOf.Weapon, 1, "0004")));
            ListOfItem.Add("0005", new InventorySlot(new Equipment("Cajado de Demetris", "", 10, 10, 10, 10, 10, false, Classification.Perso.Mage, 100, 100, Classification.TypeOf.Weapon, 1, "0005")));
            ListOfItem.Add("0006", new InventorySlot(new Equipment("Raio de Zeus", "", 10, 10, 10, 10, 10, false, Classification.Perso.Mage, 100, 100, Classification.TypeOf.Weapon, 1, "0006")));
            ListOfItem.Add("0007", new InventorySlot(new Consumable("Nectar", "", 50, 50, 10, 0, 1, "0007")));
            ListOfItem.Add("0008", new InventorySlot(new Consumable("Ambrosia", "", 10, 10, 0, 10, 1, "0008")));
            ListOfItem.Add("0009", new InventorySlot(new ItemGame("Toque de Ouro", "", 10, 10, 1, "0009")));
            ListOfItem.Add("0010", new InventorySlot(new ItemGame("Oraculo  de Delfus", "", 10, 10, 1, "0010")));

            return ListOfItem;
        }



    }
}