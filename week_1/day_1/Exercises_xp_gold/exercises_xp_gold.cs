using System;
//Exercise — FizzBuzz
class Program
{
        int n = int.Parse(Console.ReadLine());

        if (n % 15 == 0) Console.WriteLine("FizzBuzz");
        else if (n % 3 == 0) Console.WriteLine("Fizz");
        else if (n % 5 == 0) Console.WriteLine("Buzz");
        else Console.WriteLine(n);




//Exercise : Reverse a Word 

string w = Console.ReadLine();
for (int i = w.Length - 1; i >= 0; i--)
    Console.Write(w[i]);

}