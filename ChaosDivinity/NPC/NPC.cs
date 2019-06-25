using ChaosDivinity.Physics;
using ChaosDivinity.Char;
using System.Collections.Generic;
using ChaosDivinity.Inventory;

namespace ChaosDivinity.NPCNamespace
{

    public enum TypeNPC { NPCTrader = 1, NPCQuester = 2 };

    public class NPC : PhysicObject
    {
        public string Name { get; set; }
        public uint IDNpc { get; set; }
        public string Description { get; set; }
        public TypeNPC TPN { get; set; }
        //InObject == null -> Dentro do PhysicObject
        public Dictionary<int, InventorySlot> BagShop;

        public NPC(uint ID, string Name, TypeNPC Type)
        {
            this.Name = Name;
            this.IDNpc = ID;
            this.TPN = Type;
        }

        public override void InInteraction(PhysicObject intetacted)
        {
            return;
        }
    }

    public interface IActions //ações que os NPCs vão fazer
    {
        void StartFunction();
        void EndFunction();
        string TypeNpc();
    }


    //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* NPC de Negociação *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
    public sealed class Trader : IActions
    {

        public void StartFunction()
        {
            throw new System.NotImplementedException();
        }

        public void EndFunction()
        {
            throw new System.NotImplementedException();
        }

        public string TypeNpc()
        {
            return "Trader";
        }

    }

    //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* NPC de Quest *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
    public sealed class Quester : IActions
    {

        public void StartFunction()
        {
            throw new System.NotImplementedException();
        }

        public void EndFunction()
        {
            throw new System.NotImplementedException();
        }

        public string TypeNpc()
        {
            return "Quester";
        }

    }

}
