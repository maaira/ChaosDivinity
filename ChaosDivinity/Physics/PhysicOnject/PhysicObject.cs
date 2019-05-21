using ChaosDivinity.PhysicCollision;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Physics
{
    public delegate void CollisionHandleEvent(PhysicObject sender, EventArgs p);
    public delegate void InInterationHandleEvent(PhysicObject sender, EventArgs p);
    public delegate void IsDisturbed(PhysicObject p);
    public abstract class PhysicObject
    {
        public Canvas Container { get; set; }
        public string Path { get; set; }
        public ObjectMoment InMoment { get; set; }
        public bool IsMoving { get; set; }
        public bool Interaction { get; set; }
        public PhysicObject MinimumObjectInteractive { get; set; }
        public double MinimumObjectInteractiveDist { get; set; }
        public bool IsInteractive { get; set; }

        public IsDisturbed InterationEvent;

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
            Container.SetValue(Canvas.ZIndexProperty, Container.GetValue(Canvas.TopProperty));
        }
        public void SetRadius()
        {
            if (Container == null) return;
            this.Radius = (Container.Width/2 + Container.Height/2) / 8;
        }
        public void OnCollision()
        {
            StartCollisionManager?.Invoke(this, EventArgs.Empty);
        }
        public virtual void CollisionEvent(PhysicObject sender, EventArgs p)
        {
            PhysicObject obj= (PhysicObject)sender;
            obj.CollisionUp.UpdateColisions();
        }

        public virtual void SetPhysics(List<PhysicObject> _worldlist)
        {
            
        }
        public virtual void OnInteraction()
        {
            InterationEvent?.DynamicInvoke(this, EventArgs.Empty);
        }

        public void EndExistence()
        {
            if (Container == null) return;
            Canvas p = (Canvas)Container.Parent;
            p.Children.Remove(Container);            
        }

        
        
    }
}
