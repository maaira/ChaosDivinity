using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.NPCNamespace
{
    class QuestList
    {
        public static Dictionary<uint, Quest> allQuests;

        //A função que contém a lista das quest e os carrega no início do jogo
        public static void LoadQuestList()
        {
            allQuests = new Dictionary<uint, Quest>();
            Quest sla = new ConversationQuest("Sajhsajsja",0);
            //oi
            allQuests.Add(1, sla);
        }

        

    }
}
