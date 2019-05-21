using ChaosDivinity.Assets;
using ChaosDivinity.Char;
using ChaosDivinity.Manager;
using ChaosDivinity.NPCNamespace;
using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


namespace ChaosDivinity.Managers
{
    
    class MapManager
    {
        private static List<PhysicObject> _worldObject = new List<PhysicObject>();
        private Hero h;


        public List<PhysicObject> WorldObject { get => _worldObject; set => _worldObject = value; }

        public void Map(Hero hero, Canvas Tela, Canvas Perso, Canvas MOB, Canvas MOB2, Canvas MOB3)
        {

            this.h = hero;
            InitiMob(MOB);
            InitiMob(MOB2);
            InitiMob(MOB3);
            InitPerso(hero, Tela, Perso);
           
         }

        public static void InitPerso(Hero hero, Canvas Tela, Canvas Perso)
        {

            PersoManager.AddPersoToMap(hero, Perso, _worldObject);
            InitHeroMove(Tela, hero);
            hero.SetPhysics(_worldObject);
                        
        }

        public static void InitiMob(Canvas MOB)
        {

            NPC p = new NPC(10, "Teste",TypeNPC.NPCTrade) ;
            p.Container = MOB;
            p.SetRadius();            
            p.Container.Children.Add(ImageView.ImageSet("ms-appx:///Assets/Mage/MageStopLeft.gif"));
            p.SetPosition();
            Debug.WriteLine(p.Posi.X);
            Debug.WriteLine(p.Posi.Y);
            if (p != null) _worldObject.Add(p);

        }

        public static void InitHeroMove(Canvas Background, Hero h)
        {    
            h.StartMovingProcess = new HeroMovement( Background, h);
                                               
        }
    }
}