using System;
using System.Collections.Generic;

public class FooBar
{
    public IList<string> FooBarList(int n)
    {
        var list = new List<string>(n);

        for (int i = 1; i <= n; i++)
        {
            string item = (i % 3 == 0, i % 5 == 0) switch
            {
                (true, true) => "FooBar",
                (true, false) => "Foo",
                (false, true) => "Bar",
                (false, false) => i.ToString()
            };
            list.Add(item);
        }
        return list;
    }
}

class Program {
    static void Main(){
        Console.WriteLine("Enter number:");
        int n;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            FooBar fooBar = new FooBar();
            IList<string> resultList = fooBar.FooBarList(n);
            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
