using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Char
{
    abstract class Character
    {
        //public double skilllenght;
        //public double atacklenght;
        private string nameChar;
        private int cash;
        private int hp_atual, hp_total;
        private int mp_atual, mp_total;
        private int xp_atual, xp_total, lvl;
        private int base_dmg, base_def;
        private string nameClass;
        private List<Skill> skills;
        private List<Itens> inventario = new List<Itens>();


        public string Nome { get => nome; set => nome = value; }
        public int Cash {get => cash; set => value; }
        public int Hp_atual { get => hp_atual; set => hp_atual = value; }
        public int Hp_total { get => hp_total; set => hp_total = value; }
        public int Mp_atual { get => mp_atual; set => mp_atual = value; }
        public int Mp_total { get => mp_total; set => mp_total = value; }
        public int Xp_atual { get => xp_atual; set => xp_atual = value; }
        public int Xp_total { get => xp_total; set => xp_total = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int Base_dmg { get => base_dmg; set => base_dmg = value; }
        public int Base_def { get => base_def; set => base_def = value; }

        //Verifica se o ganho de experiência fez o personagem passar de level
        public bool IsLvUP() {
            if (Xp_atual >= Xp_total) {
                return true; //Passou de level
            }
            else {
                return false; // Não passou de level
            }
        }

        // Virtual para poder realizar override
        public virtual void LvUp() {
            Lvl++;
            xp_atual = xp_atual - xp_total;
            Xp_total *= 2;
            hp_atual = Hp_total;
            mp_atual = Mp_total;
            if (IsLvUP() == true) {
                LvUp(); //Função recursiva para caso ganhe experiência suficiente para passar mais de uma vez de level
            }
        }

        //Realiza o aumento de experiência
        public void Gain_xp(int xp_gain) {
            Xp_atual += xp_gain;
            if (IsLvUP() == true) {
                LvUp();
            }
        }

        //Verifica se tem mana o suficiente para usar a habilidade
        public bool IsManaAvaliable(int custo_de_mana) {
            if (Mp_atual >= custo_de_mana) {
                return true; // Pode usar a habilidade
            }
            else {
                return false; //Não pode usar a habilidade
            }
        }

        //Verifica se o personagem está vivo
        public bool IsAlive() {
            if (Hp_atual > 0) {
                return true; // Está vivo
            }
            else {
                return false; // Morreu
            }
        }

        //Calcula o dano com base nos items equipados
        public int Atk_base() {
            int damage_add = 0;
            foreach (Itens i in Inventario) {
                if (i != null) {
                    if (i.Equipado == true) {
                        damage_add += i.Dmg;
                    }
                }
            }
            return Base_dmg + damage_add;
        }

        //Verifica se o golpe passa da defesa e modifica o HP
        public bool Take_dmg(int dmg) {
            if (dmg > Base_def) {
                Hp_atual -= dmg;
                return true;
            }
            else {
                return false;
            }
        }


    }
}
