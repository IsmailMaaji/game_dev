//Exercise 1: Birthday Look-up
Dictionary<string, string> birthdays = new Dictionary<string, string>()
{
    { "Ismail Maaji", "28/01/2000" },
    { "Mouad fahimi", "21/02/2000" },
    { "Rabab Barkach", "03/07/2003" },
    { "Kawatar lololo", "14/09/1998" },
    { "Soufian Rahimi", "17/11/1993" },
    
};

    Console.WriteLine("Welcome! You can look up birthdays.");
    Console.Write("Enter a person's name: ");
        string name = Console.ReadLine();



//Exercise 2: Birthdays Advanced

Dictionary<string, string> birthdays = new Dictionary<string, string>()
{
    { "Ismail Maaji", "28/01/2000" },
    { "Mouad fahimi", "21/02/2000" },
    { "Rabab Barkach", "03/07/2003" },
    { "Kawatar lololo", "14/09/1998" },
    { "Soufian Rahimi", "17/11/1993" },
    
};


        Console.WriteLine("Available names:");

        foreach (var person in birthdays.Keys)
        {
            Console.WriteLine("- " + person);
        }

        Console.Write("\nEnter a name to look up: ");
        string name = Console.ReadLine();

        if (birthdays.ContainsKey(name))
        {
            Console.WriteLine($"{name}'s birthday is: {birthdays[name]}");
        }
        else
        {
            Console.WriteLine($"Sorry, we don’t have the birthday information for {name}.");
        }

        //Exercise 3 : Sum Sequence
        
        Console.WriteLine("Enter a number");

            String s = Console.ReadLine();



            int n1 = int.Parse(s);
            int n2 = int.Parse(s+s);
            int n3 = int.Parse(s+s+s);
            int n4 = int.Parse(s+s+s+s);

            Console.WriteLine(n1 + n2 + n3 + n4);


     // Exercise 4: Double Dice

     class Program
{
  static void ThrowDice() 
  {
    
  }
}