using ChaosDivinity.Inventory;
using ChaosDivinity.Item;
using System.Collections.Generic;
using ChaosDivinity.Interface;
using ChaosDivinity.Physics;
using System;
using ChaosDivinity.PhysicCollision;

namespace ChaosDivinity.Char
{
    public abstract class Hero : Character
    {
        protected BackPack mochila = new BackPack();
        protected int draquimas = 500;
        protected List<Skill> listOfSkills;
        protected EquippedSlot[] Armo { get; set; }

        public BackPack BackPack { get; }
        public int Draquimas { get => draquimas; set => draquimas = value; }
        public float Xp_atual { get; set; }
        public float Xp_total { get; set; }
        public List<Skill> ListofSkill { get; }

        public int Power { get; set; }
        public int Agility { get; set; }
        public int Sort { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }
        public Classification.Perso ClassGroup { get; }

        public string MoveToRight { get; set; }
        public string MoveToLeft { get; set; }
        //protected string MoveUp { get; set; }
        //protected string MoveDown { get; set; }
        public string StopLeft { get; set; }
        public string StopRight { get; set; }

        

        public Hero(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl, int power, int agility, int sort, int intelligence, int vitality, Classification.Perso classGroup) : base(nomeChar, hp_atual, hp_total, mp_total, mp_atual, lvl)
        {
            this.Power = power;
            this.Agility = agility;
            this.Sort = sort;
            this.Intelligence = intelligence;
            this.Vitality = vitality;
            this.ClassGroup = classGroup;
            
            ArmoInit();
        }

        private void ArmoInit()
        {
            this.Armo = new EquippedSlot[4];
            this.Armo[0] = new EquippedSlot(Classification.TypeOf.Armo, this);
            this.Armo[1] = new EquippedSlot(Classification.TypeOf.Acessorio, this);
            this.Armo[2] = new EquippedSlot(Classification.TypeOf.Acessorio, this);
            this.Armo[3] = new EquippedSlot(Classification.TypeOf.Acessorio, this);
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
            Xp_atual = Xp_atual - Xp_total;
            Xp_total *= (float)1.5;
            hp_atual = Hp_total;
            mp_atual = Mp_total;
            if (IsLvUP() == true)
            {
                LvUp(); //Função recursiva para caso ganhe experiência suficiente para passar mais de uma vez de level
            }
        }

        public void InteractionEvent(PhysicObject sender, EventArgs p)
        {

        }

        public override void CollisionEvent(PhysicObject sender, EventArgs p)
        {
            PhysicObject obj = (PhysicObject)sender;
            //Debug.WriteLine("Here");
            obj.CollisionUp.UpdateColisions();
        }

        public override void SetPhysics(List<PhysicObject> _worldlist)
        {
            CollisionUp = new Collision(_worldlist, this);
            StartCollisionManager += new CollisionHandleEvent(CollisionEvent);
        }

        public bool AddtemToEquip(Equipment item)
        {

            foreach (EquippedSlot x in Armo)
            {
                if (x.Type == item.Category
                    && x.Equip == null)
                {
                    x.EquipItem(item);
                    return true;
                }
                if (x.Type == item.Category)
                {
                    x.EquipItem(item);
                    return true;
                }
            }
            return false;
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
        

        public bool Equip()
        {
            return false;
        }

    }
}
