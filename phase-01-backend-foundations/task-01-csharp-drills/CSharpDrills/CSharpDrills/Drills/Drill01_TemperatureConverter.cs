using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill01_TemperatureConverter
    {
        public static void Run()
        {
            Console.WriteLine("enter the degree in Celsius value");
            // double input = Convert.ToDouble( Console.ReadLine());

            string x =Console.ReadLine();
            if(!double.TryParse(x,out double y))
            {
                Console.WriteLine("invalid value");
                return;
            }
            double result = y * 9 / 5 + 32;
            Console.WriteLine(x+ "°C = "+ result.ToString("F2") + "°F");
        }


       
    }
}
