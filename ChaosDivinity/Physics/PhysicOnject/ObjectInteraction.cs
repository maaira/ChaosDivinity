using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Physics
{
    class ObjectInteraction
    {
        public delegate void Interaction(CoreWindow sender, KeyEventArgs e, UIElementCollection p);
        
        public void InteractionWithPysicObject(CoreWindow sender, KeyEventArgs e, UIElementCollection p)
        {

        }        
    }
}
