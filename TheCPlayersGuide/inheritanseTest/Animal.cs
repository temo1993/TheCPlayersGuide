using System;

namespace TheCPlayersGuide.inheritanseTest
{
    internal abstract class Animal
    {
        protected Animal()
        {
        }

        protected Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        protected Animal(string name)
        {
            this.Name = name;
        }

        protected Animal(int age)
        {
            this.Age = age;
        }

        public string Name { get; set; } = "";

        public int Age { get; set; } = 0;

        public abstract void MakeNoise(string noise);
    }
}