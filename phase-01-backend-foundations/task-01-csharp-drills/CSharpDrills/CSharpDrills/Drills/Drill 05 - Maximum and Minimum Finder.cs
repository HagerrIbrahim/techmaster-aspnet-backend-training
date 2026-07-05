using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_05___Maximum_and_Minimum_Finder
    {
        public static void Run()
        {
            Console.Write("How many numbers do you want to enter? ");
            string x = Console.ReadLine();
            if (!int.TryParse(x, out int count) || count <= 0)
            {
                Console.WriteLine("List cannot be empty.");
                return;
            }

            List<int> numbers = new List<int>();

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Enter number ");
                string y = Console.ReadLine();
                if (!int.TryParse(y, out int num))
                {
                    Console.WriteLine("Invalid number.");
                    return;
                }

                numbers.Add(num);
            }

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Max = "+ max+"|"+ "Min = " + min);
         
        }
        }
}
