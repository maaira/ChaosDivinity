using ChaosDivinity.Assets;
using ChaosDivinity.Inventory;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.MapObjects
{
    class FlyoutManager
    {
        public void SetFlyout(Chest p)
        {
            Flyout.SetAttachedFlyout(ImageView.ImageSet(p.Item.Path), p.Fl);
            
        }
        public void SetFlyout(InventorySlot p)
        {
            Flyout f = new Flyout();
            Flyout.SetAttachedFlyout(ImageView.ImageSet(p.Path), f);
        }
    }
}
