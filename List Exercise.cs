using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9,
             * 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask
             * the user to re-try; otherwise, display the 3 smallest numbers in the list. */

            string[] sep;
            while (true)
            {
                Console.WriteLine("Enter a list of numbers.");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    sep = input.Split(',');
                    if (sep.Length > 5 )
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid List. Try again.");
            }

            var result = new int[sep.Length];
            for (var i = 0; i < sep.Length ; i++)
                result[i] = Convert.ToInt32(sep[i]);

            Array.Sort(result);
            Console.WriteLine("The result is : {0} ,{1} ,{2}",result[0],result[1],result[2]);

        }
    }
}
