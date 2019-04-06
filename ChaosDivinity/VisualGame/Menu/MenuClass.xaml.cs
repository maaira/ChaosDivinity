using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ChaosDivinity;
using Windows.Media.Core;
using static ChaosDivinity.Interface.Classification;
using Windows.UI.ViewManagement;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace ChaosDivinity.VisualGame.Menu
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MenuClass : Page
    {
        public MenuClass()
        {

            this.InitializeComponent();
        }
        private void IniciarGladiador(object sender, RoutedEventArgs e)
        {

            Perso w = new Perso();

            this.Frame.Navigate(typeof(MainPage), w);

           // song.Source = MediaSource.CreateFromUri(new Uri(""));
           // song.Play();
        }

        private void IniciarMago(object sender, RoutedEventArgs e)
        {

            Perso m = new Perso();
            this.Frame.Navigate(typeof(MainPage), m);

            //song.Source = MediaSource.CreateFromUri(new Uri(""));
           // song.Play();
        }

        private void IniciarLadina(object sender, RoutedEventArgs e)
        {

            Perso r = new Perso();
            this.Frame.Navigate(typeof(MainPage), r);

            //song.Source = MediaSource.CreateFromUri(new Uri(""));
            //song.Play();
        }
        private void Retornar(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuHome));

            //song.Source = MediaSource.CreateFromUri(new Uri(""));
            //song.Play();
        }
    }
}
