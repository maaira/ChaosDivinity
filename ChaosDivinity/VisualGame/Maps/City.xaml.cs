using ChaosDivinity.Char;
using ChaosDivinity.Managers;
using ChaosDivinity.NPCNamespace;
using ChaosDivinity.Physics;
using System.Diagnostics;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;


namespace ChaosDivinity.VisualGame.Maps
{
    public sealed partial class City : Page
    {
        private Hero hero;
        private bool isInventoryOpen;
        private MediaPlayer song = new MediaPlayer();


        public City()
        {
            this.InitializeComponent();
            this.AddEventToShop();
            QuestList.LoadQuestList();
            SetAllMenusReady();
            Window.Current.CoreWindow.KeyDown += KeySentinel;
            song.Source = MediaSource.CreateFromUri(new System.Uri("ms-appx:///Assets/Musicas/City.mp3"));
            song.Play();


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



        private void Init(FrameworkElement sender, object args)
        {
            MapManager m = new MapManager();
            m.Map(hero, Background, Perso, MOB, MOB2, MOB3);

        }

        private void AddEventToShop()
        {
            foreach (UIElement element in ShopGrid.Children)
            {
                if (element is Image)
                {
                    element.PointerPressed += SlotShop;
                }
            }
        }

        private void ClickVerificationNPC()
        {



        }

        private void SlotShop(object sender, PointerRoutedEventArgs e)
        {
            Debug.WriteLine("Imagem clicada : " + ((Image)sender).Name);
        }

        private void ExitInventory(object sender, RoutedEventArgs e)
        {

            Principle.Children.Remove(Inventory);
            isInventoryOpen = false;
        }

        private void SetAllMenusReady()
        {

            Principle.Children.Remove(quick_menu);
            Principle.Children.Add(quick_menu);

            Principle.Children.Remove(Inventory);
            isInventoryOpen = false;

        }

        private void KeySentinel(CoreWindow sender, KeyEventArgs e)
        {
            switch (e.VirtualKey)
            {
                case Windows.System.VirtualKey.I:
                  

                    if (isInventoryOpen) Principle.Children.Remove(Inventory);
                    else Principle.Children.Add(Inventory);

                    isInventoryOpen ^= true;

                    break;
            }
        }


    }
}