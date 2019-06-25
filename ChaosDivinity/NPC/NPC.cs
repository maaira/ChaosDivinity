﻿using ChaosDivinity.Physics;

namespace ChaosDivinity.NPCNamespace
{

    public enum TypeNPC { NPCTrader, NPCTalk };

    class NPC : PhysicObject, IActions
    {
        public string Name { get; set; }
        public uint IDNpc { get; set; }
        public string Description { get; set; }
        public TypeNPC TPN { get; set; }

        public NPC(uint ID, string Name, TypeNPC Type)
        {
            this.Name = Name;
            this.IDNpc = ID;
            this.TPN = Type;
        }

        public void NPCAction()
        {
            switch (this.TPN)
            {
                case TypeNPC.NPCTrader:

                    break;

                case TypeNPC.NPCTalk:
                    //
                    break;
            }
        }

        public void Trade(TypeNPC TP)
        {
            //
        }

        public void Conversation(TypeNPC TP)
        {
            //
        }
    }

    class MyFunction //dar as funções ao NPCs
    {

    }

    public interface IActions //ações que os NPCs vão fazer
    {
        void Trade(TypeNPC TP);
        void Conversation(TypeNPC TP);
    }

}
