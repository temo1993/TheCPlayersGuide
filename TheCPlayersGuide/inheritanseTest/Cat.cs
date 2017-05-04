using System;

namespace TheCPlayersGuide.inheritanseTest
{
    internal class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(string name, int age) : base(name, age)
        {
        }

        public Cat(string name) : base(name)
        {
        }

        public Cat(int age) : base(age)
        {
        }

        public new string Name { get; set; } = "";

        public new int Age { get; set; } = 0;



        public override void MakeNoise(string noise)
        {
            Console.WriteLine($"Cat has noise: {noise}");
        }
    }
}