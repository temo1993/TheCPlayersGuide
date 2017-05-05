using System;
using System.Collections.Generic;
using System.Linq;

namespace TheCPlayersGuide
{
    public class GenericsTest
    {
        private static readonly List<string> TestList = new List<string>();

        public static void Main_(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                TestList.Add("Item" + i);
            }

            TestList.ForEach(Console.WriteLine);
            TestList.Insert(10, "Item10");
            var elementAt = TestList.ElementAt(10);
            Console.WriteLine("__________");
            Console.WriteLine(elementAt);
            TestList.RemoveAt(0);
            Console.WriteLine("__________");
            TestList.ForEach(Console.WriteLine);
            TestList.Clear();
            Console.WriteLine("List after cleal method:");
            TestList.ForEach(Console.WriteLine);
            // Collection initializer syntax
            List<int> someNumbersInAList = new List<int> { 14, 24, 37 };
            Console.WriteLine("__________");
            someNumbersInAList.ForEach(Console.WriteLine);


            Dictionary<string, int> phoneBook = new Dictionary<string, int>
            {
                ["Gates, Bill"] = 5550100,
                ["Zuckerberg, Mark"] = 5551438
            };
            var billsNumber = phoneBook["Gates, Bill"];
            Console.WriteLine(billsNumber);
        } 
    }
}