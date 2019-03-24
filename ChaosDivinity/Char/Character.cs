using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTESTE.Char
{
    abstract class Character
    {
        public double skilllenght;
        public double atacklenght;
        private string nameChar;
        private int hp_atual, hp_total;
        private int mp_atual, mp_total;
        private int xp_atual, xp_total, lvl;
        private int base_dmg, base_def;
        private string nameClass;
        //private List<Skill> skills;
        //private List<Itens> inventario = new List<Itens>();

    }
}
