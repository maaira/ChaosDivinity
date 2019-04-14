
using ChaosDivinity.Item;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.System.Threading;
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
using ChaosDivinity.Char;

namespace ChaosDivinity
{

    public sealed partial class MainPage : Page
    {
        internal static object instance;
        HeroMovement hero;

        public MainPage()
        {
            this.InitializeComponent();
            //TelaY = (double)Tela.GetValue(Canvas.TopProperty);
            //TelaX = (double)Tela.GetValue(Canvas.LeftProperty);       
            hero = new HeroMovement(Perso, Tela);
        }

    }

}
