using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Item
{
    public class Consumable :  ItemGame
    {
        private int hp, mp;
        public int HP { get => hp; set => hp = value; }
        public int MP{ get => mp; set => mp = value; }

        public Consumable(string name, string description, int draqui, int cash, int hp , int mp, string id) : base(name, description, draqui ,cash, id)
        {
            this.hp = hp;
            this.mp = mp;
        }


    }
}
