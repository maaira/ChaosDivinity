using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace ChaosDivinity.Char
{
    public class Enemies : Character
    {
        public string Path_def { get; set; }
        public string Path_attack { get; set; }
        public int Attack { get; set; }
        public int Def { get; set; }
        public bool InBattle { get; set; }

        public bool InMod { get; set; }

        public Dictionary<int, Skill> ListofSkill { get; set; }

        public Enemies(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl, int attack, int def) : base(nomeChar, hp_atual, hp_total, mp_atual, mp_total, lvl)
        {
            this.Def = def;
            this.Attack = attack;
            ListofSkill = new Dictionary<int, Skill>();
        }

        public override void DisturbedEvent(PhysicObject sender, PhysicObject p)
        {
            sender.InMoment.NegMoment();
            sender.InBattle = true;
            p.InBattle = true;
            p.InMoment.NegMoment();
            p.InBattle = true;
            
        }

    }
}
