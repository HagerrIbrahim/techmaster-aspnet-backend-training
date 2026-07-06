using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_07___Name_Formatter
    {
        public static void Run()
        {
            Console.WriteLine("enter full name");
            string x = Console.ReadLine().ToLower();
           x= x.Trim();
            string[] y = x.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string word = "";
            foreach (string s in y) { 
                 word += Char.ToUpper(s[0]) + s.Substring(1)+ " ";
            
            }
            Console.WriteLine(word);
        }   
    }
}
