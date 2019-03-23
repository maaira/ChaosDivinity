using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChaosDivinity.Item
{
    class ItemGame
    {
        
        /* ---------- Objetos da classe ------------- */
        private String name, description; //nome do item/equipamento/consumívle
        private int marketValueDraquima; //valor no NPC
        private int sellValue ; // 
        //private Image sprite; //Imagem
        private string id;
        /*  ---------- Objetos para instaciar ----------- */
        public string Name { get => name; set => name = value; }
        public string Description { get => description; }
        public int MarketValue { get => marketValueDraquima; }
        public int SellValue { get => sellValue; }
        //public Image Sprite { get => sprite; set => sprite = value; }
        public string ID { get => id; }



        public ItemGame(string name, string description, int draqui, int sell, string id )
        {
            this.name = name;
            this.description = description;
            this.sellValue = sell;
            this.marketValueDraquima = draqui;
            this.id = id;
        }

        


    }
}
