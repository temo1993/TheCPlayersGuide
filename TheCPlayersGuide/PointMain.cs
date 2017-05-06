namespace TheCPlayersGuide
{
    public class PointMain
    {
        public static void Main_(string[] args)
        {
            Point point = new Point();

            // Attaching handler to the event
            point.PointChanged += point.HandlePointChanged;

            //            To detach an event, you simply use the -= operator in a manner similar to attaching events:
            //            point.PointChanged -= HandlePointChanged;
            //            After this executes, HandlePointChanged will not be called when the PointChanged event occurs.

            // Now if we change the point, the PointChanged event will get raised,
            // and HandlePointChanged will get called.
            point.X = 3;
        }
    }
}