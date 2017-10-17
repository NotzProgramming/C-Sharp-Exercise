using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a series of numbers separated by comma.
             * Find the maximum of the numbers and display it on the console. For example, if 
             * the user enters “5, 3, 8, 1, 4", the program should display 8. */

            Console.WriteLine("Enter the nunber.");
            var input = Console.ReadLine();
            var arraystrings = input.Split(',');
            var comparenumber = 0;

            foreach (var arraystring in arraystrings)
            {
                var convertnumber = Convert.ToInt32(arraystring);
                if (convertnumber > comparenumber)
                    comparenumber = convertnumber;
            }

            Console.WriteLine("The biggest number is {0}.",comparenumber);

        }
    }
}
