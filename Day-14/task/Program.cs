using System.Threading;

class Program{
    static void Main(){
        Task task1 = new(() => System.Console.WriteLine("Task1"));
        task1.Start();
        
        Task task2 = Task.Run(() => System.Console.WriteLine("Task2"));
        System.Console.WriteLine(task2.IsCompleted);

        
    }
}