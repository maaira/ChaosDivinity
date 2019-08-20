namespace ChaosDivinity.Physics
{
    public class ObjectMoment
    {
        public enum Moment { Right = 1, Left = 1, Up = 1, Bottom = 1 };
        public bool Right { get; set; }
        public bool Left { get; set; }
        public bool Up { get; set; }
        public bool Down { get; set; }

        public void RevertMoment()
        {
            Right = !Right;
            Left = !Left;
            Up = !Up;
            Down = !Down;
        }

        public void NegMoment()
        {
            Right = Left = Up = Down = false;
        }
    }


}

