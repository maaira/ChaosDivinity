using ChaosDivinity.Assets;
using ChaosDivinity.Char;
using ChaosDivinity.Interface;
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
            //InitChest(Tela);
            InitPerso(hero, Tela, Perso);
            InitEnemes(Tela);
            InitiMob(Tela);

        }

        public static void InitPerso(Hero hero, Canvas Tela, Canvas Perso)
        {

            PersoManager.AddPersoToMap(hero, Perso, _worldObject);
            InitHeroMove(Tela, hero);
            hero.SetPhysics(_worldObject);


        }

        public static void InitiMob(Canvas Tela)
        {
            NPC p = new NPC(10, "Teste", TypeNPC.NPCTrader);
            p.SetPy(50, 100, 70,70);
            p.Container.Children.Add(ImageView.ImageSet("ms-appx:///Assets/Mage/MageStopLeft.gif"));
            if (p != null) _worldObject.Add(p);
            Tela.Children.Add(p.Container);
            p.InterationEvent += p.DisturbedEvent;

            NPC nTrader = new NPC(50, "Maga Malvadinha", TypeNPC.NPCTrader);
            nTrader.SetPy(300, 120, 70, 70);
            nTrader.Container.Children.Add(ImageView.ImageSet("ms-appx:///Assets/NPC/NPC_TRADER_OFFICIAL.gif"));
            if (nTrader != null) _worldObject.Add(nTrader);
            Tela.Children.Add(nTrader.Container);
            nTrader.InterationEvent += nTrader.DisturbedEvent;

            NPC nQuester = new NPC(60, "Polvinho Show", TypeNPC.NPCQuester);
            nQuester.SetPy(140, 220, 70, 70);
            nQuester.Container.Children.Add(ImageView.ImageSet("ms-appx:///Assets/NPC/NPC_QUESTER_OFFICIAL.gif"));
            if (nQuester != null) _worldObject.Add(nQuester);
            Tela.Children.Add(nQuester.Container);
            nQuester.InterationEvent += nQuester.DisturbedEvent;

        }

        public void InitEnemes(Canvas tela)
        {
            Enemies p = new Enemies("", 10, 10, 10, 10, 10, 10, 10);
            p.ListofSkill.Add(1, new Skill("Brilho de Sabedoria", 5, 0, 0, 0, 30, p));
            p.ListofSkill.Add(2, new Skill("Cura", 0, 0, 10, 10, 0, p));
            p.ListofSkill.Add(3, new Skill("Brilho de Sabedoria", 12, 2, 10, 0, 0, p));
            p.Path = "ms-appx:///Assets/Mage/MageStopLeft.gif";
            p.Container.Children.Add(ImageView.ImageSet(p.Path));
            p.SetPy(500, 710, 70, 70);
            tela.Children.Add(p.Container);
            if (p != null) _worldObject.Add(p);
            p.IsInteractive = true;
            p.InterationEvent += p.DisturbedEvent;
        }
        public void InitChest(Canvas Tela)
        {
            Chest p = new Chest();
            p.Item = p.RandomPremium(DBItem.DBItens());
            p.Item.Path = "ms-appx:///Assets/Mage/MageStopLeft.gif";
            p.Path = "ms-appx:///Assets/Mage/MageStopLeft.gif";
            p.Container.Children.Add(ImageView.ImageSet(p.Path));
            p.SetPy(710, 700, 70, 70);
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