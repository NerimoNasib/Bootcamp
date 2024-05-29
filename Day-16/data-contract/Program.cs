using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Player momoi = new Player("Momoi",2000,300,1500);
        Player midori = new Player("Momoi",3000,400,1500);
        Player arisu = new Player("Momoi",4000,500,1500);

        List<Player> players = new(){
            momoi, midori, arisu
        };

        DataContractJsonSerializer dataContractJsonSerializer = new(typeof(List<Player>));
        using(FileStream fs = new("players.json", FileMode.OpenOrCreate)){
            dataContractJsonSerializer.WriteObject(fs, players);
        }
    }
}

[DataContract] class Player{
    [DataMember]
    private string _name;

    [DataMember]
    private int _money;
    public int Gold{get; set;}

    public int Exp{get; set;}

    public Player(string name, int money, int gold, int exp){
        _name = name;
        _money = money;
        Gold = gold;
        Exp = exp;
    }

    public string GetName(){
        return _name;
    }

    public int GetMoney(){
        return _money;
    }
} 