using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
        string textWithDuplicates= "aaabbcccggg";

        Console.WriteLine(textWithDuplicates.Count());
        var letters = new HashSet<char>(textWithDuplicates);
        Console.WriteLine(letters.Count());

        foreach (char c in letters) Console.Write(c);
        }
    }
}
