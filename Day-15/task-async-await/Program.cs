using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        int result = await Add(3, 4);
        Console.WriteLine(result);
    }

    public static async Task<int> Add(int a, int b)
    {
        await Task.Delay(100);
        
        return a + b;
    }
}
