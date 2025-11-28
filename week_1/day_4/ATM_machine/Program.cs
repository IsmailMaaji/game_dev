using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        var accounts = new Dictionary<string, Account>
        {
            { "bh55587", new Account("bh55587", 6789, 1000) },
            { "bh47963", new Account("bh47963", 1111, 2000) }
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
        Console.WriteLine(" summary of your transactions:");

        loggedInAccount.ShowTransactions();
    }
}
