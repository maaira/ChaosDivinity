using ChaosDivinity.Assets;
using ChaosDivinity.Inventory;
using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace ChaosDivinity.MapObjects
{
    public class Chest : PhysicObject
    {
        public Flyout Fl { get; set; }
        public InventorySlot Item;

        public Chest()
        {
            Fl = new Flyout();
        }
        public InventorySlot RandomPremium(Dictionary<int, InventorySlot> p)
        {
            int max = 10, mim = 1;
            Random rnd = new Random();
            int id_random = rnd.Next(mim, max);
            if (p[id_random] == null) return p[1];
            else return p[id_random];
        }

        public override void DisturbedEvent(PhysicObject sender, PhysicObject p)
        {

            StackPanel s = new StackPanel();
            s.Children.Add(ImageView.ImageSet(Item.Path));
            TextBlock t = new TextBlock()
            {
                Text = "Click E to add to you inventory",
            };
            s.Children.Add(t);
            Fl.Content = s;
            FlyoutBase.SetAttachedFlyout(p.Container, Fl);
            FlyoutBase.ShowAttachedFlyout(p.Container);


        }

    }
}
