internal class Program
{
    private static async Task Main(string[] args)
    {
        Task mission1 = Task.Run(async () =>
        {
            await Task.Delay(2000);
            System.Console.WriteLine("Mission 1: Complete 1 daily mission");
        });

        Task mission2 = Task.Run(async () =>
        {
            await Task.Delay(1000);
            System.Console.WriteLine("Mission 2: Pull 1 gacha");
        });

        Task mission3 = Task.Run(async () =>
        {
            await Task.Delay(2000);
            System.Console.WriteLine("Mission 3: Visit your students");
        });

        Task mission4 = Task.Run(async () =>
        {
            await Task.Delay(2000);
            System.Console.WriteLine("Mission 4: Develop a new weapon");
        });

        
        Task completedTask = await Task.WhenAny(mission1, mission2, mission3, mission4);

        if (completedTask == mission1)
        {
            System.Console.WriteLine("First completed mission: Mission 1");
        }
        else if (completedTask == mission2)
        {
            System.Console.WriteLine("First completed mission: Mission 2");
        }
        else if (completedTask == mission3)
        {
            System.Console.WriteLine("First completed mission: Mission 3");
        }
        else if (completedTask == mission4)
        {
            System.Console.WriteLine("First completed mission: Mission 4");
        }
    }
}
