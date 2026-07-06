using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_13___Palindrome_Checker
    {
        public static void Run()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine().ToLower().Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Input cannot be empty.");
                return;
            }

            

            bool hasSpaces = text.Contains(" ");

            if (hasSpaces)
            {
                text = text.Replace(" ", "");
            }

            string reversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            if (text == reversed)
            {
                if (hasSpaces)
                    Console.WriteLine("Palindrome if spaces ignored");
                else
                    Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
