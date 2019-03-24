
using ChaosDivinity.Item;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChaosDivinity
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Equipment p, p2, p3, p1;
        public MainPage()
        {
            
            this.InitializeComponent();
            Window.Current.Content.KeyDown += EventFunc;
            p = new Equipment("Rolinha", "", 10, 10, false, "", "", "", 0, 0, "");
            p1 = new Equipment("Rolinha Grande", "", 10, 10, false, "", "", "", 0, 0, "");
            p2 = new Equipment("Rolinha Pequena", "", 10, 10, false, "", "", "", 0, 0,"");
            p3 = new Equipment("Rolinha dos Seus Sonhos", "", 10, 10, false, "", "", "", 0, 0,"");
        }

        public void EventFunc(object sender, KeyRoutedEventArgs e)
        {
            double PersoY = (double)Perso.GetValue(Canvas.TopProperty);
            double PersoX = (double)Perso.GetValue(Canvas.LeftProperty);
            if (e.Key == Windows.System.VirtualKey.A)
            {
                boli.Text = p.Name;

                Perso.SetValue(Canvas.LeftProperty, PersoX - 8);
            }
            if (e.Key == Windows.System.VirtualKey.D)
            {
                boli.Text = p1.Name;
                Perso.SetValue(Canvas.LeftProperty, PersoX + 8);
            }
            if (e.Key == Windows.System.VirtualKey.W)
            {
                boli.Text = p2.Name;
                Perso.SetValue(Canvas.TopProperty, PersoY - 8);
            }
            if (e.Key == Windows.System.VirtualKey.S)
            {
                boli.Text = p3.Name;
                Perso.SetValue(Canvas.TopProperty, PersoY + 8);
            }
        }
    }

}
