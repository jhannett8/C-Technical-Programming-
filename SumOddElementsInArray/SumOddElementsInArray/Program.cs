using System;

namespace SumOddElementsInArray
{
    class Program
    {
        static void Main()
        {
            {
                // Adds the odd index elements 
                int[] arr = { 17, 20, 37, 409, 500, 692 };
                int even = 0, odd = 0;

                // Loop to find even, odd sum 
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                        even += arr[i];
                    else
                        odd += arr[i];
                }
                
                Console.WriteLine("Odd index positions "+ "sum: " + odd);
                Console.ReadLine();
            }
        }
    }
}
