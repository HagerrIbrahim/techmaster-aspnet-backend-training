using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_09___Shopping_Cart_Total
    {
        public static void Run()
        {
            Console.Write("Enter number of items: ");
            int items = int.Parse(Console.ReadLine());

            decimal total = 0;
            decimal subtotal;


            for (int i = 1; i <= items; i++)
            {
                Console.Write("Enter price of item  ");
                string x = Console.ReadLine();
                if (!decimal.TryParse(x, out decimal price) || price <= 0)
                {
                    Console.WriteLine("invalid price");
                    return;

                }

                Console.Write("Enter quantity of item  ");
                string y = Console.ReadLine();
                if (!int.TryParse(y, out int quantity) || quantity <= 0)
                {
                    Console.WriteLine("invalid quantity");
                    return;

                }


                subtotal = price * quantity;
                total += subtotal;
            }

            if (total > 1000)
            {
                decimal discount = total * 0.10m;
                total -= discount;
                Console.Write($"discount {discount} , final {total}  ");
            }
            else {
                Console.Write($"no discount , total {total}  ");
            }

            }
    }
}
