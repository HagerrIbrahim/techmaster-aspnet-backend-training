using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_11___Duplicate_Number_Detector
    {
        public static void Run()
        {
            Console.Write("Enter integers separate by commas ");

            string x = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(x))
            {
                Console.WriteLine("No duplicates found.");
                return;
            }

            string[] d = x.Split(',', StringSplitOptions.RemoveEmptyEntries);

            HashSet<int> seen = new HashSet<int>(); // if first time => true   if the digit duplicate => false
            HashSet<int> duplicates = new HashSet<int>();

            foreach (string dig in d)
            {
                int num = int.Parse(dig);

                if (!seen.Add(num))
                {
                    duplicates.Add(num);
                }
            }

            if (duplicates.Count == 0)
            {
                Console.WriteLine("No duplicates found.");
            }
            else
            {
                Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));
            }
        }
    }
}
