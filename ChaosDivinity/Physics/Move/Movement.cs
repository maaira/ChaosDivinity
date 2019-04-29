using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChaosDivinity.Physics
{
    public class Movement
    {
        public double TelaY = 0;
        public double TelaX = 0;
        public bool up, down, right, left;
        public Thread UpdateMovement;
    }
}
