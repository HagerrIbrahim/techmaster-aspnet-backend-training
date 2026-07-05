using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_04___Even_Odd_Analyzer
    {
        public static void Run()
        {
            Console.Write("How many numbers will you enter? ");
            string x = Console.ReadLine();
            if (!int.TryParse(x, out int count) || count <= 0)
            {
                Console.WriteLine("Count must be a positive number.");
                return;
            }

            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Enter number");
                string y = Console.ReadLine();
                if (!int.TryParse(y, out int number))
                {
                    Console.WriteLine("Invalid number.");
                    return;
                }

                if (number % 2 == 0)
                {
                    even.Add(number);
                }
                else
                {
                    odd.Add(number);
                }
            }
            if (odd.Count == 0)
            {
                Console.WriteLine("odd list should be empty");
            }
            else if (even.Count == 0) { Console.WriteLine("even list should be empty"); }
            
            Console.WriteLine($"Even : {string.Join(", ", even)}" + "|" + $"Odd Numbers: {string.Join(", ", odd)}");
           
        }
    }
}
