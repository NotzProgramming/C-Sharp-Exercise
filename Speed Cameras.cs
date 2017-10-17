using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Your job is to write a program for a speed camera. For simplicity,
             * ignore the details such as camera, sensors, etc and focus purely on 
             * the logic. Write a program that asks the user to enter the speed limit.
             * Once set, the program asks for the speed of a car. If the user enters 
             * a value less than the speed limit, program should display Ok on the 
             * console. If the value is above the speed limit, the program should 
             * calculate the number of demerit points. For every 5km/hr above the 
             * speed limit, 1 demerit points should be incurred and displayed on 
             * the console. If the number of demerit points is above 12, the program
             * should display License Suspended.*/

            Console.WriteLine("Enter speed limited.");
            var input1 = Console.ReadLine();
            Console.WriteLine("Enter the speed of your car.");
            var input2 = Console.ReadLine();

            var number1 = Convert.ToInt32(input1);
            var number2 = Convert.ToInt32(input2);

            if (number1 >= number2)
                Console.WriteLine("OK.");
            else
            {
                number2 = (number2 - number1) / 5;
                Console.WriteLine("Your demerit points is " + number2);
                if (number2 >= 12)
                    Console.WriteLine("License Suspended.");
            }
        }


    }
}
