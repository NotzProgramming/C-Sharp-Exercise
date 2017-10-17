using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter an English word. Count the number of
             * vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program
             * should display 6 on the console. */

            Console.WriteLine("Enter the words.");
            var input = Console.ReadLine();

            var count = CountVowels(input);
            Console.WriteLine(count);
            
        }

        public static int CountVowels (string words)
        {
            var count = 0;

            for (var i = 0; i < words.Length; i++)
            {
                var word = words.ToLower().Substring(i, 1);
                switch (word)
                {
                    case "a":
                        count++;
                        break;
                    case "e":
                        count++;
                        break;
                    case "i":
                        count++;
                        break;
                    case "o":
                        count++;
                        break;
                    case "u":
                        count++;
                        break;
                }
            }

            return count;

        }
    }
}
