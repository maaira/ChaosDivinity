using ChaosDivinity.Physics;
using ChaosDivinity.Char;
using System.Collections.Generic;
using ChaosDivinity.Inventory;
using Windows.UI.Xaml.Controls;
using ChaosDivinity.Assets;
using Windows.UI.Xaml.Controls.Primitives;
using ChaosDivinity.NPCNamespace;

namespace ChaosDivinity
{

    public enum TypeNPC { NPCTrader = 1, NPCQuester = 2 };
  

    public class NPC : PhysicObject
    {
        public ListItemShopDB ListShop;
        public Flyout Flt { get; set; }
        public string Name { get; set; }
        public uint IDNpc { get; set; }
        public string Description { get; set; }
        public TypeNPC TPN { get; set; }
        //InObject == null -> Dentro do PhysicObject
        public Dictionary<int, InventorySlot> BagShop;

        public NPC(uint ID, string Name, TypeNPC Type)
        {
            Flt = new Flyout();
            this.Name = Name;
            this.IDNpc = ID;
            this.TPN = Type;
        }

        public override void DisturbedEvent(PhysicObject sender, PhysicObject physicObject)
        {
            StackPanel s = new StackPanel();
           // s.Children.Add(ImageView.ImageSet(ListShop));
            TextBlock t = new TextBlock()
            {
                Text = "Click J to activate the NPC function.",
            };
            s.Children.Add(t);
            Flt.Content = s;
            FlyoutBase.SetAttachedFlyout(sender.Container, Flt);
            FlyoutBase.ShowAttachedFlyout(sender.Container);
            
        }

        //foreach (ListItemShopDB element in ListItemShopDB)
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
