using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Item
{
    public class DBItem
    {
        static private int id = 100;
        static private string[] person = { "Guerreiro", "Ladino", "Mago", "All" };
        private static string[] type = { "Arma", "Consumivel", "Coleção" };
        private static string[] categoryType = { "", "Espada", "Adaga", "Cajado", "Acessorio" , "Escudo"  };

        private static string IDCalculate(string person)
        {

            switch (person) { 
                case "Guerreiro":
                    id += 1;
                    return person + id;
                case  "Ladina" :
                    id += 1;
                    return person + id;
                case "Mago":
                    id += 1;
                    return person + id;

                default:return "Item" + id;            
            }
            
        }
        public static ItemGame [] ItemDBGuerreiro()
        {

            return new ItemGame []{ new Equipment ("Espada dos Mil Relampagos", "",10, 10, false , person[0] , 100, 100 , IDCalculate(person[0])),
                                    new Equipment("Espada de Pandora", "", 10, 3, false, person[0],  10,500, IDCalculate(person[0]))           

                                 };
        }

        public static ItemGame[] ItemDBLadino()
        {
            return new ItemGame[] { new Equipment ("Arco de Artemis", "",10, 10, false , person[1] ,  100, 100 , IDCalculate(person[1])),
                                    new Equipment( "Sombras das Noites", "",10, 10, false, person[1] , 100, 100, IDCalculate(person[1])) };


        }

        public static ItemGame[] ItemDBMago()
        {
            return new ItemGame[] { new Equipment ("Cajado de Demetris", "",10, 10, false , person[2] ,  100, 100 , IDCalculate(person[2])),
                                    new Equipment( "Raio de Zeus", "",10, 10, false, person[2] , 100, 100, IDCalculate(person[2])) };
        }

        public static ItemGame[] ItemDBConsumivel()
        {
            return new ItemGame[] {new Consumable("Nectar", "", 50, 50, 10, 0 , IDCalculate(person[3])) ,
                                   new Consumable("Ambrosia", "", 10, 10, 0, 10 ,IDCalculate(person[3])) };


        }

        public static ItemGame[] ItemDB()
        {
            return new ItemGame[] {new ItemGame("Toque de Ouro", "", 10, 10, IDCalculate(person[3])),
                                   new ItemGame("Oraculo  de Delfus", "", 10, 10,IDCalculate(person[3]))};
        }
    }
}