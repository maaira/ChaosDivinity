

using System.Diagnostics;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Physics
{
    public class PositionRelative
    {
        public static void SetThirdDimension(PhysicObject p, PhysicObject b)
        {
            double z1;
            if (p.Posi.Y > b.Posi.Y )
            {
                z1 = p.Posi.Z;
                Debug.WriteLine(p.Container.GetValue(Canvas.ZIndexProperty));
                Debug.WriteLine(b.Container.GetValue(Canvas.ZIndexProperty));
                p.Container.SetValue(Canvas.ZIndexProperty, b.Posi.Z);
                b.Container.SetValue(Canvas.ZIndexProperty, z1);
            }
            else
            {
                z1 = b.Posi.Z;
                Debug.WriteLine(p.Container.GetValue(Canvas.ZIndexProperty));
                Debug.WriteLine(b.Container.GetValue(Canvas.ZIndexProperty));
                b.Container.SetValue(Canvas.ZIndexProperty, p.Posi.Z);
                p.Container.SetValue(Canvas.ZIndexProperty, z1);
            }
        }
    }
}
