namespace TheCPlayersGuide
{
    internal class ColoredBalls
    {
        public static void Main_(string[] args) {
            Ball _football = new Ball(1, 1, new Color(255, 0, 0));
            Ball _basketBall = new Ball(2, 2, new Color(200, 10, 10));
            Ball _rugbyball = new Ball(1, 2, new Color(255, 255, 255));
            _football.Throw();
            _football.Throw();
            _football.Throw();
            System.Console.WriteLine(_football.ThrowCount());
            _football.Pop();
            System.Console.WriteLine(_football.ThrowCount());

            _basketBall.Throw();
            _basketBall.Throw();
            System.Console.WriteLine(_basketBall.ThrowCount());
            
            _rugbyball.Throw();
            System.Console.WriteLine(_rugbyball.ThrowCount());
            


        }
    }
}