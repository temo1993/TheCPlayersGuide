using System;
using System.Collections.Generic;
using System.IO;

namespace TheCPlayersGuide
{
    internal class LineCounter
    {
        static void Main_(string[] args)
        {
            string directory = @"C:\Users\Temo\Source\Repos\TheCPlayersGuide\TheCPlayersGuide";
            Console.WriteLine("Project contains " + CountLinesOfCode(directory) + " lines of code.");
        }

        /// <summary>
        /// Totals up all of the lines of code in all of the files in a
        /// particular directory. This method is used recursively, so 
        /// any directory contained within this directory will be counted
        /// up by another call to this method.
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static int CountLinesOfCode(string directory)
        {
            // Start at 0.
            int count = 0;

            // Go through each child directory that is contained within
            // this directory and add up their lines of code.
            foreach (string child in Directory.GetDirectories(directory))
            {
                count += CountLinesOfCode(child);
            }

            // Go through each file in this directory...
            foreach (string file in Directory.GetFiles(directory))
            {
                // ... and if they're a .cs file...
                if (file.EndsWith(".cs"))
                {
                    // include the number of lines in that file.
                    count += CountLinesOfCodeInFile(file);
                }
            }

            return count;
        }


        /// <summary>
        /// Counts the number of lines in a file. This does not account
        /// for blank lines or lines that are just comments.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static int CountLinesOfCodeInFile(string file)
        {
            return File.ReadAllText(file).ParagraphCount();

            // or alternatively...
            // return File.ReadAllLines(file).Length;
        }
    }



    /*        internal int CountLinesInFile(string pathToFile)
            {
                FileStream fileStream = null;
                StreamReader sr = null;
                var stringList = new List<string>();
                try
                {
                    fileStream = File.OpenRead(pathToFile);
                    sr = new StreamReader(fileStream);
                    while (!sr.EndOfStream)
                    {
                        if (!string.IsNullOrEmpty(sr.ReadLine()))
                        {
                            stringList.Add(sr.ReadLine());
                        }
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    fileStream?.Close();
                    sr?.Close();
                }
                stringList.ForEach(Console.WriteLine);
                return stringList.Count;
            }*/
}


internal static class StringExtension
{
    /// <summary>
    /// Counts the number of paragraphs in a string. Paragraphs
    /// are assumed to be delimited by the new line character
    /// ('\n').
    /// </summary>
    public static int ParagraphCount(this string text)
    {
        return text.Split('\n').Length;
    }
}
