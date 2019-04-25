using ChaosDivinity.Char;
using ChaosDivinity.Interface;
using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


namespace ChaosDivinity.Managers
{
    class MapManager
    {

        public static void InitPerso(Canvas Perso, Hero hero)
        {
            Image img = new Image();
            BitmapImage bitmapImage = new BitmapImage();
            img.Width = bitmapImage.DecodePixelWidth = 70;
            if (hero == null)
            {
                Debug.WriteLine("Turury");
                bitmapImage.UriSource = new Uri(hero.StopLeft);
            }
            else if (hero.ClassGroup == Classification.Perso.Rogue)
            {
                Debug.WriteLine("Turury");
                bitmapImage.UriSource = new Uri(hero.StopLeft);
            }
            else if (hero.ClassGroup == Classification.Perso.Warrior)
            {
                Debug.WriteLine("Turury");
                bitmapImage.UriSource = new Uri(hero.StopLeft);
            }
            else if (hero.ClassGroup == Classification.Perso.Mage)
            {
                Debug.WriteLine("Turury");
                bitmapImage.UriSource = new Uri(hero.StopLeft);
            }


            img.Source = bitmapImage;
            Perso.Children.Add(img);

        }

        public static void InitMapMove(Canvas Perso, Canvas Tela, HeroMovement hero, Hero h)
        {
            hero = new HeroMovement(Perso, Tela, h);
        }
    }
}
