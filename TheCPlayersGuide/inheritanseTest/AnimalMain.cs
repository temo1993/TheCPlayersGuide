namespace TheCPlayersGuide.inheritanseTest
{
    internal class AnimalMain
    {
        public static void Main_(string[] args)
        {
            Cat cat1 = new Cat("Cat1", 1);
            Dog dog1 = new Dog("Dog1", 2);
            cat1.MakeNoise("Meaw");
            dog1.MakeNoise("Bark");
        }
    }
}
