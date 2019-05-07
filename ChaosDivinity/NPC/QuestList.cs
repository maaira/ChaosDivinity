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
            //Bacon esteve aqui
            allQuests = new Dictionary<uint, Quest>();
            Quest First_Quest = new ConversationQuest("First Quest",1);
            
            allQuests.Add(1, First_Quest);
        }

        //Realiza a procura da quest no dicionario a partir do ID
        public static Quest SearchQuest(uint QuestIDRequested)
        {
            if (allQuests.ContainsKey(QuestIDRequested) == true)
            {
                return allQuests[QuestIDRequested];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }


    }
}
