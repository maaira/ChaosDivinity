using ChaosDivinity.Char;
using ChaosDivinity.Managers;
using ChaosDivinity.Physics;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChaosDivinity.VisualGame.Maps
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class City : Page
    {
        private HeroMovement movement;
        private Hero hero;

        public City()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is Hero)
            {
                hero = (Hero)e.Parameter;
                Debug.WriteLine(hero.Nome);
            }

            base.OnNavigatedTo(e);
        }



        private void Init(Windows.UI.Xaml.FrameworkElement sender, object args)
        {

            MapManager.InitPerso(Perso, hero);

            MapManager.InitMapMove(Perso, Tela, movement, hero);
        }
    }
}
