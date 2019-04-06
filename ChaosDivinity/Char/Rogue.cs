﻿using System;
using System.Collections.Generic;
using ChaosDivinity.Interface;

namespace ChaosDivinity.Char
{
    public class Rogue : Hero
    {


        public Rogue(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl, int power, int agility, int sort, int intelligence, int vitality, Classification.Perso classGroup) : base(nomeChar, hp_atual, hp_total, mp_atual, mp_total, lvl, power, agility, sort, intelligence, vitality, classGroup)
        {
            listOfSkills = new List<Skill>();
            listOfSkills.Add(new Skill("Sombras da Noite ", 5, 5, 1, 10, 0, 35, 0, 50));
            listOfSkills.Add(new Skill("Mordida Feroz ", 20, 25, 3, 5, 0, 0, 0, 100));
            listOfSkills.Add(new Skill("Apunhalar ", 30, 12, 7, 0, 0, 0, 0, 200));
            listOfSkills.Add(new Skill("Combo Triplo ", 35, 10, 10, 50, 0, 0, 0, 300));
            
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
