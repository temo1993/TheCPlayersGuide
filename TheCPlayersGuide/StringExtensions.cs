using System;
using System.IO;

namespace TheCPlayersGuide
{
    internal static class StringExtensions
    {
        private static readonly Random Random = new Random();

        internal static string ToRandomCase(this string text)
        {
            string result = "";
            for (int index = 0; index < text.Length; index++)
            {
                if (Random.Next(2) == 0) 
                    result += text.Substring(index, 1).ToUpper();
                else
                    result += text.Substring(index, 1).ToLower();
            }
            return result;
        }

        internal static int WordCount(this string stringToCountWordsIn)
        {
            return stringToCountWordsIn.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /// <summary>
        /// Splits given text into sentence and paragraph count
        /// </summary>
        /// <param name="text">String to count sentences and paragraphs in</param>
        /// <returns>Tuple containing setence and paragraph quantity in given string</returns>
        internal static (int sentenceCount, int paragraphCount) SentenceAndParagraphCount(this string text)
        {
            text = text.Replace("...", "");
            var sentenceCount = text.Split('.').Length;
            var paragraphCount = text.Split('\n').Length;
            return (sentenceCount, paragraphCount);
        }

        public static void Main_(string[] args)
        {
            string userName = "Steve Jobs";
            // Using extension method syntax it looks like these methods are internals of string original class
            // But they are not. first one is converted into StringExtensions.ToRandomCase(text);
            Console.WriteLine(userName.ToRandomCase());
            Console.WriteLine(userName.WordCount());
            
            // Reading file
            var readFile = File.ReadAllText("../../files/SomeText.txt");
            Console.WriteLine($"SomeText.txt file conains words: {readFile.WordCount()}, " +
                              $"sentences: {readFile.SentenceAndParagraphCount().sentenceCount}," +
                              $" paragraphs: {readFile.SentenceAndParagraphCount().paragraphCount}");
        }
    }
}