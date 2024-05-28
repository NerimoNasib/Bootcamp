internal class Program
{
    private static async Task Main(string[] args)
    {
        // Task task1 = Task.Run(() => System.Console.WriteLine("1"+"1"));
        // Task task2 = Task.Run(() => System.Console.WriteLine("Hello"));

        // Task.WhenAll(task1, task2); //Doesnt block the main thread making the "Finished" goes first
        // Task.WaitAll(task1, task2); //Wait the thread then finish
        // System.Console.WriteLine("Finished");

        Task task1 = Task.Run(async () => {await Task.Delay(2000); System.Console.WriteLine("Task1");});
        Task task2 = Task.Run(async () => {await Task.Delay(2000); System.Console.WriteLine("Task2");});

        Task completedTask = await Task.WhenAny(task1, task2);
        Console.WriteLine($"First completed task: " +(completedTask == task1 ? "Task 1": "Task 2"));
    }
}