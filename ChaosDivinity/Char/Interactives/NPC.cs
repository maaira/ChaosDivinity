using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Char
{
    public class NPC : Character
    {
        //Quest
        public NPC(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl) : base(nomeChar, hp_atual, hp_total, mp_atual, mp_total, lvl)
        {
            this.IsInteractive = true;
        }
    }
}
