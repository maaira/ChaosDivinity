
using ChaosDivinity.Physics;
using ChaosDivinity.VisualGame.Battle;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Char
{
    public class Enemies : Character
    {
        public Enemies(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl) : base(nomeChar, hp_atual, hp_total, mp_atual, mp_total, lvl)
        {

        }

        public override void DisturbedEvent(PhysicObject sender, PhysicObject p)
        {
            Canvas c1 = this.Container;
            Canvas c2 = c1.Parent as Canvas;
            Canvas c3 = c2.Parent as Canvas;
            Page p2 = c3.Parent as Page;
            p.MinimumObjectInteractive = sender;

            p2.Frame.Navigate(typeof(Battle), p);
            
        }
    }
}
