internal class Program
{
    static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
    private static void Main(string[] args)
    {
        Thread thread = new Thread(SomeMethod){
            Name = "NewThread"
        };
        thread.Start();

        Console.ReadKey();

        autoResetEvent.Set();
    }

    static void SomeMethod(){
        System.Console.WriteLine("Starting...");
        autoResetEvent.WaitOne();
        System.Console.WriteLine("Finishing");
    }
}