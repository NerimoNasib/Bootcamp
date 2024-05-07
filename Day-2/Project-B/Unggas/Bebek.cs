namespace Unggas;

public class Bebek
{
    int weight;
    string origin;
    string species;
    public Bebek(
        int weight,
        string origin,
        string species
    )
    {
        this.weight = weight;
        this.origin = origin;
        this.species = species;
    }

    public void PrintAttribute(){
        Console.WriteLine("Weight: " + weight + "KG");
        Console.WriteLine("Place of Origin: " + origin);
        Console.WriteLine("Sp.: " + species);
    }
}
