using System;
using System.IO;

namespace TheCPlayersGuide
{
    public class FileWrite
    {
        public static void Main_(string[] args)
        {
            FileStream fileStream = File.OpenWrite("../../files/some_data.txt");
            StreamWriter writer = new StreamWriter(fileStream);
            writer.Write("Hello ");
            writer.Write("and Goodbye ");
            writer.Write("at the same time");
            writer.Close();


            FileStream fileStream2 = File.OpenRead("../../files/some_data.txt");
            StreamReader reader = new StreamReader(fileStream2);

//            Console.WriteLine(reader.ReadLine());
            
            // Read a single character at a time.
            char nextCharacter = (char)reader.Read();
            // Read multiple characters at a time.
            char[] bufferToPutStuffIn = new char[2];
            reader.Read(bufferToPutStuffIn, 0, 2);
            string whatWasReadIn = new string(bufferToPutStuffIn);
            // Read a full line at a time.
            string restOfLine = reader.ReadLine();
            reader.Close();


            Console.WriteLine(nextCharacter);
            Console.WriteLine(whatWasReadIn);
            Console.WriteLine(restOfLine);
        } 
    }
}