namespace TheCPlayersGuide
{
    internal class ColoredBalls
    {
        public static void Main_(string[] args) {
            Ball football = new Ball(1, 1, new Color(255, 0, 0));
            Ball basketBall = new Ball(2, 2, new Color(200, 10, 10));
            Ball rugbyball = new Ball(1, 2, new Color(255, 255, 255));
            football.Throw();
            football.Throw();
            football.Throw();
            System.Console.WriteLine(football.ThrowCount());
            football.Pop();
            System.Console.WriteLine(football.ThrowCount());

            basketBall.Throw();
            basketBall.Throw();
            System.Console.WriteLine(basketBall.ThrowCount());
            
            rugbyball.Throw();
            System.Console.WriteLine(rugbyball.ThrowCount());
            


        }
    }
}