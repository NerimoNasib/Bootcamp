class Calculator{
    public int Add(params int[] number){
        int sum = 0;
        foreach (int i in number)
        {
            sum += i;
        }
        return sum;
    }
        // Calculator calcu = new();
        // Console.WriteLine(calcu.Add(69,420));
        // Put in Main()
}

class Order{
    public void List(params object[] array){
        for (int i = 0; i < array.Length; i++){
            System.Console.WriteLine(array[i]);
        }
    }

    public void ListInput(){
        string input = Console.ReadLine();
        string[] items = input.Split(',');
        Console.WriteLine("Pesenan njenengan:");
        List(items);
    }
}

class Program{
    static void Main(){

        Order ord = new();
        Console.WriteLine("Pesen opo? ");
        ord.ListInput();
    }
}