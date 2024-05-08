namespace Ship;


public class Warship : ShipDefault {
    public string servedIn;
    public string warshipType;

    public Warship(string name, 
    int length, 
    int weight, 
    bool isExisting,
    string servedIn, 
    string warshipType) : base()
    {
    this.name = name;
    this.length = length;
    this.weight = weight; 
    this.isExisting = isExisting;
    this.servedIn = servedIn;
    this.warshipType = warshipType;
    }

    public void PrintShip(){
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Length " + length + "M");
        Console.WriteLine("Weight " + weight + "KG");
        Console.WriteLine("Still around? " + isExisting);
        Console.WriteLine("Served in " + servedIn);
        Console.WriteLine("Type: " + warshipType);
        Console.WriteLine("\n");
    }
}