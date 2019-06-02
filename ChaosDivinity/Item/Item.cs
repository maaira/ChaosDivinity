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
        /*  ---------- Objetos para instanciar ----------- */
        public string Name { get; set; }
        public string Description { get; set; }
        public int MarketValue { get; set; }
        public int SellValue { get; set; }
        public int Level { get; set; }
        //public string ID { get; set; }
        public string Path { get; set; }

    }
}
