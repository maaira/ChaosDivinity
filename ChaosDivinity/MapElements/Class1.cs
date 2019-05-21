using ChaosDivinity.Assets;
using ChaosDivinity.Inventory;
using ChaosDivinity.MapObjects;
using ChaosDivinity.NPCNamespace;
using ChaosDivinity.Physics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace ChaosDivinity.MapElements
{
    class FlyoutManager : Flyout
    {
        
        public static void SetFlyout(PhysicObject p)
        {
            
            if(p is Chest)
            {
                Chest physic_container = (Chest)p;
                MenuFlyout n = new MenuFlyout();
                Canvas m = new Canvas();
                m.Children.Add(ImageView.ImageSet(physic_container.Path));
                n.SetValue(Flyout.ContentProperty, physic_container);
                FlyoutBase.SetAttachedFlyout(physic_container.Container, n );
            }
            else if(p is BackPack)
            {

            }
            else
            {
                var physic_container = (NPC)p;
            }
        }


    }
}
