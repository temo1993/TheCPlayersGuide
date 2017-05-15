using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TheCPlayersGuide.TryItOut
{
    public class EncryptDecrypt
    {
        private static readonly string[] EngAlphabet =
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U",
            "V", "W", "X", "Y", "Z"
        };

        private static readonly string[] RusAlphabet =
        {
            "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У",
            "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я"
        };

        private static readonly string[] GeoAlphabet =
        {
            "ა", "ბ", "გ", "დ", "ე", "ვ", "ზ", "თ", "ი", "კ", "ლ", "მ", "ნ", "ო", "პ", "ჟ", "რ", "ს", "ტ", "უ", "ფ",
            "ქ", "ღ", "ყ", "შ", "ჩ", "ც", "ძ", "წ", "ჭ", "ხ", "ჯ", "ჰ"
        };

        private static readonly Dictionary<string, string[]> Alphabet = new Dictionary<string, string[]>();


        static EncryptDecrypt()
        {
            Alphabet.Add("Eng", EngAlphabet);
            Alphabet.Add("Rus", RusAlphabet);
            Alphabet.Add("Geo", GeoAlphabet);
        }


        /// <summary>
        ///     Encrypts given file by Caesar cipher encryption
        /// </summary>
        /// <param name="fileToEncrypt">Path to file to encrypt(EX: ../../files/SampleText.txt)</param>
        /// <param name="fileToSaveIn">Path to file in which to save encrypted data</param>
        /// <param name="alphabet">Usage: Eng/Rus/Geo for English/Russian/Georgian text</param>
        /// <param name="shift">Shifts down every letter's alphabet by a certain number of letters.</param>
        public static void EncryptTofile(string fileToEncrypt, string fileToSaveIn, string alphabet, int shift)
        {
            if (shift < 0)
            {
                Console.WriteLine("shift must be equal or more than zero(0)!!!");
            }
            else
            {
                shift %= Alphabet[alphabet].Length;
                var text = File.ReadAllText(fileToEncrypt);
                var newString = new StringBuilder();
                int counter = 0;
                foreach (var t in text)
                {
                    for (var j = 0; j < Alphabet[alphabet].Length; j++)
                    {
                        if (t.ToString().Equals(Alphabet[alphabet][j],
                            StringComparison.InvariantCultureIgnoreCase))
                        {
                            if (shift == 0)
                            {
                                counter = j;
                            }
                            else if (j - shift >= 0)
                            {
                                counter = j - shift;
                            }
                            else if (j - shift < 0)
                            {
                                counter = (Alphabet[alphabet].Length) + (j - shift);
                            }
                        }
                    }
                    if (char.IsUpper(t) && char.IsLetter(t))
                    {
                        newString.Append(Alphabet[alphabet][counter]);
                    }
                    else if (char.IsLower(t) && char.IsLetter(t))
                    {
                        newString.Append(Alphabet[alphabet][counter].ToLowerInvariant());
                    }
                    else
                    {
                        newString.Append(t);
                    }
                }
                File.WriteAllText(fileToSaveIn, newString.ToString());
            }
        }

        /// <summary>
        ///     Decrypts given file by Caesar cipher encryption
        /// </summary>
        /// <param name="fileToDecrypt">Path to file to decrypt(EX: ../../files/SampleText.txt)</param>
        /// <param name="fileToSaveIn">Path to file in which to save decrypted data</param>
        /// <param name="alphabet">Usage: Eng/Rus/Geo for English/Russian/Georgian text</param>
        /// <param name="shift">Shifts up every letter's alphabet by a certain number of letters.</param>
        public static void DecryptTofile(string fileToDecrypt, string fileToSaveIn, string alphabet, int shift)
        {
            if (shift < 0)
            {
                Console.WriteLine("shift must be equal or more than zero(0)!!!");
            }
            else
            {
                shift %= Alphabet[alphabet].Length;
                var text = File.ReadAllText(fileToDecrypt);
                var newString = new StringBuilder();
                int counter = 0;
                foreach (var t in text)
                {
                    for (var j = 0; j < Alphabet[alphabet].Length; j++)
                    {
                        if (t.ToString().Equals(Alphabet[alphabet][j],
                            StringComparison.InvariantCultureIgnoreCase))
                        {
                            if (shift == 0)
                            {
                                counter = j;
                            }
                            else if (j + shift <= Alphabet[alphabet].Length - 1)
                            {
                                counter = j + shift;
                            }
                            else if (j + shift > Alphabet[alphabet].Length - 1)
                            {
                                counter = (j + shift) - (Alphabet[alphabet].Length);
                            }
                        }
                    }
                    if (char.IsUpper(t) && char.IsLetter(t))
                    {
                        newString.Append(Alphabet[alphabet][counter]);
                    }
                    else if (char.IsLower(t) && char.IsLetter(t))
                    {
                        newString.Append(Alphabet[alphabet][counter].ToLowerInvariant());
                    }
                    else
                    {
                        newString.Append(t);
                    }
                }
                File.WriteAllText(fileToSaveIn, newString.ToString());
            }
        }

        public static void Main_(string[] args)
        {
            EncryptTofile("../../TryItOut/files/input/SampleText.txt",
                "../../TryItOut/files/Output/OutputSampleText.txt", "Geo", 1);
            EncryptTofile("../../TryItOut/files/input/SampleText2.txt",
                "../../TryItOut/files/Output/OutputSampleText2.txt", "Eng", 1);
            EncryptTofile("../../TryItOut/files/input/SampleText3.txt",
                "../../TryItOut/files/Output/OutputSampleText3.txt", "Rus", 111);
            DecryptTofile("../../TryItOut/files/Output/OutputSampleText3.txt",
                "../../TryItOut/files/decrypted/DecryptedSampleText3.txt", "Rus", 111);
        }
    }
}