using ChaosDivinity.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Interface;
//using System.Windows.Media.Imaging.BitmapSourcel;

namespace ChaosDivinity.Item
{

    public class DBItem
    {
        static private Dictionary<int, InventorySlot> ListOfItem;

        public static Dictionary<int, InventorySlot> DBItens()
        {
            ListOfItem = new Dictionary<int, InventorySlot>();

            //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*Criação dos consumíveis-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

            Consumable cn1 = new Consumable()
            {
                ID = "1",
                Name = "Pequena Poção Vermelha",
                Description = "Poção que recupera um pouco sua vida",
                MarketValue = 6,
                SellValue = 3,
                HP = 20,
                MP = 1,
                Path = "/Assets/Pots/redPotSmall.png"
            }; ListOfItem.Add(1, new InventorySlot(cn1));

            Consumable cn2 = new Consumable()
            {
                ID = "2",
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
                ID = "3",
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
                ID = "4",
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
                ID = "5",
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
                ID = "6",
                Name = "Grande Poção Azul",
                Description = "Poção Blindona",
                MarketValue = 20,
                SellValue = 10,
                HP = 2,
                MP = 200,
                Path = "/Assets/Pots/bluePotGiant.png"
            }; ListOfItem.Add(6, new InventorySlot(cn6));

            
            //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Criação das Armas *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

            Equipment eq1 = new Equipment()
            {
                ID = "7",
                Name = "Espada de Cobre",
                Description = "Fraquinhaaa..coitadaaa. Q1",
                Power = 2,
                Agility = 2,
                Sort = 1,
                Vitality = 2,
                Intelligence = 0,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 20,
                SellValue = 10,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            };
            ListOfItem.Add(7, new InventorySlot(eq1));

            Equipment eq2 = new Equipment()
            {
                ID = "8",
                Name = "Espada de Bronze",
                Description = "Já aguenta cortar papel. Q2",
                Power = 6,
                Agility = 5,
                Sort = 3,
                Vitality = 5,
                Intelligence = 1,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 40,
                SellValue = 20,
                Category = Classification.TypeOf.Weapon,
                Level = 2
            };
            ListOfItem.Add(8, new InventorySlot(eq2));

            Equipment eq3 = new Equipment()
            {
                ID = "9",
                Name = "Espada de Ferro",
                Description = "Dá para o gasto. Q3",
                Power = 10,
                Agility = 10,
                Sort = 5,
                Vitality = 8,
                Intelligence = 2,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 80,
                SellValue = 30,
                Category = Classification.TypeOf.Weapon,
                Level = 3
            };
            ListOfItem.Add(9, new InventorySlot(eq3));

            Equipment eq4 = new Equipment()
            {
                ID = "10",
                Name = "Espada de Electrum",
                Description = "Também nunca vi esse material, mas eh tinindo! Q4",
                Power = 14,
                Agility = 12,
                Sort = 6,
                Vitality = 10,
                Intelligence = 3,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 160,
                SellValue = 80,
                Category = Classification.TypeOf.Weapon,
                Level = 4
            };
            ListOfItem.Add(10, new InventorySlot(eq4));

            Equipment eq5 = new Equipment()
            {
                ID = "11",
                Name = "Espada de Aço",
                Description = "Ado ado ado, quem segura espada de aço eh macho. Q5",
                Power = 20,
                Agility = 18,
                Sort = 10,
                Vitality = 12,
                Intelligence = 5,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 220,
                SellValue = 80,
                Category = Classification.TypeOf.Weapon,
                Level = 5
            };
            ListOfItem.Add(11, new InventorySlot(eq5));

            Equipment eq6 = new Equipment()
            {
                ID = "12",
                Name = "Espada de Titanium",
                Description = "Esse eh barril DROBADO! Q6",
                Power = 30,
                Agility = 22,
                Sort = 12,
                Vitality = 18,
                Intelligence = 8,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 340,
                SellValue = 100,
                Category = Classification.TypeOf.Weapon,
                Level = 6
            };
            ListOfItem.Add(12, new InventorySlot(eq6));

            Equipment eq7 = new Equipment()
            {
                ID = "13",
                Name = "Espada de Adamantium",
                Description = "Java >> All. Q7",
                Power = 38,
                Agility = 30,
                Sort = 15,
                Vitality = 20,
                Intelligence = 10,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 450,
                SellValue = 120,
                Category = Classification.TypeOf.Weapon,
                Level = 7
            };
            ListOfItem.Add(13, new InventorySlot(eq7));

            Equipment eq8 = new Equipment()
            {
                ID = "14",
                Name = "Espada de Hihiirokane",
                Description = "Nego...se o mob resistir a essa, nada mais te derruba. Q8",
                Power = 50,
                Agility = 40,
                Sort = 30,
                Vitality = 50,
                Intelligence = 15,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 800,
                SellValue = 200,
                Category = Classification.TypeOf.Weapon,
                Level = 8
            }; ListOfItem.Add(14, new InventorySlot(eq8));

            //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Criação das Adagas *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

            Equipment eq9 = new Equipment()
            {
                ID = "15",
                Name = "Adaga de Cobre",
                Description = "Fraquinhaaa..coitadaaa. Q1",
                Power = 1,
                Agility = 3,
                Sort = 3,
                Vitality = 1,
                Intelligence = 0,
                Equipped = false,
                Class = Classification.Perso.Rogue,
                MarketValue = 20,
                SellValue = 10,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            }; ListOfItem.Add(15, new InventorySlot(eq9));

            Equipment eq10 = new Equipment()
            {
                ID = "16",
                Name = "Adaga de Bronze",
                Description = "Corta até vento, reeee. Q2",
                Power = 3,
                Agility = 6,
                Sort = 5,
                Vitality = 3,
                Intelligence = 2,
                Equipped = false,
                Class = Classification.Perso.Rogue,
                MarketValue = 40,
                SellValue = 20,
                Category = Classification.TypeOf.Weapon,
                Level = 2
            }; ListOfItem.Add(16, new InventorySlot(eq10));

            Equipment eq11 = new Equipment()
            {
                ID = "17",
                Name = "Adaga de Ferro",
                Description = "Dá para bincar, Q3",
                Power = 8,
                Agility = 10,
                Sort = 10,
                Vitality = 5,
                Intelligence = 3,
                Equipped = false,
                Class = Classification.Perso.Rogue,
                MarketValue = 80,
                SellValue = 30,
                Category = Classification.TypeOf.Weapon,
                Level = 3
            }; ListOfItem.Add(17, new InventorySlot(eq11));

            Equipment eq12 = new Equipment()
            {
                ID = "18",
                Name = "Adaga de Prata",
                Description = "Ofuscanteee. Q4",
                Power = 10,
                Agility = 14,
                Sort = 12,
                Vitality = 6,
                Intelligence = 4,
                Equipped = false,
                Class = Classification.Perso.Rogue,
                MarketValue = 160,
                SellValue = 80,
                Category = Classification.TypeOf.Weapon,
                Level = 4
            }; ListOfItem.Add(18, new InventorySlot(eq12));

            Equipment eq13 = new Equipment()
            {
                ID = "19",
                Name = "Adaga de Aço",
                Description = "Corta até intimidade. Q5",
                Power = 16,
                Agility = 16,
                Sort = 16,
                Vitality = 10,
                Intelligence = 10,
                Equipped = false,
                Class = Classification.Perso.Rogue,
                MarketValue = 220,
                SellValue = 80,
                Category = Classification.TypeOf.Weapon,
                Level = 5
            }; ListOfItem.Add(19, new InventorySlot(eq13));

            Equipment eq14 = new Equipment()
            {
                ID = "20",
                Name = "Adaga de Platinum",
                Description = "Na verdade só tem um Relampago. Q6",
                Power = 22,
                Agility = 25,
                Sort = 20,
                Vitality = 12,
                Intelligence = 12,
                Equipped = false,
                Class = Classification.Perso.Rogue,
                MarketValue = 340,
                SellValue = 100,
                Category = Classification.TypeOf.Weapon,
                Level = 6
            }; ListOfItem.Add(20, new InventorySlot(eq14));

            Equipment eq15 = new Equipment()
            {
                ID = "21",
                Name = "Adaga de Titanium",
                Description = "OLHA A FAAACAAAA. Q7",
                Power = 30,
                Agility = 38,
                Sort = 28,
                Vitality = 15,
                Intelligence = 15,
                Equipped = false,
                Class = Classification.Perso.Rogue,
                MarketValue = 100,
                SellValue = 50,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            }; ListOfItem.Add(21, new InventorySlot(eq15));

            Equipment eq16 = new Equipment()
            {
                ID = "22",
                Name = "Adaga de Orichalcum",
                Description = "Corte rápido, Tramontina. Q8",
                Power = 30,
                Agility = 50,
                Sort = 35,
                Vitality = 20,
                Intelligence = 20,
                Equipped = false,
                Class = Classification.Perso.Rogue,
                MarketValue = 800,
                SellValue = 200,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            }; ListOfItem.Add(22, new InventorySlot(eq16));

            //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Criação dos Cajados *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

            Equipment eq17 = new Equipment()
            {
                ID = "23",
                Name = "Cajado de Madeira",
                Description = "Tá mais para um palito de dente. Q1",
                Power = 1,
                Agility = 2,
                Sort = 1,
                Vitality = 3,
                Intelligence = 5,
                Equipped = false,
                Class = Classification.Perso.Mage,
                MarketValue = 20,
                SellValue = 10,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            }; ListOfItem.Add(23, new InventorySlot(eq17));

            Equipment eq18 = new Equipment()
            {
                ID = "24",
                Name = "Cajado de Pérola",
                Description = "Dá para o gasto. Q2",
                Power = 1,
                Agility = 5,
                Sort = 1,
                Vitality = 5,
                Intelligence = 10,
                Equipped = false,
                Class = Classification.Perso.Mage,
                MarketValue = 40,
                SellValue = 20,
                Category = Classification.TypeOf.Weapon,
                Level = 2
            }; ListOfItem.Add(24, new InventorySlot(eq18));

            Equipment eq19 = new Equipment()
            {
                ID = "25",
                Name = "Cajado de Jade",
                Description = "Cajado que mais parece varinha que solta purpurina. Q3",
                Power = 1,
                Agility = 8,
                Sort = 2,
                Vitality = 10,
                Intelligence = 15,
                Equipped = false,
                Class = Classification.Perso.Mage,
                MarketValue = 80,
                SellValue = 30,
                Category = Classification.TypeOf.Weapon,
                Level = 3
            }; ListOfItem.Add(25, new InventorySlot(eq19));

            Equipment eq20 = new Equipment()
            {
                ID = "26",
                Name = "Cajado de Esmeralda",
                Description = "Cajado forjado pelos elfos. Q4",
                Power = 1,
                Agility = 10,
                Sort = 2,
                Vitality = 12,
                Intelligence = 18,
                Equipped = false,
                Class = Classification.Perso.Mage,
                MarketValue = 160,
                SellValue = 80,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            }; ListOfItem.Add(26, new InventorySlot(eq20));

            Equipment eq21 = new Equipment()
            {
                ID = "27",
                Name = "Cajado de Rubi",
                Description = "Agora a coisa tá ficando loucaa!! Q5",
                Power = 5,
                Agility = 15,
                Sort = 5,
                Vitality = 15,
                Intelligence = 20,
                Equipped = false,
                Class = Classification.Perso.Mage,
                MarketValue = 220,
                SellValue = 80,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            }; ListOfItem.Add(27, new InventorySlot(eq21));

            Equipment eq22 = new Equipment()
            {
                ID = "28",
                Name = "Cajado de Safira",
                Description = "Na verdade só tem um Relampago",
                Power = 8,
                Agility = 20,
                Sort = 8,
                Vitality = 20,
                Intelligence = 28,
                Equipped = false,
                Class = Classification.Perso.Mage,
                MarketValue = 340,
                SellValue = 100,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            }; ListOfItem.Add(28, new InventorySlot(eq22));

            Equipment eq23 = new Equipment()
            {
                ID = "29",
                Name = "Cajado da Onyx",
                Description = "Na verdade só tem um Relampago",
                Power = 10,
                Agility = 30,
                Sort = 10,
                Vitality = 25,
                Intelligence = 35,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 450,
                SellValue = 120,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            }; ListOfItem.Add(29, new InventorySlot(eq23));

            Equipment eq24 = new Equipment()
            {
                ID = "30",
                Name = "Cajado de Diamente",
                Description = "Na verdade só tem um Relampago",
                Power = 20,
                Agility = 40,
                Sort = 20,
                Vitality = 60,
                Intelligence = 60,
                Equipped = false,
                Class = Classification.Perso.Warrior,
                MarketValue = 800,
                SellValue = 200,
                Category = Classification.TypeOf.Weapon,
                Level = 1
            }; ListOfItem.Add(30, new InventorySlot(eq24));

            //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Criação das Armaduras *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

            Equipment eq25 = new Equipment()
            {
                ID = "31",
                Name = "Armadura de Ferro",
                Description = "Armadura dos calouros. Q1",
                Power = 10,
                Agility = 10,
                Sort = 10,
                Vitality = 10,
                Intelligence = 10,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 100,
                SellValue = 50,
                Category = Classification.TypeOf.Armor,
                Level = 1
            }; ListOfItem.Add(31, new InventorySlot(eq25));

            Equipment eq26 = new Equipment()
            {
                ID = "32",
                Name = "Armadura de Aço",
                Description = "A coisa começou a ficar séria hahaha. Q2",
                Power = 25,
                Agility = 25,
                Sort = 25,
                Vitality = 25,
                Intelligence = 25,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 250,
                SellValue = 100,
                Category = Classification.TypeOf.Armor,
                Level = 2
            }; ListOfItem.Add(32, new InventorySlot(eq26));

            Equipment eq27 = new Equipment()
            {
                ID = "33",
                Name = "Armadura de Titanium",
                Description = "Q3",
                Power = 40,
                Agility = 40,
                Sort = 40,
                Vitality = 40,
                Intelligence = 40,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 500,
                SellValue = 250,
                Category = Classification.TypeOf.Armor,
                Level = 4
            }; ListOfItem.Add(33, new InventorySlot(eq25));

            Equipment eq28 = new Equipment()
            {
                ID = "34",
                Name = "Armadura de Adamantium",
                Description = "Q4",
                Power = 60,
                Agility = 50,
                Sort = 60,
                Vitality = 60,
                Intelligence = 50,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 1000,
                SellValue = 500,
                Category = Classification.TypeOf.Armor,
                Level = 8
            }; ListOfItem.Add(34, new InventorySlot(eq28));

            //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Criação dos Acessórios *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

            Equipment eq29 = new Equipment()
            {
                ID = "35",
                Name = "Anel Necronomicom",
                Description = "Rouba vida no próximo ataque. Q1",
                Power = 1,
                Agility = 50,
                Sort = 60,
                Vitality = 60,
                Intelligence = 50,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 200,
                SellValue = 100,
                Category = Classification.TypeOf.Acessorio,
                Level = 1
            }; ListOfItem.Add(35, new InventorySlot(eq29));

            Equipment eq30 = new Equipment()
            {
                ID = "36",
                Name = "Anel Magna Scriptura",
                Description = "Causa dano ao inimigo e cura. Q2",
                Power = 60,
                Agility = 50,
                Sort = 60,
                Vitality = 60,
                Intelligence = 50,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 350,
                SellValue = 200,
                Category = Classification.TypeOf.Acessorio,
                Level = 2
            }; ListOfItem.Add(36, new InventorySlot(eq30));

            Equipment eq31 = new Equipment()
            {
                ID = "37",
                Name = "Anel do Dragão",
                Description = "Adquiri rajada de fogo. Q3",
                Power = 60,
                Agility = 50,
                Sort = 60,
                Vitality = 60,
                Intelligence = 50,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 500,
                SellValue = 250,
                Category = Classification.TypeOf.Acessorio,
                Level = 3
            }; ListOfItem.Add(37, new InventorySlot(eq31));

            Equipment eq32 = new Equipment()
            {
                ID = "38",
                Name = "Anel Coroa do Rei da Tempestade",
                Description = "Adquiri rajada de raio. Q4",
                Power = 60,
                Agility = 50,
                Sort = 60,
                Vitality = 60,
                Intelligence = 50,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 650,
                SellValue = 300,
                Category = Classification.TypeOf.Acessorio,
                Level = 4
            }; ListOfItem.Add(38, new InventorySlot(eq32));

            Equipment eq33 = new Equipment()
            {
                ID = "39",
                Name = "Anel Santo Graal",
                Description = "Curaa! Q5",
                Power = 60,
                Agility = 50,
                Sort = 60,
                Vitality = 60,
                Intelligence = 50,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 750,
                SellValue = 325,
                Category = Classification.TypeOf.Acessorio,
                Level = 5
            }; ListOfItem.Add(39, new InventorySlot(eq33));

            Equipment eq34 = new Equipment()
            {
                ID = "40",
                Name = "Anel Véu da Noite",
                Description = "Ignora próximo dano recebido. Q6",
                Power = 60,
                Agility = 50,
                Sort = 60,
                Vitality = 60,
                Intelligence = 50,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 850,
                SellValue = 425,
                Category = Classification.TypeOf.Acessorio,
                Level = 6
            }; ListOfItem.Add(40, new InventorySlot(eq34));

            Equipment eq35 = new Equipment()
            {
                ID = "41",
                Name = "Anel Coração da Dama Congelada",
                Description = "Adquiri escudo de gelo e solta debuff em quem bater. Q7",
                Power = 60,
                Agility = 50,
                Sort = 60,
                Vitality = 60,
                Intelligence = 50,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 900,
                SellValue = 450,
                Category = Classification.TypeOf.Acessorio,
                Level = 7
            }; ListOfItem.Add(41, new InventorySlot(eq35));

            Equipment eq36 = new Equipment()
            {
                ID = "42",
                Name = "Amuleto da Estrela Caída",
                Description = "Meteoro com chance de crítico",
                Power = 60,
                Agility = 50,
                Sort = 60,
                Vitality = 60,
                Intelligence = 50,
                Equipped = false,
                Class = Classification.Perso.Warrior & Classification.Perso.Rogue & Classification.Perso.Mage,
                MarketValue = 1000,
                SellValue = 1001,
                Category = Classification.TypeOf.Acessorio,
                Level = 8
            }; ListOfItem.Add(42, new InventorySlot(eq36));

            //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* Criação dos Collectible *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

            return ListOfItem;
        }
        

    }
}