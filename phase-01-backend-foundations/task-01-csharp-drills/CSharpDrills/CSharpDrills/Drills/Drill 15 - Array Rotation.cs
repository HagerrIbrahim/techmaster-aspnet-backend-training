using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_15___Array_Rotation
    {
        public static void Run()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Elements ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            if (arr.Length > 1)
            {
                int temp = arr[arr.Length - 1];

                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }

                arr[0] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
