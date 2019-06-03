using System.Threading;

namespace ChaosDivinity.Physics
{
    public abstract class Movement
    {
        public double TelaY = 0;
        public double TelaX = 0;
        public bool up, down, right, left;
        public Thread UpdateMovement;

        public abstract void UpdateMove();
    }
}
