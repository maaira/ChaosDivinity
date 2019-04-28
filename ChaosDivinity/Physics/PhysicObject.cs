﻿using ChaosDivinity.PhysicCollision;
using System.Numerics;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Physics
{
    public delegate void ActionInCollision();
    public delegate void ActionInIntertion();
    public delegate void IsCollision();
    public delegate void IsInteration();
    public delegate void UpdateCollision(PhysicObject[] array, PhysicObject p);
    public delegate void Move();

    public abstract class PhysicObject
    {        
        public Canvas Container { get; set; }
        
        public ObjectMoment InMoment { get; set; }
        public bool IsMoving { get; set; }

        public bool Interaction { get; set; }        
        public PhysicObject MinimumObjectInteractive { get; set; }
        public PhysicObject OnColide { get; set; }
        public double MinimumObjectInteractiveDist { get; set; }
        public bool IsInteractive { get; set; }

        public Movement StartMovingProcess;

        public CollisionTrigger StartCollisionManager;
        public Position Posi { get; }
        
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
        }
    }
}
