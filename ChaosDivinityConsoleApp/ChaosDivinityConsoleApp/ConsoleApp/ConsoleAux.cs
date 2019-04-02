using System;
using ChaosDivinity.Char;
using ChaosDivinity.Inventory;
using ChaosDivinity.Item;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Market;

namespace ChaosDivinity.ConsoleApp
{
    public static class ConsoleAux
    {
        public static Hero hero;
        public static string Menssagem()
        {
            return "Bem vindo ao Chaos Divinity!\nO mundo vivia uma era tranquila, o mal se mantinha afastado por séculos, mas existiam aqueles que operavam das sombras para trazer o retorno das trevas. Uma seita começou seus planos de reviver o seu deus maligno Ba-Kon, e para isso não poupariam esforços. O fim do mundo estava próximo e a catástrofe espreitava perto. Os avatares do deus estavam vivos exerciam sua influencia devastadora sobre a natureza. As águas se envenenavam, o céu sufocava e a terra morria pouco a pouco. Monstros vinham de todos os lados e as pessoas perdiam sua esperança. E agora quem poderá nos defender?";
        }

        public static string MenssagemGuerreiro()
        {
            return "Das montanhas vinha um homem, um soldado renegado, mercenário forjado nas guerras do reino que deixou, abandonando sua antiga glória para manter a sua honra. Sua força agora serviria aquele que pagasse mais alto, porém nunca se desviando de seus preceitos, o que faria de seu caminho ainda mais árduo. O guerreiro tinha cada vez mais trabalho devido às aparições das criaturas das trevas, mas sabia que existia algo muito maior por trás de tudo. Ele então decidiu mais uma vez usar sua espada não por si mesmo, mas por todo o mundo.";
        }

        public static string MenssagemLadino()
        {
            return "Todos os reinos a procuravam, a ladra que já havia roubado em becos, estradas e castelos. Suas lâminas rasgavam carteiras e gargantas como uma folha dança no vento. Nenhuma parede era alta o suficiente, nenhuma guarda forte o bastante, porém aquelas hordas malignas eram algo a se temer. A mulher que cresceu nas ruas das cidades, e já tinha visto de tudo nunca tinha posto os olhos em miséria como aquela, ela então resolveu fazer algo sobre a escuridão iminente, e confronta-la pelas sombras, talvez algum lucro viesse ao seu encontro.";
        }

        public static string MenssagemMago()
        {
            return "A imagem do jovem apaixonado por livros havia se dissipado. Os anos passaram e o erudito perdeu a noção do tempo. O mago já não sabia mais quando havia começado a se dedicar aos estudos, mas isso era o único pensamento em sua mente, não haviam mais família, amigos ou professores. Talvez até mesmo já tivesse perdido sua humanidade, enquanto contemplava o abismo arcano. Agora as figuras mais sombrias que apareceram em seus textos tocavam a realidade, e esse seria o seu chamado.";
        }



        public static void MenuSeleçãoDePersonagem()
        {
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("Então...Oque voce vai querer ser!?");
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("        1 - Um Bravo Guerreiro?");
            Console.WriteLine("        " + MenssagemGuerreiro());
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("        2 - Uma Astuta Ladina?");
            Console.WriteLine("        " + MenssagemLadino());
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("        3 - Um Incrivel Mago?");
            Console.WriteLine("        " + MenssagemMago());
            Console.WriteLine("_" +
                "_______________________________________________________________________________________________");


            string type = Console.ReadLine();
            Console.Clear();

            if (Int32.TryParse(type, out int numValue))
            {
                Console.Clear();
                Console.WriteLine("Poderia me dizer seu lindo nome?");
                string nome = Console.ReadLine();
                switch (numValue)
                {
                    case 1:
                        hero = new Warrior(nome, 50, 50, 50, 50, 1, 5, 5, 5, 5, 5);

                        break;
                    case 2:
                        hero = new Rogue(nome, 50, 50, 50, 50, 1, 5, 5, 5, 5, 5);
                        break;
                    case 3:
                        hero = new Mage(nome, 50, 50, 50, 50, 1, 5, 5, 5, 5, 5);
                        break;
                    default:
                        Console.WriteLine("Hum...Não conheço essa opção!Me diga algo diferente dessa vez.");
                        MenuSeleçãoDePersonagem();
                        break;
                }
                
                Console.ReadKey();
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("Nome     : " + hero.Nome);
                Console.WriteLine("Level    : " + hero.Lvl);
                Console.WriteLine("Vitality : " + hero.Vitality);
                Console.WriteLine("Level    : " + hero.Power);
                Console.WriteLine("Sort     : " + hero.Sort);
                Console.WriteLine("HP       : " + hero.Hp_total);
                Console.WriteLine("MP       : " + hero.Mp_total);
                Console.WriteLine("Draquimas: " + hero.Draquimas);
                Console.WriteLine("BackPack : " + "No item found");
                Console.WriteLine("________________________________________________________________________________________________");
                Console.ReadKey();
                Console.Clear();

                MenuPrincipal();

            }
            else
            {
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("Impossivel identificar sua opção. Digite novamente!");
                Console.WriteLine("________________________________________________________________________________________________");
                Console.Clear();
                MenuSeleçãoDePersonagem();
            }
        }

        static void MenuMarketBuy()
        {
            Console.WriteLine("_______________________________________________________________________________________________");

            foreach (KeyValuePair<string, InventorySlot> x in DBItem.DBItens())
            {
                Console.WriteLine("ID        : " + x.Key);
                Console.WriteLine("Name      : " + x.Value.Slot.Name);
                Console.WriteLine("Preço     : " + x.Value.Slot.MarketValue);
                if (x.Value.GetType() == typeof(Equipment))
                {
                    //Atributos de Equipement
                }
                else if (x.Value.GetType() == typeof(Consumable))
                {
                    //Atributos de Consumable
                }
                Console.WriteLine("_______________________________________________________________________________________________");
            }
            Console.WriteLine("Insira o ID do item que voce quer comprar.");
            string id = Console.ReadLine();
            Console.WriteLine("________________________________________________________________________________________________");
            if (DBItem.DBItens().ContainsKey(id))
            {

                if (MarketClass.BuyItem(DBItem.DBItens()[id].Slot, hero))
                {                    
                    Console.WriteLine("Compra realizada com sucesso");
                    Console.ReadKey();
                }
                else
                {

                    Console.WriteLine("Impossivel realizar compra.");
                    Console.ReadKey();
                }
                MenuPrincipal();

            }
            else
            {
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("ID não encontrado.");
                Console.WriteLine("________________________________________________________________________________________________");
                Console.Clear();
                MenuPrincipal();

            }

        }

        public static void MenuMarketSell()
        {
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("Nome     : " + hero.Nome);
            Console.WriteLine("Level    : " + hero.Lvl);
            Console.WriteLine("Vitality : " + hero.Vitality);
            Console.WriteLine("Level    : " + hero.Power);
            Console.WriteLine("Sort     : " + hero.Sort);
            Console.WriteLine("HP       : " + hero.Hp_total);
            Console.WriteLine("MP       : " + hero.Mp_total);
            Console.WriteLine("Draquimas: " + hero.Draquimas);
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("___________________________________________BackPack_____________________________________________");

            foreach (InventorySlot x in hero.BackPack.InventoryOfBackPack.Values)
            {

                Console.WriteLine("Name       : " + x.Slot.Name);
                Console.WriteLine("ID         : " + x.Slot.ID);
                Console.WriteLine("Item       : " + x.Slot.Level);
                Console.WriteLine("Level      : " + x.Slot.Level);
                Console.WriteLine("Quantidade : " + x.Tam + 1);
                Console.WriteLine("________________________________________________________________________________________________");

            }
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("Deseja vender algo? [S/N]");
            string resp = Console.ReadLine();
            Console.WriteLine("________________________________________________________________________________________________");
        }
        public static void MenuMarket()
        {
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("Voce quer comprar ou vender?");
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("       1-Vender");
            Console.WriteLine("       2-Comprar");
            string resp = Console.ReadLine();
            Console.Clear();
            switch (resp)
            {
                case "1":
                    MenuMarketSell();
                    break;
                case "2":
                    MenuMarketBuy();
                    break;
                default:

                    break;
            }

        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("________________________________________________________________________________________________");
            Console.WriteLine("Nome     : " + hero.Nome);
            Console.WriteLine("Level    : " + hero.Lvl);
            Console.WriteLine("Vitality : " + hero.Vitality);
            Console.WriteLine("Level    : " + hero.Power);
            Console.WriteLine("Sort     : " + hero.Sort);
            Console.WriteLine("HP       : " + hero.Hp_total);
            Console.WriteLine("MP       : " + hero.Mp_total);
            Console.WriteLine("Draquimas: " + hero.Draquimas);
            Console.WriteLine("BackPack : " + "No item found");
            Console.WriteLine("________________________________________________________________________________________________");
            Console.ReadKey();
            
            Console.WriteLine("Agora voce pode ter acesso ao Market e aos itens do game!");
            Console.Clear();
            Console.WriteLine("O que voce quer fazer?");
            Console.WriteLine("       1 - Market.");
            Console.WriteLine("       2 - Backpack.");
            string select = Console.ReadLine();

            if (Int32.TryParse(select, out int numValue))
            {

                switch (numValue)
                {
                    case 1:
                        MenuMarket();
                        break;
                    case 2:
                        MenuInventario();
                        break;
                    default:
                        break;
                }

            }
            else
            {

                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("Impossivel identificar sua opção. Digite novamente!");
                Console.WriteLine("________________________________________________________________________________________________");
                Console.Clear();

            }

        }

        static void MenuInventario()
        {
            if (!hero.BackPack.ContainsItem())
            {
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("Nome     : " + hero.Nome);
                Console.WriteLine("Level    : " + hero.Lvl);
                Console.WriteLine("Vitality : " + hero.Vitality);
                Console.WriteLine("Level    : " + hero.Power);
                Console.WriteLine("Sort     : " + hero.Sort);
                Console.WriteLine("HP       : " + hero.Hp_total);
                Console.WriteLine("MP       : " + hero.Mp_total);
                Console.WriteLine("Draquimas: " + hero.Draquimas);
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("Sorry...Seu inventario está vazio! Compre itens no Market e eles irão aparecer aqui!");
                Console.WriteLine("________________________________________________________________________________________________");
                Console.ReadKey();
                Console.Clear();
                MenuPrincipal();
                
            }
            else
            {
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("Nome     : " + hero.Nome);
                Console.WriteLine("Level    : " + hero.Lvl);
                Console.WriteLine("Vitality : " + hero.Vitality);
                Console.WriteLine("Level    : " + hero.Power);
                Console.WriteLine("Sort     : " + hero.Sort);
                Console.WriteLine("HP       : " + hero.Hp_total);
                Console.WriteLine("MP       : " + hero.Mp_total);
                Console.WriteLine("Draquimas: " + hero.Draquimas);
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("___________________________________________BackPack_____________________________________________");
                
                foreach (InventorySlot x in hero.BackPack.InventoryOfBackPack.Values)
                {

                    Console.WriteLine("Name       : " + x.Slot.Name);
                    Console.WriteLine("ID         : " + x.Slot.ID  );
                    Console.WriteLine("Item       : " + x.Slot.Level);
                    Console.WriteLine("Level      : " + x.Slot.Level);
                    Console.WriteLine("Quantidade : " + x.Tam+1);
                    Console.WriteLine("________________________________________________________________________________________________");

                }
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("Deseja equipar algo? [S/N]");
                string resp = Console.ReadLine();
                Console.WriteLine("________________________________________________________________________________________________");
                switch (resp)
                {
                    case "S":
                        Console.WriteLine("________________________________________________________________________________________________");
                        Console.WriteLine("Insira o ID do item que voce quer equipar");
                        Console.WriteLine("________________________________________________________________________________________________");
                        string id = Console.ReadLine();
                        if (hero.BackPack.InventoryOfBackPack.ContainsKey(id) && hero.BackPack.InventoryOfBackPack[id].Slot.GetType() == typeof(Equipment) && hero.AddtemToEquip(hero.BackPack.InventoryOfBackPack[id].Slot))
                        {
                            Console.WriteLine("Item Equipado");
                            Console.ReadKey();
                            MenuPrincipal();



                        }
                        else Console.WriteLine("Hum...Não deu certo...");
                        Console.ReadKey();
                        MenuPrincipal();

                        break;
                    case "N":
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Não intendi...");
                        Console.ReadKey();
                        MenuPrincipal();
                        break;
                }
            }

            

        }
    }
}
