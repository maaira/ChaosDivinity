using ChaosDivinity.Char;
using ChaosDivinity.Interface;
using ChaosDivinity.Manager;
using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


namespace ChaosDivinity.Managers
{
    class MapManager
    {
        
        private static List<PhysicObject> _worldObject = new List<PhysicObject>();

        public List<PhysicObject> WorldObject { get => _worldObject; set => _worldObject = value; }

        public static void Map(Hero hero, Canvas Tela, Canvas Perso, Canvas MOB)
        {
            
            InitiMob(MOB);
            InitPerso(hero, Tela, Perso);
        }

        public static void InitPerso( Hero hero, Canvas Tela, Canvas Perso)
        {

            PersoManager.AddPersoToMap(hero, Perso, _worldObject);
            InitHeroMove(Tela, hero);
                        
        }

        public static void InitiMob(Canvas MOB)
        {

            NPC p = new NPC("Tururu", 10,10,10,10,10);
            p.Container = MOB;
            Image img = new Image();
            BitmapImage bitmapImage = new BitmapImage();
            img.Width = bitmapImage.DecodePixelWidth = 70;

            try
            {

               bitmapImage.UriSource = new Uri("ms-appx:///Assets/Mage/MageStopLeft.gif");

            }
            catch (UriFormatException e)
            {

                Debug.WriteLine(e.Source);
                Debug.WriteLine(e.Message);

            }
            img.Source = bitmapImage;
            p.Container.Children.Add(img);
            p.SetPosition();
            Debug.WriteLine(p.Posi.X);
            Debug.WriteLine(p.Posi.Y);
            if (p!=null)_worldObject.Add(p);
            
        }

        public static void InitHeroMove( Canvas Background, Hero h)
        {
            h.StartMovingProcess = new HeroMovement( h.Container, h);
            h.StartCollisionManager = new CollisionTrigger( _worldObject, h);
            
        }

        
    }
}
