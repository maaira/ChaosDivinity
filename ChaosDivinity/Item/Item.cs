using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChaosDivinity.Item
{
    public class ItemGame : PhysicObject 
    {
        /*  ---------- Objetos para instaciar ----------- */
        public string Name { get; set; }
        public string Description { get; }
        public int MarketValue { get; }
        public int SellValue { get; }
        public int Level { get; set; }
        //public Image Sprite { get => sprite; set => sprite = value; }
        public string ID { get; }
        public string Path { get; set; }

        public ItemGame(string name, string description, int draqui, int sell, int lvl, string id)
        {

            this.Name = name;
            this.Description = description;
            this.SellValue = sell;
            this.MarketValue = draqui;
            this.ID = id;
            this.Level = lvl;

        }




    }
}
