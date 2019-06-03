using System;


namespace ChaosDivinity.Char
{

    public class Skill
    {
        public Skill(String skill_name, int custo_mp, int custo_hp, int lv_requerido, int hp_up, int mp_up, int base_dmg_up, int base_def_up, int skill_dmg)
        {
            this.Base_def_up = base_def_up; this.Base_dmg_up = base_dmg_up;
            this.Custo_hp = custo_hp; this.Custo_mp = custo_mp;
            this.Hp_up = hp_up; this.Mp_up = mp_up;
            this.Lv_requerido = lv_requerido;
            this.Skill_dmg = skill_dmg;
            this.Skill_name = skill_name;
        }

        public string Skill_name { get; set ; }
        public int Custo_mp { get ; set; }
        public int Custo_hp { get ; set; }
        public int Lv_requerido { get ; set ; }
        public int Hp_up { get ; set ; }
        public int Mp_up { get ; set ; }
        public int Base_dmg_up { get; set ; }
        public int Base_def_up { get ; set ; }
        public int Skill_dmg { get ; set ; }


        public int Executar(Hero p1)
        {
            if (p1.IsManaAvaliable(Custo_mp) == false)
            {
                return -1; //Código para quando o jogador não tiver mana para a skill
            }
            else if (p1.Lvl < Lv_requerido)
            {
                return -2; //Código para quando o jogador não tiver level para usar a skill
            }
            else
            {
                p1.Mp_atual += Mp_up;
                p1.Mp_total += Mp_up;
                p1.Hp_atual += Hp_up;
                p1.Hp_total += Hp_up;
                p1.Mp_atual -= Custo_mp;
                return Skill_dmg;
            }

        }
    }

}

