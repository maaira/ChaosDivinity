using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.NPCNamespace
{
    class NPCFlyout
    {
        public DependencyObject FavoritesBar { get; private set; }

        private void Folder2_Click(object sender, RoutedEventArgs e)
        {
            Flyout flyout = new Flyout();
            flyout.OverlayInputPassThroughElement = FavoritesBar;
            //
            flyout.ShowAt(sender as FrameworkElement);
            {

            }
        }
    }
}
