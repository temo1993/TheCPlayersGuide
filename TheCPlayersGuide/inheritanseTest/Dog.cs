using System;

namespace TheCPlayersGuide.inheritanseTest
{
    internal class Dog : Animal
    {
        public Dog()
        {
        }

        public Dog(string name, int age) : base(name, age)
        {
        }

        public Dog(string name) : base(name)
        {
        }

        public Dog(int age) : base(age)
        {
        }

        public new string Name { get; set; } = "";

        public new int Age { get; set; } = 0;



        public override void MakeNoise(string noise)
        {
            Console.WriteLine($"Dog has noise: {noise}");          
        }
    }
}