internal class Program
{
    private static void Main(string[] args)
    {
        int? a = null;
        System.Console.WriteLine(a == null);
        //Is the same as
        Nullable<int> i = new Nullable<int>();
        System.Console.WriteLine(!i.HasValue);
    }
}