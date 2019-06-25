using ChaosDivinity.Interface;
using ChaosDivinity.Physics;
using System.Collections.Generic;

namespace ChaosDivinity.Char
{
    public class Enemies : Hero
    {
        public int Power { get; set; }
        public int Agility { get; set; }
        public int Sort { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }
        public Classification.Perso ClassGroup { get; }

        public string Path_Attack { get; set; }
        public string Path_Def { get; set; }
        public string Path_Standard { get; set; }
        public string Path_Esp { get; set; }

        public Dictionary<int, Skill> ListOfISkill;

        public Enemies(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl, int power, int agility, int sort, int intelligence, int vitality, Classification.Perso classGroup) : base(nomeChar, hp_atual, hp_total, mp_atual, mp_total, lvl, power, agility, sort, intelligence, vitality, classGroup)
        {
            this.Power = power;
            this.Agility = agility;
            this.Sort = sort;
            this.Intelligence = intelligence;
            this.Vitality = vitality;
            this.ClassGroup = classGroup;
                        
        }

        public override void OnDisturberd(PhysicObject p, PhysicObject obj)
        {
            InterationEvent?.DynamicInvoke(obj, p);
        }

        public override void DisturbedEvent(PhysicObject sender, PhysicObject p)
        {
            if(sender is Hero && p is Enemies)
            {
                sender.StartMovingProcess.UpdateMovement.Suspend();
                
            }
        }

        public override void SetRadius()
        {
            if (Container == null) return;
            this.Radius = (Container.Width / 2 + Container.Height / 2)*3;
        }

        
        public void Attack()
        {
            
        }


    }
}
