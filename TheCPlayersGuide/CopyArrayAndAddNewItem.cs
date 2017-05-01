using System;

namespace TheCPlayersGuide
{
    class CopyArrayAndAddNewItem
    {
        public static void Main_(string[] args)
        {
            int[] someIntegers = { 1, 2};
            var newSomeIntegers = CopyArrayAndAddElement(someIntegers, 3);
            Console.WriteLine("Array contains elements: ");
            Console.WriteLine("[{0}]", string.Join(", ", newSomeIntegers));
            Console.WriteLine("If you want to add some press key: Y/Yes, N/No");
            var input = Console.ReadLine();
            
            while (!string.IsNullOrEmpty(input))
            {
                if (string.Equals(input, "Y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter number to add in the array:");
                    int userNumberInput = int.Parse(Console.ReadLine());
                    newSomeIntegers = CopyArrayAndAddElement(newSomeIntegers, userNumberInput);
                    Console.WriteLine("Array contains elements: ");
                    Console.WriteLine("[{0}]", string.Join(", ", newSomeIntegers));
                    Console.WriteLine("If you want to add some press key: Y/Yes, N/No");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bye! :-)");
                    break;
                }
            }            
        }

        private static int[] CopyArrayAndAddElement(int[] arr, int element)
        {
            int[] array = new int[arr.Length+1];;
            for (int j = 0; j < arr.Length; j++)
            {
                array[j] = arr[j];
            }
            array[array.Length - 1] = element;
            return array;
        }
    }
}
