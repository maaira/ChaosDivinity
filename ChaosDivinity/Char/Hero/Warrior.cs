using System;
using System.Collections.Generic;
using ChaosDivinity.Interface;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Char
{
    public class Warrior : Hero
    {

        public Warrior(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl, int power, int agility, int sort, int intelligence, int vitality, Classification.Perso classGroup) : base(nomeChar, hp_atual, hp_total, mp_atual, mp_total, lvl, power, agility, sort, intelligence, vitality, classGroup)
        {
            this.MoveToLeft = "ms-appx:///Assets/Warrior/walkLeft.gif";
            this.MoveToRight = "ms-appx:///Assets/Warrior/walkRight.gif";
            this.StopLeft = "ms-appx:///Assets/Warrior/idleLeft.gif";
            this.StopRight = "ms-appx:///Assets/Warrior/idleRight.gif";

        }

        public override void LvUp()
        {
            Lvl++;
            Xp_atual = Xp_atual - Xp_total;
            Xp_total *= 2;
            Hp_total += 0;
            Mp_total += 0;
            Hp_atual = Hp_total;
            Mp_atual = Mp_total;
            if (IsLvUP() == true)
            {
                LvUp();
            }
        }
    }
}
