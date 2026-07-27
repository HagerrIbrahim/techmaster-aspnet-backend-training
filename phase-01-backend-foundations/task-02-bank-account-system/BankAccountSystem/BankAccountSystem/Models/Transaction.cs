using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountSystem.Models
{
     public class Transaction
        {
            public int TransactionId { get; set; }

            public int AccountNumber { get; set; }

            public TransactionType TransactionType { get; set; }

            public decimal Amount { get; set; }

            public DateTime TransactionDate { get; set; } = DateTime.Now;

            public string Description { get; set; } = string.Empty;

            public decimal BalanceAfterTransaction { get; set; }
        }
    
}
