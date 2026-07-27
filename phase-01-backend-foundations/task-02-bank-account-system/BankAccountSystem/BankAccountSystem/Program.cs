//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;
using BankAccountSystem.Services;
using BankAccountSystem.Models;
using BankAccountSystem.UI;


BankService bankService = new BankService();

ConsoleMenu c = new ConsoleMenu(bankService);

c.Run();