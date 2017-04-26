using System;
using System.IO;
using System.Threading.Tasks;

namespace TheCPlayersGuide
{
    public class FileWriteRead
    {
        public static void Main_(string[] args)
        {
            FileStream fileStream = File.OpenWrite("../../files/some_data.txt");
            StreamWriter writer = new StreamWriter(fileStream);
            writer.Write("Hello ");
            writer.Write("and Goodbye ");
            writer.Write("at the same time.");
            writer.Write("\nEvery little thing gonna be alright");
            writer.Close();


            FileStream fileStream2 = File.OpenRead("../../files/some_data.txt");
            StreamReader reader = new StreamReader(fileStream2);


//            Console.WriteLine(reader.ReadLine());
            
            // Read a single character at a time.
            char nextCharacter = (char)reader.Read();
            // Read multiple characters at a time.
            char[] bufferToPutStuffIn = new char[2];
            //You also indicate what index to start writing in the array (we use 0 here)
            //and how many characters to read in (2, in this case).
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