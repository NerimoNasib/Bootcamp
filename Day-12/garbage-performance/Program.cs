using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        string text = String.Empty;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 10000; i++){
            text += "a";
            text += "b";
            text = text.Replace('a', 'c');
        }
        stopwatch.Stop();
        System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}