internal class Program
{
    private static void Main(string[] args)
    {
        HumanCapitalist cap = new();
        HumanCommunist cmn = new();

        Console.WriteLine("Enter balance for HumanCapitalist:");
        int capitalistBalance = int.Parse(Console.ReadLine());
        cap.SetBalance(capitalistBalance);

        Console.WriteLine("Enter balance for HumanCommunist:");
        int communistBalance = int.Parse(Console.ReadLine());
        cmn.Balance = communistBalance;

        Console.WriteLine("HumanCapitalist Balance: " + cap.Balance);
        Console.WriteLine("HumanCommunist Balance: " + cmn.Balance);
    }
}

class HumanCapitalist
{
    public int Balance { get; private set; }
    public string ID{get; private set;}

    public void SetBalance(int balance)
    {
        Balance = balance;
    }

    public void GetID(string ID){
        ID = "19191919191919";
    }
}

class HumanCommunist
{
    public int Balance { get; set; }

    public void SetBalance(int balance)
    {
        Balance = balance;
    }
}
