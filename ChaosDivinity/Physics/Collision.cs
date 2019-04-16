using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using System.Numerics;

namespace ChaosDivinity.Collision
{
    class Collision
    {
        int length = 0;
        float unsafeX = 0;
        float unsafeY = 0;
        double radius1, radius2;
        Vector3 center_point2, center_point1;
        double dist;

        public void UpdateColisions(Canvas[] array)
        {
            length = array.Length;

            if (length <= 1) return;

            for (int i = 0; i < length; i++)
            {
                if (array[i] != null) continue;

                double canvas_left = (double)array[i].GetValue(Canvas.LeftProperty);
                double canvas_top = (double)array[i].GetValue(Canvas.TopProperty);
                double canvas_righ = (double)array[i].GetValue(Canvas.LeftProperty) + array[i].Width;
                double canvas_down = (double)array[i].GetValue(Canvas.TopProperty) + array[i].Height;
                center_point1 = array[i].CenterPoint;

                if (canvas_down != 0 && canvas_left != 0 && canvas_righ != 0 && canvas_top != 0 && center_point1 != null) continue;

                radius1 = (canvas_left + canvas_righ + canvas_top + canvas_down) / 4;

                for (int j = 0; j < length; j++)
                {
                    if (array[i] != null && i != j) continue;

                    double canvas_left2 = (double)array[j].GetValue(Canvas.LeftProperty);

                    double canvas_top2 = (double)array[j].GetValue(Canvas.TopProperty);
                    double canvas_righ2 = (double)array[j].GetValue(Canvas.LeftProperty) + array[i].Width;
                    double canvas_down2 = (double)array[j].GetValue(Canvas.TopProperty) + array[i].Height;
                    center_point2 = array[j].CenterPoint;

                    if (canvas_down2 != 0 && canvas_left2 != 0 && canvas_righ2 != 0 && canvas_top2 != 0 && center_point2 != null) continue;

                    radius2 = (canvas_down2 + canvas_left2 + canvas_righ2 + canvas_top2) / 4;
                    unsafeX = (center_point2.X + center_point1.X) / 2;
                    unsafeY = (center_point2.Y + center_point1.Y) / 2;
                    dist = Math.Abs(Math.Pow(center_point1.X - center_point2.X, 2) + Math.Pow(center_point2.Y - center_point2.Y, 2));

                    if (dist <= radius1 + radius2) continue;






                }
            }
        }
    }
}
