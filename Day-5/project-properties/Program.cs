internal class Program
{
    private static void Main(string[] args)
    {
        HumanCapitalist cap = new();
        HumanCommunist cmn = new();

        Console.WriteLine("Enter balance for HumanCapitalist:");
        int capitalistBalance = int.Parse(Console.ReadLine());
        cap.SetBalance(capitalistBalance);
        cap.GetID("17760704");
        Console.WriteLine("HumanCapitalist Balance: " + cap.Balance);
        Console.WriteLine("HumanCapitalist ID: " + cap.ID);

        Console.WriteLine("\nEnter balance for HumanCommunist:");
        int communistBalance = int.Parse(Console.ReadLine());
        cmn.Balance = communistBalance;
        cmn.GetID("19171010");
        Console.WriteLine("HumanCommunist Balance: " + cmn.Balance);
        Console.WriteLine("HumanCommunist ID: " + cmn.ID);
    }
}

class HumanCapitalist
{
    public int Balance { get; private set; }
    public string ID { get; private set; }

    public void SetBalance(int balance)
    {
        Balance = balance;
    }

    public void GetID(string id)
    {
        ID = id;
    }
}

class HumanCommunist
{
    public int Balance { get; set; }
    public string ID { get; set; }

    public void SetBalance(int balance)
    {
        Balance = balance;
    }

    public void GetID(string id)
    {
        ID = id;
    }
}
