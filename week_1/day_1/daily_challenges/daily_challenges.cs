using System;
using System.Collections.Generic;


//Challenge 1: Multiples List Generator
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

       
        Console.WriteLine("Enter the length:");
        int length = Convert.ToInt32(Console.ReadLine());

        
        List<int> multiples = new List<int>();

        
        for (int i = 1; i <= length; i++)
        {
            multiples.Add(number * i);
        }

        Console.WriteLine(string.Join(", ", multiples));
    }
}


//Challenge 2: Remove Consecutive Dupl/icate Letters

class DuplicateRemover
{
    static void Main()
    {
        Console.WriteLine("Enter something:");
        string input = Console.ReadLine();
        List<string> numbersWithDuplicates = new List<string> { };
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {

            if (i == 0 || input[i] != input[i - 1])
            {
                result += input[i];
            }
        }


        Console.WriteLine("Result: " + result);



    }
}




