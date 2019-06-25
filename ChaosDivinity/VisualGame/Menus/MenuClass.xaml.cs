using ChaosDivinity.Char;
using ChaosDivinity.Interface;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ChaosDivinity.VisualGame.Maps;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ChaosDivinity.VisualGame.Menu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuClass : Page
    {
        public MenuClass()
        {
            this.InitializeComponent();
        }

        private void InitWarrior(object sender, RoutedEventArgs e)
        {

            Warrior w = new Warrior("Ayddra", 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, Classification.Perso.Warrior)
            {
                Path = "ms-appx:///Assets/Mage/MageStopLeft.gif"
            };

            this.Frame.Navigate(typeof(City), w);

        }

        private void InitMage(object sender, RoutedEventArgs e)
        {

            Mage m = new Mage("Ayddra", 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, Classification.Perso.Mage)
            {
                Path = "ms-appx:///Assets/Mage/MageStopLeft.gif"
            };
            this.Frame.Navigate(typeof(City), m);

        }

        private void InitRogue(object sender, RoutedEventArgs e)
        {
            Rogue r = new Rogue("Ayddra", 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, Classification.Perso.Rogue)
            {
                Path = "ms-appx:///Assets/Mage/MageStopLeft.gif"
            };
            this.Frame.Navigate(typeof(City), r);

        }
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuHome));

        }
    }
}
