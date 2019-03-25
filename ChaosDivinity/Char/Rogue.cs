﻿using System;

namespace ChaosDivinity.Char
{
    public class Rogue : Character
    {

        //Construtor genérico
        public Rogue(String nome)
        {

            //Inicializa atributos do personagem

            this.Nome = nome;
            Lvl = 1; Xp_atual = 0; Xp_total = 1000;
            Hp_total = 200; Hp_atual = Hp_total;
            Mp_total = 100; Mp_atual = Mp_total;
            Base_def = 40; Base_dmg = 30;
            Nome_classe = "Rogue";
            
            //Cria e inicializa as skills da classe do personagem
            Skills = new List<Skill>();
            //(String skill_name, custo_mp, custo_hp, lv_requerido, hp_up, mp_up, base_dmg_up, base_def_up, skill_dmg)
            Skills.Add(new Skill("Furia Silenciosa", 15, 0, 1, 0, 0, 0, 0, 50));

        }

        public override void LvUp()
        {
            Lvl++;
            Xp_atual = Xp_atual - Xp_total;
            Xp_total *= 2;
            Hp_total += 30;
            Mp_total += 30;
            Base_def += 10;
            Base_dmg += 15;
            Hp_atual = Hp_total;
            Mp_atual = Mp_total;
            if (IsLvUP() == true)
            {
                LvUp();
            }
        }
    }
}
