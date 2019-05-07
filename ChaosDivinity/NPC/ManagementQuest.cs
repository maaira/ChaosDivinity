using ChaosDivinity.Char;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.NPCNamespace
{
    class ManagementQuest
    {
        public List<Quest> startedQuest = new List<Quest>(); //Lista de missões startadas (para realizar)
        public List<Quest> finishedQuest = new List<Quest>(); //Lista de missões realizadas (finalizadas)
        public int numQuestCaught { get; set; } //Para auxiliar na hora de tirar e colcoar missão (OBS: VARIÁVEL NÃO OFICIAL, VAI SER EXCLUÍDA DPS, FOI CRIADA PARA TESTE)
        public int numQuestDelivered { get; set; } //Para auxiliar na hora de tirar e colcoar missão (OBS: VARIÁVEL NÃO OFICIAL, VAI SER EXCLUÍDA DPS, FOI CRIADA PARA TESTE)
        public int numQuestActive { get; set; }
        private Hero hero;

        public ManagementQuest(Hero hr)
        {
            numQuestCaught = 0; //Çomeçamos com 0 Quest Pegas
            numQuestDelivered = 0; //Çomeçamos com 0 Quest Entregues
            numQuestActive = 0;//Começamos com 0 missões
            this.hero = hr;
        }

        //Adicionar uma quest ao personagem
        public void AddNewQuest(Quest q)
        {
            startedQuest.Add(q);
            numQuestCaught++;
            numQuestActive++;
        }

        //APENAS verificar se a quest foi completa

        public bool VerificationQuestComplete(Quest q)
        {
            if (q.Verification)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Recompensa da quest para o Personagem
        public void ReceiveRewards(Quest q)
        {
            if (VerificationQuestComplete(q))
            {
                hero.Gain_xp(q.XPQuest);
                hero.Draquimas += q.MoneyQuest;
            }
        }

        //Verificar se a quest foi completa e faz -> ação necessária = ENTREGA A QUEST <-
        public void DeliveryQuest(Quest q)
        {
            if (VerificationQuestComplete(q))
            {
                startedQuest.Remove(q);
                finishedQuest.Add(q);
                numQuestDelivered++;
                numQuestActive--;
                ReceiveRewards(q);
            }
            else
            {
                Debug.WriteLine("Se fudeu");
            }
        }

    }
}
