using System;
using System.Runtime.InteropServices;

namespace TheCPlayersGuide
{
    public struct StructTest
    {
        private int age;
        private string name;

        public int Age { get; set; }
        public string Name { get; set; }


        public static void Main_(string[] args)
        {
            StructTest structOne = new StructTest() {Age = 30, Name = "JQ"};
            Console.WriteLine(structOne.Age);
            structOne.Age = 15;
            Console.WriteLine(structOne.Age);
            Console.WriteLine(structOne.Name);
            structOne.Name = "FQ";
            Console.WriteLine(structOne.Name);

            Console.WriteLine();
            StructTest structTwo = new StructTest();
            Console.WriteLine($"{structTwo.Name} {structTwo.Age}");
            Console.WriteLine();
            structTwo = structOne;
            Console.WriteLine($"{structTwo.Name} {structTwo.Age}");
            structTwo.Age = 115;
            structTwo.Name = "Bob";
            Console.WriteLine($"{structTwo.Name} {structTwo.Age}");
            Console.WriteLine($"{structOne.Name} {structOne.Age}");
        }
    }
}