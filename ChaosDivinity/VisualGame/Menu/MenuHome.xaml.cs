using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ChaosDivinity.VisualGame.Menu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuHome : Page
    {
        private MediaPlayer song = new MediaPlayer();

        public MenuHome()
        {
            this.InitializeComponent();
        }

        
        
        private void Sair(object sender, RoutedEventArgs e)
        {
            song.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Musicas/ClickSound.mp3"));
            song.Play();

            CoreApplication.Exit();
        }

        private void Iniciar(object sender, RoutedEventArgs e)
        {
            song.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Musicas/ClickSound.mp3"));
            song.Play();
            this.Frame.Navigate(typeof(MenuClass));
        }
    }
}
