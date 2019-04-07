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
        private int def;
        private int dmg;
       
        public Classification.TypeOf Category { get; }
        public Classification.Perso Class { get; }
        

        public int Power { get ; set ; }
        public int Agility { get ; set; }
        public int Sort { get ; set ; }
        public int Vitality { get ; set ; }
        public int Intelligence { get ; set; }

        public bool Equipped { get ; set ; }

        
        public Equipment(string name, string description, int power, int agi, int sort, int vit, int intel, bool equipped, Classification.Perso perso, int draqui, int cash, Classification.TypeOf type, int lvl, string id) : base(name, description, draqui, cash, lvl, id)
        {
            this.Power = power;
            this.Agility = agi;
            this.Intelligence = intel;
            this.Sort = sort;
            this.Vitality = vit;
            this.Equipped = equipped;
            this.Category = type;
            this.Class = perso;
        }

    }
}
