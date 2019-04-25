using ChaosDivinity.Inventory;
using ChaosDivinity.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Char
{
    public abstract class Character
    {
        protected string nameChar;
        protected int hp_atual, hp_total;
        protected int mp_atual, mp_total;
        protected int dmg;
        protected int lvl;

        //protected string nameClass;  


        public string Nome { get => nameChar; set => nameChar = value; }
        public int Hp_atual { get => hp_atual; set => hp_atual = value; }
        public int Hp_total { get => hp_total; set => hp_total = value; }
        public int Mp_atual { get => mp_atual; set => mp_atual = value; }
        public int Mp_total { get => mp_total; set => mp_total = value; }
        public int Damage { get => dmg; set => dmg = value; }
        public int Lvl { get => lvl; set => lvl = value; }



        public Character(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl)
        {
            this.nameChar = nomeChar;
            this.hp_atual = hp_atual;
            this.hp_total = hp_total;
            this.mp_atual = mp_atual;
            this.mp_total = mp_total;
            this.lvl = lvl;
        }




    }
}