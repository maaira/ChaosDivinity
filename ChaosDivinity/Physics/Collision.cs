using System.Collections.Generic;
using System.Numerics;
using ChaosDivinity.Physics;
using System.Diagnostics;
using System;

namespace ChaosDivinity.PhysicCollision
{
    public class Collision
    {
        protected double tam_x, tam_y;
        protected double percent = 0.85;
        protected Vector2 dist_vector;
        protected double dist, radius;
        protected List<PhysicObject> array;
        protected PhysicObject p;

        public Collision(List<PhysicObject> array, PhysicObject p)
        {
            this.array = array;
            this.p = p;
        }

        public void UpdateColisions()
        {
            
            if (array.Count <= 1) return;

            if (p == null && p.Container== null) return;            
                                    
            foreach(PhysicObject obj in array )
            {

                if (obj == null && obj.Container == null ) return;
                if (p == obj) return;

                dist_vector.Y = (float)Math.Abs(p.Posi.Y - obj.Posi.Y);
                dist_vector.X = (float)Math.Abs(p.Posi.X - obj.Posi.X);

                double right = (obj.Posi.X - obj.Container.Width/2) - ( p.Posi.X + p.Container.Width/2 );
                double left  = (p.Posi.X   - p.Container.Width/2  ) - (obj.Posi.X + p.Container.Width/2);
                double bot   = (p.Posi.Y - p.Container.Height/2) - (obj.Posi.Y + obj.Container.Height/2);
                double top   = (obj.Posi.Y - obj.Container.Height / 2) - (p.Posi.Y + p.Container.Height / 2);

                tam_y = (p.Container.Height / 2 + obj.Container.Height / 2);
                tam_x = (p.Container.Width / 2 + obj.Container.Width / 2);

                radius = Math.Abs(Math.Pow((p.Posi.X - obj.Posi.X),2) + Math.Pow((p.Posi.Y - obj.Posi.Y), 2));
                
                if ( radius <= 90 && obj.IsInteractive)
                {
                    if(p.MinimumObjectInteractive== null)
                    {
                        p.MinimumObjectInteractive = obj;
                        p.MinimumObjectInteractiveDist = radius;
                    }
                    else if(p.MinimumObjectInteractiveDist > radius)
                    {
                        p.MinimumObjectInteractive = obj;
                        p.MinimumObjectInteractiveDist = radius;
                    }
                }

                if (p.Posi.X <= obj.Posi.X)
                {
                    
                    if (right < 0 && dist_vector.X <= tam_x * percent)
                    {
                        //Debug.WriteLine("DIR");
                        p.InMoment.Right = false;
                        p.OnColide = obj;
                        
                        continue;
                    }else p.InMoment.Right = true;

                }else p.InMoment.Right = true;

                if (p.Posi.X >= obj.Posi.X)
                {
                    
                    if ( right< 0 && dist_vector.Y <= tam_x * percent)
                    {
                        //Debug.WriteLine("ESQ");
                        p.InMoment.Left = false; 
                        p.OnColide = obj;
                        
                        continue;
                        
                    }else p.InMoment.Left = true;

                }else p.InMoment.Left = true;

                if (p.Posi.X >= obj.Posi.X)
                {
                    
                    if (top < 0 && dist_vector.Y <= tam_y * percent)
                    {
                        //Debug.WriteLine("C");
                        p.InMoment.Up = false;
                        p.OnColide = obj;
                        
                        continue;

                    }else p.InMoment.Up = true;

                }else p.InMoment.Up = true;

                if (p.Posi.X <= obj.Posi.X)
                {
                    //Debug.WriteLine("tururu4");
                    if (bot < 0 && dist_vector.Y <= tam_y * percent)
                    {
                        //Debug.WriteLine("B");
                        p.InMoment.Down = false;
                        p.OnColide = obj;
                        
                        continue;

                    }else p.InMoment.Down = true;
                
                }else p.InMoment.Down = true;
            }
        }
    }
}

