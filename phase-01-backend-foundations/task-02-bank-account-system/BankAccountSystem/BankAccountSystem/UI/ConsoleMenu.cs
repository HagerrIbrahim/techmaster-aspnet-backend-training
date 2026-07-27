using System;
using System.Collections.Generic;
using System.Text;
using BankAccountSystem.Services;
using BankAccountSystem.Models;
namespace BankAccountSystem.UI
{
    public class ConsoleMenu
    {
        private BankService bankService;

        public ConsoleMenu(BankService bankService)
        {
            this.bankService = bankService;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("====== TechMaster Bank System ======");
                Console.WriteLine("1. Create Customer Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Transfer Money");
                Console.WriteLine("5. View Account Details");
                Console.WriteLine("6. View Transaction History");
                Console.WriteLine("7. View All Accounts");
                Console.WriteLine("8. Exit");

                Console.Write("Choose an option: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CreateAccount();
                        break;

                    case 2:
                        Deposit_Money();
                        break;

                    case 3:
                        Withdraw_Money();
                        break;

                    case 4:
                        Transfer_Money();
                        break;
                    case 5:
                        ViewAccountDetails();
                        break;
                    case 6:
                        ViewTransactionHistory();
                        break;
                    case 7:
                        ViewAllAccounts();
                        break;
                    case 8:
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }


        public void CreateAccount()
        {
            AccountType accountType;

            Console.WriteLine("Enter Full Name");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid input");
                return;
            }


            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Invalid input");
                return;
            }


            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                Console.WriteLine("Invalid input");
                return;
            }


            Console.WriteLine("Enter Initial Balance");

            decimal initialBalance;

            if (!decimal.TryParse(Console.ReadLine(), out initialBalance))
            {
                Console.WriteLine("Invalid balance");
                return;
            }


            Console.WriteLine("Enter Account Type [1-Savings / 2-Current]");

            int type;

            if (!int.TryParse(Console.ReadLine(), out type))
            {
                Console.WriteLine("Invalid input");
                return;
            }


            if (type == 1)
            {
                accountType = AccountType.Savings;
            }
            else if (type == 2)
            {
                accountType = AccountType.Current;
            }
            else
            {
                Console.WriteLine("Invalid account type");
                return;
            }


            BankAccount account = bankService.CreateCustomerAccount(name,email,phoneNumber,initialBalance,accountType);


            if (account != null)
            {
                Console.WriteLine("Account created successfully");
                Console.WriteLine($"Account Number: {account.AccountNumber}");
            }
            else
            {
                Console.WriteLine("Account creation failed");
            }

        }



        public void Deposit_Money()
        {
            Console.WriteLine("Enter your account number");

            int accountNumber;

            if (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid account number");
                return;
            }


            Console.WriteLine("Enter amount to deposit");

            decimal amount;

            if (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount");
                return;
            }


            bool answer = bankService.DepositMoney(accountNumber, amount);


            if (answer)
            {
                Console.WriteLine("Transaction done successfully");
            }
            else
            {
                Console.WriteLine("Transaction failed");
            }
        }



        public void Withdraw_Money()
        {
            Console.WriteLine("Enter your account number");

            int accountNumber;

            if (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid account number");
                return;
            }


            Console.WriteLine("Enter amount to withdraw");

            decimal amount;

            if (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount");
                return;
            }


            bool answer = bankService.WithdrawMoney(accountNumber, amount);


            if (answer)
            {
                Console.WriteLine("Transaction done successfully");
            }
            else
            {
                Console.WriteLine("Transaction failed");
            }
        }



        public void Transfer_Money()
        {
            Console.WriteLine("Enter your account number");

            int sourceAccount;

            if (!int.TryParse(Console.ReadLine(), out sourceAccount))
            {
                Console.WriteLine("Invalid account number");
                return;
            }


            Console.WriteLine("Enter destination account number");

            int destinationAccount;

            if (!int.TryParse(Console.ReadLine(), out destinationAccount))
            {
                Console.WriteLine("Invalid account number");
                return;
            }


            Console.WriteLine("Enter amount to transfer");

            decimal amount;

            if (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount");
                return;
            }


            bool answer = bankService.TransferMoney(sourceAccount, destinationAccount, amount);


            if (answer)
            {
                Console.WriteLine("Transaction done successfully");
            }
            else
            {
                Console.WriteLine("Transaction failed");
            }
        }



        public void ViewAccountDetails()
        {
            Console.WriteLine("Enter account number");

            int accountNumber;

            if (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid account number");
                return;
            }


            BankAccount account = bankService.GetAccountDetails(accountNumber);


            if (account == null)
            {
                Console.WriteLine("Account not found");
                return;
            }


            Console.WriteLine("====== Account Details ======");

            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Customer Name: {account.Customer.FullName}");
            Console.WriteLine($"Email: {account.Customer.Email}");
            Console.WriteLine($"Phone: {account.Customer.PhoneNumber}");
            Console.WriteLine($"Account Type: {account.AccountType}");
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine($"Created At: {account.CreatedAt}");
            Console.WriteLine($"Status: {(account.IsActive ? "Active" : "Inactive")}");
        }




        public void ViewTransactionHistory()
        {
            Console.WriteLine("Enter account number");

            int accountNumber;

            if (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid account number");
                return;
            }


            List<Transaction> transactions = bankService.GetTransactionHistory(accountNumber);


            if (transactions == null)
            {
                Console.WriteLine("Account not found");
                return;
            }


            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions yet");
                return;
            }


            Console.WriteLine("====== Transaction History ======");


            foreach (Transaction transaction in transactions)
            {
                Console.WriteLine($"Transaction ID: {transaction.TransactionId}");
                Console.WriteLine($"Type: {transaction.TransactionType}");
                Console.WriteLine($"Amount: {transaction.Amount}");
                Console.WriteLine($"Date: {transaction.TransactionDate}");
                Console.WriteLine($"Description: {transaction.Description}");
                Console.WriteLine($"Balance After Transaction: {transaction.BalanceAfterTransaction}");
                Console.WriteLine("------------------------------");
            }
        }

        public void ViewAllAccounts()
        {
            List<BankAccount> accounts = bankService.GetAllAccounts();


            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts created yet");
                return;
            }


            Console.WriteLine("====== All Accounts ======");


            foreach (BankAccount account in accounts)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}");
                Console.WriteLine($"Customer Name: {account.Customer.FullName}");
                Console.WriteLine($"Account Type: {account.AccountType}");
                Console.WriteLine($"Balance: {account.Balance}");
                Console.WriteLine($"Status: {(account.IsActive ? "Active" : "Inactive")}");
                Console.WriteLine("-------------------------");
            }
        }

    }
}