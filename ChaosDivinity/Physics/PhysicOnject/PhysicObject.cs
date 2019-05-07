using ChaosDivinity.PhysicCollision;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Physics
{
    public delegate void CollisionHandleEvent(PhysicObject sender, EventArgs p);
    public abstract class PhysicObject
    {        
        public Canvas Container { get; set; }        
        public ObjectMoment InMoment { get; set; }
        public bool IsMoving { get; set; }
        public bool Interaction { get; set; }        
        public PhysicObject MinimumObjectInteractive { get; set; }
        public double MinimumObjectInteractiveDist { get; set; }
        public bool IsInteractive { get; set; }

        public Movement StartMovingProcess;

        public Collision CollisionUp;

        public CollisionHandleEvent StartCollisionManager;
        public Position Posi { get; }
        public double Radius { get; set; }
        public PhysicObject()
        {
            Posi           = new Position();
            InMoment       = new ObjectMoment();
            InMoment.Down  = true;
            InMoment.Left  = true;
            InMoment.Up    = true;
            InMoment.Right = true;
            
        }

        public void SetPosition()
        {
            if (Container == null) return;
            this.Posi.X = (double)Container.GetValue(Canvas.LeftProperty) + Container.Width / 2;
            this.Posi.Y = (double)Container.GetValue(Canvas.TopProperty) + Container.Height / 2;
        }
        public void SetRadius()
        {
            if (Container == null) return;
            this.Radius = (Container.Width + Container.Height) / 4;
        }
        public virtual void OnCollision()
        {
            StartCollisionManager?.Invoke(this, EventArgs.Empty);
        }
        public void CollisionEvent(PhysicObject sender, EventArgs p)
        {
            PhysicObject obj= (PhysicObject)sender;
            //Debug.WriteLine("Here");
            obj.CollisionUp.UpdateColisions();
        }

        public void SetPhysics(List<PhysicObject> _worldlist)
        {
            CollisionUp = new Collision(_worldlist, this);
            StartCollisionManager += new CollisionHandleEvent(CollisionEvent);
        }
    }
}
