﻿using ChaosDivinity.PhysicCollision;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Windows.UI.Core;

namespace ChaosDivinity.Physics
{
    public class CollisionTrigger 
    {
        private Collision collider;
        private Thread UpdateCollision;
        
        public CollisionTrigger(List<PhysicObject> array, PhysicObject po) 
        {
            this.collider = new Collision(array, po);
            UpdateCollision = new Thread(CollisionRegister);
            UpdateCollision.Start();
            
        }
                
        public async void CollisionRegister()
        {
            while (true)
            {
                await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
                {
                    collider.UpdateColisions();
                    
                });
                
            }
        }

        
    }
}
