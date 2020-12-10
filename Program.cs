using System;
using System.Linq;
using System.Collections.Generic;


namespace _19.LinqProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()   //We taks so the input
                              .Split(' ')
                              .Select(int.Parse)
                              .ToArray();

            int k = numbers.Length / 4;

            int[] topLeftRow = numbers.Take(k).Reverse().ToArray();
            int[] topRightRow = numbers.Reverse().Take(k).ToArray();
            int[] topRow = topLeftRow.Concat(topRightRow).ToArray();
            int[] bottomRow = numbers.Skip(k).Take(k * 2).ToArray();

            int[] result = new int[bottomRow.Length];

            for (int i = 0; i < bottomRow.Length; i++)
            {
                result[i] = topRow[i] + bottomRow[i];
            }
            Console.WriteLine(string.Join(" ", result));

            // Dictionaty is : collection {key-Value} pairs, map, hash, associative array; or collection that holds key and associative value;
            // dictionary is collection that holds pairs {key-Value}, 
            //  can be sorted or not sorted, dictionary is table of key-value pairs ! , the key must be unique ! value- hold a value, 
            // when we iterate over dictionary we need to use  {key -> value} KeyValuePair <k, v>
            // Lambda and Linq simplifies the collection working, processing information;
            // Lambda is inline definition of a function which take some value, and retuns some value
            // Lambda inline functons is used together with Linq -> Language integrated native query-adds more logic to our collection sorces
            // so we can use more mehtods over our collections

        }
    }
}
