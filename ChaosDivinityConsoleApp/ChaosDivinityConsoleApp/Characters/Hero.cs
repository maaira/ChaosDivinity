using ChaosDivinity.Inventory;
using ChaosDivinity.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Char
{
    public class Hero : Character
    {
        protected BackPack mochila;
        protected int draquimas;
        protected int xp_atual, xp_total;
        protected List<Skill> listOfSkills;
        protected Equipped armo;


        protected int power;
        protected int agility;
        protected int intelligence;
        protected int sort;
        protected int vitality;


        public BackPack BackPack { get => mochila; }        
        public int Draquimas { get => draquimas; set => draquimas = value; }
        public int Xp_atual { get => xp_atual; set => xp_atual = value; }
        public int Xp_total { get => xp_total; set => xp_total = value; }
        public List<Skill> ListofSkill { get => listOfSkills; }
        

        public int Power { get => power; set => power = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Sort { get => sort; set => sort = value; }
        public int Vitality { get => vitality; set => vitality = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }




        public Hero(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int dmg , int lvl , int power , int agility , int sort, int intelligence, int vitality) : base(nomeChar, hp_atual, hp_total, mp_total, mp_atual, dmg, lvl)
        {
            this.power = power;
            this.agility = agility;
            this.sort = sort;
            this.intelligence = intelligence;
            this.vitality = vitality;
        }

        //Verifica se o ganho de experiência fez o personagem passar de level
        public bool IsLvUP()
        {
            if (Xp_atual >= Xp_total)
            {
                return true; //Passou de level
            }
            else
            {
                return false; // Não passou de level
            }
        }

        // Virtual para poder realizar override
        public virtual void LvUp()
        {
            Lvl++;
            xp_atual = xp_atual - xp_total;
            Xp_total *= 2;
            hp_atual = Hp_total;
            mp_atual = Mp_total;
            if (IsLvUP() == true)
            {
                LvUp(); //Função recursiva para caso ganhe experiência suficiente para passar mais de uma vez de level
            }
        }


        //Realiza o aumento de experiência
        public void Gain_xp(int xp_gain)
        {
            Xp_atual += xp_gain;
            if (IsLvUP() == true)
            {
                LvUp();
            }
        }

        //Verifica se tem mana o suficiente para usar a habilidade
        public bool IsManaAvaliable(int custo_de_mana)
        {
            if (Mp_atual >= custo_de_mana)
            {
                return true; // Pode usar a habilidade
            }
            else
            {
                return false; //Não pode usar a habilidade
            }
        }

        //Verifica se o personagem está vivo
        public bool IsAlive()
        {
            if (Hp_atual > 0)
            {
                return true; // Está vivo
            }
            else
            {
                return false; // Morreu
            }
        }
        /*
        //Calcula o dano com base nos items equipados
        public int Atk_base()
        {
            int damage_add = 0;
            foreach ( i in mochila.InventoryOfBackPack)
            {
                if (i != null)
                {
                    if (i == true)
                    {
                        damage_add += i.Dmg;
                    }
                }
            }
            return Base_dmg + damage_add;
        }

        //Verifica se o golpe passa da defesa e modifica o HP
        public bool Take_dmg(int dmg)
        {
            if (dmg > Base_def)
            {
                Hp_atual -= dmg;
                return true;
            }
            else
            {
                return false;
            }
        }
        */

    }
}
