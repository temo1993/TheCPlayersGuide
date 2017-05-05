using System;
using System.IO;

namespace TheCPlayersGuide
{
    public class BinaryFileReadWriteTest
    {
        public static void Main_(string[] args)
        {
            FileStream fileStream = File.OpenWrite("../../files/Here4.txt");
            BinaryWriter writer = new BinaryWriter(fileStream);
            writer.Write(3);
            writer.Write("Hello");
            writer.Close();

            fileStream = File.OpenRead("../../files/Here4.txt");
            BinaryReader reader = new BinaryReader(fileStream);
            int number = reader.ReadInt32();
            string text = reader.ReadString();
            Console.Write(number + " ");
            Console.WriteLine();
            Console.Write(text + " ");
            Console.WriteLine();
            reader.Close();
        }
    }
}