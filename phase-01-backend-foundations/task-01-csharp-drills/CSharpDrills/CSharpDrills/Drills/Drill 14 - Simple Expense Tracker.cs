using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CSharpDrills.Drills
{
    class Expense
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }

    internal class Drill_14___Simple_Expense_Tracker
    {
        public static void Run()
        {
            Console.Write("Enter number of expenses: ");
            int count = int.Parse(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("No expenses.");
                return;
            }

            List<Expense> expenses = new List<Expense>();

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Enter expense name: ");
                string name = Console.ReadLine();

                decimal amount;

                
                Console.Write("Enter amount ");
                amount = decimal.Parse(Console.ReadLine());

                if (amount <= 0)
                 {
                   Console.WriteLine("Invalid amount.");
                    return;
                 }
                expenses.Add(new Expense{Name = name,
                    Amount = amount });
            }

            decimal total = expenses.Sum(e => e.Amount);
            decimal average = expenses.Average(e => e.Amount);
            Expense highest = expenses.MaxBy(e => e.Amount);

            //Expense highest = expenses.OrderByDescending(e => e.Amount).First();


            Console.Write($"total :{total} , avg: {average} highest: {highest.Name } ");
        }
        }
}
