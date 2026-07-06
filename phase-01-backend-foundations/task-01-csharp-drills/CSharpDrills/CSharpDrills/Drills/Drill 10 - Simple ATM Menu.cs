using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDrills.Drills
{
    internal class Drill_10___Simple_ATM_Menu
    {
        public static void Run()
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
                        Console.Write("Enter withdrawal amount: ");
                        decimal withdraw = decimal.Parse(Console.ReadLine());

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
        }
    }
}
