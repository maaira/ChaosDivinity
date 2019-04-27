using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using System.Numerics;
using ChaosDivinity.Physics;
using System.Diagnostics;

namespace ChaosDivinity.PhysicCollision
{
    public class Collision
    {
        protected int length = 0;
        protected double unsafeX = 0;
        protected double unsafeY = 0;
        protected double radius1, radius2;
        protected Vector3 center_point2, center_point1;
        protected Vector2 dist_vector;
        protected double radius, dist;
        protected List<PhysicObject> array;
        protected PhysicObject p;

        public Collision(List<PhysicObject> array, PhysicObject p)
        {
            this.array = array;
            this.p = p;
            length = array.Count;
        }

        public void UpdateColisions()
        {
            
            if (length <= 1) return;

            if (p == null && p.Container== null) return;
            //Debug.WriteLine("uhuu");

            double canvas_left = (double)p.Container.GetValue(Canvas.LeftProperty);
            double canvas_top  = (double)p.Container.GetValue(Canvas.TopProperty);
            double canvas_righ = (double)p.Container.GetValue(Canvas.LeftProperty) + p.Container.Width;
            double canvas_down = (double)p.Container.GetValue(Canvas.TopProperty) + p.Container.Height;
            center_point1 = p.Container.CenterPoint;

            if (canvas_down == 0 && canvas_left == 0 && canvas_righ == 0 && canvas_top == 0 && center_point1 == null) return;
            //Debug.WriteLine("1");
            radius1 = (canvas_left + canvas_righ + canvas_top + canvas_down) / 4;

            foreach(PhysicObject obj in array )
            {
                
                
                //Debug.WriteLine("6");
                if (obj == null && obj.Container == null ) return;
                //Debug.WriteLine("5");

                dist_vector.X = (float)(p.Container.Width / 2 + obj.Container.Width / 2);
                dist_vector.Y = (float)(p.Container.Height / 2 + obj.Container.Height / 2); 

                double canvas_left2 = (double)obj.Container.GetValue(Canvas.LeftProperty);
                double canvas_top2  = (double)obj.Container.GetValue(Canvas.TopProperty);  
                double canvas_righ2 = (double)obj.Container.GetValue(Canvas.LeftProperty) + p.Container.Width;
                double canvas_down2 = (double)obj.Container.GetValue(Canvas.TopProperty) + p.Container.Height;
                center_point2 = obj.Container.CenterPoint;

                if (canvas_down2 == 0 && canvas_left2 == 0 && canvas_righ2 == 0 && canvas_top2 == 0 && center_point2 == null) return;
                //Debug.WriteLine("2");

                radius2 = (canvas_down2 + canvas_left2 + canvas_righ2 + canvas_top2) / 4;
                unsafeX = (center_point2.X + center_point1.X) / 2;
                unsafeY = (center_point2.Y + center_point1.Y) / 2;
                radius = Math.Abs(Math.Pow(center_point1.X - center_point2.X, 2) + Math.Pow(center_point2.Y - center_point2.Y, 2));

                double right = (center_point2.X - p.Container.Width / 2)  - (center_point1.X + p.Container.Width / 2);
                double left  = (center_point1.X - p.Container.Width / 2)  - (center_point2.X + p.Container.Width / 2);
                double bot   = (center_point1.Y - p.Container.Height / 2) - (center_point2.Y - obj.Container.Height / 2);
                double top   = (center_point2.Y - obj.Container.Height / 2) - (center_point1.Y - p.Container.Height / 2);

                unsafeX = (p.Container.Height / 2 + obj.Container.Height / 2);
                unsafeY = (p.Container.Width / 2 + obj.Container.Width / 2);

                //Debug.WriteLine("Radius = " + radius);
                //Debug.WriteLine("Distancia = " + dist);
                
                if (radius <= radius1 + radius2)

                {
                    //Debug.WriteLine("Interacrion");
                    if (p.MinimumObjectInteractive == null && obj.IsInteractive == true)
                    {
                        p.MinimumObjectInteractive = obj;
                    }
                    else if (p.MinimumObjectInteractiveDist < dist && obj.IsInteractive == true)
                    {
                        p.MinimumObjectInteractive = obj;
                        p.MinimumObjectInteractiveDist = dist;
                    }
                }

                if (center_point1.X < center_point2.X)
                {
                    if (right < 0 && dist_vector.X <= unsafeY * 0.93f)
                        {
                        p.InMoment.Right = false;
                        p.OnColide = obj;                   
                        continue;
                    }
                    else p.InMoment.Right = true;
                        
                }
                if (center_point1.X > center_point2.X)
                {
                    if ( right< 0 && dist_vector.Y <= unsafeY * 0.93f)
                    {
                         p.InMoment.Left = false; 
                         p.OnColide = obj;
                         continue;   
                    }
                    else p.InMoment.Left = true;
                }
                if (center_point1.Y > center_point2.Y)
                {
                    if (top < 0 && dist_vector.Y <= unsafeY * 0.93f)
                    {
                            p.InMoment.Up = false;
                            p.OnColide = obj;
                            continue;
                    }
                    else p.InMoment.Up = true;
                }
                if (center_point1.Y < center_point2.Y)
                {
                    if (bot < 0 && dist_vector.Y <= unsafeY * 0.9f)
                    {
                        p.InMoment.Down = false;
                        p.OnColide = obj;

                        continue;
                    }
                    else p.InMoment.Down = true;

                }                   
                
            }
        }
    }
}

