using System;
using System.Threading;
using System.Collections;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        BlueArchiveWelcome();
        BlueArchiveMenu();
        Task task3 = Task.Run(() => BlueArchiveUpdater());
        Maths maths = new Maths();
        task3.Wait();
        BlueArchiveID(maths);
        Task task4 = Task.Run(() => BlueArchiveHomescreen());
        task4.Wait();
    }

    public static void BlueArchiveWelcome()
    {
        Console.WriteLine("Current PID:" + Thread.CurrentThread.ManagedThreadId); //Thread ID
        Console.WriteLine($"Welcome to Blue Archive!\n");
    }

    public static void BlueArchiveMenu()
    {
        Console.WriteLine("Current PID:" + Thread.CurrentThread.ManagedThreadId); //Thread ID
        Console.WriteLine("Welcome to the menu!\n");
    }


    public static void BlueArchiveUpdater()
    {
        Console.WriteLine("Current PID:" + Thread.CurrentThread.ManagedThreadId); //Thread ID
        string[] loadingFrames = { "|", "/", "-", "\\" };
        int currentFrame = 0;

        for (int i = 0; i < 50; i++)
        {
            System.Console.Write($"\rUpdating: Loading{loadingFrames[currentFrame]}");
            currentFrame = (currentFrame + 1) % loadingFrames.Length;
            Thread.Sleep(100);
        }
        System.Console.WriteLine("\nUpdate done!");
    }

    public static void BlueArchiveID(Maths maths)
    {
        Console.WriteLine("Current PID:" + Thread.CurrentThread.ManagedThreadId); //Thread ID
        System.Console.WriteLine("\nInput ID: ");
        int input = Int32.Parse(Console.ReadLine());
        int result = maths.Login(input);
        System.Console.WriteLine($"\nYour ID: {result}-UID");
        if (input == 123)
        {
            System.Console.WriteLine("Welcome, Ega-Sensei!");
        }
    }

    public static void BlueArchiveHomescreen()
    {
        Console.WriteLine("\nCurrent PID:" + Thread.CurrentThread.ManagedThreadId); //Thread ID
        Console.WriteLine("Welcome to the main menu!\nPlease choose your destination!");
        Console.WriteLine("|1.Cafe|2.Chars|3.Gacha|4.Battle|");
        string input = Console.ReadLine().ToLower();
        switch (input)
        {
            case "cafe" or "1":
                System.Console.WriteLine("coming soon");
                break;
            case "chars" or "2":
                System.Console.WriteLine("coming soon");
                break;
            case "gacha" or "3":
                Task task5 = Task.Run(() => GachaMenu());
                task5.Wait();
                break;
            case "battle" or "4":
                Task task6 = Task.Run(() => BattleMenu());
                task6.Wait();
                break;
        }
        BlueArchiveHomescreen();
    }

    public static void GachaMenu()
    {
        Console.WriteLine("\nCurrent PID:" + Thread.CurrentThread.ManagedThreadId); //Thread ID
        Console.WriteLine("Welcome to gacha menu!");
        Console.WriteLine($"How many pulls do you want?\n1 (cost 2) | 10 (cost 20)");
        int input = Int32.Parse(Console.ReadLine());

        if (input == 1)
        {
            PullGacha(1);
        }
        else if (input == 10)
        {
            PullGacha(10);
        }
        else
        {
            Console.WriteLine("Please enter a valid number of pulls!");
        }
    }

    public static void BattleMenu()
    {
        Console.WriteLine("\nCurrent PID:" + Thread.CurrentThread.ManagedThreadId); //Thread ID
        List<string> charList = new List<string>
        {
            "Aru",
            "Toki",
            "Hoshino",
            "Shun",
            "Asuna",
        };

        List<string> enemies = new List<string>
        {
            "Crook",
            "Boss",
        };

        Random random = new Random();
        string playerCharacter = charList[random.Next(charList.Count)];
        string enemy = enemies[random.Next(enemies.Count)];

        Console.WriteLine($"You encountered a {enemy}!");

        bool playerWon = SimulateBattle(playerCharacter, enemy);

        if (playerWon)
        {
            Console.WriteLine($"Congratulations! {playerCharacter} defeated the {enemy}!");
        }
        else
        {
            Console.WriteLine($"Oh no! {playerCharacter} was defeated by the {enemy}!");
        }
    }

    public static bool SimulateBattle(string playerCharacter, string enemy)
    {
        return true;
    }

public static void PullGacha(int numberOfPulls)
{
    Console.WriteLine("\nCurrent PID:" + Thread.CurrentThread.ManagedThreadId); //Thread ID
    List<string> gachaItems = new List<string>
    {
        "Karin",
        "Shiroko",
        "Momoi",
        "Midori",
        "Aris",
        "Serina",
    };
    
    double equalProbability = 100.0 / gachaItems.Count;

    Random random = new Random();

    for (int i = 0; i < numberOfPulls; i++)
    {
        double randomNumber = random.NextDouble() * 100;

        double cumulativeProbability = 0;

        for (int j = 0; j < gachaItems.Count; j++)
        {
            cumulativeProbability += equalProbability;

            if (randomNumber <= cumulativeProbability)
            {
                string item = gachaItems[j];
                Console.WriteLine($"You pulled {item}!");
                break;
            }
        }
    }
}



}

class Maths
{
    public int Login(int x)
    {
        return x;
    }
}
