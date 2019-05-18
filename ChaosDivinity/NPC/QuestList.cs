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

            Quest First_Quest = new ConversationQuest("First Quest", 1 )
            {
                ID = 1,
                Description = "Pirmeiro Missão do Chaos Divinity",
                XPQuest = 100,
                MoneyQuest = 200,
                Verification = false
            };

            Quest Second_Quest = new ConversationQuest("Second Quest", 2)
            {
                ID = 2,
                Description = "Segunda Missão, compre um equip",
                XPQuest = 100,
                MoneyQuest = 200,
                Verification = false
            };

            Quest Third_Quest = new ConversationQuest("Third Quest", 1)
            {
                ID = 3,
                Description = "Derrote um monstro",
                XPQuest = 100,
                MoneyQuest = 200,
                Verification = false
            };

            Quest Fourth_Quest = new ConversationQuest("Fourth Quest", 1)
            {
                ID = 4,
                Description = "Colete 5 Ossos",
                XPQuest = 100,
                MoneyQuest = 200,
                Verification = false
            };

            Quest Fifth_Quest = new ConversationQuest("Fifth Quest", 1)
            {
                ID = 5,
                Description = "Encontre o NPC Dino",
                XPQuest = 100,
                MoneyQuest = 200,
                Verification = false
            };

            Quest Sixth_Quest = new ConversationQuest("Sixth Quest", 1)
            {
                ID = 1,
                Description = "Mude de mapa 'A Floresta Cabulosamente Nebulosa Sangrenta Trevosa do Deus Bakon <3' ",
                XPQuest = 500,
                MoneyQuest = 1000,
                Verification = false
            }; 

            allQuests.Add(1, First_Quest);
            allQuests.Add(2, Second_Quest);
            allQuests.Add(3, First_Quest);
            allQuests.Add(4, First_Quest);
            allQuests.Add(5, First_Quest);
            allQuests.Add(6, First_Quest);
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
                //Armengue <3
                throw new ArgumentOutOfRangeException();
            }

        }


    }
}
