using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.NPC
{
    class NPC:IActions
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
                case TypeNPC.NPCShop:
                    //
                    break;

                case TypeNPC.NPCTalk:
                    //
                    break;
            }
        }

        public void Shop(TypeNPC TP)
        {
          //
        }

        public void Conversation(TypeNPC TP)
        {
            //
        }
    }

    public enum TypeNPC{ NPCShop, NPCTalk };

    class Function //dar as funções ao NPCs
    {

    }

    public interface IActions //ações que os NPCs vão fazer
    {
        void Shop(TypeNPC TP);
        void Conversation(TypeNPC TP);
    }


}
