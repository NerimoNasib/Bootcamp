namespace Ship;
public class MerchantShip : ShipDefault {
    public string item;

    public MerchantShip(string name, 
    int length, 
    int weight, 
    bool isExisting,  
    string item) : base()
    {
    this.name = name;
    this.length = length;
    this.weight = weight; 
    this.isExisting = isExisting;
    this.item = item;
    }

    public void PrintShip(){
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Length " + length + "M");
        Console.WriteLine("Weight " + weight + "KG");
        Console.WriteLine("Still around? " + isExisting);
        Console.WriteLine("Carried: " + item);
        Console.WriteLine("\n");
    }
}