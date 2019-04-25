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

            Warrior w = new Warrior("Ayddra", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Classification.Perso.Warrior);

            this.Frame.Navigate(typeof(City), w);

            // song.Source = MediaSource.CreateFromUri(new Uri(""));
            // song.Play();
        }

        private void InitMage(object sender, RoutedEventArgs e)
        {

            Mage m = new Mage("Ayddra", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Classification.Perso.Mage);
            this.Frame.Navigate(typeof(City), m);

        }

        private void InitRogue(object sender, RoutedEventArgs e)
        {
            Rogue r = new Rogue("Ayddra", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Classification.Perso.Rogue);
            this.Frame.Navigate(typeof(City), r);

            //song.Source = MediaSource.CreateFromUri(new Uri(""));
            //song.Play();
        }
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuHome));

            //song.Source = MediaSource.CreateFromUri(new Uri(""));
            //song.Play();
        }
    }
}
