
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
using ChaosDivinity.VisualGame.Menu;

namespace ChaosDivinity
{
    
    public sealed partial class MainPage : Page
    {

        double TelaY = 0;
        double TelaX = 0;

        public MainPage()
        {

            this.InitializeComponent();
             TelaY = (double)Tela.GetValue(Canvas.TopProperty);
             TelaX = (double)Tela.GetValue(Canvas.LeftProperty);       

        }

        
        public void EventFunc(object sender, KeyRoutedEventArgs e)
        {
            double PersoY = (double)Perso.GetValue(Canvas.TopProperty);
            double PersoX = (double)Perso.GetValue(Canvas.LeftProperty);
           
            
            if (e.Key == Windows.System.VirtualKey.A)
            {
                //Perso.SetValue(Canvas.LeftProperty, PersoX - 18);
                TelaX += 8;
                Tela.SetValue(Canvas.LeftProperty,TelaX );
             }
            if (e.Key == Windows.System.VirtualKey.D)
            {
                //Perso.SetValue(Canvas.LeftProperty, PersoX + 18);
                TelaX -= 8;
                Tela.SetValue(Canvas.LeftProperty, TelaX);

            }
            if (e.Key == Windows.System.VirtualKey.W)
            {
                TelaY += 8;
                Tela.SetValue(Canvas.TopProperty, TelaY);
                //Perso.SetValue(Canvas.TopProperty, PersoY - 18);
            }
            if (e.Key == Windows.System.VirtualKey.S)
            {
                TelaY -= 8;
                //Perso.SetValue(Canvas.TopProperty, PersoY + 18);
                Tela.SetValue(Canvas.TopProperty, TelaY);
            }
        }

        
        
    }

}
