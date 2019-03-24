using System;


namespace RPGTESTE.Char { 
    public class Skill
    {

        private String skill_name;
        private int custo_mp, custo_hp, lv_requerido;
        private int hp_up, mp_up, base_dmg_up, base_def_up;
        private int skill_dmg;

        public Skill(String skill_name, int custo_mp, int custo_hp, int lv_requerido, int hp_up, int mp_up, int base_dmg_up, int base_def_up, int skill_dmg)
        {
            this.Base_def_up = base_def_up; this.Base_dmg_up = base_dmg_up;
            this.Custo_hp = custo_hp; this.Custo_mp = custo_mp;
            this.Hp_up = hp_up; this.Mp_up = mp_up;
            this.Lv_requerido = lv_requerido;
            this.Skill_dmg = skill_dmg;
            this.Skill_name = skill_name;
        }

        public string Skill_name { get => skill_name; set => skill_name = value; }
        public int Custo_mp { get => custo_mp; set => custo_mp = value; }
        public int Custo_hp { get => custo_hp; set => custo_hp = value; }
        public int Lv_requerido { get => lv_requerido; set => lv_requerido = value; }
        public int Hp_up { get => hp_up; set => hp_up = value; }
        public int Mp_up { get => mp_up; set => mp_up = value; }
        public int Base_dmg_up { get => base_dmg_up; set => base_dmg_up = value; }
        public int Base_def_up { get => base_def_up; set => base_def_up = value; }
        public int Skill_dmg { get => skill_dmg; set => skill_dmg = value; }
    }

    public int executar(Character p1)
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
            p1.Base_dmg += Base_dmg_up;
            p1.Base_def += Base_def_up;
            p1.Mp_atual -= Custo_mp;
            return Skill_dmg;
        }
    }

}

