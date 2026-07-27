using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_20___Method_Refactoring_Challenge
    {
       /*ublic void Run()
        {
            Dictionary<string, int> usernames = new Dictionary<string, int>() { { "hager", 123 }, { "ruaa", 555 }, { "farah", 232 } };
            Login(usernames);
        }
        static void Login(Dictionary<string, int> users)
        {
            for (int t = 1; t <= 3; t++)
            {
                Console.WriteLine("enter your user name");
                string u = Console.ReadLine().ToLower();
                Console.WriteLine("enter your password");
                string PP = Console.ReadLine();
                if (!int.TryParse(PP, out int p))
                {
                    Console.WriteLine("Invalid password.");
                    continue;
                }
                bool found = false;
                foreach (var x in users)
                {
                    if (u == x.Key && p == x.Value)
                    {
                        found = true;
                        break;

                    }


                }
                if (found)
                {
                    Console.WriteLine("login successfully");
                    decimal x = Drill_09___Shopping_Cart_Total.Run();
                    if (x != 0)
                    {
                        Drill_10___Simple_ATM_Menu.Run(x);
                    }
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                }


            }
            Console.WriteLine("Account locked. Too many failed attempts");

        }





        public static decimal Run()
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
                    return 0;

                }

                Console.Write("Enter quantity of item  ");
                string y = Console.ReadLine();
                if (!int.TryParse(y, out int quantity) || quantity <= 0)
                {
                    Console.WriteLine("invalid quantity");
                    return 0;

                }


                subtotal = price * quantity;
                total += subtotal;
            }

            if (total > 1000)
            {
                decimal discount = total * 0.10m;
                total -= discount;
                //Console.Write($"discount {discount} , final {total}  ");

                return total;
            }
            else
            {
                //Console.Write($"no discount , total {total}  ");
                return total;
            }

        }






        public static void Run(decimal amount_money)
        {
            decimal balance = 1000m;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== ATM Menu =====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Balance: {balance}");
                        break;

                    case 2:
                        Console.Write("Enter deposit amount: ");
                        decimal deposit = decimal.Parse(Console.ReadLine());

                        if (deposit > 0)
                        {
                            balance += deposit;
                            Console.WriteLine($"New Balance: {balance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount.");
                        }
                        break;

                    case 3:
                        //Console.Write("Enter withdrawal amount: ");
                        //decimal withdraw = decimal.Parse(Console.ReadLine());
                        decimal withdraw = amount_money;
                        if (withdraw <= 0)
                        {
                            Console.WriteLine("Invalid withdrawal amount.");
                        }
                        else if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient balance.");
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine($"New Balance: {balance}");
                        }
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Thank you for using our ATM.");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }*/
    }
}
