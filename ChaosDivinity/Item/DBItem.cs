using ChaosDivinity.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Interface;
using System.Windows.Media.Imaging.BitmapSourcel;

namespace ChaosDivinity.Item
{

    public class DBItem
    {
        static private Dictionary<int, InventorySlot> ListOfItem;

        public static Dictionary<int, InventorySlot> DBItens()
        {
            ListOfItem = new Dictionary<int, InventorySlot>();
            
            //Criação dos consumíveis
            Consumable cn1 = new Consumable()
            {
                Name = "Pequena Poção Vermelha",
                Description = "Poção que recupera um pouco sua vida",
                MarketValue = 6,
                SellValue = 3,
                HP = 20,
                MP = 1,
                Path = "/Assets/Pots/redPotSmall.png"
            };ListOfItem.Add(1, new InventorySlot(cn1));

            Consumable cn2 = new Consumable()
            {
                Name = "Média Poção Vermelha",
                Description = "Poção de cura boazinha",
                MarketValue = 14,
                SellValue = 7,
                HP = 100,
                MP = 1,
                Path = "/Assets/Pots/redPotMedium.png"
            }; ListOfItem.Add(2, new InventorySlot(cn2));

            Consumable cn3 = new Consumable()
            {
                Name = "Grande Poção Vermelha",
                Description = "Poção Blindona",
                MarketValue = 20,
                SellValue = 10,
                HP = 200,
                MP = 2,
                Path = "/Assets/Pots/redPotGiant.png"
            }; ListOfItem.Add(3, new InventorySlot(cn3));

            Consumable cn4 = new Consumable()
            {
                Name = "Pequena Poção Azul",
                Description = "Poção que recupera um pouco sua mana",
                MarketValue = 6,
                SellValue = 3,
                HP = 1,
                MP = 10,
                Path = "/Assets/Pots/bluePotSmall.png"
            }; ListOfItem.Add(4, new InventorySlot(cn4));

            Consumable cn5 = new Consumable()
            {
                Name = "Média Poção Azul",
                Description = "Poção de cura boazinha",
                MarketValue = 20,
                SellValue = 10,
                HP = 1,
                MP = 50,
                Path = "/Assets/Pots/bluePotMedium.png"
            }; ListOfItem.Add(5, new InventorySlot(cn5));

            Consumable cn6 = new Consumable()
            {
                Name = "Grande Poção Azul",
                Description = "Poção Blindona",
                MarketValue = 20,
                SellValue = 10,
                HP = 2,
                MP = 200,
                Path = "/Assets/Pots/bluePotGiant.png"
            }; ListOfItem.Add(6, new InventorySlot(cn6));

            //Criação dos equips
            Equipment eq1 = new Equipment()
            {
                Name = "Espada dos Mil Relampagos",
                Description = "Na verdade só tem um Relampago",
                Power = 10,
                Agility = 10,
                Sort = 10,
                Vitality = 10,
                Intelligence = 10,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 100,
                SellValue = 50,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            };
            ListOfItem.Add(7, new InventorySlot(eq1));

            //Criação dos Itens "Aleatórios"


            /*
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
            */
            return ListOfItem;
        }
        

    }
}