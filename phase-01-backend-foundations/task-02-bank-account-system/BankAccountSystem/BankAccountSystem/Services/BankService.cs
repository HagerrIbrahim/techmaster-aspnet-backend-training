using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BankAccountSystem.Models;
namespace BankAccountSystem.Services
{
    public class BankService
    {
        private List<BankAccount> accounts = new List<BankAccount>();

        private int nextCustomerId = 1;
        private int nextAccountNumber = 1001;
        private int nextTransactionId = 1;
        public BankAccount CreateCustomerAccount(string fullName, string email, string phoneNumber, decimal initialBalance, AccountType accountType)
        {

            Customer customer = new Customer
            {
                FullName = fullName,
                Email = email,
                PhoneNumber = phoneNumber,
                CreatedAt = DateTime.Now,
                CustomerId = nextCustomerId
            };
            nextCustomerId++;

            BankAccount account = new BankAccount
            {
                AccountNumber = nextAccountNumber,
                Customer = customer,
                AccountType = accountType,
                CreatedAt = DateTime.Now
            };

            if (initialBalance >=0)
            {
                account.Deposit(initialBalance, nextTransactionId);
                nextTransactionId++;
            }
            else
            {
                return null;//no account well be done
            }
                nextAccountNumber++;
                accounts.Add(account);
                return account;
            
        }

        public BankAccount FindAccount(int accountNumber)
        {
            bool found = false;
            
            foreach (BankAccount account in accounts) {
                if (account.AccountNumber == accountNumber) {
                    return account;
                
                }
            }
            
                return null;
            
        }

        public bool DepositMoney(int accountNumber, decimal amount)
        {
            BankAccount accountt = FindAccount(accountNumber);
            if (accountt!=null)
            {
               bool answer= accountt.Deposit(amount, nextTransactionId);

                if (answer) {
                    nextTransactionId++; 
                    return true; }



            }
            return false;

        }
        public bool WithdrawMoney(int accountNumber, decimal amount) {
            BankAccount accountt = FindAccount(accountNumber);
            if (accountt != null)
            {
                bool answer = accountt.Withdraw(amount, nextTransactionId);
                if (answer) { nextTransactionId++; return true; }
            }
            return false;
        }

        public bool TransferMoney(int sourceAccountNumber, int destinationAccountNumber, decimal amount)
        {
            BankAccount sourceAccount = FindAccount(sourceAccountNumber);
            BankAccount destinationAccount = FindAccount(destinationAccountNumber);
            if (amount <= 0)
            {
                return false;
            }
            if (sourceAccount != null && destinationAccount!=null && sourceAccount != destinationAccount)
            {
                bool answer = sourceAccount.TransferOut(amount, nextTransactionId);
                if (answer) {
                    nextTransactionId++;
                    bool ans = destinationAccount.TransferIn(amount, nextTransactionId);
                    if (ans) { nextTransactionId++; return true; }
                }
            }
            return false;

        }

        public BankAccount GetAccountDetails(int accountNumber)
        {
            return FindAccount(accountNumber);
        }

        public List<BankAccount> GetAllAccounts()
        {
            return new List<BankAccount>(accounts);
        }


        public List<Transaction> GetTransactionHistory(int accountNumber)
        {
            BankAccount account = FindAccount(accountNumber);

            if (account == null)
            {
                return null;
            }

            return new List<Transaction>(account.Transactions.OrderByDescending(t => t.TransactionDate).ToList());
        }
    }
}
