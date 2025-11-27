using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        
        Dictionary<char, List<int>> letterPositions = new Dictionary<char, List<int>>();

        
        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];

            
            if (!letterPositions.ContainsKey(c))
            {
                letterPositions[c] = new List<int>();
            }

            
            letterPositions[c].Add(i);
        }

       
        Console.Write("{ ");
        bool firstKey = true;

        foreach (var kvp in letterPositions)
        {
            if (!firstKey) Console.Write(", ");
            Console.Write($"'{kvp.Key}': [{string.Join(", ", kvp.Value)}]");
            firstKey = false;
        }

        Console.WriteLine(" }");
    }
}
