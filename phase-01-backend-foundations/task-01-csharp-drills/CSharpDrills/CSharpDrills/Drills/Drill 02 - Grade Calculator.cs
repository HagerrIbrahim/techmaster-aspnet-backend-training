using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_02___Grade_Calculator
    {
        public static void Run()
        {

            Console.WriteLine("enter your score");
            string x=Console.ReadLine();
            if(!double.TryParse(x, out double grade))
            {
                Console.WriteLine("invalid grade");
                return;

            }
            if(grade<0 || grade > 100)
            {
                Console.WriteLine("Score must be between 0 and 100.");
                return;
            }
            else if (grade > 89)
            {
                Console.WriteLine("A");
            }
            else if (grade > 79)
            {
                Console.WriteLine("B");
            }
            else if (grade > 69)
            {
                Console.WriteLine("C");
            }
            else if (grade > 59)
            {
                Console.WriteLine("D");
            }
            else 
            {
                Console.WriteLine("F");

            }
            
           
        }
    }
}
