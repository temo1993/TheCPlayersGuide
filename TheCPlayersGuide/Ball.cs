namespace TheCPlayersGuide
{
    internal class Ball
    {
        public Ball(int size, int radius, Color color)
        {
            Size = size;
            Radius = radius;
            Color = color;
            TimesWasThrown = 0;
        }

        public int Size { get; set; }
        public int Radius { get; set; }
        public int TimesWasThrown { get; set; }
        public Color Color { get; set; }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
            {
                TimesWasThrown += 1;
            }
        }

        public int ThrowCount()
        {
            return TimesWasThrown;
        }
    }
}