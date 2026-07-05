using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_06___Word_Counter
    {
        public static void Run()
        {
            Console.Write("Enter a sentence: ");
            string x = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(x))
            {
                Console.WriteLine("Sentence cannot be empty.");
                return;
            }

            x = x.Trim();

            string[] words = x.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Word count: "+words.Length);
        }
    }
}
