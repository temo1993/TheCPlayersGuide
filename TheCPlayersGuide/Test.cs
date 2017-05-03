using System;
using System.Collections.Generic;

namespace TheCPlayersGuide
{
    public class ListAddRemove
    {   
            static void Main_(string[] args)
            {
                List<string> simpleList = new List<string>();

                while (true)
                {
                    Console.WriteLine($"List contains: {string.Join(",", simpleList)}");
                    Console.WriteLine("Enter command (+ item, - item, or -- to clear, to Exit Press N)):");
                    Console.WriteLine("To add/remove all/remove items in the List press: +/--/-.");
                    var userInput = Console.ReadLine();
                    if (userInput != null)
                    {
                        string[] userInputStrings = userInput.Split(' ');
                        if (userInput.Contains("+"))
                        {
                            for (int i = 1; i < userInputStrings.Length; i++)
                            {
                                simpleList.Add(userInputStrings[i]);
                            } 
                        }
                        else if (userInput.Contains("--"))
                        {
                            simpleList.Clear();  
                        }
                        else if (userInput.Contains("-"))
                        {
                            for (int i = 1; i < userInputStrings.Length; i++)
                            {
                                simpleList.Remove(userInputStrings[i]);
                            }
                        }
                        else if (string.Equals("N", userInput, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Bye! :)");
                            break;
                        }
                    }
                }
            }
        }
    }
