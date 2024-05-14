using System;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //Array
        string[] midway = new string[]{"Kaga", "Akagi"};
        foreach (var kapal in midway)
        {
            Console.WriteLine(kapal);
        }

        //Enumerator
        List<string> phillipines = new(){"Shokaku", "Zuikaku"};
        IEnumerator<string> enumerator = phillipines.GetEnumerator();
        while(enumerator.MoveNext()){
            Console.WriteLine(enumerator.Current);
        }

        // Accessing the iterator outside the method
        foreach (var number in GetNumbers())
        {
            Console.WriteLine(number);   
        }
    }

    // Iterator
    public static IEnumerable<int> GetNumbers()
    {
    for (int i = 2; i < 100; i++)
    {
            bool isPrime = true;
            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                yield return i;
            }
        }
    }
}
