using System;
using System.Diagnostics;
using System.Text;

class Program{
    static void Main(){
        StringBuilder text = new();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for(int i = 0; i < 100000; i++){
            text.Append('a');
            text.Append('b');
            text.Append('c');
        }
        stopwatch.Stop();
        System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}