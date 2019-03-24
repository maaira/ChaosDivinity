using System;

namespace RPGTESTE.Char
{
    public class Rogue : Character
    {

        //Construtor genérico
        public Rogue(String nome)
        {

            //Inicializa atributos do personagem

            this.Nome = nome;
            Lvl = 1; Xp_atual = 0; Xp_total = 0;
            Hp_total = 0; Hp_atual = Hp_total;
            Mp_total = 0; Mp_atual = Mp_total;
            Base_def = 0; Base_dmg = 0;
            Nome_classe = "Rogue";
            
            //Cria e inicializa as skills da classe do personagem
            Skills = new List<Skill>();
            //(String skill_name, custo_mp, custo_hp, lv_requerido, hp_up, mp_up, base_dmg_up, base_def_up, skill_dmg)
            Skills.Add(new Skill("NomeDaHabilidade", 20, 0, 1, 0, 0, 0, 0, 200));

        }

        public override void LvUp()
        {
            Lvl++;
            Xp_atual = Xp_atual - Xp_total;
            Xp_total *= 2;
            Hp_total += 0;
            Mp_total += 0;
            Base_def += 0;
            Base_dmg += 0;
            Hp_atual = Hp_total;
            Mp_atual = Mp_total;
            if (IsLvUP() == true)
            {
                LvUp();
            }
        }
    }
}
