using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_03___Simple_Login_Validator
    {
        public static void Run()
        {

            Dictionary<string, int> usernames = new Dictionary<string, int>() { { "hager", 123 }, { "ruaa", 555 }, { "farah", 232 } };
            for (int t = 1; t  <=3; t++)
            {
                Console.WriteLine("enter your user name");
                string u =  Console.ReadLine().ToLower();
                Console.WriteLine("enter your password");
                string PP = Console.ReadLine();
                if (!int.TryParse(PP, out int p))
                {
                    Console.WriteLine("Invalid password.");
                    continue;
                }
                bool found = false;
                foreach (var x in usernames)
                {
                    if (u == x.Key && p== x.Value)
                    {
                        found = true;
                        break;

                    }
                   

                }
                if (found)
                {
                    Console.WriteLine("login successfully");
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                }


            }
            Console.WriteLine("Account locked. Too many failed attempts");
        }
    }
}
