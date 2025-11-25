using System;

class Program
{
    static void Main()
    {
        //Exercise 1
        Console.WriteLine("Welcome to C# Programming");

        //Exercise 2
        string name = "Ismail Maaji";
        int age = 25;

        Console.WriteLine("My name is " + name + " and I am " + age + " years old");

        //Exercise 3
        int num1 = 3;
        int num2 = 56;
        int sum = num1 + num2;
        Console.WriteLine(sum);

        //Exercise 4
        int userAge = 16;

        if (userAge >= 18)
        {
            Console.WriteLine("Access Granted.");
        }
        else
        {
            Console.WriteLine("Access Denied.");
        }

        //Exercise 5 
        int countdown = 10;
        while (countdown >= 1)
        {
            Console.WriteLine(countdown);
            countdown--;
        }
        Console.WriteLine("Liftoff!");

        //Exercise 6
        SayHello("Yassine");
        SayHello("Ahmed");
        SayHello("Ayoub");

        //Exercise 7
        for (int n = 1; n <= 10; n++)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"Number {n} is Even");
            }
            else
            {
                Console.WriteLine($"Number {n} is Odd");
            }
        }
    }

    static void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
        //Exercise 8
    






