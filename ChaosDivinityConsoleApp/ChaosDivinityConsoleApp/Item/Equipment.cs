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

        public int Def { get => def; }
        public int Dmg { get => dmg; }
        public bool Equipped { get => equipped; set => equipped = value; }
        public string Category { get => category; }

        public Equipment(string name, string description, int def, int dmg, bool equipped, string classGroup,   int draqui, int cash, string id) : base(name, description, draqui, cash, id)
        {            
            this.def = def;
            this.dmg = dmg;
            this.equipped = equipped;           

        }

    }
}
