﻿using System;
using System.Collections.Generic;

namespace ChaosDivinity.Char
{
    public class Mage : Hero
    {
        //private new List<Skill> listOfSkills;

        public Mage(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl, int power, int agility, int sort, int intelligence, int vitality) : base(nomeChar, hp_atual, hp_total, mp_atual, mp_total, lvl, power, agility, sort, intelligence, vitality)
        {
            listOfSkills = new List<Skill>();
            listOfSkills.Add(new Skill("Lança Chamas", 10, 5, 0, 10, 0, 35, 0, 50));
            listOfSkills.Add(new Skill("Nuvem Tóxica", 15, 25, 0, 5, 0, 0, 0, 100));
            listOfSkills.Add(new Skill("Tsunami", 20, 12, 7, 0, 0, 0, 0, 200));
            listOfSkills.Add(new Skill("Avalanche", 30, 10, 0, 50, 0, 0, 0, 300));
            this.className = "Mage";
        }

        public override void LvUp()
        {
            Lvl++;
            Xp_atual = Xp_atual - Xp_total;
            Xp_total *= 2;
            Hp_total += 0;
            Mp_total += 0;
            dmg += 0;
            Hp_atual = Hp_total;
            Mp_atual = Mp_total;
            if (IsLvUP() == true)
            {
                LvUp();
            }
        }
    }
}