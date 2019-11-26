using System;

namespace ReverseWordsInSpring
{
    class Program
    {
        public static void Main()
        {
            //set array values
            string[] s = "i like this program very much".Split(' ');
            string ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + " ";
            }
            Console.Write(ans.Substring(0, ans.Length - 1));
            Console.ReadLine();
            
            
            //Allows for user input
            Console.WriteLine("Write a line and I will reverse it!");
            string[] input = Console.ReadLine().Split(' ');
            string inputstring = "";
            for (int j = input.Length - 1; j >= 0; j--)
            {
                inputstring += input[j] + " ";
            }
            Console.WriteLine(inputstring);
            Console.ReadLine();
        }
    }
}
