using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_18___Number_Statistics
    {
        public static void Run()
        {
            Console.Write("Enter array of number swparate by comma: ");
            string numbers = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numbers))
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            string[] n = numbers.Split(",", StringSplitOptions.RemoveEmptyEntries);
            int count = n.Length;
            double sum = 0;
            int positiveCount = 0;
            int negativeCount = 0;
            

            int first = int.Parse(n[0].Trim());
            int max = first;
            int min = first;

            foreach (string x in n)
            {
                int number = int.Parse(x.Trim());

                sum += number;

                if (number > max)
                    max = number;

                if (number < min)
                    min = number;

                if (number > 0)
                    positiveCount++;
                else if (number < 0)
                    negativeCount++;
               
            }

            double average = sum / count;
            Console.WriteLine($"Count: {count}, Sum: {sum} , Average: {average} , Max: {max} , Min: {min} , Positive Numbers: {positiveCount} , Negative Numbers: {negativeCount}");

        }
    }
}
