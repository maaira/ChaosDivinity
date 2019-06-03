using ChaosDivinity.Assets;
using ChaosDivinity.Char;
using ChaosDivinity.Item;
using ChaosDivinity.Manager;
using ChaosDivinity.MapObjects;
using ChaosDivinity.NPCNamespace;
using ChaosDivinity.Physics;
using System.Collections.Generic;
using System.Numerics;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Managers
{

    class MapManager
    {
        private static List<PhysicObject> _worldObject = new List<PhysicObject>();
        private Hero h;
        private Dictionary<Vector2, PhysicObject> Matriz2D { get; set; }

        public List<PhysicObject> WorldObject { get => _worldObject; set => _worldObject = value; }

        public void Map(Hero hero, Canvas Tela, Canvas Perso, Canvas MOB, Canvas MOB2, Canvas MOB3)
        {

            this.h = hero;
            InitChest(Tela);
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

            NPC p = new NPC(10, "Teste", TypeNPC.NPCTrade);
            p.Container = MOB;
            p.SetRadius();
            p.Container.Children.Add(ImageView.ImageSet("ms-appx:///Assets/Mage/MageStopLeft.gif"));
            p.SetPosition();
            if (p != null) _worldObject.Add(p);

        }

        public void InitChest(Canvas Tela)
        {
            Chest p = new Chest();
            p.Item = p.RandomPremium(DBItem.DBItens());
            p.Item.Path = "ms-appx:///Assets/Mage/MageStopLeft.gif";
            p.Path = "ms-appx:///Assets/Mage/MageStopLeft.gif";
            p.Container = new Canvas();
            p.Container.Children.Add(ImageView.ImageSet(p.Path));
            p.Container.SetValue(Canvas.LeftProperty, 700);
            p.Container.SetValue(Canvas.TopProperty, 710);
            p.Container.Width = 70;
            p.Container.Height = 70;
            p.SetPosition();
            Tela.Children.Add(p.Container);
            if (p != null) _worldObject.Add(p);
            p.InterationEvent += p.DisturbedEvent;

        }

        public static void InitHeroMove(Canvas Background, Hero h)
        {
            h.StartMovingProcess = new HeroMovement(Background, h);

        }

        public void SetMatriz2D(int height, int withd)
        {

        }
    }
}