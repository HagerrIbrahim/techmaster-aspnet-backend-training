using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountSystem.Models
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }

        public Customer Customer { get; set; } = new Customer();

        public decimal Balance { get; private set; }

        public AccountType AccountType { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public bool Deposit(decimal amount,int transictionid)
        {
            bool found = false;
            if(amount <= 0) {  return found; }
            else
            {
                Balance += amount;
                found = true;
            }
            /*Transaction t =new Transaction();
            t.BalanceAfterTransaction = Balance;
            t.Amount = amount;
            t.TransactionDate = DateTime.Now;
           // t.TransactionId += 1;
            t.TransactionType = TransactionType.Deposit;
            t.AccountNumber = AccountNumber;
            t.Description = "Cash Deposit";
            Transactions.Add(t);*/

            AddTransaction(Balance, amount, TransactionType.Deposit, AccountNumber, " Cash Deposit", DateTime.Now, transictionid);
            return found;

        }
        public bool TransferIn(decimal amount, int transictionid)
        {
            bool found = false;
            if (amount <= 0) { return found; }
            else
            {
                Balance += amount;
                found = true;
            }
            /*Transaction t = new Transaction();
            t.BalanceAfterTransaction = Balance;
            t.Amount = amount;
            t.TransactionDate = DateTime.Now;
            // t.TransactionId += 1;
            t.TransactionType = TransactionType.TransferIn;
            t.AccountNumber = AccountNumber;
            t.Description = "Cash transfere in";
            Transactions.Add(t);*/
            AddTransaction(Balance, amount, TransactionType.TransferIn, AccountNumber, " Cash transfere in", DateTime.Now, transictionid);
            return found;

        }

        public bool Withdraw(decimal amount, int transictionid) {
            bool found = false;// because when return false ui write it is wrong or invalid transaction else write new balance
            if (amount <= 0) { return found; }
            else if (amount > Balance) { return found; }
            else
            {
                Balance-= amount;
                //Object Initializer.
                /* Transaction t = new Transaction
                 {
                     BalanceAfterTransaction = Balance,
                     Amount = amount,
                     TransactionDate = DateTime.Now,
                     TransactionType = TransactionType.Withdraw,
                     AccountNumber = AccountNumber,
                     Description = "Cash withdraw"
                 };
                 Transactions.Add(t);*/

                AddTransaction(Balance, amount, TransactionType.Withdraw, AccountNumber, " Cash withdraw", DateTime.Now, transictionid);
                found = true;
            }
            return found;
        }

        public bool TransferOut(decimal amount, int transictionid)
        {
            bool found = false;// because when return false ui write it is wrong or invalid transaction else write new balance
            if (amount <= 0) { return found; }
            else if (amount > Balance) { return found; }
            else
            {
                Balance -= amount;
                //Object Initializer.
                /* Transaction t = new Transaction
                 {
                     BalanceAfterTransaction = Balance,
                     Amount = amount,
                     TransactionDate = DateTime.Now,
                     TransactionType = TransactionType.TransferOut,
                     AccountNumber = AccountNumber,
                     Description = "Cash Transfer Out"
                 };
                 Transactions.Add(t);*/

                AddTransaction(Balance, amount, TransactionType.TransferOut, AccountNumber," Cash Transfer Out", DateTime.Now, transictionid);
                found = true;
            }
            return found;
        }


        private void AddTransaction(decimal balance, decimal Amountt, TransactionType type, int accountnumber, string description, DateTime TransactionDate, int transictionid)
        {
            Transaction t = new Transaction
            {
                BalanceAfterTransaction = balance,
                Amount = Amountt,
                TransactionDate = TransactionDate,
                TransactionType = type,
                AccountNumber = accountnumber,
                Description = description,
                TransactionId = transictionid
            };
            Transactions.Add(t);
        }
    }


}
