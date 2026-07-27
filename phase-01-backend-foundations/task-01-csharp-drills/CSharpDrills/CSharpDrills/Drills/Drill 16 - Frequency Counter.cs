 using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpDrills.Drills
{
    internal class Drill_16___Frequency_Counter
    {
        public static void Run()
        {
            Console.Write("Enter array of number swparate by comma: ");
           string  numbers = Console.ReadLine();
            string[] n = numbers.Split(",", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (string num in n)
            {
                int s = int.Parse(num);
                if (frequency.ContainsKey(s))
                {
                    frequency[s]++;
                }
                else
                {
                    frequency[s] = 1;
                }
            }
            foreach (var item in frequency)
            {
                Console.Write($"{item.Key} => {item.Value} ,  ");
            }


        }
    }
}
