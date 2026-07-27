using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_19___Simple_Ticket_Price_Calculator
    {
        public static void Run()
        {
             double price = 100;
            double discount = 0;

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Invalid age.");
                return;
            }

            Console.Write("Are you a student? (yes/no): ");
            string student = Console.ReadLine().ToLower();

            if (age < 12)
            {
                discount = Math.Max(discount, 0.50);
            }

            if (age > 60)
            {
                discount = Math.Max(discount, 0.30);
            }

            if (student == "yes")
            {
                discount = Math.Max(discount, 0.20);
            }

            price = price * (1 - discount);

            Console.WriteLine(price);
        }
    }
}
