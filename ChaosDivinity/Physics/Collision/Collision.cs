using System.Collections.Generic;
using System.Numerics;
using ChaosDivinity.Physics;
using System.Diagnostics;
using System;

namespace ChaosDivinity.PhysicCollision
{
    public class Collision
    {
        private double tam_x, tam_y;
        private Vector2 dist_vector;
        private double radius, radius_collider;
        private List<PhysicObject> array;
        private PhysicObject p;

        public Collision(List<PhysicObject> array, PhysicObject p)
        {
            this.array = array;
            this.p = p;
        }

        public void UpdateColisions()
        {
            int cont = 0;

            if (array.Count <= 1) return;

            if (p == null && p.Container== null) return;            
                                    
            foreach(PhysicObject obj in array )
            {
                cont++;
                if (obj == null && obj.Container == null ) continue;
                if (p == obj) continue;

                dist_vector.Y = (float)Math.Abs(p.Posi.Y - obj.Posi.Y);
                dist_vector.X = (float)Math.Abs(p.Posi.X - obj.Posi.X);

                tam_x = Math.Abs(p.Container.Width/2 + obj.Container.Width/2);
                tam_y = Math.Abs(p.Container.Height / 2 + obj.Container.Height / 2);

                radius = Math.Sqrt(Math.Pow((p.Posi.X - obj.Posi.X),2) + Math.Pow((p.Posi.Y - obj.Posi.Y), 2));
                radius_collider = p.Radius + obj.Radius;

                if ( radius <= radius_collider && obj.IsInteractive)
                {
                    if(p.MinimumObjectInteractive== null && radius <= radius_collider)
                    {
                        p.MinimumObjectInteractive = obj;
                        p.MinimumObjectInteractiveDist = radius;
                    }

                    else if(p.MinimumObjectInteractiveDist > radius && radius <= radius_collider)
                    {
                        p.MinimumObjectInteractive = obj;
                        p.MinimumObjectInteractiveDist = radius;
                    }
                }

                Debug.WriteLine(cont);
                Debug.WriteLine("");
                Debug.WriteLine("Vector Y: " + dist_vector.Y);
                Debug.WriteLine("Vector X: " + dist_vector.X);
                Debug.WriteLine("Raio: " + radius);
                Debug.WriteLine("Raio Collider" + radius_collider);
                Debug.WriteLine("");

                if (p.Posi.X < obj.Posi.X)
                {
                    Debug.WriteLine("DIR");
                    if (radius <= radius_collider && dist_vector.Y < tam_y / 2) 
                    {
                        Debug.WriteLine("Collider");
                        if (p.InMoment.Right == false) { }
                        else p.InMoment.Right = false;
                        //p.InMoment.Right = false;
                        p.OnColide = obj;
                    }
                    else p.InMoment.Right = true;

                }
                
                else if (p.Posi.X > obj.Posi.X)
                {
                    Debug.WriteLine("ESQ");
                    if (radius < radius_collider && dist_vector.Y <= tam_y/2)
                    {
                        Debug.WriteLine("Collider");
                        if (p.InMoment.Left == false) { }
                        else p.InMoment.Left = false;
                        //p.InMoment.Left = false;
                        p.OnColide = obj;
                    }
                    else p.InMoment.Left = true;
                }
                
                if (p.Posi.Y > obj.Posi.Y)
                {
                    Debug.WriteLine("Up");
                    if (radius < radius_collider && dist_vector.X < tam_x / 2)
                    {
                        Debug.WriteLine("Collider");
                        if (p.InMoment.Up == false) { }
                        else p.InMoment.Up = false;
                        //p.InMoment.Up = false;
                        p.OnColide = obj;
                    }
                    else p.InMoment.Up = true;

                }
                
                else if (p.Posi.Y < obj.Posi.Y)
                {
                    Debug.WriteLine("Down"); 

                    if (radius < radius_collider && dist_vector.X < tam_x / 2)
                    {
                        Debug.WriteLine("Collider");
                        if (p.InMoment.Down == false) { }
                        else p.InMoment.Down = false;
                        //p.InMoment.Down = false;
                        p.OnColide = obj;
                    }
                    else p.InMoment.Down = true;

                }
                


            }
        }
    }
}

