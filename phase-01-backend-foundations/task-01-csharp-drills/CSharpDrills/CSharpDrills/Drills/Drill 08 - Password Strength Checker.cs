using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_08___Password_Strength_Checker
    {
        public static void Run()
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool upper = false;
            bool lower = false;
            bool digit = false;
            bool scase = false;

            foreach (char x in password) {
                if (char.IsLower(x))
                {
                    lower=true;
                }
               else if (char.IsUpper(x))
                {
                    upper = true;
                }
                else if (char.IsDigit(x))
                {
                    digit = true;
                }
                else 
                {
                    scase = true;
                }
            }


            if (lower && upper && digit && scase) { Console.Write("Strong ");
                return;
            }
            else { 
            List<string> missing = new List<string>();

            if (password.Length < 8)
                missing.Add("length >= 8");

            if (!upper)
                missing.Add("uppercase");

            if (!lower)
                missing.Add("lowercase");

            if (!digit)
                missing.Add("digit");

            if (!scase)
                missing.Add("special character");

            
                Console.WriteLine("Weak - missing " + string.Join(", ", missing));
            }

        }
    }
}
