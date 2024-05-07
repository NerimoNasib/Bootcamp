namespace Ternak;

using Mamalia;
using Unggas;

public class List
{
    Babi babi;
    Sapi sapi;
    Ayam ayam;
    Bebek bebek;
    public List(
    Babi babi,
    Sapi sapi,
    Ayam ayam,
    Bebek bebek
    )
    {
        this.babi = babi;
        this.sapi = sapi;
        this.ayam = ayam;
        this.bebek = bebek;
    }

    public void PrintAttribute(){
        Console.WriteLine(babi);
        Console.WriteLine(sapi);
        Console.WriteLine(ayam);
        Console.WriteLine(bebek);
    }
}
