using System;

namespace TheCPlayersGuide
{
    internal class DictionaryMain
    {
        public static void Main_(string[] args)
        {
            Dictionary dictionary = new Dictionary
            {
                ["apple"] = "A particularly delicious pomaceous fruit of " +
                            "the genus Malus."
            };

                /*  Above is the same as below (Using indexer initializer syntax)   */

//            Dictionary dictionary = new Dictionary();
//            dictionary["apple"] = "A particularly delicious pomaceous fruit of the genus Malus.";
//            dictionary["broccoli"] = "The 7th most flavorless vegetable on the planet."

            Console.WriteLine(dictionary["apple"]);

            dictionary["apple"] = "A fruit of thae genus Malus that often times " +
                                  "rots and is no longer delicious.";
            string definitionOfApple = dictionary["apple"];
            Console.WriteLine(definitionOfApple);
        }
    }
}