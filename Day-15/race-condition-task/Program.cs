internal class Program
{
    private static async Task Main(string[] args)
    {
        Task task1 = IncrementCounter();
        Task task2 = IncrementCounter();

        await Task.WhenAll(task1, task2);
        System.Console.WriteLine("Final counter: " + counter);
    }
    
    static int counter = 0;

    static object lockedIn = new();

    static async Task IncrementCounter(){
        lock(lockedIn){
            for (int i = 0; i < 50; i++)
            {
                counter++;
                System.Console.WriteLine($"Counting {i}");
            }
        }
        await Task.Delay(100);
    }
}