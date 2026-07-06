using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_12___Email_Validator
    {
        public static void Run()
        {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Invalid: Email cannot be empty.");
                return;
            }
            if (email.StartsWith("@") || email.EndsWith("@") || email.StartsWith(".") || email.EndsWith(".")|| !email.Contains("@"))
            {
                Console.WriteLine("Invalid");
                return;
            }
            
            if (!email.Contains("."))
            {
                Console.WriteLine("Invalid if you require dot");
                return;
            }

            if (email.Contains(" "))
            {
                Console.WriteLine("Invalid: Email cannot contain spaces.");
                return;
            }

            Console.WriteLine("Valid email.");
        }
    }
}
