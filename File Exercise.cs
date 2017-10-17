using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads a text file and displays the longest word in the file. */

            var input = File.ReadAllText(@"D:\test.txt");
            var count = 0;
            var maxlength = 0;
            var words = new List<string>();
            
            foreach (var word in input.Split(' '))
            {
                if (word.Length > maxlength)
                {
                    maxlength = word.Length;
                    words.Clear();
                    words.Add(word);
                }
                count++;
            }
            Console.WriteLine("Number Of Words: " + count);
            Console.WriteLine("The Longest Word is " + words[0]);
        }
    }
}
