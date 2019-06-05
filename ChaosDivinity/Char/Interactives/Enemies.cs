
using ChaosDivinity.Interface;
using ChaosDivinity.Physics;

namespace ChaosDivinity.Char
{
    public class Enemies : Hero
    {
        public Enemies(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl, int power, int agility, int sort, int intelligence, int vitality, Classification.Perso classGroup) : base(nomeChar, hp_atual, hp_total, mp_atual, mp_total, lvl, power, agility, sort, intelligence, vitality, classGroup)
        {
            
        }

        public object Frame { get; private set; }

        public override void DisturbedEvent(PhysicObject sender, PhysicObject p)
        {
            if (sender is Hero && p is Enemies)
            {
                
            }
        }
    }
}
