using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountSystem.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; } = "";// to not be equal null

        public string Email { get; set; } = "";

        public string PhoneNumber { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
