internal class Program
{
    private static void Main(string[] args)
    {
        Garbage garbage = new();
        garbage.GarbColle();
        GC.Collect();
    }
}

class Garbage{
    public void GarbColle(){
        System.Console.WriteLine("Garbage Collection");
    }
}