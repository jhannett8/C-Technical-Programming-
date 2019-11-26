using System;

namespace FizzBuzz
{
    class Program
    {
        //Write a program that prints the numbers from 1 to 100. 
        //But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
        //For numbers which are multiples of both three and five print "FizzBuzz".
        static void Main()
        {
            for (int n = 1; n <= 100; n++)
            {
                bool fizz = (n % 3 == 0);
                bool buzz = (n % 5 == 0);
                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (buzz)
                {
                    Console.WriteLine("buzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadLine();
        }
    }
}
