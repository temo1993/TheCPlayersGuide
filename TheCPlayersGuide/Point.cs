using System;

namespace TheCPlayersGuide
{
    public class Point
    {
        private double _x;
        private double _y;
        public double X
        {
            get => _x;
            set
            {
                _x = value;
                OnPointChanged();
            }
        }
        public double Y
        {
            get => _y;
            set
            {
                _y = value;
                OnPointChanged();
            }
        }

        public event EventHandler PointChanged;

        private void HandlePointChanged(Point pointThatChanged)
        {
            // Do something in response to the point changing.
        }

        public void OnPointChanged()
        {
            PointChanged?.Invoke(this, EventArgs.Empty);
            // Above code is the same as bellow (Called null propagation)
//            if (PointChanged != null)
//            PointChanged(this, EventArgs.Empty);
        }

        public void HandlePointChanged(object sender, EventArgs eventArgs)
        {
            // Do something intelligent when the point changes. Perhaps redraw the GUI,
            // or update another data structure, or anything else you can think of.
        }
    }
}