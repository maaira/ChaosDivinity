using System.Collections.Generic;
using System.Numerics;
using ChaosDivinity.Physics;
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

            if (p == null && p.Container == null) return;

            foreach (PhysicObject obj in array)
            {
                cont++;
                if (obj == null && obj.Container == null) continue;
                if (p == obj) continue;

                dist_vector.Y = (float)Math.Abs(p.Posi.Y - obj.Posi.Y);
                dist_vector.X = (float)Math.Abs(p.Posi.X - obj.Posi.X);

                tam_x = Math.Abs(p.Container.Width / 2 + obj.Container.Width / 2);
                tam_y = Math.Abs(p.Container.Height / 2 + obj.Container.Height / 2);


                radius = Math.Sqrt(Math.Pow((p.Posi.X - obj.Posi.X), 2) + Math.Pow((p.Posi.Y - obj.Posi.Y), 2));
                radius_collider = p.Radius / 2 + obj.Radius / 2;

                if (radius <= radius_collider && obj.IsInteractive)
                {
                    if (p.MinimumObjectInteractive == null && radius <= radius_collider)
                    {
                        p.MinimumObjectInteractive = obj;
                        p.MinimumObjectInteractiveDist = radius;
                    }

                    else if (p.MinimumObjectInteractiveDist > radius && radius <= radius_collider)
                    {
                        p.MinimumObjectInteractive = obj;
                        p.MinimumObjectInteractiveDist = radius;
                    }
                }

                if (p.Posi.X < obj.Posi.X)
                {
                    if (radius <= radius_collider && dist_vector.Y <= tam_y / 4)
                    {
                        p.InMoment.Right = false;
                        obj.OnDisturberd(p, obj);
                        break;
                    }
                    else p.InMoment.Right = true;

                }

                if (p.Posi.X > obj.Posi.X)
                {
                    if (radius <= radius_collider && dist_vector.Y <= tam_y / 2)
                    {
                        p.InMoment.Left = false;
                        obj.OnDisturberd(p, obj);
                        break;
                    }
                    else p.InMoment.Left = true;
                }

                if (p.Posi.Y > obj.Posi.Y)
                {
                    if (radius <= radius_collider && dist_vector.X <= tam_x / 2)
                    {
                        p.InMoment.Up = false;
                        obj.OnDisturberd(p, obj);
                        break;
                    }
                    else p.InMoment.Up = true;

                }

                if (p.Posi.Y < obj.Posi.Y)
                {

                    if (radius <= radius_collider && dist_vector.X < tam_x / 2)
                    {
                        p.InMoment.Down = false;
                        obj.OnDisturberd(p, obj);
                        break;
                    }
                    else p.InMoment.Down = true;

                }
            }
        }
    }
}
