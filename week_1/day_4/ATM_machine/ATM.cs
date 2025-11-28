using System;
using System.Collections.Generic;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        var accounts = new Dictionary<string, Account>
        {
            { "12345", new Account("12345", 6789, 1000) },
            { "54321", new Account("54321", 1111, 2000) }
        };

        ATM atm = new ATM(accounts);

        Console.WriteLine("Welcome to the ATM Machine!\n");

        Account loggedInAccount = null;
        while (loggedInAccount == null)
        {
            loggedInAccount = atm.Authenticate();
        }
        string choice = "";
        while (choice != "5")
        {
            atm.ShowMenu();
            Console.Write("\nSelect an option: ");
            choice = Console.ReadLine();

            atm.PerformAction(loggedInAccount, choice);
        }

        Console.WriteLine("\nThank you for using our ATM!");
        Console.WriteLine("summary of your transactions:");

        loggedInAccount.ShowTransactions();
    }
}
