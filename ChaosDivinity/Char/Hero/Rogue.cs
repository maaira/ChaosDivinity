using System;
using System.Collections.Generic;
using ChaosDivinity.Interface;

namespace ChaosDivinity.Char
{
    public class Rogue : Hero
    {


        public Rogue(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl, int power, int agility, int sort, int intelligence, int vitality, Classification.Perso classGroup) : base(nomeChar, hp_atual, hp_total, mp_atual, mp_total, lvl, power, agility, sort, intelligence, vitality, classGroup)
        {
            this.MoveToLeft = "ms-appx:///Assets/Rogue/RogueToLeft.gif";
            this.MoveToRight = "ms-appx:///Assets/Rogue/RogueToRight.gif";
            this.StopLeft = "ms-appx:///Assets/Rogue/RogueStopLeft.gif";
            this.StopRight = "ms-appx:///Assets/Rogue/RogueStopRight.gif";

            ListofSkill.Add(Windows.System.VirtualKey.Number1, new Skill("Ataque Sorrateira", 5, 0, 0, 0, 30, this));
            ListofSkill.Add(Windows.System.VirtualKey.Number2, new Skill("Roubo das Trevas", 0, 0, 10, 10, 0, this));
            ListofSkill.Add(Windows.System.VirtualKey.Number3, new Skill("Selando a Besta", 12, 2, 10, 0, 0, this));
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
