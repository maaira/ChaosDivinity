using ChaosDivinity.PhysicCollision;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Physics
{
    public delegate void CollisionHandleEvent(PhysicObject sender, EventArgs p);
    public delegate void IsDisturbedHandleEvent(PhysicObject sender, PhysicObject p);
    public abstract class PhysicObject
    {
        public Canvas Container { get; set; }
        public string Path { get; set; }
        public ObjectMoment InMoment { get; set; }
        public bool IsMoving { get; set; }
        public PhysicObject MinimumObjectInteractive { get; set; }
        public double MinimumObjectInteractiveDist { get; set; }
        public bool IsInteractive { get; set; }

        public IsDisturbedHandleEvent InterationEvent;

        public Movement StartMovingProcess;

        public Collision CollisionUp;

        public CollisionHandleEvent StartCollisionManager;

        public Position Posi { get; }
        public double Radius { get; set; }
        public PhysicObject()
        {
            Posi = new Position();
            InMoment = new ObjectMoment();
            InMoment.Down = true;
            InMoment.Left = true;
            InMoment.Up = true;
            InMoment.Right = true;

        }

        public void SetPosition()
        {
            if (Container == null) return;
            this.Posi.X = (double)Container.GetValue(Canvas.LeftProperty) + Container.Width / 2;
            this.Posi.Y = (double)Container.GetValue(Canvas.TopProperty) + Container.Height / 2;
            Container.SetValue(Canvas.ZIndexProperty, Container.GetValue(Canvas.TopProperty));
        }
        public void SetRadius()
        {
            if (Container == null) return;
            this.Radius = (Container.Width / 2 + Container.Height / 2) / 2;
        }
        public virtual void OnCollision()
        {
            StartCollisionManager?.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnDisturberd(PhysicObject p, PhysicObject obj)
        {
            InterationEvent?.DynamicInvoke(obj, p);
        }

        public virtual void CollisionEvent(PhysicObject sender, EventArgs p)
        {
            PhysicObject obj = sender;
            obj.CollisionUp.UpdateColisions();
        }

        public void EndExistence()
        {
            if (Container == null) return;
            Canvas p = (Canvas)Container.Parent;
            p.Children.Remove(Container);
        }

        public virtual void SetPhysics(List<PhysicObject> _worldlist)
        {
            CollisionUp = new Collision(_worldlist, this);
            StartCollisionManager += new CollisionHandleEvent(CollisionEvent);
        }

        public virtual void DisturbedEvent(PhysicObject sender, PhysicObject p)
        {
            return;
        }

       public virtual void InInteraction(PhysicObject intetacted)
       {
            return;
       }



    }
}