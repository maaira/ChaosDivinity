using ChaosDivinity.PhysicCollision;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Windows.UI.Core;

namespace ChaosDivinity.Physics
{
    public class CollisionTrigger : Collision
    {
        private Thread UpdateCollision;
        private PhysicObject obj;

        public CollisionTrigger(List<PhysicObject> array, PhysicObject po) : base(array, po)
        {
            
            this.obj = po;
            UpdateCollision = new Thread(CollisionRegister);
            UpdateCollision.Start();
            
        }
                
        public async void CollisionRegister()
        {
            while (true)
            {
                await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
                {

                    UpdateColisions();
                    
                });
                
            }
        }

        private void CollisionSets()
        {

        }
    }
}
