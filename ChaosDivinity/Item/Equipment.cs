using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Interface;

namespace ChaosDivinity.Item
{
    public class Equipment : ItemGame
    {
        public Classification.TypeOf Category { get; set; }
        public Classification.Perso Class { get; set; }

        public int Power { get; set; }
        public int Agility { get; set; }
        public int Sort { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }

        public bool Equipped { get; set; }

    }
}
