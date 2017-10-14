using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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
