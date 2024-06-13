using System.Text;
using BenchmarkDotNet.Attributes;
[MemoryDiagnoser]
public class StringVsStringBuilder
{
    
    [Params(10, 100, 100)]
    public int n;
    [Benchmark]
    public string MyString()
    {
        string str = String.Empty;
        for (int i = 0; i < n; i++)
        {
            str += i;
        }
        return str;
    }

    [Benchmark]
    public string MyStringBuilder()
    {
        StringBuilder str = new();
        for (int i = 0; i < n; i++)
        {
            str.Append(i);
        }
        return str.ToString();
    }
}