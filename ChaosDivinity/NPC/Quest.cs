using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaosDivinity.Char;

namespace ChaosDivinity.NPC
{
    public abstract class Quest
    {
        public uint ID { get; set; }//ID (identificador) para ativar/desativar a quest
        public string name { get; set; }//nome da quest
        public string Description { get; set; }//descrição da quest
        public int QuestProgress { get; set; }//progresso da quest
        public int XPQuest { get; set; }//EXP ganho
        public int MoneyQuest { get; set; }//Dinheiro ganho
        public bool Verification { get; set; }//está completa sim ou não

        //construtor
        public Quest(string name)
        {
            this.name = name;
        }

        //Informa se a quest foi completada retornando um true
        public void CompleteVerificarionQuest()
        {
            this.Verification = true;
        }
    }



    //Quest de contagens (CRÉDITO: COMUNA <3)
    public class TypeCountQuest : Quest
    {
        public int IDEntity { get; set; } //Identificador
        public int CountForEntity { get; set; } //Quantos você tem (contador)
        public int QuantityRequestedEntity { get; set; } //quantos foram solicitados

        //Construtor
        public TypeCountQuest(string name, int entityCount, int entityRequest) : base(name)
        {
            this.CountForEntity = entityCount;
            this.QuantityRequestedEntity = entityRequest;
        }

        //Adicionar mais um na quantidade da entidade contadora
        public void AddRequestedEntity()
        {
            CountForEntity++;
        }

        //Realiza as contagem e completa a quest
        public void CounterActionCompleteQuest(int entityUniversalID)
        {
            if(entityUniversalID == IDEntity)
            {
                if(CountForEntity == QuantityRequestedEntity)
                {
                    CompleteVerificarionQuest();
                }
                else
                {
                    AddRequestedEntity();
                }
            }
        }
    }



    //Quest de conversação
    public class ConversationQuest : Quest
    {
        public int NpcQuestID { get; set; }

        public ConversationQuest(string name, int NpcRequestID) : base(name)
        {
            this.NpcQuestID = NpcRequestID;
        }

        public void TalkNpcComplet(int NpcGenericId)
        {
            if(NpcGenericId == NpcQuestID)
            {
                CompleteVerificarionQuest();
            }
        }

    }



    //Quest de conversação com entrega
    public class ConversationDelivery : Quest
    {
        public int NpcQuestID { get; set; }
        public int ItemQuestId { get; set; }
        public int QuantityRequestedItem { get; set; }

        public ConversationDelivery(string name, int NpcIdRequested, int itemRequested, int itemQuantityRequested) : base(name)
        {
            this.NpcQuestID = NpcIdRequested;
            this.ItemQuestId = itemRequested;
            this.QuantityRequestedItem = itemQuantityRequested;
        }

        public bool VerificationTalkNpc(int NpcGenericId)
        {
            if (NpcGenericId == NpcQuestID)
            {
                CompleteVerificarionQuest();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TalkDeliveryNpcComplet(int NpcGenericId, int ItemGenericId, int QuantityItemGeneric)
        {
            if (VerificationTalkNpc(NpcGenericId))
            {
                if(ItemGenericId == ItemQuestId && QuantityItemGeneric == QuantityRequestedItem)
                {
                    CompleteVerificarionQuest();
                }
            }
            
        }

    }

}