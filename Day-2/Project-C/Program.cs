using Ship;

class Program{
    public static void Main(){
        Warship warship = new Warship("Enterprise", 256, 50000, true, "Midway", "CV");
        ResearchShip res = new ResearchShip("Evergreen", 120, 100000, false, "Antartic Exploration");
        MerchantShip merch = new MerchantShip("Soya", 120, 5000, true, "Food");
        Console.WriteLine("Ship List!\n");
        warship.PrintShip();
        res.PrintShip();
        merch.PrintShip();
    }
}