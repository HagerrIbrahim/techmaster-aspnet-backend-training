using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_17___Simple_Search_Eng
    {
        public static void Run()
        {
            List<string> names = new List<string>
        {
            "hager ibrahim",
            "salma fathy",
            "shada ahmed",
            "Sara Mohamed",
            "farah younis",
            "farah mohamed"
        };

            Console.Write("Enter search keyword: ");
            string keyword = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                Console.WriteLine("Keyword cannot be empty.");
                return;
            }

            bool found = false;

            foreach (string name in names)
            {
                if (name.ToLower().Contains(keyword.ToLower()))
                {
                    Console.Write(name+ " , ");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No results found.");
            }

        }
    }
}
