using Mamalia;
using Unggas;
using Ternak;

class Program{
    public static void Main(){
        Babi babi = new Babi(50, "Babi-grad", "Babi Sp.");
        Sapi sapi = new Sapi(200, "Sapi-city", "Sapi Sp.");
        Ayam ayam = new Ayam(5, "Ayam-somewhere", "Avian Sp.");
        Bebek bebek = new Bebek(5, "Bebek-to", "Bebek Sp.");
        List list = new List(babi, sapi, ayam, bebek);

        Console.WriteLine("\nDaftar Hewan Mamalia:\n");
        Console.WriteLine("Babi info: ");
        babi.PrintAttribute();
        Console.WriteLine("\nSapi info: ");
        sapi.PrintAttribute();
        Console.WriteLine("\n");
        Console.WriteLine("\nDaftar Hewan Unggas:\n");
        ayam.PrintAttribute();
        Console.WriteLine("\n");
        Console.WriteLine("List tipe hewan: \n");
        list.PrintAttribute();
    }
}