
using ChaosDivinity.Char;
using ChaosDivinity.Interface;
using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ChaosDivinity.Manager
{
    class PersoManager
    {
        public static void AddPersoToMap(Hero hero, Canvas Perso, List<PhysicObject> p)
        {
            Image img = new Image();
            BitmapImage bitmapImage = new BitmapImage();
            img.Width = bitmapImage.DecodePixelWidth = 70;

            if (hero != null)
            {
                try
                {

                    bitmapImage.UriSource = new Uri(hero.StopLeft);

                }
                catch (UriFormatException e)
                {
                    
                    Debug.WriteLine(e.Source);
                    Debug.WriteLine(e.Message);

                }
                
            }
            
            img.Source = bitmapImage;
            hero.Container = Perso;
            Perso.Children.Add(img);
            if(hero!=null)p.Add(hero);
            
            
        }
    }
}
