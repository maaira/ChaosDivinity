using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Item
{ 
    public class Equipment : ItemGame
    {
        private int def;
        private int dmg;
        private bool equipped;
        private string category;
        protected int power;
        protected int agility;
        protected int intelligence;
        protected int sort;
        protected int vitality;
        
        public int Power { get => power; set => power = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Sort { get => sort; set => sort = value; }
        public int Vitality { get => vitality; set => vitality = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
                
        public bool Equipped { get => equipped; set => equipped = value; }
         

        public Equipment(string name, string description, int power, int agi, int sort, int vit, int intel, bool equipped, string classGroup, int draqui, int cash, string categoty, int lvl, string id) : base(name, description, draqui, cash, lvl, id)
        {
            this.power = power;
            this.agility = agi;
            this.intelligence = intel;
            this.sort = sort;
            this.vitality = vit;           
            this.equipped = equipped;
            this.category = classGroup;
        }

    }
}
