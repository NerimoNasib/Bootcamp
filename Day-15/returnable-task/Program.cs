using System;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Task<int> task = new Task<int>(Login);
        task.Start();
        task.Wait();
        Console.WriteLine($"Your id is {task.Result}");

        var task3 = new Task<Dictionary<string, int>>(CharList);
        task3.Start();
        task3.Wait();

        foreach (var item in task3.Result)
        {
            Console.WriteLine(item);
        }
    }

    static int Login()
    {
        Console.Write("Enter your ID: ");
        int inputID = Int32.Parse(Console.ReadLine());
        return inputID;
    }

    static Dictionary<string, int> CharList()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        Console.WriteLine("Enter how many item you want to add: ");
        int numPairs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numPairs; i++)
        {
            Console.WriteLine($"Enter name {i + 1}:");
            string key = Console.ReadLine();
            Console.WriteLine($"Enter id '{key}':");
            int value = int.Parse(Console.ReadLine());

            dict.Add(key, value);
        }

        return dict;
    }
}
