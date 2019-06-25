using System;


namespace ChaosDivinity.Char
{

    public class Skill
    {
        public string Skill_name { get; set; }
        public int Custo_mp { get; set; }
        public int Lv_requerido { get; set; }
        public int Hp_up { get; set; }
        public int Mp_up { get; set; }
        public int Skill_dmg { get; set; }

        public Character Heroi { get; set; }

        public Skill(String skill_name, int custo_mp, int lv_requerido, int hp_up, int mp_up, int skill_dmg, Character c)
        {
            this.Custo_mp = custo_mp;
            this.Hp_up = hp_up;
            this.Mp_up = mp_up;
            this.Lv_requerido = lv_requerido;
            this.Skill_dmg = skill_dmg;
            this.Skill_name = skill_name;
            this.Heroi = c;
        }

        
        public int Executar()
        {
            if (Heroi.GetType() == typeof(Enemies))
            {
                if (Heroi.Mp_atual + Mp_up > Heroi.Mp_total) Heroi.Mp_atual = Heroi.Mp_total;
                else Heroi.Mp_atual += Mp_up;
                if (Heroi.Hp_atual + Hp_up > Heroi.Hp_total) Heroi.Hp_atual = Heroi.Hp_total;
                else Heroi.Hp_atual += Hp_up;
                Heroi.Mp_atual -= Custo_mp;
                return Skill_dmg;
            }
            if (Heroi.GetType() == typeof(Hero) && ((Hero)Heroi).IsManaAvaliable(Custo_mp) == false)
            {
                return -1; //Código para quando o jogador não tiver mana para a skill
            }
            else if (((Hero)Heroi).Lvl < Lv_requerido)
            {
                return -2; //Código para quando o jogador não tiver level para usar a skill
            }
            else
            {
                if (Heroi.Mp_atual + Mp_up > Heroi.Mp_total) Heroi.Mp_atual = Heroi.Mp_total;
                else Heroi.Mp_atual += Mp_up;
                if (Heroi.Hp_atual + Hp_up > Heroi.Hp_total) Heroi.Hp_atual = Heroi.Hp_total;
                else Heroi.Hp_atual += Hp_up;
                Heroi.Mp_atual -= Custo_mp;
                return Skill_dmg;
            }
            

        }
    }

}

