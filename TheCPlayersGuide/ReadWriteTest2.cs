using System;
using System.IO;

namespace TheCPlayersGuide
{
    public class ReadWriteTest2
    {
        public static void Main_(string[] args)
        {
            FileStream fileStream = File.OpenWrite("../../files/Here3.txt");
            StreamWriter writer = new StreamWriter(fileStream);
            writer.Write(3);
            writer.Write("Hello");
            writer.Close();


            fileStream = File.OpenRead("../../files/Here3.txt");
            StreamReader reader = new StreamReader(fileStream);
            // Read a single character at a time.
            char nextCharacter = (char)reader.Read();
            Console.Write(nextCharacter);

            // Read multiple characters at a time.
            char[] bufferToPutStuffIn = new char[2];
            reader.Read(bufferToPutStuffIn, 0, 2);
            string whatWasReadIn = new string(bufferToPutStuffIn);
            Console.Write(whatWasReadIn);

            // Read a full line at a time.
            string restOfLine = reader.ReadLine();
            Console.Write(restOfLine);
            reader.Close();
        }
    }
}