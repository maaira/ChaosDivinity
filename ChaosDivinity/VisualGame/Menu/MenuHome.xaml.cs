using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



namespace ChaosDivinity.VisualGame.Menu
{
   
    public sealed partial class MenuHome : Page
    {
        

        public MenuHome ()
        {
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            

            this.InitializeComponent();
        }
        private void Sair(object sender, RoutedEventArgs e)
        {

            //song.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/sound"));
            //song.Play();

            CoreApplication.Exit();
        }

        private void Iniciar(object sender, RoutedEventArgs e)
        {

            //song.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/sound"));
            //song.Play();

            this.Frame.Navigate(typeof(MenuClass));
        }
    }
}
