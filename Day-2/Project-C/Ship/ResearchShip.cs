namespace Ship;


public class ResearchShip : ShipDefault {
    public string researchName;

    public ResearchShip(string name, 
    int length, 
    int weight, 
    bool isExisting,  
    string researchName) : base()
    {
    this.name = name;
    this.length = length;
    this.weight = weight; 
    this.isExisting = isExisting;
    this.researchName = researchName;
    }

    public void PrintShip(){
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Length " + length + "M");
        Console.WriteLine("Weight " + weight + "KG");
        Console.WriteLine("Still around? " + isExisting);
        Console.WriteLine("Research topic: " + researchName);
        Console.WriteLine("\n");
    }
}