internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new();
        GC.Collect();
        Console.ReadKey();
    }
}

class Car{
    public Car(){
        System.Console.WriteLine("Car Constructor is build");
    }

    ~Car(){
        System.Console.WriteLine("This is garbage destructor, goodbye");
    }
}